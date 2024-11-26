using System;
using System.Windows.Forms;

namespace HuellasDeEsperanzaC_.FormsTOH
{
    partial class ConfiguracionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new HuellasDeEsperanzaC_.CustomUserControls.RoundButton();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.tbNombreCompleto = new HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox();
            this.lblNumeroTelefono = new System.Windows.Forms.Label();
            this.tbDireccion = new HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox();
            this.lblNumeroCedula = new System.Windows.Forms.Label();
            this.tbNumeroTelefono = new HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox();
            this.tbNumeroCedula = new HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox();
            this.tbOcupacion = new HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox();
            this.lblOcupacion = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new HuellasDeEsperanzaC_.CustomUserControls.RoundButton();
            this.button8 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbEmail);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.lblDireccion);
            this.panel2.Controls.Add(this.tbNombreCompleto);
            this.panel2.Controls.Add(this.lblNumeroTelefono);
            this.panel2.Controls.Add(this.tbDireccion);
            this.panel2.Controls.Add(this.lblNumeroCedula);
            this.panel2.Controls.Add(this.tbNumeroTelefono);
            this.panel2.Controls.Add(this.tbNumeroCedula);
            this.panel2.Controls.Add(this.tbOcupacion);
            this.panel2.Controls.Add(this.lblOcupacion);
            this.panel2.Controls.Add(this.lblNombreCompleto);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1311, 760);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(445, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Correo Electrónico:";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(210)))), ((int)(((byte)(178)))));
            this.tbEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(136)))), ((int)(((byte)(115)))));
            this.tbEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.tbEmail.BorderSize = 2;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.DimGray;
            this.tbEmail.Location = new System.Drawing.Point(608, 205);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(6);
            this.tbEmail.MaxLength = 32767;
            this.tbEmail.Multiline = false;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Padding = new System.Windows.Forms.Padding(10);
            this.tbEmail.PasswordChar = false;
            this.tbEmail.Size = new System.Drawing.Size(623, 39);
            this.tbEmail.TabIndex = 2;
            this.tbEmail.Texts = "";
            this.tbEmail.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(441, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Editar Perfil";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(1112, 615);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 47);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(440, 400);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(82, 18);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Dirección:";
            this.lblDireccion.Click += new System.EventHandler(this.lblDireccion_Click);
            // 
            // tbNombreCompleto
            // 
            this.tbNombreCompleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(210)))), ((int)(((byte)(178)))));
            this.tbNombreCompleto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(136)))), ((int)(((byte)(115)))));
            this.tbNombreCompleto.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.tbNombreCompleto.BorderSize = 2;
            this.tbNombreCompleto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNombreCompleto.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreCompleto.ForeColor = System.Drawing.Color.DimGray;
            this.tbNombreCompleto.Location = new System.Drawing.Point(608, 140);
            this.tbNombreCompleto.Margin = new System.Windows.Forms.Padding(6);
            this.tbNombreCompleto.MaxLength = 32767;
            this.tbNombreCompleto.Multiline = false;
            this.tbNombreCompleto.Name = "tbNombreCompleto";
            this.tbNombreCompleto.Padding = new System.Windows.Forms.Padding(10);
            this.tbNombreCompleto.PasswordChar = false;
            this.tbNombreCompleto.Size = new System.Drawing.Size(620, 39);
            this.tbNombreCompleto.TabIndex = 1;
            this.tbNombreCompleto.Texts = "";
            this.tbNombreCompleto.UnderlinedStyle = true;
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTelefono.Location = new System.Drawing.Point(445, 356);
            this.lblNumeroTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(77, 18);
            this.lblNumeroTelefono.TabIndex = 10;
            this.lblNumeroTelefono.Text = "Teléfono:";
            this.lblNumeroTelefono.Click += new System.EventHandler(this.lblNumeroTelefono_Click);
            // 
            // tbDireccion
            // 
            this.tbDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(210)))), ((int)(((byte)(178)))));
            this.tbDireccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(136)))), ((int)(((byte)(115)))));
            this.tbDireccion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.tbDireccion.BorderSize = 2;
            this.tbDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDireccion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDireccion.ForeColor = System.Drawing.Color.DimGray;
            this.tbDireccion.Location = new System.Drawing.Point(608, 400);
            this.tbDireccion.Margin = new System.Windows.Forms.Padding(6);
            this.tbDireccion.MaxLength = 32767;
            this.tbDireccion.Multiline = true;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Padding = new System.Windows.Forms.Padding(10);
            this.tbDireccion.PasswordChar = false;
            this.tbDireccion.Size = new System.Drawing.Size(623, 83);
            this.tbDireccion.TabIndex = 5;
            this.tbDireccion.Texts = "";
            this.tbDireccion.UnderlinedStyle = true;
            // 
            // lblNumeroCedula
            // 
            this.lblNumeroCedula.AutoSize = true;
            this.lblNumeroCedula.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCedula.Location = new System.Drawing.Point(445, 291);
            this.lblNumeroCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroCedula.Name = "lblNumeroCedula";
            this.lblNumeroCedula.Size = new System.Drawing.Size(65, 18);
            this.lblNumeroCedula.TabIndex = 11;
            this.lblNumeroCedula.Text = "Cédula:";
            this.lblNumeroCedula.Click += new System.EventHandler(this.lblNumeroCedula_Click);
            // 
            // tbNumeroTelefono
            // 
            this.tbNumeroTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(210)))), ((int)(((byte)(178)))));
            this.tbNumeroTelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(136)))), ((int)(((byte)(115)))));
            this.tbNumeroTelefono.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.tbNumeroTelefono.BorderSize = 2;
            this.tbNumeroTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNumeroTelefono.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeroTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.tbNumeroTelefono.Location = new System.Drawing.Point(608, 335);
            this.tbNumeroTelefono.Margin = new System.Windows.Forms.Padding(6);
            this.tbNumeroTelefono.MaxLength = 32767;
            this.tbNumeroTelefono.Multiline = false;
            this.tbNumeroTelefono.Name = "tbNumeroTelefono";
            this.tbNumeroTelefono.Padding = new System.Windows.Forms.Padding(10);
            this.tbNumeroTelefono.PasswordChar = false;
            this.tbNumeroTelefono.Size = new System.Drawing.Size(623, 39);
            this.tbNumeroTelefono.TabIndex = 4;
            this.tbNumeroTelefono.Texts = "";
            this.tbNumeroTelefono.UnderlinedStyle = true;
            // 
            // tbNumeroCedula
            // 
            this.tbNumeroCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(210)))), ((int)(((byte)(178)))));
            this.tbNumeroCedula.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(136)))), ((int)(((byte)(115)))));
            this.tbNumeroCedula.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.tbNumeroCedula.BorderSize = 2;
            this.tbNumeroCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNumeroCedula.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeroCedula.ForeColor = System.Drawing.Color.DimGray;
            this.tbNumeroCedula.Location = new System.Drawing.Point(608, 270);
            this.tbNumeroCedula.Margin = new System.Windows.Forms.Padding(6);
            this.tbNumeroCedula.MaxLength = 32767;
            this.tbNumeroCedula.Multiline = false;
            this.tbNumeroCedula.Name = "tbNumeroCedula";
            this.tbNumeroCedula.Padding = new System.Windows.Forms.Padding(10);
            this.tbNumeroCedula.PasswordChar = false;
            this.tbNumeroCedula.Size = new System.Drawing.Size(623, 39);
            this.tbNumeroCedula.TabIndex = 3;
            this.tbNumeroCedula.Texts = "";
            this.tbNumeroCedula.UnderlinedStyle = true;
            // 
            // tbOcupacion
            // 
            this.tbOcupacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(210)))), ((int)(((byte)(178)))));
            this.tbOcupacion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(136)))), ((int)(((byte)(115)))));
            this.tbOcupacion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.tbOcupacion.BorderSize = 2;
            this.tbOcupacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOcupacion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOcupacion.ForeColor = System.Drawing.Color.DimGray;
            this.tbOcupacion.Location = new System.Drawing.Point(608, 522);
            this.tbOcupacion.Margin = new System.Windows.Forms.Padding(6);
            this.tbOcupacion.MaxLength = 32767;
            this.tbOcupacion.Multiline = false;
            this.tbOcupacion.Name = "tbOcupacion";
            this.tbOcupacion.Padding = new System.Windows.Forms.Padding(10);
            this.tbOcupacion.PasswordChar = false;
            this.tbOcupacion.Size = new System.Drawing.Size(623, 39);
            this.tbOcupacion.TabIndex = 6;
            this.tbOcupacion.Texts = "";
            this.tbOcupacion.UnderlinedStyle = true;
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.AutoSize = true;
            this.lblOcupacion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupacion.Location = new System.Drawing.Point(445, 543);
            this.lblOcupacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(92, 18);
            this.lblOcupacion.TabIndex = 12;
            this.lblOcupacion.Text = "Ocupación:";
            this.lblOcupacion.Click += new System.EventHandler(this.lblOcupacion_Click);
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.Location = new System.Drawing.Point(445, 161);
            this.lblNombreCompleto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(153, 18);
            this.lblNombreCompleto.TabIndex = 8;
            this.lblNombreCompleto.Text = "Nombre Completo:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(110)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnConfiguracion);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 760);
            this.panel1.TabIndex = 15;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(70, 615);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(139, 50);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = global::HuellasDeEsperanzaC_.Properties.Resources.icons8_info_32;
            this.button8.Location = new System.Drawing.Point(12, 705);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(47, 43);
            this.button8.TabIndex = 1;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(210)))), ((int)(((byte)(178)))));
            this.panel4.Location = new System.Drawing.Point(3, 331);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 67);
            this.panel4.TabIndex = 3;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.btnConfiguracion.Image = global::HuellasDeEsperanzaC_.Properties.Resources.icons8_settings_40;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Location = new System.Drawing.Point(30, 331);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(247, 67);
            this.btnConfiguracion.TabIndex = 6;
            this.btnConfiguracion.Text = "    Configuración";
            this.btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.button6.Image = global::HuellasDeEsperanzaC_.Properties.Resources.icons8_animal_shelter_50;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(30, 258);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(247, 67);
            this.button6.TabIndex = 5;
            this.button6.Text = "   Ver Organizaciones";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.button3.Image = global::HuellasDeEsperanzaC_.Properties.Resources.icons8_pets_50;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(30, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(247, 67);
            this.button3.TabIndex = 2;
            this.button3.Text = "   Agregar Mascotas";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.button2.Image = global::HuellasDeEsperanzaC_.Properties.Resources.icons8_heart_with_dog_paw_50__1_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(30, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "   Adoptar Mascotas";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.button1.Image = global::HuellasDeEsperanzaC_.Properties.Resources.icons8_home_40;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(30, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "    Inicio";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(192)))), ((int)(((byte)(184)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(299, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 116);
            this.panel3.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HuellasDeEsperanzaC_.Properties.Resources.Huellas_Esperanza_LogoIcono;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(240)))), ((int)(((byte)(197)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(280, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1031, 36);
            this.panel5.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button11);
            this.panel6.Controls.Add(this.button10);
            this.panel6.Controls.Add(this.button9);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(884, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(147, 36);
            this.panel6.TabIndex = 9;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Image = global::HuellasDeEsperanzaC_.Properties.Resources.icons8_minimizar_32__1_;
            this.button11.Location = new System.Drawing.Point(27, 0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(40, 36);
            this.button11.TabIndex = 10;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(179)))), ((int)(((byte)(146)))));
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Image = global::HuellasDeEsperanzaC_.Properties.Resources.icons8_maximizar_32__1_;
            this.button10.Location = new System.Drawing.Point(67, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(40, 36);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.button9.BackgroundImage = global::HuellasDeEsperanzaC_.Properties.Resources.icons8_close_window_38;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(107, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 36);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // ConfiguracionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(210)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(1311, 760);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConfiguracionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox tbNombreCompleto;
        private HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox tbDireccion;
        private HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox customTextBox;
        private HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox tbNumeroTelefono;
        private HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox tbNumeroCedula;
        private HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox tbOcupacion;
        private HuellasDeEsperanzaC_.CustomUserControls.RoundButton btnGuardar;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNumeroTelefono;
        private System.Windows.Forms.Label lblNumeroCedula;
        private System.Windows.Forms.Label lblOcupacion;
        private CustomUserControls.CustomTextBox tbEmail;
        private Label label3;
        private Panel panel1;
        private CustomUserControls.RoundButton btnCerrarSesion;
        private Button button8;
        private Panel panel4;
        private Button btnConfiguracion;
        private Button button6;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Panel panel6;
        private Button button11;
        private Button button10;
        private Button button9;
    }
}