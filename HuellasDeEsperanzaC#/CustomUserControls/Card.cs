using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuellasDeEsperanzaC_.CustomUserControls
{
    public partial class Card : UserControl
    {
        public event EventHandler OnSelect = null;

        private int borderRadius = 30;
        private int borderSize = 0;
        private Color borderColor = Color.White;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public Card()
        {
            InitializeComponent();
            this.AutoSize = false;
            this.AutoScaleMode = AutoScaleMode.None;
            this.Size = new Size(240, 300); 

            this.MinimumSize = new Size(240, 300);
            this.MaximumSize = new Size(240, 300);

            this.panel1.AutoSize = false;
            this.panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.panel1.BackColor = Color.White;
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
            this.Size = new Size(240, 300);
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, 240, 300, specified); 
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

        private void circlePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        //public enum Estado
        //{
        //    Disponible, EnEspera, Adoptado
        //}

        //public Estado EstadoMascota
        //{
        //    get { return EstadoMascota; }
        //    set { EstadoMascota = value; }
        //}

        public string CardNombreMascota
        {
            get { return lblNombreMascota.Text; }
            set { lblNombreMascota.Text = value; }
        }
        public string CardRaza
        {
            get { return lblRaza.Text; }
            set { lblRaza.Text = value; }
        }
        public string CardSexo
        {
            get { return lblSexo.Text; }
            set { lblSexo.Text = value; }
        }

        public string CardEdad
        {
            get { return lblEdad.Text; }
            set { lblEdad.Text = value; }
        }

        public Image CardImagen
        {
            get { return circlePictureBox1.Image; }
            set { circlePictureBox1.Image = value; }
        }

    }
}
