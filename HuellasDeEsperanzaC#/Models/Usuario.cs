using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HuellasDeEsperanzaC_.Models
{
    public enum TipoUsuario
    {
        Comun,
        Organizacion,
        Administrador
    }
    public class Usuario
    {
        public int Id { get; set; }
        public string CorreoElectronico { get; set; }
        public string HashContrasena { get; set; }
        public string Direccion { get; set; }
        public string NumeroTelefono { get; set; }
        public TipoUsuario Tipo { get; set; }
        public bool PerfilCompleto { get; set; }

        // Para usuarios comunes y administradores
        public string NombreCompleto { get; set; }
        public string NumeroCedula { get; set; }
        public string Ocupacion { get; set; }
        public List<Mascota> MascotasAdoptadas { get; set; }
        public List<ActividadVoluntariado> ActividadesInscritas { get; set; }

        // Para organizaciones
        public string NombreOrganizacion { get; set; } // Equivalente a NombreCompleto
        public string Descripcion { get; set; } // Equivalente a Ocupacion
        public List<Mascota> MascotasOfrecidasParaAdopcion { get; set; }
        public List<ActividadVoluntariado> ActividadesOrganizadas { get; set; } // Equivalente a ActividadesInscritas

        public Usuario()
        {
            CorreoElectronico = "correo@ejemplo.com";
            HashContrasena = string.Empty;
            Direccion = "Dirección de ejemplo";
            NumeroTelefono = "000-000-0000";
            Tipo = TipoUsuario.Comun;
            PerfilCompleto = false;

            // Para usuarios comunes y administradores
            NombreCompleto = "Nombre Completo";
            NumeroCedula = "0000000000";
            Ocupacion = "Ocupación de ejemplo";
            MascotasAdoptadas = new List<Mascota>();
            ActividadesInscritas = new List<ActividadVoluntariado>();

            // Para organizaciones
            NombreOrganizacion = "Nombre de la Organización";
            Descripcion = "Descripción de la organización";
            MascotasOfrecidasParaAdopcion = new List<Mascota>();
            ActividadesOrganizadas = new List<ActividadVoluntariado>();
        }

        public void EstablecerContraseña(string contraseña)
        {
            HashContrasena = HashPassword(contraseña);
        }

        public bool VerificarContraseña(string contraseña)
        {
            return HashContrasena == HashPassword(contraseña);
        }

        public string HashPassword(string contraseña)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(contraseña));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public void CompletarPerfil(string nombre, string direccion, string numeroTelefono, string identificacion, string ocupacionODescripcion)
        {
            Direccion = direccion;
            NumeroTelefono = numeroTelefono;
            PerfilCompleto = true;

            if (Tipo == TipoUsuario.Comun || Tipo == TipoUsuario.Administrador)
            {
                NombreCompleto = nombre;
                NumeroCedula = identificacion;
                Ocupacion = ocupacionODescripcion;
            }
            else if (Tipo == TipoUsuario.Organizacion)
            {
                NombreOrganizacion = nombre;
                Descripcion = ocupacionODescripcion;
            }
        }

        public void CompletarPerfilUsuario(Usuario usuario, string nombre, string direccion, string numeroTelefono, string identificacion, string ocupacionODescripcion)
        {
            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(direccion) ||
                string.IsNullOrWhiteSpace(numeroTelefono) ||
                string.IsNullOrWhiteSpace(identificacion) ||
                string.IsNullOrWhiteSpace(ocupacionODescripcion))
            {
                throw new ArgumentException("Todos los campos son obligatorios para completar el perfil.");
            }

            if (usuario.Tipo == TipoUsuario.Comun || usuario.Tipo == TipoUsuario.Administrador)
            {
                if (!Regex.IsMatch(numeroTelefono, @"^\d{4}-\d{4}$")) // Validar formato de teléfono
                {
                    throw new ArgumentException("El número de teléfono debe tener el formato ####-####.");
                }
            }

            usuario.CompletarPerfil(nombre, direccion, numeroTelefono, identificacion, ocupacionODescripcion);
        }

        public void AdoptarMascota(Mascota mascota)
        {
            if (PerfilCompleto && (Tipo == TipoUsuario.Comun || Tipo == TipoUsuario.Administrador))
            {
                MascotasAdoptadas.Add(mascota);
            }
            else
            {
                throw new InvalidOperationException("El perfil debe estar completo y ser un usuario común o administrador para adoptar una mascota.");
            }
        }

        public void InscribirseEnActividad(ActividadVoluntariado actividad)
        {
            if (PerfilCompleto && (Tipo == TipoUsuario.Comun || Tipo == TipoUsuario.Administrador))
            {
                ActividadesInscritas.Add(actividad);
            }
            else
            {
                throw new InvalidOperationException("El perfil debe estar completo y ser un usuario común o administrador para inscribirse en una actividad de voluntariado.");
            }
        }

        public void OrganizarActividad(ActividadVoluntariado actividad)
        {
            if (PerfilCompleto && Tipo == TipoUsuario.Organizacion)
            {
                ActividadesOrganizadas.Add(actividad);
            }
            else
            {
                throw new InvalidOperationException("El perfil debe estar completo y ser una organización para organizar una actividad de voluntariado.");
            }
        }
    }
}
