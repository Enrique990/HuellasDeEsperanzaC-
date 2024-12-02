using HuellasDeEsperanzaC_.Models;
using HuellasDeEsperanzaC_.Servicio;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace HuellasDeEsperanzaC_.CustomUserControls
{
    public partial class WaitingCard : UserControl
    {
        private void circlePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Datos de la mascota
        public event EventHandler OnSelect = null;

        private int borderRadius = 30;
        private int borderSize = 0;
        private Color borderColor = Color.White;
        private GestorAdopcion gestorAdopcion;
        private GestorUsuario gestorUsuario;
        private int solicitudId;

        public int SolicitudId
        {
            get { return solicitudId; }
            set
            {
                solicitudId = value;
                CargarDatosSolicitud();
            }
        }

        // Constructor sin parámetros
        public WaitingCard()
        {
            InitializeComponent();
            ConfigurarControl();
            this.gestorAdopcion = new GestorAdopcion();
        }

        // Constructor con parámetros
        public WaitingCard(int solicitudId)
        {
            InitializeComponent();
            ConfigurarControl();

            this.solicitudId = solicitudId;
            this.gestorAdopcion = new GestorAdopcion();
            gestorUsuario = new GestorUsuario();

            CargarDatosSolicitud();
        }

        private void ConfigurarControl()
        {
            this.AutoSize = false;
            this.AutoScaleMode = AutoScaleMode.None;
            this.Size = new Size(466, 156);
            this.MinimumSize = new Size(466, 156);
            this.MaximumSize = new Size(466, 156);

            this.panel1.AutoSize = false;
            this.panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.panel1.BackColor = Color.White;
        }

        private void CargarDatosSolicitud()
        {
            SolicitudAdopcion solicitud = gestorAdopcion.ObtenerPrimeraSolicitudEnEsperaPorUsuario(solicitudId);
            if (solicitud != null)
            {
                Mascota mascota = gestorAdopcion.ObtenerMascotaPorId(solicitud.MascotaId);
                if (mascota != null)
                {
                    NombreMascota = mascota.Nombre;
                    ImagenMascota = CargarImagenMascota(mascota.RutaImagen);
                }

                Usuario usuario = gestorUsuario.ObtenerUsuarioPorId(solicitud.UsuarioId);
                if (usuario != null)
                {
                    NombreSolicitante = usuario.NombreCompleto;
                    EmailSolicitante = usuario.NombreUsuario;
                    TelefonoSolicitante = usuario.NumeroTelefono;
                }
            }
        }

        private Image CargarImagenMascota(string rutaImagen)
        {
            try
            {
                string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string fullPath = Path.Combine(projectDirectory, rutaImagen);
                if (string.IsNullOrEmpty(rutaImagen) || !File.Exists(fullPath))
                {
                    throw new FileNotFoundException();
                }

                return Image.FromFile(fullPath);
            }
            catch (Exception)
            {
                // Ruta de la imagen predeterminada
                string rutaImagenPredeterminada = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\icons8-pets-50.png");
                return Image.FromFile(rutaImagenPredeterminada);
            }
        }

        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; this.Invalidate(); }
        }

        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(5466, 156);
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, 466, 156, specified);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if (borderRadius > 2) // Panel con bordes redondeados
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    if (borderSize >= 1)
                    {
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else // Panel normal
            {
                this.Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        

        // Datos de la mascota
        public string NombreMascota
        {
            get { return lblNombreMascota.Text; }
            set { lblNombreMascota.Text = value; }
        }
        
        public Image ImagenMascota
        {
            get { return circlePictureBox1.Image; }
            set { circlePictureBox1.Image = value; }
        }

        // Datos del usuario
        public string NombreSolicitante
        {
            get { return lblNombreSolicitante.Text; }
            set { lblNombreSolicitante.Text = value; }
        }
        public string EmailSolicitante
        {
            get { return lblEmailSolicitante.Text; }
            set { lblEmailSolicitante.Text = value; }
        }
        public string TelefonoSolicitante
        {
            get { return lblTelefonoSolicitante.Text; }
            set { lblTelefonoSolicitante.Text = value; }
        }
    }
}
