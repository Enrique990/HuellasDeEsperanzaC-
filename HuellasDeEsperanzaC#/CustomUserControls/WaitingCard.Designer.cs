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
            this.roundButton2 = new HuellasDeEsperanzaC_.CustomUserControls.RoundButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.roundButton1 = new HuellasDeEsperanzaC_.CustomUserControls.RoundButton();
            this.lblTelefonoSolicitante = new System.Windows.Forms.Label();
            this.lblEmailSolicitante = new System.Windows.Forms.Label();
            this.lblNombreSolicitante = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.circlePictureBox1 = new HuellasDeEsperanzaC_.CustomUserControls.CirclePictureBox();
            this.lblNombreMascota = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 192);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.Red;
            this.roundButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton2.ForeColor = System.Drawing.Color.White;
            this.roundButton2.Location = new System.Drawing.Point(24, 132);
            this.roundButton2.Margin = new System.Windows.Forms.Padding(4);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(167, 52);
            this.roundButton2.TabIndex = 15;
            this.roundButton2.Text = "Rechazar";
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Info de el adoptante:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quiere adoptar a:";
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.roundButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(384, 132);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(4);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(167, 52);
            this.roundButton1.TabIndex = 8;
            this.roundButton1.Text = "Aceptar";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // lblTelefonoSolicitante
            // 
            this.lblTelefonoSolicitante.AutoSize = true;
            this.lblTelefonoSolicitante.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoSolicitante.Location = new System.Drawing.Point(142, 112);
            this.lblTelefonoSolicitante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoSolicitante.Name = "lblTelefonoSolicitante";
            this.lblTelefonoSolicitante.Size = new System.Drawing.Size(138, 16);
            this.lblTelefonoSolicitante.TabIndex = 7;
            this.lblTelefonoSolicitante.Text = "Nombre de Mascota";
            // 
            // lblEmailSolicitante
            // 
            this.lblEmailSolicitante.AutoSize = true;
            this.lblEmailSolicitante.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailSolicitante.Location = new System.Drawing.Point(142, 87);
            this.lblEmailSolicitante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailSolicitante.Name = "lblEmailSolicitante";
            this.lblEmailSolicitante.Size = new System.Drawing.Size(136, 16);
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
            this.lblNombreSolicitante.Size = new System.Drawing.Size(61, 16);
            this.lblNombreSolicitante.TabIndex = 5;
            this.lblNombreSolicitante.Text = "Nombre ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // circlePictureBox1
            // 
            this.circlePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("circlePictureBox1.Image")));
            this.circlePictureBox1.Location = new System.Drawing.Point(274, 12);
            this.circlePictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.circlePictureBox1.Name = "circlePictureBox1";
            this.circlePictureBox1.Size = new System.Drawing.Size(43, 40);
            this.circlePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circlePictureBox1.TabIndex = 1;
            this.circlePictureBox1.TabStop = false;
            this.circlePictureBox1.Click += new System.EventHandler(this.circlePictureBox1_Click);
            // 
            // lblNombreMascota
            // 
            this.lblNombreMascota.AutoSize = true;
            this.lblNombreMascota.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMascota.Location = new System.Drawing.Point(381, 23);
            this.lblNombreMascota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreMascota.Name = "lblNombreMascota";
            this.lblNombreMascota.Size = new System.Drawing.Size(171, 18);
            this.lblNombreMascota.TabIndex = 0;
            this.lblNombreMascota.Text = "Nombre de Mascota";
            // 
            // WaitingCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WaitingCard";
            this.Size = new System.Drawing.Size(582, 201);
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
