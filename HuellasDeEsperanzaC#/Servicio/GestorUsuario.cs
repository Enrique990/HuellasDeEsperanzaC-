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
        List<Usuario> usuarios = new List<Usuario>();

        public void RegistrarUsuario(Usuario usuario, Form formulario, GestorAdopcion gestorAdopcion, bool esEdicion = false)
        {
            usuarios.Clear();
            CargarDatosUsuarios();

            if (esEdicion)
            {
                // Buscar y actualizar el usuario existente según los datos cargados
                var usuarioExistente = usuarios.FirstOrDefault(u => u.Id == usuario.Id);
                if (usuarioExistente != null)
                {
                    int index = usuarios.IndexOf(usuarioExistente);
                    usuarios[index] = usuario;
                }
            }
            else
            {
                // Asignar un Id único al nuevo usuario
                usuario.Id = usuarios.Any() ? usuarios.Max(u => u.Id) + 1 : 1;
                usuarios.Add(usuario);
            }

            GuardarArchivoUsuario();

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

        public void GuardarArchivoUsuario()
        {
            using (FileStream mArchivoEscritor = new FileStream("datos.dat", FileMode.Create, FileAccess.Write))
            using (BinaryWriter Escritor = new BinaryWriter(mArchivoEscritor))
            {
                usuarios.ForEach(usuario =>
                {
                    Escritor.Write(usuario.Id);
                    Escritor.Write(usuario.NombreCompleto ?? string.Empty);
                    Escritor.Write(usuario.CorreoElectronico ?? string.Empty);
                    Escritor.Write(usuario.HashContrasena ?? string.Empty);
                    Escritor.Write(usuario.Direccion ?? string.Empty);
                    Escritor.Write(usuario.NumeroTelefono ?? string.Empty);
                    Escritor.Write(usuario.Descripcion ?? string.Empty);
                    Escritor.Write(usuario.NumeroCedula ?? string.Empty);
                    Escritor.Write(usuario.Ocupacion ?? string.Empty);
                    Escritor.Write(usuario.Tipo.ToString() ?? string.Empty);
                });
            }

        }

        public void ActualizarUsuario(Usuario usuario, Form formulario, GestorAdopcion gestorAdopcion)
        {
            RegistrarUsuario(usuario, formulario, gestorAdopcion, true);
        }

        public void CargarDatosUsuarios()
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
            var usuario = usuarios.FirstOrDefault(u => u.CorreoElectronico == correoVerificar && u.VerificarContraseña(contrasenaVerificar));
            if (usuario != null)
            {
                //HomeGeneralForm Home = new HomeGeneralForm(usuario, gestorAdopcion);
                //Home.Show();
                HomeAdminForm homeAdminForm = new HomeAdminForm(usuario, gestorAdopcion);
                homeAdminForm.Show();
                formulario.Hide();
                return;
            }

            MetroFramework.MetroMessageBox.Show(formulario, "Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public Usuario BuscarUsuarioPorID(int id)
        {
            return usuarios.FirstOrDefault(u => u.Id == id);
        }

        public Usuario BuscarUsuarioPorCorreo(string correo)
        {
            return usuarios.FirstOrDefault(u => string.Equals(u.CorreoElectronico, correo, StringComparison.OrdinalIgnoreCase));
        }

        public List<Usuario> GetListaUsuarios()
        {
            return usuarios;
        }
    }
}
