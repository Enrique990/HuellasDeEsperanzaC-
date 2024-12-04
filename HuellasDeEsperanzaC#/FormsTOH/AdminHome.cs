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
    public partial class AdminHome : Form
    {
        GestorAdopcion gestorAdopcion = new GestorAdopcion();
        Usuario usuarioActual;
        GestorUsuario gestorusuario = new GestorUsuario();

        //private Usuario usuarioActual;
        private GestorAdopcion gestorAdopcionUser;

        public AdminHome(Usuario usuario, GestorAdopcion gestorAdopcion)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
            this.gestorAdopcionUser = gestorAdopcion;
            showUsuario();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminWaitingList adminWaitingList = new AdminWaitingList(usuarioActual, gestorAdopcion, gestorusuario);
            adminWaitingList.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
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

        private void button6_Click(object sender, EventArgs e)
        {
            AdminCreator creator = new AdminCreator();
            creator.Show();
            this.Hide();
        }

        public void showUsuario()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(usuarioActual.CorreoElectronico);
            listBox1.Items.Add(usuarioActual.Tipo);
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
    }
}
