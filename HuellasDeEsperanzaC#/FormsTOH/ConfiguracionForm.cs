using HuellasDeEsperanzaC_.Models;
using HuellasDeEsperanzaC_.Servicio;
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
    public partial class ConfiguracionForm : Form
    {
        private Usuario usuarioActual;

        public ConfiguracionForm(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
            CargarDatosUsuario();
        }

        private void CargarDatosUsuario()
        {
            tbNombreCompleto.Texts = usuarioActual.NombreCompleto;
            tbDireccion.Texts = usuarioActual.Direccion;
            tbNumeroTelefono.Texts = usuarioActual.NumeroTelefono;
            tbNumeroCedula.Texts = usuarioActual.NumeroCedula;
            tbOcupacion.Texts = usuarioActual.Ocupacion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreCompleto = tbNombreCompleto.Texts.Trim();
            string direccion = tbDireccion.Texts.Trim();
            string numeroTelefono = tbNumeroTelefono.Texts.Trim();
            string numeroCedula = tbNumeroCedula.Texts.Trim();
            string ocupacion = tbOcupacion.Texts.Trim();

            if (string.IsNullOrEmpty(nombreCompleto) &&
                string.IsNullOrEmpty(direccion) &&
                string.IsNullOrEmpty(numeroTelefono) &&
                string.IsNullOrEmpty(numeroCedula) &&
                string.IsNullOrEmpty(ocupacion))
            {
                MessageBox.Show("No hay cambios para guardar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (nombreCompleto == usuarioActual.NombreCompleto &&
                direccion == usuarioActual.Direccion &&
                numeroTelefono == usuarioActual.NumeroTelefono &&
                numeroCedula == usuarioActual.NumeroCedula &&
                ocupacion == usuarioActual.Ocupacion)
            {
                MessageBox.Show("No hay cambios para guardar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            usuarioActual.CompletarPerfil(nombreCompleto, direccion, numeroTelefono, numeroCedula, ocupacion);

            GestorUsuario gestorUsuario = new GestorUsuario();
            gestorUsuario.ActualizarUsuario(usuarioActual, this);

            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            HomeGeneralForm homeForm = new HomeGeneralForm(usuarioActual);
            homeForm.Show();
            this.Close();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
           
        }
    }
}
