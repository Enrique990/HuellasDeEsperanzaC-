using System;
using System.Windows.Forms;

namespace HuellasDeEsperanzaC_.CustomUserControls
{
    partial class WaitingCard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaitingCard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTelefonoSolicitante = new System.Windows.Forms.Label();
            this.lblEmailSolicitante = new System.Windows.Forms.Label();
            this.lblNombreSolicitante = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombreMascota = new System.Windows.Forms.Label();
            this.btnRechazar = new HuellasDeEsperanzaC_.CustomUserControls.RoundButton();
            this.btnAceptar = new HuellasDeEsperanzaC_.CustomUserControls.RoundButton();
            this.circlePictureBox1 = new HuellasDeEsperanzaC_.CustomUserControls.CirclePictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRechazar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.lblTelefonoSolicitante);
            this.panel1.Controls.Add(this.lblEmailSolicitante);
            this.panel1.Controls.Add(this.lblNombreSolicitante);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.circlePictureBox1);
            this.panel1.Controls.Add(this.lblNombreMascota);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 192);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Info de el adoptante:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quiere adoptar a:";
            // 
            // lblTelefonoSolicitante
            // 
            this.lblTelefonoSolicitante.AutoSize = true;
            this.lblTelefonoSolicitante.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoSolicitante.Location = new System.Drawing.Point(141, 112);
            this.lblTelefonoSolicitante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoSolicitante.Name = "lblTelefonoSolicitante";
            this.lblTelefonoSolicitante.Size = new System.Drawing.Size(179, 20);
            this.lblTelefonoSolicitante.TabIndex = 7;
            this.lblTelefonoSolicitante.Text = "Nombre de Mascota";
            // 
            // lblEmailSolicitante
            // 
            this.lblEmailSolicitante.AutoSize = true;
            this.lblEmailSolicitante.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailSolicitante.Location = new System.Drawing.Point(141, 87);
            this.lblEmailSolicitante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailSolicitante.Name = "lblEmailSolicitante";
            this.lblEmailSolicitante.Size = new System.Drawing.Size(181, 20);
            this.lblEmailSolicitante.TabIndex = 6;
            this.lblEmailSolicitante.Text = "Email de Solicitante";
            // 
            // lblNombreSolicitante
            // 
            this.lblNombreSolicitante.AutoSize = true;
            this.lblNombreSolicitante.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSolicitante.Location = new System.Drawing.Point(21, 23);
            this.lblNombreSolicitante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreSolicitante.Name = "lblNombreSolicitante";
            this.lblNombreSolicitante.Size = new System.Drawing.Size(83, 20);
            this.lblNombreSolicitante.TabIndex = 5;
            this.lblNombreSolicitante.Text = "Nombre ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // lblNombreMascota
            // 
            this.lblNombreMascota.AutoSize = true;
            this.lblNombreMascota.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMascota.Location = new System.Drawing.Point(380, 23);
            this.lblNombreMascota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreMascota.Name = "lblNombreMascota";
            this.lblNombreMascota.Size = new System.Drawing.Size(222, 23);
            this.lblNombreMascota.TabIndex = 0;
            this.lblNombreMascota.Text = "Nombre de Mascota";
            // 
            // btnRechazar
            // 
            this.btnRechazar.BackColor = System.Drawing.Color.Red;
            this.btnRechazar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechazar.FlatAppearance.BorderSize = 0;
            this.btnRechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechazar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazar.ForeColor = System.Drawing.Color.White;
            this.btnRechazar.Location = new System.Drawing.Point(24, 132);
            this.btnRechazar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(167, 52);
            this.btnRechazar.TabIndex = 15;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(384, 132);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(167, 52);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // circlePictureBox1
            // 
            this.circlePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("circlePictureBox1.Image")));
            this.circlePictureBox1.Location = new System.Drawing.Point(315, 23);
            this.circlePictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.circlePictureBox1.Name = "circlePictureBox1";
            this.circlePictureBox1.Size = new System.Drawing.Size(43, 39);
            this.circlePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circlePictureBox1.TabIndex = 1;
            this.circlePictureBox1.TabStop = false;
            this.circlePictureBox1.Click += new System.EventHandler(this.circlePictureBox1_Click);
            // 
            // WaitingCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WaitingCard";
            this.Size = new System.Drawing.Size(629, 201);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombreMascota;
        private CirclePictureBox circlePictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTelefonoSolicitante;
        private System.Windows.Forms.Label lblEmailSolicitante;
        private System.Windows.Forms.Label lblNombreSolicitante;
        private RoundButton btnAceptar;
        private RoundButton btnRechazar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
