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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isORA = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblORA3 = new System.Windows.Forms.Label();
            this.lblORA2 = new System.Windows.Forms.Label();
            this.lblORA1 = new System.Windows.Forms.Label();
            this.tbOra3 = new HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox();
            this.tbOra2 = new HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox();
            this.tbOra1 = new HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox();
            this.customTextBox3 = new HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox();
            this.customTextBox2 = new HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox();
            this.customTextBox1 = new HuellasDeEsperanzaC_.CustomUserControls.CustomTextBox();
            this.roundButton1 = new HuellasDeEsperanzaC_.CustomUserControls.RoundButton();
            this.roundButton2 = new HuellasDeEsperanzaC_.CustomUserControls.RoundButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 30);
            this.label1.TabIndex = 1;
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
            this.label3.TabIndex = 2;
            this.label3.Text = "¡Regístrate!";
            // 
            // isORA
            // 
            this.isORA.AutoSize = true;
            this.isORA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.isORA.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isORA.Location = new System.Drawing.Point(395, 275);
            this.isORA.Name = "isORA";
            this.isORA.Size = new System.Drawing.Size(447, 23);
            this.isORA.TabIndex = 10;
            this.isORA.Text = "¿Registrar como Organización de Rescate Animal?";
            this.isORA.UseVisualStyleBackColor = true;
            this.isORA.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre Completo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Correo Electrónico:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Contraseña:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblORA3
            // 
            this.lblORA3.AutoSize = true;
            this.lblORA3.Location = new System.Drawing.Point(370, 428);
            this.lblORA3.Name = "lblORA3";
            this.lblORA3.Size = new System.Drawing.Size(99, 18);
            this.lblORA3.TabIndex = 19;
            this.lblORA3.Text = "Descripción:";
            this.lblORA3.Visible = false;
            // 
            // lblORA2
            // 
            this.lblORA2.AutoSize = true;
            this.lblORA2.Location = new System.Drawing.Point(370, 374);
            this.lblORA2.Name = "lblORA2";
            this.lblORA2.Size = new System.Drawing.Size(153, 18);
            this.lblORA2.TabIndex = 18;
            this.lblORA2.Text = "Número Telefónico:";
            this.lblORA2.Visible = false;
            // 
            // lblORA1
            // 
            this.lblORA1.AutoSize = true;
            this.lblORA1.Location = new System.Drawing.Point(370, 328);
            this.lblORA1.Name = "lblORA1";
            this.lblORA1.Size = new System.Drawing.Size(82, 18);
            this.lblORA1.TabIndex = 17;
            this.lblORA1.Text = "Dirección:";
            this.lblORA1.Visible = false;
            // 
            // tbOra3
            // 
            this.tbOra3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(210)))), ((int)(((byte)(178)))));
            this.tbOra3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(136)))), ((int)(((byte)(115)))));
            this.tbOra3.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.tbOra3.BorderSize = 2;
            this.tbOra3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOra3.ForeColor = System.Drawing.Color.DimGray;
            this.tbOra3.Location = new System.Drawing.Point(528, 428);
            this.tbOra3.Margin = new System.Windows.Forms.Padding(4);
            this.tbOra3.Multiline = true;
            this.tbOra3.Name = "tbOra3";
            this.tbOra3.Padding = new System.Windows.Forms.Padding(7);
            this.tbOra3.PasswordChar = false;
            this.tbOra3.Size = new System.Drawing.Size(327, 111);
            this.tbOra3.TabIndex = 16;
            this.tbOra3.Texts = "";
            this.tbOra3.UnderlinedStyle = true;
            this.tbOra3.Visible = false;
            // 
            // tbOra2
            // 
            this.tbOra2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(210)))), ((int)(((byte)(178)))));
            this.tbOra2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(136)))), ((int)(((byte)(115)))));
            this.tbOra2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.tbOra2.BorderSize = 2;
            this.tbOra2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOra2.ForeColor = System.Drawing.Color.DimGray;
            this.tbOra2.Location = new System.Drawing.Point(528, 359);
            this.tbOra2.Margin = new System.Windows.Forms.Padding(4);
            this.tbOra2.Multiline = false;
            this.tbOra2.Name = "tbOra2";
            this.tbOra2.Padding = new System.Windows.Forms.Padding(7);
            this.tbOra2.PasswordChar = false;
            this.tbOra2.Size = new System.Drawing.Size(327, 33);
            this.tbOra2.TabIndex = 15;
            this.tbOra2.Texts = "";
            this.tbOra2.UnderlinedStyle = true;
            this.tbOra2.Visible = false;
            // 
            // tbOra1
            // 
            this.tbOra1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(210)))), ((int)(((byte)(178)))));
            this.tbOra1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(136)))), ((int)(((byte)(115)))));
            this.tbOra1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.tbOra1.BorderSize = 2;
            this.tbOra1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOra1.ForeColor = System.Drawing.Color.DimGray;
            this.tbOra1.Location = new System.Drawing.Point(528, 313);
            this.tbOra1.Margin = new System.Windows.Forms.Padding(4);
            this.tbOra1.Multiline = false;
            this.tbOra1.Name = "tbOra1";
            this.tbOra1.Padding = new System.Windows.Forms.Padding(7);
            this.tbOra1.PasswordChar = false;
            this.tbOra1.Size = new System.Drawing.Size(327, 33);
            this.tbOra1.TabIndex = 14;
            this.tbOra1.Texts = "";
            this.tbOra1.UnderlinedStyle = true;
            this.tbOra1.Visible = false;
            // 
            // customTextBox3
            // 
            this.customTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(210)))), ((int)(((byte)(178)))));
            this.customTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(136)))), ((int)(((byte)(115)))));
            this.customTextBox3.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.customTextBox3.BorderSize = 2;
            this.customTextBox3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox3.Location = new System.Drawing.Point(528, 207);
            this.customTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox3.Multiline = false;
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBox3.PasswordChar = true;
            this.customTextBox3.Size = new System.Drawing.Size(327, 33);
            this.customTextBox3.TabIndex = 9;
            this.customTextBox3.Texts = "";
            this.customTextBox3.UnderlinedStyle = true;
            this.customTextBox3._TextChanged += new System.EventHandler(this.customTextBox3__TextChanged);
            // 
            // customTextBox2
            // 
            this.customTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(210)))), ((int)(((byte)(178)))));
            this.customTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(136)))), ((int)(((byte)(115)))));
            this.customTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.customTextBox2.BorderSize = 2;
            this.customTextBox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox2.Location = new System.Drawing.Point(528, 156);
            this.customTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox2.Multiline = false;
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBox2.PasswordChar = false;
            this.customTextBox2.Size = new System.Drawing.Size(327, 33);
            this.customTextBox2.TabIndex = 7;
            this.customTextBox2.Texts = "";
            this.customTextBox2.UnderlinedStyle = true;
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(210)))), ((int)(((byte)(178)))));
            this.customTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(136)))), ((int)(((byte)(115)))));
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.customTextBox1.BorderSize = 2;
            this.customTextBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox1.Location = new System.Drawing.Point(528, 105);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.Size = new System.Drawing.Size(327, 33);
            this.customTextBox1.TabIndex = 6;
            this.customTextBox1.Texts = "";
            this.customTextBox1.UnderlinedStyle = true;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(710, 569);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(145, 60);
            this.roundButton1.TabIndex = 5;
            this.roundButton1.Text = "Registrarse";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(125)))), ((int)(((byte)(106)))));
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.ForeColor = System.Drawing.Color.White;
            this.roundButton2.Location = new System.Drawing.Point(79, 281);
            this.roundButton2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(153, 60);
            this.roundButton2.TabIndex = 6;
            this.roundButton2.Text = "Iniciar Sesión";
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(210)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(902, 653);
            this.Controls.Add(this.lblORA3);
            this.Controls.Add(this.lblORA2);
            this.Controls.Add(this.lblORA1);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.tbOra3);
            this.Controls.Add(this.tbOra2);
            this.Controls.Add(this.tbOra1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isORA);
            this.Controls.Add(this.customTextBox3);
            this.Controls.Add(this.customTextBox2);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private CustomUserControls.CustomTextBox customTextBox1;
        private CustomUserControls.CustomTextBox customTextBox2;
        private CustomUserControls.CustomTextBox customTextBox3;
        private System.Windows.Forms.CheckBox isORA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblORA3;
        private System.Windows.Forms.Label lblORA2;
        private System.Windows.Forms.Label lblORA1;
        private CustomUserControls.CustomTextBox tbOra3;
        private CustomUserControls.CustomTextBox tbOra2;
        private CustomUserControls.CustomTextBox tbOra1;
    }
}