using HuellasDeEsperanzaC_.Models;
using HuellasDeEsperanzaC_.Servicio;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuellasDeEsperanzaC_.FormsTOH
{
    public partial class AdminCreator : Form
    {
        GestorAdopcion gestorAdopcion = new GestorAdopcion();
        Usuario usuarioActual;
        GestorUsuario gestorusuario = new GestorUsuario();
        public AdminCreator()
        {
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            // Crear una instancia de Usuario para el nuevo administrador
            Usuario nuevoAdmin = new Usuario
            {
                CorreoElectronico = tbCorreo.Texts.Trim(),
                Tipo = TipoUsuario.Administrador
            };

            // Establecer la contraseña
            nuevoAdmin.EstablecerContraseña(customTextBox1.Texts.Trim());

            // Validar los campos
            if (string.IsNullOrWhiteSpace(nuevoAdmin.CorreoElectronico) || string.IsNullOrWhiteSpace(nuevoAdmin.HashContrasena))
            {
                MetroFramework.MetroMessageBox.Show(this, "Por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Usuario.EsCorreoValido(nuevoAdmin.CorreoElectronico))
            {
                MetroFramework.MetroMessageBox.Show(this, "El correo electrónico ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear una instancia de GestorUsuario y registrar el nuevo administrador
            GestorUsuario gestorUsuario = new GestorUsuario();
            GestorAdopcion gestorAdopcion = new GestorAdopcion();
            gestorUsuario.RegistrarUsuario(nuevoAdmin, this, gestorAdopcion);

            // Mostrar mensaje de éxito
            MetroFramework.MetroMessageBox.Show(this, "Administrador creado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome(usuarioActual, gestorAdopcion);
            adminHome.Show();
            this.Hide();
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
            AdminWaitingList adminWaitingList = new AdminWaitingList(usuarioActual, gestorAdopcion, gestorusuario);
            adminWaitingList.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GestorMascota gestorMascota = new GestorMascota();
            gestorMascota.CargarDatosMascotas();

            ReportDataSource reportDataSource = new ReportDataSource("DsDatos", gestorMascota.GetListaMascotas());

            AdminReports adminReports = new AdminReports();
            adminReports.reportViewer1.LocalReport.DataSources.Clear();
            adminReports.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            adminReports.reportViewer1.LocalReport.ReportEmbeddedResource = "HuellasDeEsperanzaC_.Reportes.RptMascotas.rdlc";
            adminReports.reportViewer1.RefreshReport();
            adminReports.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
