using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseMundial
{
    public partial class FromMenu : Form
    {
        //Constructor
        public FromMenu()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelprincipal.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void panelprincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //METODO ABRIR FORMULARIO DENTRO DE UN PANEL.
        private void AbrirFormulario<MiFrom>() where MiFrom : Form, new() {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiFrom>().FirstOrDefault(); //busca en la coleccion en formulario, si el formulario no existe:
            if (formulario == null)
            {
                formulario = new MiFrom();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario existe:
            else
            {
                formulario.BringToFront();

            }

        }

        //PRIMER FORMULARIO
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormSelecciones>();
        }

        //PRIMER FORMULARIO
        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormDetGol>();
        }


        //PRIMER FORMULARIO
        //private void button3_Click(object sender, EventArgs e)
        //{
            //AbrirFormulario<FormEstadisJuga>();
        //}

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormEstadisPais>();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormEstaPartidos>();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //AQUI VA LO DE DANNY
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormRondas>();
        }
    }

}
