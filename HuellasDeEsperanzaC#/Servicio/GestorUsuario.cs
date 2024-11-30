﻿using System;
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
        public void RegistrarUsuario(Usuario usuario, Form formulario, GestorAdopcion gestorAdopcion, bool esEdicion = false)
        {
            List<Usuario> usuarios = new List<Usuario>();
            CargarDatosUsuarios(usuarios);

            if (esEdicion)
            {
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
                usuarios.Add(usuario);
            }

            GuardarUsuarios(usuarios);

            //string mensaje = esEdicion ? "Usuario actualizado exitosamente" : "Usuario registrado exitosamente";
            //string titulo = esEdicion ? "Actualización exitosa" : "Registro exitoso";

            //MetroFramework.MetroMessageBox.Show(formulario, mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            try
            {
                using (FileStream mArchivoLector = new FileStream("datos.dat", FileMode.Open, FileAccess.Read))
                using (BinaryReader Lector = new BinaryReader(mArchivoLector))
                {
                    while (mArchivoLector.Position < mArchivoLector.Length)
                    {
                        try
                        {
                            Usuario usuario = new Usuario
                            {
                                NombreCompleto = Lector.ReadString(),
                                CorreoElectronico = Lector.ReadString(),
                                HashContrasena = Lector.ReadString(),
                                Direccion = Lector.ReadString(),
                                NumeroTelefono = Lector.ReadString(),
                                Descripcion = Lector.ReadString(),
                                NumeroCedula = Lector.ReadString(),
                                Ocupacion = Lector.ReadString(),
                                PreguntaEmergencia = Lector.ReadString()
                            };

                            string tipoUsuarioStr = Lector.ReadString();
                            if (Enum.TryParse(tipoUsuarioStr, true, out TipoUsuario tipoUsuario))
                            {
                                usuario.Tipo = (TipoUsuario)tipoUsuario;
                            }
                            else
                            {
                                // Manejar el caso en que el valor no es válido
                                usuario.Tipo = TipoUsuario.Comun; // Asumiendo que Default es un valor válido en el enum
                            }

                            usuarios.Add(usuario);
                        }
                        catch (Exception ex)
                        {
                            // Manejar errores específicos de análisis de datos
                            MessageBox.Show($"Error al cargar un usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar errores de lectura del archivo
                MessageBox.Show($"Error al leer el archivo de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarUsuarios(List<Usuario> usuarios)
        {
            using (FileStream mArchivoEscritor = new FileStream("datos.dat", FileMode.Create, FileAccess.Write))
            using (BinaryWriter Escritor = new BinaryWriter(mArchivoEscritor))
            {
                for (int i = 0; i < usuarios.Count; i++)
                {
                    Escritor.Write(usuarios[i].NombreCompleto ?? string.Empty);
                    Escritor.Write(usuarios[i].CorreoElectronico ?? string.Empty);
                    Escritor.Write(usuarios[i].HashContrasena ?? string.Empty);
                    Escritor.Write(usuarios[i].Direccion ?? string.Empty);
                    Escritor.Write(usuarios[i].NumeroTelefono ?? string.Empty);
                    Escritor.Write(usuarios[i].Descripcion ?? string.Empty);
                    Escritor.Write(usuarios[i].NumeroCedula ?? string.Empty);
                    Escritor.Write(usuarios[i].Ocupacion ?? string.Empty);
                    Escritor.Write(usuarios[i].PreguntaEmergencia ?? string.Empty);
                    Escritor.Write(usuarios[i].Tipo.ToString() ?? string.Empty);
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
                    formulario.Hide();
                    return;
                }
            }

            MetroFramework.MetroMessageBox.Show(formulario, "Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
