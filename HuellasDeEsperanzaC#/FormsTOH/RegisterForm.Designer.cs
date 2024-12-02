namespace HuellasDeEsperanzaC_.FormsTOH
{
    partial class RegisterForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundButton2 = new HuellasDeEsperanzaC_.CustomUserControls.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEsORA = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblORA3 = new System.Windows.Forms.Label();
            this.lblORA2 = new System.Windows.Forms.Label();
            this.lblORA1 = new System.Windows.Forms.Label();
            this.roundButton1 = new HuellasDeEsperanzaC_.CustomUserControls.RoundButton();
            this.tbNombreCompleto = new HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox();
            this.tbEmail = new HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox();
            this.tbPass = new HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox();
            this.tbDireccion = new HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox();
            this.tbTelefono = new HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox();
            this.tbDescripcion = new HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(240)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.roundButton2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 653);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HuellasDeEsperanzaC_.Properties.Resources.HuellasDeEsperanzaLogoMedianoNegro;
            this.pictureBox1.Location = new System.Drawing.Point(0, 81);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(125)))), ((int)(((byte)(106)))));
            this.roundButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.ForeColor = System.Drawing.Color.White;
            this.roundButton2.Location = new System.Drawing.Point(79, 281);
            this.roundButton2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(153, 60);
            this.roundButton2.TabIndex = 8;
            this.roundButton2.Text = "&Iniciar Sesión";
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "¿Ya tienes una cuenta?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(361, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "¡Regístrate!";
            // 
            // cbEsORA
            // 
            this.cbEsORA.AutoSize = true;
            this.cbEsORA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEsORA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbEsORA.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEsORA.Location = new System.Drawing.Point(392, 97);
            this.cbEsORA.Name = "cbEsORA";
            this.cbEsORA.Size = new System.Drawing.Size(447, 23);
            this.cbEsORA.TabIndex = 0;
            this.cbEsORA.Text = "¿Registrar como Organización de Rescate Animal?";
            this.cbEsORA.UseVisualStyleBackColor = true;
            this.cbEsORA.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.cbEsORA.Click += new System.EventHandler(this.isORA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre Completo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Correo Electrónico:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Contraseña:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblORA3
            // 
            this.lblORA3.AutoSize = true;
            this.lblORA3.Location = new System.Drawing.Point(367, 478);
            this.lblORA3.Name = "lblORA3";
            this.lblORA3.Size = new System.Drawing.Size(99, 18);
            this.lblORA3.TabIndex = 15;
            this.lblORA3.Text = "Descripción:";
            this.lblORA3.Visible = false;
            // 
            // lblORA2
            // 
            this.lblORA2.AutoSize = true;
            this.lblORA2.Location = new System.Drawing.Point(365, 349);
            this.lblORA2.Name = "lblORA2";
            this.lblORA2.Size = new System.Drawing.Size(153, 18);
            this.lblORA2.TabIndex = 14;
            this.lblORA2.Text = "Número Telefónico:";
            this.lblORA2.Visible = false;
            // 
            // lblORA1
            // 
            this.lblORA1.AutoSize = true;
            this.lblORA1.Location = new System.Drawing.Point(365, 300);
            this.lblORA1.Name = "lblORA1";
            this.lblORA1.Size = new System.Drawing.Size(82, 18);
            this.lblORA1.TabIndex = 13;
            this.lblORA1.Text = "Dirección:";
            this.lblORA1.Visible = false;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.roundButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(710, 540);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(145, 60);
            this.roundButton1.TabIndex = 7;
            this.roundButton1.Text = "&Registrarse";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
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
            this.tbNombreCompleto.Location = new System.Drawing.Point(528, 138);
            this.tbNombreCompleto.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombreCompleto.MaxLength = 30;
            this.tbNombreCompleto.Multiline = false;
            this.tbNombreCompleto.Name = "tbNombreCompleto";
            this.tbNombreCompleto.Padding = new System.Windows.Forms.Padding(7);
            this.tbNombreCompleto.PasswordChar = false;
            this.tbNombreCompleto.Size = new System.Drawing.Size(327, 33);
            this.tbNombreCompleto.TabIndex = 1;
            this.tbNombreCompleto.Texts = "";
            this.tbNombreCompleto.UnderlinedStyle = true;
            this.tbNombreCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombreCompleto_KeyPress);
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
            this.tbEmail.Location = new System.Drawing.Point(528, 187);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.MaxLength = 30;
            this.tbEmail.Multiline = false;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Padding = new System.Windows.Forms.Padding(7);
            this.tbEmail.PasswordChar = false;
            this.tbEmail.Size = new System.Drawing.Size(327, 33);
            this.tbEmail.TabIndex = 2;
            this.tbEmail.Texts = "";
            this.tbEmail.UnderlinedStyle = true;
            this.tbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEmail_KeyPress);
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(210)))), ((int)(((byte)(178)))));
            this.tbPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(136)))), ((int)(((byte)(115)))));
            this.tbPass.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.tbPass.BorderSize = 2;
            this.tbPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPass.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.ForeColor = System.Drawing.Color.DimGray;
            this.tbPass.Location = new System.Drawing.Point(528, 236);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbPass.MaxLength = 12;
            this.tbPass.Multiline = false;
            this.tbPass.Name = "tbPass";
            this.tbPass.Padding = new System.Windows.Forms.Padding(7);
            this.tbPass.PasswordChar = true;
            this.tbPass.Size = new System.Drawing.Size(327, 33);
            this.tbPass.TabIndex = 3;
            this.tbPass.Texts = "";
            this.tbPass.UnderlinedStyle = true;
            this.tbPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPass_KeyPress);
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
            this.tbDireccion.Location = new System.Drawing.Point(528, 285);
            this.tbDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.tbDireccion.MaxLength = 50;
            this.tbDireccion.Multiline = false;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Padding = new System.Windows.Forms.Padding(7);
            this.tbDireccion.PasswordChar = false;
            this.tbDireccion.Size = new System.Drawing.Size(327, 33);
            this.tbDireccion.TabIndex = 4;
            this.tbDireccion.Texts = "";
            this.tbDireccion.UnderlinedStyle = true;
            this.tbDireccion.Visible = false;
            this.tbDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOra1_KeyPress);
            // 
            // tbTelefono
            // 
            this.tbTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(210)))), ((int)(((byte)(178)))));
            this.tbTelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(136)))), ((int)(((byte)(115)))));
            this.tbTelefono.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.tbTelefono.BorderSize = 2;
            this.tbTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTelefono.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.tbTelefono.Location = new System.Drawing.Point(528, 334);
            this.tbTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelefono.MaxLength = 9;
            this.tbTelefono.Multiline = false;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Padding = new System.Windows.Forms.Padding(7);
            this.tbTelefono.PasswordChar = false;
            this.tbTelefono.Size = new System.Drawing.Size(327, 33);
            this.tbTelefono.TabIndex = 5;
            this.tbTelefono.Texts = "";
            this.tbTelefono.UnderlinedStyle = true;
            this.tbTelefono.Visible = false;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOra2_KeyPress);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(210)))), ((int)(((byte)(178)))));
            this.tbDescripcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(136)))), ((int)(((byte)(115)))));
            this.tbDescripcion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.tbDescripcion.BorderSize = 2;
            this.tbDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDescripcion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.ForeColor = System.Drawing.Color.DimGray;
            this.tbDescripcion.Location = new System.Drawing.Point(528, 383);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.tbDescripcion.MaxLength = 100;
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Padding = new System.Windows.Forms.Padding(7);
            this.tbDescripcion.PasswordChar = false;
            this.tbDescripcion.Size = new System.Drawing.Size(327, 113);
            this.tbDescripcion.TabIndex = 6;
            this.tbDescripcion.Texts = "";
            this.tbDescripcion.UnderlinedStyle = true;
            this.tbDescripcion.Visible = false;
            this.tbDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOra3_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblORA3);
            this.panel2.Controls.Add(this.tbDescripcion);
            this.panel2.Controls.Add(this.lblORA2);
            this.panel2.Controls.Add(this.cbEsORA);
            this.panel2.Controls.Add(this.lblORA1);
            this.panel2.Controls.Add(this.tbTelefono);
            this.panel2.Controls.Add(this.roundButton1);
            this.panel2.Controls.Add(this.tbPass);
            this.panel2.Controls.Add(this.tbDireccion);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbEmail);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbNombreCompleto);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(902, 653);
            this.panel2.TabIndex = 21;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCerrar);
            this.panel3.Controls.Add(this.btnMinimizar);
            this.panel3.Location = new System.Drawing.Point(788, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 41);
            this.panel3.TabIndex = 16;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::HuellasDeEsperanzaC_.Properties.Resources.icons8_eliminar_32;
            this.btnCerrar.Location = new System.Drawing.Point(66, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(49, 41);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::HuellasDeEsperanzaC_.Properties.Resources.icons8_subtract_32;
            this.btnMinimizar.Location = new System.Drawing.Point(19, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(49, 41);
            this.btnMinimizar.TabIndex = 0;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(210)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(902, 653);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private CustomUserControls.RoundButton roundButton1;
        private CustomUserControls.RoundButton roundButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbEsORA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblORA3;
        private System.Windows.Forms.Label lblORA2;
        private System.Windows.Forms.Label lblORA1;
        private CustomUserControls.CustomTextBox tbNombreCompleto;
        private CustomUserControls.CustomTextBox tbEmail;
        private CustomUserControls.CustomTextBox tbPass;
        private CustomUserControls.CustomTextBox tbDireccion;
        private CustomUserControls.CustomTextBox tbTelefono;
        private CustomUserControls.CustomTextBox tbDescripcion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
    }
}