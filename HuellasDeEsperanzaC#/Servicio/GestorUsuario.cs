using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HuellasDeEsperanzaC_.FormsTOH;
using System.Windows.Forms;
using HuellasDeEsperanzaC_.Models;

namespace HuellasDeEsperanzaC_.Servicio
{
    public class GestorUsuario
    {
        // Registro

        public void RegistrarUsuario(Usuario usuario, Form formulario, bool esEdicion = false)
        {
            List<Usuario> usuarios = new List<Usuario>();
            CargarDatosUsuarios(usuarios);

            if (esEdicion)
            {
                // Buscar y actualizar el usuario existente segun los datos cargados
                for (int i = 0; i < usuarios.Count; i++)
                {
                    if (usuarios[i].CorreoElectronico == usuario.CorreoElectronico)
                    {
                        usuarios[i] = usuario;
                        break;
                    }
                }
            }
            else
            {
                usuarios.Add(usuario);
            }

            using (FileStream mArchivoEscritor = new FileStream("datos.dat", FileMode.Create, FileAccess.Write))
            using (BinaryWriter Escritor = new BinaryWriter(mArchivoEscritor))
            {
                foreach (var usr in usuarios)
                {
                    Escritor.Write(usr.NombreCompleto);
                    Escritor.Write(usr.CorreoElectronico);
                    Escritor.Write(usr.HashContrasena);
                    Escritor.Write(usr.Direccion);
                    Escritor.Write(usr.NumeroTelefono);
                    Escritor.Write(usr.Descripcion);
                    Escritor.Write(usr.Tipo.ToString());
                }
            }

            string mensaje;
            string titulo;

            if (esEdicion)
            {
                mensaje = "Usuario actualizado exitosamente";
                titulo = "Actualización exitosa";
            }
            else
            {
                mensaje = "Usuario registrado exitosamente";
                titulo = "Registro exitoso";
            }

            MetroFramework.MetroMessageBox.Show(formulario, mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

            HomeGeneralForm Home = new HomeGeneralForm(usuario);
            Home.Show();
            formulario.Hide();

        }

        public void ActualizarUsuario(Usuario usuario, Form formulario)
        {
            RegistrarUsuario(usuario, formulario, true);
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
                        NombreCompleto = Lector.ReadString(),
                        CorreoElectronico = Lector.ReadString(),
                        HashContrasena = Lector.ReadString(),
                        Direccion = Lector.ReadString(),
                        NumeroTelefono = Lector.ReadString(),
                        Descripcion = Lector.ReadString(),
                        Tipo = (TipoUsuario)Enum.Parse(typeof(TipoUsuario), Lector.ReadString())
                    };

                    usuarios.Add(usuario);
                }
            }
        }

        // Login

        public void VerificarUsuario(string correoVerificar, string contrasenaVerificar, List<Usuario> usuarios, Form formulario)
        {
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].CorreoElectronico == correoVerificar && usuarios[i].VerificarContraseña(contrasenaVerificar))
                {
                    MetroFramework.MetroMessageBox.Show(formulario, "Bienvenido", "Inicio de Sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HomeGeneralForm Home = new HomeGeneralForm(usuarios[i]);
                    Home.Show();
                    formulario.Hide();
                    return;
                }
            }

            MetroFramework.MetroMessageBox.Show(formulario, "Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
