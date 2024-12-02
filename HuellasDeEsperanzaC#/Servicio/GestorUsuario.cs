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
using System.Text.RegularExpressions;

namespace HuellasDeEsperanzaC_.Servicio
{
    public class GestorUsuario
    {
        List<Usuario> usuarios = new List<Usuario>();

        public void RegistrarUsuario(Usuario usuario, Form formulario, GestorAdopcion gestorAdopcion, bool esEdicion = false)
        {
            if (!ValidarRegistroUsuario(usuario))
            {
                MetroFramework.MetroMessageBox.Show(formulario, "Por favor complete los campos obligatorios correctamente.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!esEdicion)
            {
                usuario.Id = usuarios.Any() ? usuarios.Max(u => u.Id) + 1 : 1;
                usuarios.Add(usuario);
            }
            else
            {
                ActualizarUsuarioExistente(usuario);
            }

            GuardarArchivoUsuario();

            MetroFramework.MetroMessageBox.Show(formulario, "Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public bool ValidarRegistroUsuario(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.CorreoElectronico?.Trim()) ||
                string.IsNullOrWhiteSpace(usuario.HashContrasena?.Trim()))
            {
                return false;
            }

            if (!Regex.IsMatch(usuario.CorreoElectronico, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return false;
            }

            if (usuario.HashContrasena.Length < 11)
            {
                return false;
            }

            if (usuario.Tipo == TipoUsuario.Organizacion)
            {
                if (string.IsNullOrWhiteSpace(usuario.Direccion?.Trim()) ||
                    string.IsNullOrWhiteSpace(usuario.NumeroTelefono?.Trim()) ||
                    string.IsNullOrWhiteSpace(usuario.Descripcion?.Trim()))
                {
                    return false;
                }
            }

            return true;
        }

        public bool ValidarPerfilCompleto(Usuario usuario)
        {
            if (usuario.Tipo == TipoUsuario.Comun || usuario.Tipo == TipoUsuario.Administrador)
            {
                return ValidarPerfilUsuarioComun(usuario);
            }
            else if (usuario.Tipo == TipoUsuario.Organizacion)
            {
                return ValidarPerfilOrganizacion(usuario);
            }

            return false;
        }

        private bool ValidarPerfilUsuarioComun(Usuario usuario)
        {
            return !string.IsNullOrWhiteSpace(usuario.NombreCompleto?.Trim()) &&
                   !string.IsNullOrWhiteSpace(usuario.Direccion?.Trim()) &&
                   !string.IsNullOrWhiteSpace(usuario.NumeroTelefono?.Trim()) &&
                   Regex.IsMatch(usuario.NumeroTelefono, @"^\d{4}-\d{4}$");
        }

        private bool ValidarPerfilOrganizacion(Usuario usuario)
        {
            return !string.IsNullOrWhiteSpace(usuario.NombreOrganizacion?.Trim()) &&
                   !string.IsNullOrWhiteSpace(usuario.Direccion?.Trim()) &&
                   !string.IsNullOrWhiteSpace(usuario.NumeroTelefono?.Trim()) &&
                   Regex.IsMatch(usuario.NumeroTelefono, @"^\d{4}-\d{4}$");
        }

        // Método para Validar Formato de Correo
        private bool EsCorreoValido(string correo)
        {
            return Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        // Método para Validar Formato de Teléfono (####-####)
        private bool EsTelefonoValido(string telefono)
        {
            return Regex.IsMatch(telefono, @"^\d{4}-\d{4}$");
        }


        public void ActualizarUsuarioExistente(Usuario usuarioActualizado)
        {
            var usuarioExistente = usuarios.FirstOrDefault(u => u.Id == usuarioActualizado.Id);
            if (usuarioExistente != null)
            {
                usuarioExistente.NombreCompleto = usuarioActualizado.NombreCompleto;
                usuarioExistente.CorreoElectronico = usuarioActualizado.CorreoElectronico;
                usuarioExistente.Direccion = usuarioActualizado.Direccion;
                usuarioExistente.NumeroTelefono = usuarioActualizado.NumeroTelefono;
                usuarioExistente.Descripcion = usuarioActualizado.Descripcion;
                usuarioExistente.NumeroCedula = usuarioActualizado.NumeroCedula;
                usuarioExistente.Ocupacion = usuarioActualizado.Ocupacion;
                usuarioExistente.HashContrasena = usuarioActualizado.HashContrasena;
            }
        }

        private void AbrirFormularioPrincipal(Usuario usuario, Form formularioActual, GestorAdopcion gestorAdopcion)
        {
            try
            {
                Form homeForm;

                // Redirigir al formulario correspondiente según el tipo de usuario
                if (usuario.Tipo == TipoUsuario.Administrador)
                {
                    homeForm = new HomeAdminForm(usuario, gestorAdopcion);
                }
                else
                {
                    homeForm = new HomeGeneralForm(usuario, gestorAdopcion);
                }

                homeForm.Show();
                formularioActual.Hide();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(formularioActual, $"Error al abrir el formulario principal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    try
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
                        };

                        // Validar que los datos cargados sean correctos
                        if (string.IsNullOrWhiteSpace(usuario.CorreoElectronico) || string.IsNullOrWhiteSpace(usuario.HashContrasena))
                        {
                            throw new Exception("Datos de usuario incompletos o corruptos.");
                        }

                        usuarios.Add(usuario);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al cargar usuario: {ex.Message}");
                    }
                }
            }
        }

        public Usuario VerificarCredenciales(string correo, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(correo))
            {
                throw new ArgumentException("El correo electrónico es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(contrasena))
            {
                throw new ArgumentException("La contraseña es obligatoria.");
            }

            // Cargar usuarios si no se han cargado previamente
            CargarDatosUsuarios();

            // Buscar el usuario por correo y contraseña
            Usuario usuario = usuarios.FirstOrDefault(u =>
                u.CorreoElectronico.Equals(correo, StringComparison.OrdinalIgnoreCase) &&
                u.VerificarContraseña(contrasena));

            return usuario; // Devuelve null si no se encuentra el usuario
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

        public bool EsPerfilCompleto(int usuarioId)
        {
            var usuario = BuscarUsuarioPorID(usuarioId);
            if (usuario == null)
            {
                return false;
            }

            if (usuario.Tipo == TipoUsuario.Comun || usuario.Tipo == TipoUsuario.Administrador)
            {
                return !string.IsNullOrEmpty(usuario.NombreCompleto) &&
                       !string.IsNullOrEmpty(usuario.CorreoElectronico) &&
                       !string.IsNullOrEmpty(usuario.Direccion) &&
                       !string.IsNullOrEmpty(usuario.NumeroTelefono) &&
                       !string.IsNullOrEmpty(usuario.NumeroCedula) &&
                       !string.IsNullOrEmpty(usuario.Ocupacion);
            }
            else if (usuario.Tipo == TipoUsuario.Organizacion)
            {
                return !string.IsNullOrEmpty(usuario.NombreOrganizacion) &&
                       !string.IsNullOrEmpty(usuario.CorreoElectronico) &&
                       !string.IsNullOrEmpty(usuario.Direccion) &&
                       !string.IsNullOrEmpty(usuario.NumeroTelefono) &&
                       !string.IsNullOrEmpty(usuario.Descripcion);
            }
            else
            {
                return false;
            }
        }
    }
}
