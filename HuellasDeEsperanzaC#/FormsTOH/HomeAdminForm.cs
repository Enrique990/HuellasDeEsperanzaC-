using HuellasDeEsperanzaC_.Models;
using HuellasDeEsperanzaC_.Servicio;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuellasDeEsperanzaC_.FormsTOH
{
    public partial class HomeAdminForm : Form
    {
        private Usuario usuarioActual;
        private GestorAdopcion gestorAdopcionUser;

        public HomeAdminForm(Usuario usuario, GestorAdopcion gestorAdopcion)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
            this.gestorAdopcionUser = gestorAdopcion;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        // Constantes para manejar el arrastre de la ventana
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        // Método para permitir arrastrar la ventana desde el panel2
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            // Libera el control del mouse
            ReleaseCapture();
            // Envía un mensaje para iniciar el arrastre de la ventana
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la lista de mascotas disponibles para adopción
                List<Mascota> mascotasDisponibles = gestorAdopcionUser.ObtenerMascotasDisponibles();

                if (mascotasDisponibles == null || !mascotasDisponibles.Any())
                {
                    MessageBox.Show("No hay mascotas disponibles para mostrar en el informe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Manejar valores nulos y formatear datos
                for (int i = 0; i < mascotasDisponibles.Count; i++)
                {
                    Mascota mascota = mascotasDisponibles[i];

                    // Validar propiedades
                    if (mascota.FechaNacimiento == DateTime.MinValue)
                    {
                        mascota.FechaNacimiento = DateTime.Now; // Asignar fecha actual si no está definida
                    }

                    // Asegurarse de que la edad esté calculada o asignada
                    int edadCalculada = mascota.CalcularEdad();

                    if (edadCalculada < 0 || edadCalculada > 50) // Validar edades poco probables
                    {
                        mascota.Edad = -1; // Edad inválida
                    }

                    if (mascota.Tamaño == null)
                    {
                        mascota.Tamaño = "Sin tamaño"; // Asignar valor por defecto si es null
                    }

                    if (mascota.OrganizacionId == 0)
                    {
                        mascota.OrganizacionId = -1; // Asignar valor por defecto si es 0
                    }

                    if (!mascota.EstaAdoptado)
                    {
                        mascota.EstaAdoptado = false; // Asegurar que tenga un valor booleano predeterminado
                    }
                }

                // Crear una fuente de datos para el ReportViewer
                ReportDataSource rds = new ReportDataSource("DsDatos", mascotasDisponibles);

                ViewReportForm viewReportForm = new ViewReportForm(usuarioActual, gestorAdopcionUser);

                viewReportForm.reportViewer1.LocalReport.DataSources.Clear();

                viewReportForm.reportViewer1.LocalReport.DataSources.Add(rds);

                try
                {
                    viewReportForm.reportViewer1.LocalReport.ReportEmbeddedResource = "HuellasDeEsperanzaC_.Reportes.RptMascotas.rdlc";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el recurso incrustado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                viewReportForm.reportViewer1.RefreshReport();


                viewReportForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte: " + ex.Message);
            }
        }
    }
}
