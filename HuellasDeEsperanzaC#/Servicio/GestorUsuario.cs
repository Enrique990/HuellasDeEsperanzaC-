using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HuellasDeEsperanzaC_.FormsTOH;
using System.Windows.Forms;
using HuellasDeEsperanzaC_.Models;
using HuellasDeEsperanzaC_.Servicio;

namespace HuellasDeEsperanzaC_.Servicio
{
    public class GestorUsuario
    {
        // Registro

        public void RegistrarUsuario(Usuario usuario, Form formulario, GestorAdopcion gestorAdopcion, bool esEdicion = false)
        {
            List<Usuario> usuarios = new List<Usuario>();
            CargarDatosUsuarios(usuarios);

            if (esEdicion)
            {
                // Buscar y actualizar el usuario existente según los datos cargados
                for (int i = 0; i < usuarios.Count; i++)
                {
                    if (usuarios[i].Id == usuario.Id)
                    {
                        usuarios[i] = usuario;
                        break;
                    }
                }
            }
            else
            {
                // Asignar un Id único al nuevo usuario
                if (usuarios.Count > 0)
                {
                    int maxId = 0;
                    for (int i = 0; i < usuarios.Count; i++)
                    {
                        if (usuarios[i].Id > maxId)
                        {
                            maxId = usuarios[i].Id;
                        }
                    }
                    usuario.Id = maxId + 1;
                }
                else
                {
                    usuario.Id = 1;
                }
                usuarios.Add(usuario);
            }

            using (FileStream mArchivoEscritor = new FileStream("datos.dat", FileMode.Create, FileAccess.Write))
            using (BinaryWriter Escritor = new BinaryWriter(mArchivoEscritor))
            {
                for (int i = 0; i < usuarios.Count; i++)
                {
                    Escritor.Write(usuarios[i].Id);

                    if (usuarios[i].NombreCompleto != null)
                        Escritor.Write(usuarios[i].NombreCompleto);
                    else
                        Escritor.Write(string.Empty);

                    if (usuarios[i].CorreoElectronico != null)
                        Escritor.Write(usuarios[i].CorreoElectronico);
                    else
                        Escritor.Write(string.Empty);

                    if (usuarios[i].HashContrasena != null)
                        Escritor.Write(usuarios[i].HashContrasena);
                    else
                        Escritor.Write(string.Empty);

                    if (usuarios[i].Direccion != null)
                        Escritor.Write(usuarios[i].Direccion);
                    else
                        Escritor.Write(string.Empty);

                    if (usuarios[i].NumeroTelefono != null)
                        Escritor.Write(usuarios[i].NumeroTelefono);
                    else
                        Escritor.Write(string.Empty);

                    if (usuarios[i].Descripcion != null)
                        Escritor.Write(usuarios[i].Descripcion);
                    else
                        Escritor.Write(string.Empty);

                    if (usuarios[i].NumeroCedula != null)
                        Escritor.Write(usuarios[i].NumeroCedula);
                    else
                        Escritor.Write(string.Empty);

                    if (usuarios[i].Ocupacion != null)
                        Escritor.Write(usuarios[i].Ocupacion);
                    else
                        Escritor.Write(string.Empty);

                    if (usuarios[i].Tipo.ToString() != null)
                        Escritor.Write(usuarios[i].Tipo.ToString());
                    else
                        Escritor.Write(string.Empty);
                }
            }

            string mensaje;
            string titulo;

            if (esEdicion)
            {
                mensaje = "Usuario actualizado exitosamente";
                titulo = "Actualización exitosa";

                MetroFramework.MetroMessageBox.Show(formulario, mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            HomeGeneralForm Home = new HomeGeneralForm(usuario, gestorAdopcion);
            Home.Show();
            formulario.Hide();
        }

        public void ActualizarUsuario(Usuario usuario, Form formulario, GestorAdopcion gestorAdopcion)
        {
            RegistrarUsuario(usuario, formulario, gestorAdopcion, true);
        }

        public void CargarDatosUsuarios(List<Usuario> usuarios)
        {
            usuarios.Clear();

            if (!File.Exists("datos.dat"))
            {
                return;
            }

            using (FileStream mArchivoLector = new FileStream("datos.dat", FileMode.Open, FileAccess.Read))
            using (BinaryReader Lector = new BinaryReader(mArchivoLector))
            {
                while (mArchivoLector.Position < mArchivoLector.Length)
                {
                    Usuario usuario = new Usuario
                    {
                        Id = Lector.ReadInt32(),
                        NombreCompleto = Lector.ReadString(),
                        CorreoElectronico = Lector.ReadString(),
                        HashContrasena = Lector.ReadString(),
                        Direccion = Lector.ReadString(),
                        NumeroTelefono = Lector.ReadString(),
                        Descripcion = Lector.ReadString(),
                        NumeroCedula = Lector.ReadString(),
                        Ocupacion = Lector.ReadString(),
                        Tipo = (TipoUsuario)Enum.Parse(typeof(TipoUsuario), Lector.ReadString())
                        // Perfil Completo : BOOL
                    };

                    usuarios.Add(usuario);
                }
            }
        }

        public void VerificarUsuario(string correoVerificar, string contrasenaVerificar, List<Usuario> usuarios, Form formulario, GestorAdopcion gestorAdopcion)
        {
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].CorreoElectronico == correoVerificar && usuarios[i].VerificarContraseña(contrasenaVerificar))
                {
                    HomeGeneralForm Home = new HomeGeneralForm(usuarios[i], gestorAdopcion);
                    Home.Show();
                    //HomeAdminForm homeAdminForm = new HomeAdminForm(usuarios[i], gestorAdopcion);
                    //homeAdminForm.Show();
                    formulario.Hide();
                    return;
                }
            }

            MetroFramework.MetroMessageBox.Show(formulario, "Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
