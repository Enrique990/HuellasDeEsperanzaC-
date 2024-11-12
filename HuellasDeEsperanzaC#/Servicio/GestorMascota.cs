using HuellasDeEsperanzaC_.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuellasDeEsperanzaC_.Servicio
{
    public class GestorMascota
    {
        public void RegistrarMascota(Mascota mascota, Form formulario, bool esEdicion = false)
        {
            List<Mascota> mascotas = new List<Mascota>();
            CargarDatosMascotas(mascotas);

            if (esEdicion)
            {
                // Buscar y actualizar la mascota existente según los datos cargados
                for (int i = 0; i < mascotas.Count; i++)
                {
                    if (mascotas[i].Id == mascota.Id)
                    {
                        mascotas[i] = mascota;
                        break;
                    }
                }
            }
            else
            {
                // Asignar un nuevo ID a la mascota
                if (mascotas.Count > 0)
                {
                    int maxId = 0;
                    for (int i = 0; i < mascotas.Count; i++)
                    {
                        if (mascotas[i].Id > maxId)
                        {
                            maxId = mascotas[i].Id;
                        }
                    }
                    mascota.Id = maxId + 1;
                }
                else
                {
                    mascota.Id = 1;
                }
                mascotas.Add(mascota);
            }

            using (FileStream mArchivoEscritor = new FileStream("mascotas.dat", FileMode.Create, FileAccess.Write))
            using (BinaryWriter Escritor = new BinaryWriter(mArchivoEscritor))
            {
                for (int i = 0; i < mascotas.Count; i++)
                {
                    Escritor.Write(mascotas[i].Id);
                    Escritor.Write(mascotas[i].Nombre);
                    Escritor.Write(mascotas[i].Especie);
                    Escritor.Write(mascotas[i].Sexo);
                    Escritor.Write(mascotas[i].Raza);
                    Escritor.Write(mascotas[i].FechaNacimiento.ToBinary());
                    Escritor.Write(mascotas[i].Descripcion);
                    Escritor.Write(mascotas[i].RutaImagen);
                }
            }

            string mensaje;
            string titulo;

            if (esEdicion)
            {
                mensaje = "Mascota actualizada exitosamente";
                titulo = "Actualización exitosa";
            }
            else
            {
                mensaje = "Mascota registrada exitosamente";
                titulo = "Registro exitoso";
            }

            MetroFramework.MetroMessageBox.Show(formulario, mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void CargarDatosMascotas(List<Mascota> mascotas)
        {
            mascotas.Clear();

            if (!File.Exists("mascotas.dat"))
            {
                return;
            }

            using (FileStream mArchivoLector = new FileStream("mascotas.dat", FileMode.Open, FileAccess.Read))
            using (BinaryReader Lector = new BinaryReader(mArchivoLector))
            {
                while (mArchivoLector.Position < mArchivoLector.Length)
                {
                    Mascota mascota = new Mascota
                    {
                        Id = Lector.ReadInt32(),
                        Nombre = Lector.ReadString(),
                        Especie = Lector.ReadString(),
                        Sexo = Lector.ReadString(),
                        Raza = Lector.ReadString(),
                        FechaNacimiento = DateTime.FromBinary(Lector.ReadInt64()),
                        Descripcion = Lector.ReadString(),
                        RutaImagen = Lector.ReadString()
                    };

                    mascotas.Add(mascota);
                }
            }
        }

        public void ActualizarMascota(Mascota mascota, Form formulario)
        {
            RegistrarMascota(mascota, formulario, true);
        }

        public string SeleccionarYGuardarImagen(Form formulario)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceFilePath = openFileDialog.FileName;
                    string fileName = Path.GetFileName(sourceFilePath);
                    string targetDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "FotosMascota");

                    if (!Directory.Exists(targetDirectory))
                    {
                        Directory.CreateDirectory(targetDirectory);
                    }

                    string targetFilePath = Path.Combine(targetDirectory, fileName);
                    File.Copy(sourceFilePath, targetFilePath, true);

                    return targetFilePath;
                }
            }

            return string.Empty;
        }
    }
}
