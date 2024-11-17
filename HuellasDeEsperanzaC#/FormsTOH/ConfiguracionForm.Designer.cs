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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombreCompleto = new HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox();
            this.tbDireccion = new HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox();
            this.tbNumeroTelefono = new HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox();
            this.tbNumeroCedula = new HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox();
            this.tbOcupacion = new HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox();
            this.btnGuardar = new HuellasDeEsperanzaC_.CustomUserControls.RoundButton();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNumeroTelefono = new System.Windows.Forms.Label();
            this.lblNumeroCedula = new System.Windows.Forms.Label();
            this.lblOcupacion = new System.Windows.Forms.Label();
            this.btnRegresar = new HuellasDeEsperanzaC_.CustomUserControls.RoundButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(240)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 591);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HuellasDeEsperanzaC_.Properties.Resources.HuellasDeEsperanzaLogoMedianoNegro;
            this.pictureBox1.Location = new System.Drawing.Point(0, 105);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(52, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Configuración de Perfil";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRegresar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(427, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 591);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(472, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Editar Perfil";
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
            this.tbNombreCompleto.Location = new System.Drawing.Point(704, 140);
            this.tbNombreCompleto.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbNombreCompleto.MaxLength = 32767;
            this.tbNombreCompleto.Multiline = false;
            this.tbNombreCompleto.Name = "tbNombreCompleto";
            this.tbNombreCompleto.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.tbNombreCompleto.PasswordChar = false;
            this.tbNombreCompleto.Size = new System.Drawing.Size(436, 42);
            this.tbNombreCompleto.TabIndex = 1;
            this.tbNombreCompleto.Texts = "";
            this.tbNombreCompleto.UnderlinedStyle = true;
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
            this.tbDireccion.Location = new System.Drawing.Point(704, 203);
            this.tbDireccion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbDireccion.MaxLength = 32767;
            this.tbDireccion.Multiline = false;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.tbDireccion.PasswordChar = false;
            this.tbDireccion.Size = new System.Drawing.Size(436, 42);
            this.tbDireccion.TabIndex = 2;
            this.tbDireccion.Texts = "";
            this.tbDireccion.UnderlinedStyle = true;
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
            this.tbNumeroTelefono.Location = new System.Drawing.Point(704, 266);
            this.tbNumeroTelefono.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbNumeroTelefono.MaxLength = 32767;
            this.tbNumeroTelefono.Multiline = false;
            this.tbNumeroTelefono.Name = "tbNumeroTelefono";
            this.tbNumeroTelefono.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.tbNumeroTelefono.PasswordChar = false;
            this.tbNumeroTelefono.Size = new System.Drawing.Size(436, 42);
            this.tbNumeroTelefono.TabIndex = 3;
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
            this.tbNumeroCedula.Location = new System.Drawing.Point(704, 329);
            this.tbNumeroCedula.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbNumeroCedula.MaxLength = 32767;
            this.tbNumeroCedula.Multiline = false;
            this.tbNumeroCedula.Name = "tbNumeroCedula";
            this.tbNumeroCedula.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.tbNumeroCedula.PasswordChar = false;
            this.tbNumeroCedula.Size = new System.Drawing.Size(436, 42);
            this.tbNumeroCedula.TabIndex = 4;
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
            this.tbOcupacion.Location = new System.Drawing.Point(704, 391);
            this.tbOcupacion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbOcupacion.MaxLength = 32767;
            this.tbOcupacion.Multiline = false;
            this.tbOcupacion.Name = "tbOcupacion";
            this.tbOcupacion.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.tbOcupacion.PasswordChar = false;
            this.tbOcupacion.Size = new System.Drawing.Size(436, 42);
            this.tbOcupacion.TabIndex = 5;
            this.tbOcupacion.Texts = "";
            this.tbOcupacion.UnderlinedStyle = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(947, 455);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(193, 74);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNombreCompleto.Location = new System.Drawing.Point(491, 159);
            this.lblNombreCompleto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(137, 20);
            this.lblNombreCompleto.TabIndex = 8;
            this.lblNombreCompleto.Text = "Nombre Completo:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDireccion.Location = new System.Drawing.Point(491, 222);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 20);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNumeroTelefono.Location = new System.Drawing.Point(491, 284);
            this.lblNumeroTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(70, 20);
            this.lblNumeroTelefono.TabIndex = 10;
            this.lblNumeroTelefono.Text = "Teléfono:";
            // 
            // lblNumeroCedula
            // 
            this.lblNumeroCedula.AutoSize = true;
            this.lblNumeroCedula.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNumeroCedula.Location = new System.Drawing.Point(491, 347);
            this.lblNumeroCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroCedula.Name = "lblNumeroCedula";
            this.lblNumeroCedula.Size = new System.Drawing.Size(58, 20);
            this.lblNumeroCedula.TabIndex = 11;
            this.lblNumeroCedula.Text = "Cédula:";
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.AutoSize = true;
            this.lblOcupacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOcupacion.Location = new System.Drawing.Point(491, 410);
            this.lblOcupacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(83, 20);
            this.lblOcupacion.TabIndex = 12;
            this.lblOcupacion.Text = "Ocupación:";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(53, 455);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(193, 74);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // ConfiguracionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(210)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(1203, 591);
            this.Controls.Add(this.lblOcupacion);
            this.Controls.Add(this.lblNumeroCedula);
            this.Controls.Add(this.lblNumeroTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombreCompleto);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbOcupacion);
            this.Controls.Add(this.tbNumeroCedula);
            this.Controls.Add(this.tbNumeroTelefono);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbNombreCompleto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConfiguracionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
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
        private CustomUserControls.RoundButton btnRegresar;
    }
}