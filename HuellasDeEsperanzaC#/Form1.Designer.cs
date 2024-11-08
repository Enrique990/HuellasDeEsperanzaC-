namespace HuellasDeEsperanzaC_
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageInicio = new System.Windows.Forms.TabPage();
            this.panelScrollable = new System.Windows.Forms.Panel();
            this.panelOrganizations = new System.Windows.Forms.Panel();
            this.btnDetalles3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDetalles2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.btnNextOrg = new System.Windows.Forms.Button();
            this.btnPrevOrg = new System.Windows.Forms.Button();
            this.pictureBoxOrganization = new System.Windows.Forms.PictureBox();
            this.lblOrganizations = new System.Windows.Forms.Label();
            this.panelHowToStart = new System.Windows.Forms.Panel();
            this.lblDonaciones = new System.Windows.Forms.Label();
            this.lblVoluntariado = new System.Windows.Forms.Label();
            this.lblAdopciones = new System.Windows.Forms.Label();
            this.btnHowToDonate = new System.Windows.Forms.Button();
            this.tbDonaciones = new System.Windows.Forms.TextBox();
            this.btnHowToVolunteer = new System.Windows.Forms.Button();
            this.tbVoluntariado = new System.Windows.Forms.TextBox();
            this.btnHowToAdopt = new System.Windows.Forms.Button();
            this.tbAdopciones = new System.Windows.Forms.TextBox();
            this.lblTutoriales = new System.Windows.Forms.Label();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.labelMission = new System.Windows.Forms.Label();
            this.lblWellcom = new System.Windows.Forms.Label();
            this.tabPageAdopciones = new System.Windows.Forms.TabPage();
            this.tabPageVoluntariado = new System.Windows.Forms.TabPage();
            this.tabPageDonaciones = new System.Windows.Forms.TabPage();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.labelFooter = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageInicio.SuspendLayout();
            this.panelScrollable.SuspendLayout();
            this.panelOrganizations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrganization)).BeginInit();
            this.panelHowToStart.SuspendLayout();
            this.panelWelcome.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 60);
            this.panelHeader.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(800, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Huellas de Esperanza";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageInicio);
            this.tabControlMain.Controls.Add(this.tabPageAdopciones);
            this.tabControlMain.Controls.Add(this.tabPageVoluntariado);
            this.tabControlMain.Controls.Add(this.tabPageDonaciones);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 60);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(800, 500);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageInicio
            // 
            this.tabPageInicio.Controls.Add(this.panelScrollable);
            this.tabPageInicio.Location = new System.Drawing.Point(4, 29);
            this.tabPageInicio.Name = "tabPageInicio";
            this.tabPageInicio.Size = new System.Drawing.Size(792, 467);
            this.tabPageInicio.TabIndex = 0;
            this.tabPageInicio.Text = "Inicio";
            // 
            // panelScrollable
            // 
            this.panelScrollable.AutoScroll = true;
            this.panelScrollable.Controls.Add(this.panelOrganizations);
            this.panelScrollable.Controls.Add(this.panelHowToStart);
            this.panelScrollable.Controls.Add(this.panelWelcome);
            this.panelScrollable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScrollable.Location = new System.Drawing.Point(0, 0);
            this.panelScrollable.Name = "panelScrollable";
            this.panelScrollable.Size = new System.Drawing.Size(792, 467);
            this.panelScrollable.TabIndex = 0;
            // 
            // panelOrganizations
            // 
            this.panelOrganizations.Controls.Add(this.btnDetalles3);
            this.panelOrganizations.Controls.Add(this.pictureBox2);
            this.panelOrganizations.Controls.Add(this.btnDetalles2);
            this.panelOrganizations.Controls.Add(this.pictureBox1);
            this.panelOrganizations.Controls.Add(this.btnDetalles);
            this.panelOrganizations.Controls.Add(this.btnNextOrg);
            this.panelOrganizations.Controls.Add(this.btnPrevOrg);
            this.panelOrganizations.Controls.Add(this.pictureBoxOrganization);
            this.panelOrganizations.Controls.Add(this.lblOrganizations);
            this.panelOrganizations.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrganizations.Location = new System.Drawing.Point(0, 464);
            this.panelOrganizations.Name = "panelOrganizations";
            this.panelOrganizations.Size = new System.Drawing.Size(771, 300);
            this.panelOrganizations.TabIndex = 0;
            // 
            // btnDetalles3
            // 
            this.btnDetalles3.Location = new System.Drawing.Point(553, 263);
            this.btnDetalles3.Name = "btnDetalles3";
            this.btnDetalles3.Size = new System.Drawing.Size(100, 30);
            this.btnDetalles3.TabIndex = 7;
            this.btnDetalles3.Text = "Ver Detalles";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(503, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnDetalles2
            // 
            this.btnDetalles2.Location = new System.Drawing.Point(335, 263);
            this.btnDetalles2.Name = "btnDetalles2";
            this.btnDetalles2.Size = new System.Drawing.Size(100, 30);
            this.btnDetalles2.TabIndex = 5;
            this.btnDetalles2.Text = "Ver Detalles";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(285, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnDetalles
            // 
            this.btnDetalles.Location = new System.Drawing.Point(118, 263);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(100, 30);
            this.btnDetalles.TabIndex = 0;
            this.btnDetalles.Text = "Ver Detalles";
            // 
            // btnNextOrg
            // 
            this.btnNextOrg.Location = new System.Drawing.Point(728, 130);
            this.btnNextOrg.Name = "btnNextOrg";
            this.btnNextOrg.Size = new System.Drawing.Size(40, 40);
            this.btnNextOrg.TabIndex = 1;
            this.btnNextOrg.Text = ">";
            // 
            // btnPrevOrg
            // 
            this.btnPrevOrg.Location = new System.Drawing.Point(4, 130);
            this.btnPrevOrg.Name = "btnPrevOrg";
            this.btnPrevOrg.Size = new System.Drawing.Size(40, 40);
            this.btnPrevOrg.TabIndex = 2;
            this.btnPrevOrg.Text = "<";
            // 
            // pictureBoxOrganization
            // 
            this.pictureBoxOrganization.Location = new System.Drawing.Point(68, 53);
            this.pictureBoxOrganization.Name = "pictureBoxOrganization";
            this.pictureBoxOrganization.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxOrganization.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOrganization.TabIndex = 3;
            this.pictureBoxOrganization.TabStop = false;
            // 
            // lblOrganizations
            // 
            this.lblOrganizations.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrganizations.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganizations.Location = new System.Drawing.Point(0, 0);
            this.lblOrganizations.Name = "lblOrganizations";
            this.lblOrganizations.Size = new System.Drawing.Size(771, 38);
            this.lblOrganizations.TabIndex = 4;
            this.lblOrganizations.Text = "Organizaciones asociadas";
            this.lblOrganizations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHowToStart
            // 
            this.panelHowToStart.Controls.Add(this.lblDonaciones);
            this.panelHowToStart.Controls.Add(this.lblVoluntariado);
            this.panelHowToStart.Controls.Add(this.lblAdopciones);
            this.panelHowToStart.Controls.Add(this.btnHowToDonate);
            this.panelHowToStart.Controls.Add(this.tbDonaciones);
            this.panelHowToStart.Controls.Add(this.btnHowToVolunteer);
            this.panelHowToStart.Controls.Add(this.tbVoluntariado);
            this.panelHowToStart.Controls.Add(this.btnHowToAdopt);
            this.panelHowToStart.Controls.Add(this.tbAdopciones);
            this.panelHowToStart.Controls.Add(this.lblTutoriales);
            this.panelHowToStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHowToStart.Location = new System.Drawing.Point(0, 100);
            this.panelHowToStart.Name = "panelHowToStart";
            this.panelHowToStart.Size = new System.Drawing.Size(771, 364);
            this.panelHowToStart.TabIndex = 1;
            this.panelHowToStart.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHowToStart_Paint);
            // 
            // lblDonaciones
            // 
            this.lblDonaciones.AutoSize = true;
            this.lblDonaciones.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonaciones.Location = new System.Drawing.Point(549, 75);
            this.lblDonaciones.Name = "lblDonaciones";
            this.lblDonaciones.Size = new System.Drawing.Size(101, 23);
            this.lblDonaciones.TabIndex = 9;
            this.lblDonaciones.Text = "Donaciones";
            // 
            // lblVoluntariado
            // 
            this.lblVoluntariado.AutoSize = true;
            this.lblVoluntariado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoluntariado.Location = new System.Drawing.Point(281, 77);
            this.lblVoluntariado.Name = "lblVoluntariado";
            this.lblVoluntariado.Size = new System.Drawing.Size(113, 23);
            this.lblVoluntariado.TabIndex = 8;
            this.lblVoluntariado.Text = "Voluntariado";
            this.lblVoluntariado.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAdopciones
            // 
            this.lblAdopciones.AutoSize = true;
            this.lblAdopciones.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdopciones.Location = new System.Drawing.Point(17, 75);
            this.lblAdopciones.Name = "lblAdopciones";
            this.lblAdopciones.Size = new System.Drawing.Size(103, 23);
            this.lblAdopciones.TabIndex = 7;
            this.lblAdopciones.Text = "Adopciones";
            this.lblAdopciones.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnHowToDonate
            // 
            this.btnHowToDonate.Location = new System.Drawing.Point(583, 286);
            this.btnHowToDonate.Name = "btnHowToDonate";
            this.btnHowToDonate.Size = new System.Drawing.Size(150, 50);
            this.btnHowToDonate.TabIndex = 0;
            this.btnHowToDonate.Text = "Cómo Donar";
            // 
            // tbDonaciones
            // 
            this.tbDonaciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDonaciones.Location = new System.Drawing.Point(553, 108);
            this.tbDonaciones.Multiline = true;
            this.tbDonaciones.Name = "tbDonaciones";
            this.tbDonaciones.ReadOnly = true;
            this.tbDonaciones.Size = new System.Drawing.Size(208, 245);
            this.tbDonaciones.TabIndex = 6;
            this.tbDonaciones.Text = "Encuentra a tu compañero perfecto entre nuestras mascotas en adopción.";
            // 
            // btnHowToVolunteer
            // 
            this.btnHowToVolunteer.Location = new System.Drawing.Point(305, 286);
            this.btnHowToVolunteer.Name = "btnHowToVolunteer";
            this.btnHowToVolunteer.Size = new System.Drawing.Size(150, 50);
            this.btnHowToVolunteer.TabIndex = 1;
            this.btnHowToVolunteer.Text = "Cómo ser Voluntario";
            // 
            // tbVoluntariado
            // 
            this.tbVoluntariado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVoluntariado.Location = new System.Drawing.Point(277, 108);
            this.tbVoluntariado.Multiline = true;
            this.tbVoluntariado.Name = "tbVoluntariado";
            this.tbVoluntariado.ReadOnly = true;
            this.tbVoluntariado.Size = new System.Drawing.Size(208, 245);
            this.tbVoluntariado.TabIndex = 5;
            this.tbVoluntariado.Text = "Encuentra a tu compañero perfecto entre nuestras mascotas en adopción.";
            // 
            // btnHowToAdopt
            // 
            this.btnHowToAdopt.Location = new System.Drawing.Point(34, 286);
            this.btnHowToAdopt.Name = "btnHowToAdopt";
            this.btnHowToAdopt.Size = new System.Drawing.Size(150, 50);
            this.btnHowToAdopt.TabIndex = 2;
            this.btnHowToAdopt.Text = "Cómo Adoptar";
            this.btnHowToAdopt.Click += new System.EventHandler(this.buttonHowToAdopt_Click);
            // 
            // tbAdopciones
            // 
            this.tbAdopciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdopciones.Location = new System.Drawing.Point(10, 108);
            this.tbAdopciones.Multiline = true;
            this.tbAdopciones.Name = "tbAdopciones";
            this.tbAdopciones.ReadOnly = true;
            this.tbAdopciones.Size = new System.Drawing.Size(208, 245);
            this.tbAdopciones.TabIndex = 4;
            this.tbAdopciones.Text = "Encuentra a tu compañero perfecto entre nuestras mascotas en adopción.";
            // 
            // lblTutoriales
            // 
            this.lblTutoriales.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTutoriales.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutoriales.Location = new System.Drawing.Point(0, 0);
            this.lblTutoriales.Name = "lblTutoriales";
            this.lblTutoriales.Size = new System.Drawing.Size(771, 37);
            this.lblTutoriales.TabIndex = 3;
            this.lblTutoriales.Text = "Cómo Empezar";
            this.lblTutoriales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelWelcome
            // 
            this.panelWelcome.Controls.Add(this.labelMission);
            this.panelWelcome.Controls.Add(this.lblWellcom);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWelcome.Location = new System.Drawing.Point(0, 0);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(771, 100);
            this.panelWelcome.TabIndex = 3;
            // 
            // labelMission
            // 
            this.labelMission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMission.Location = new System.Drawing.Point(0, 37);
            this.labelMission.Name = "labelMission";
            this.labelMission.Size = new System.Drawing.Size(771, 63);
            this.labelMission.TabIndex = 0;
            this.labelMission.Text = "Nuestra misión es conectar a animales necesitados con familias amorosas, y apoyar" +
    " a las organizaciones que los cuidan.";
            this.labelMission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWellcom
            // 
            this.lblWellcom.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWellcom.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWellcom.Location = new System.Drawing.Point(0, 0);
            this.lblWellcom.Name = "lblWellcom";
            this.lblWellcom.Size = new System.Drawing.Size(771, 37);
            this.lblWellcom.TabIndex = 1;
            this.lblWellcom.Text = "Bienvenidos a Huellas de Esperanza";
            this.lblWellcom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWellcom.Click += new System.EventHandler(this.lblWellcom_Click);
            // 
            // tabPageAdopciones
            // 
            this.tabPageAdopciones.Location = new System.Drawing.Point(4, 29);
            this.tabPageAdopciones.Name = "tabPageAdopciones";
            this.tabPageAdopciones.Size = new System.Drawing.Size(792, 467);
            this.tabPageAdopciones.TabIndex = 1;
            this.tabPageAdopciones.Text = "Adopciones";
            // 
            // tabPageVoluntariado
            // 
            this.tabPageVoluntariado.Location = new System.Drawing.Point(4, 29);
            this.tabPageVoluntariado.Name = "tabPageVoluntariado";
            this.tabPageVoluntariado.Size = new System.Drawing.Size(792, 467);
            this.tabPageVoluntariado.TabIndex = 2;
            this.tabPageVoluntariado.Text = "Voluntariado";
            // 
            // tabPageDonaciones
            // 
            this.tabPageDonaciones.Location = new System.Drawing.Point(4, 29);
            this.tabPageDonaciones.Name = "tabPageDonaciones";
            this.tabPageDonaciones.Size = new System.Drawing.Size(792, 467);
            this.tabPageDonaciones.TabIndex = 3;
            this.tabPageDonaciones.Text = "Donaciones";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panelFooter.Controls.Add(this.labelFooter);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 560);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(800, 40);
            this.panelFooter.TabIndex = 1;
            // 
            // labelFooter
            // 
            this.labelFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFooter.ForeColor = System.Drawing.Color.White;
            this.labelFooter.Location = new System.Drawing.Point(0, 0);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(800, 40);
            this.labelFooter.TabIndex = 0;
            this.labelFooter.Text = "© 2024 Huellas de Esperanza. Todos los derechos reservados.";
            this.labelFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Huellas de Esperanza";
            this.panelHeader.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageInicio.ResumeLayout(false);
            this.panelScrollable.ResumeLayout(false);
            this.panelOrganizations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrganization)).EndInit();
            this.panelHowToStart.ResumeLayout(false);
            this.panelHowToStart.PerformLayout();
            this.panelWelcome.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageInicio;
        private System.Windows.Forms.Panel panelScrollable;
        private System.Windows.Forms.TabPage tabPageAdopciones;
        private System.Windows.Forms.TabPage tabPageVoluntariado;
        private System.Windows.Forms.TabPage tabPageDonaciones;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label lblWellcom;
        private System.Windows.Forms.Label labelMission;
        private System.Windows.Forms.Panel panelHowToStart;
        private System.Windows.Forms.Label lblTutoriales;
        private System.Windows.Forms.Button btnHowToAdopt;
        private System.Windows.Forms.Button btnHowToVolunteer;
        private System.Windows.Forms.Button btnHowToDonate;
        private System.Windows.Forms.Panel panelOrganizations;
        private System.Windows.Forms.Label lblOrganizations;
        private System.Windows.Forms.PictureBox pictureBoxOrganization;
        private System.Windows.Forms.Button btnPrevOrg;
        private System.Windows.Forms.Button btnNextOrg;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelFooter;
        private System.Windows.Forms.Button btnDetalles3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDetalles2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbAdopciones;
        private System.Windows.Forms.Label lblAdopciones;
        private System.Windows.Forms.TextBox tbDonaciones;
        private System.Windows.Forms.TextBox tbVoluntariado;
        private System.Windows.Forms.Label lblVoluntariado;
        private System.Windows.Forms.Label lblDonaciones;
    }
}