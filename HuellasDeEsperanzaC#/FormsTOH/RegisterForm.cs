using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HuellasDeEsperanzaC_.FormsTOH;
using HuellasDeEsperanzaC_.Models;

namespace HuellasDeEsperanzaC_.FormsTOH
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.Size = new Size(902, 430);
            roundButton1.Location = new Point(710, 332);
            
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (isORA.Checked)
            {
                this.Size = new Size(902, 653);
                lblORA1.Visible = true;
                lblORA2.Visible = true;
                lblORA3.Visible = true;
                tbOra1.Visible = true;
                tbOra2.Visible = true;
                tbOra3.Visible = true;
                roundButton1.Location = new Point(710, 569);
            }
            else
            {
                this.Size = new Size(902, 430);
                lblORA1.Visible = false;
                lblORA2.Visible = false;
                lblORA3.Visible = false;
                tbOra1.Visible = false;
                tbOra2.Visible = false;
                tbOra3.Visible = false;
                roundButton1.Location = new Point(710, 332);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void customTextBox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.NombreCompleto = tbNombreCompleto.Texts;
            usuario.CorreoElectronico = tbEmail.Texts;
            usuario.EstablecerContraseña(tbPass.Texts);

            if (isORA.Checked)
            {
                usuario.Direccion = tbOra1.Texts;
                usuario.NumeroTelefono = tbOra2.Texts;
                usuario.Descripcion = tbOra3.Texts;
                usuario.Tipo = TipoUsuario.Organizacion;
            }
            else
            {
                usuario.Tipo = TipoUsuario.Comun;
            }

            if (usuario.NombreCompleto == "" || usuario.CorreoElectronico == "" || usuario.HashContrasena == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isORA.Checked && (usuario.Direccion == "" || usuario.NumeroTelefono == "" || usuario.Descripcion == ""))
            {
                MetroFramework.MetroMessageBox.Show(this, "Por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (FileStream mArchivoEscritor = new FileStream("datos.dat", FileMode.Append, FileAccess.Write)) //OpenOrCreate
                using (BinaryWriter Escritor = new BinaryWriter(mArchivoEscritor))
                {
                    Escritor.Write(usuario.NombreCompleto);
                    Escritor.Write(usuario.CorreoElectronico);
                    Escritor.Write(usuario.HashContrasena);
                    Escritor.Write(usuario.Direccion);
                    Escritor.Write(usuario.NumeroTelefono);
                    Escritor.Write(usuario.Descripcion);
                    Escritor.Write(usuario.Tipo.ToString());


                    //Escritor.Write(usuario.NombreCompleto.Length);
                    //Escritor.Write(usuario.NombreCompleto);
                    //Escritor.Write(usuario.CorreoElectronico.Length);
                    //Escritor.Write(usuario.CorreoElectronico);
                    //Escritor.Write(usuario.HashContrasena.Length);
                    //Escritor.Write(usuario.HashContrasena);
                    //Escritor.Write(usuario.Direccion.Length);
                    //Escritor.Write(usuario.Direccion);
                    //Escritor.Write(usuario.NumeroTelefono.Length);
                    //Escritor.Write(usuario.NumeroTelefono);
                    //Escritor.Write(usuario.Descripcion.Length);
                    //Escritor.Write(usuario.Descripcion);
                    //Escritor.Write(usuario.Tipo.ToString().Length);
                    //Escritor.Write(usuario.Tipo.ToString());
                }

                MetroFramework.MetroMessageBox.Show(this, "Usuario registrado exitosamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HomeGeneralForm Home = new HomeGeneralForm();
                Home.Show();
                this.Hide();
            }
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
