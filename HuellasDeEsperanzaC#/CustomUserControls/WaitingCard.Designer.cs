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
            this.roundButton2 = new HuellasDeEsperanzaC_.CustomUserControls.RoundButton();
            this.roundButton1 = new HuellasDeEsperanzaC_.CustomUserControls.RoundButton();
            this.circlePictureBox1 = new HuellasDeEsperanzaC_.CustomUserControls.CirclePictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.roundButton2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.roundButton1);
            this.panel1.Controls.Add(this.lblTelefonoSolicitante);
            this.panel1.Controls.Add(this.lblEmailSolicitante);
            this.panel1.Controls.Add(this.lblNombreSolicitante);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.circlePictureBox1);
            this.panel1.Controls.Add(this.lblNombreMascota);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 156);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Info de el adoptante:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quiere adoptar a:";
            // 
            // lblTelefonoSolicitante
            // 
            this.lblTelefonoSolicitante.AutoSize = true;
            this.lblTelefonoSolicitante.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoSolicitante.Location = new System.Drawing.Point(106, 91);
            this.lblTelefonoSolicitante.Name = "lblTelefonoSolicitante";
            this.lblTelefonoSolicitante.Size = new System.Drawing.Size(138, 16);
            this.lblTelefonoSolicitante.TabIndex = 7;
            this.lblTelefonoSolicitante.Text = "Nombre de Mascota";
            // 
            // lblEmailSolicitante
            // 
            this.lblEmailSolicitante.AutoSize = true;
            this.lblEmailSolicitante.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailSolicitante.Location = new System.Drawing.Point(106, 71);
            this.lblEmailSolicitante.Name = "lblEmailSolicitante";
            this.lblEmailSolicitante.Size = new System.Drawing.Size(136, 16);
            this.lblEmailSolicitante.TabIndex = 6;
            this.lblEmailSolicitante.Text = "Email de Solicitante";
            // 
            // lblNombreSolicitante
            // 
            this.lblNombreSolicitante.AutoSize = true;
            this.lblNombreSolicitante.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSolicitante.Location = new System.Drawing.Point(16, 19);
            this.lblNombreSolicitante.Name = "lblNombreSolicitante";
            this.lblNombreSolicitante.Size = new System.Drawing.Size(61, 16);
            this.lblNombreSolicitante.TabIndex = 5;
            this.lblNombreSolicitante.Text = "Nombre ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // lblNombreMascota
            // 
            this.lblNombreMascota.AutoSize = true;
            this.lblNombreMascota.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMascota.Location = new System.Drawing.Point(285, 19);
            this.lblNombreMascota.Name = "lblNombreMascota";
            this.lblNombreMascota.Size = new System.Drawing.Size(171, 18);
            this.lblNombreMascota.TabIndex = 0;
            this.lblNombreMascota.Text = "Nombre de Mascota";
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.Red;
            this.roundButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton2.ForeColor = System.Drawing.Color.White;
            this.roundButton2.Location = new System.Drawing.Point(18, 107);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(125, 42);
            this.roundButton2.TabIndex = 15;
            this.roundButton2.Text = "Rechazar";
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.roundButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(288, 107);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(125, 42);
            this.roundButton1.TabIndex = 8;
            this.roundButton1.Text = "Aceptar";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // circlePictureBox1
            // 
            this.circlePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("circlePictureBox1.Image")));
            this.circlePictureBox1.Location = new System.Drawing.Point(236, 19);
            this.circlePictureBox1.Name = "circlePictureBox1";
            this.circlePictureBox1.Size = new System.Drawing.Size(32, 32);
            this.circlePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circlePictureBox1.TabIndex = 1;
            this.circlePictureBox1.TabStop = false;
            this.circlePictureBox1.Click += new System.EventHandler(this.circlePictureBox1_Click);
            // 
            // WaitingCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel1);
            this.Name = "WaitingCard";
            this.Size = new System.Drawing.Size(472, 163);
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
        private RoundButton roundButton1;
        private RoundButton roundButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
