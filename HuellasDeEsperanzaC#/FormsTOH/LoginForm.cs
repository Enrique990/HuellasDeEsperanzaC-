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
    public partial class LoginForm : Form
    {
        List<Usuario> usuarios = new List<Usuario>();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            RegisterForm RegisterForm = new RegisterForm();
            RegisterForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            string correoVerificar = tbCorreo.Texts;
            string contrasenaVerificar = tbContrasena.Texts;

            cargarDatosUsuarios();

            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].CorreoElectronico == correoVerificar && usuarios[i].VerificarContraseña(contrasenaVerificar))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Bienvenido", "Inicio de Sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HomeGeneralForm Home = new HomeGeneralForm(usuarios[i]);
                    Home.Show();
                    this.Hide();
                    return;
                }
            }
            
            MetroFramework.MetroMessageBox.Show(this, "Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public void cargarDatosUsuarios()
        {
            usuarios.Clear();

            // TODO: VALIDACION DE CUANDO NO EXISTE USUARIO

            if (!File.Exists("datos.dat"))
            {
                return;
            }

            using (FileStream mArchivoLector = new FileStream("datos.dat", FileMode.Open, FileAccess.Read))
            using (BinaryReader Lector = new BinaryReader(mArchivoLector))
            {
                while (mArchivoLector.Position < mArchivoLector.Length)
                {
                    Usuario usuario = new Usuario();

                    usuario.NombreCompleto = Lector.ReadString();
                    usuario.CorreoElectronico = Lector.ReadString();
                    usuario.HashContrasena = Lector.ReadString();
                    usuario.Direccion = Lector.ReadString();
                    usuario.NumeroTelefono = Lector.ReadString();
                    usuario.Descripcion = Lector.ReadString();
                    usuario.Tipo = (TipoUsuario)Enum.Parse(typeof(TipoUsuario), Lector.ReadString());

                    usuarios.Add(usuario);


                    //int nombreCompletoLength = Lector.ReadInt32();
                    //usuario.NombreCompleto = new string(Lector.ReadChars(nombreCompletoLength));

                    //int correoElectronicoLength = Lector.ReadInt32();
                    //usuario.CorreoElectronico = new string(Lector.ReadChars(correoElectronicoLength));

                    //int hashContrasenaLength = Lector.ReadInt32();
                    //usuario.HashContrasena = new string(Lector.ReadChars(hashContrasenaLength));

                    //int direccionLength = Lector.ReadInt32();
                    //usuario.Direccion = new string(Lector.ReadChars(direccionLength));

                    //int numeroTelefonoLength = Lector.ReadInt32();
                    //usuario.NumeroTelefono = new string(Lector.ReadChars(numeroTelefonoLength));

                    //int descripcionLength = Lector.ReadInt32();
                    //usuario.Descripcion = new string(Lector.ReadChars(descripcionLength));

                    //int tipoLength = Lector.ReadInt32();
                    //usuario.Tipo = (TipoUsuario)Enum.Parse(typeof(TipoUsuario), new string(Lector.ReadChars(tipoLength)));

                    //usuarios.Add(usuario);
                }
            }
        }
    }
}
