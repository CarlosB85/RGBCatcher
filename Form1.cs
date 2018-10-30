using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGBCatcher
{
    public partial class Form1 : Form
    {
        private Nucleo _n;

        public const int LBL_ANCHO = 0;
        public const int LBL_ALTO = 1;
        public const int LBL_STATUS = 2;

        public Form1()
        {
            InitializeComponent();
            lst_puntos.DrawMode = DrawMode.OwnerDrawFixed;
            lst_puntos.DrawItem += listBox_DrawItem;
            _n = new Nucleo(this);
        }

        private void btn_probar_Click(object sender, EventArgs e)
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int offset_width = (int)inpt_auto_ancho.Value;
            int offset_height = (int)inpt_auto_largo.Value;
            int captura_ancho = (int)inpt_px_ancho.Value;
            int captura_alto = (int)inpt_px_largo.Value;
        }

        public void setText(int lbl, string texto)
        {
            switch (lbl)
            {
                case LBL_ALTO:
                    lbl_alto.Text = texto;
                    break;
                case LBL_ANCHO:
                    lbl_ancho.Text = texto;
                    break;
                case LBL_STATUS:
                    lbl_status.Text = texto;
                    break;
            }
        }

        internal void addPunto(RGBPoint rGBPoint)
        {
            lst_puntos.Items.Add(rGBPoint);
        }

        internal void quitarPunto(int indice)
        {
            if (lst_puntos.Items.Count >= indice)
            {
                lst_puntos.Items.RemoveAt(indice);
            }
        }

        internal void lst_refresh()
        {
            lst_puntos.Refresh();
        }

        internal ListBox.ObjectCollection getPuntos()
        {
            return lst_puntos.Items;
        }

        internal void limpiarPuntos()
        {
            lst_puntos.Items.Clear();
        }


        //iniciar
        private void button1_Click(object sender, EventArgs e)
        {
            _n.btn_iniciar_click();
        }

        //detener
        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                timer1.Stop();
            }
            lbl_status.Text = timer1.Enabled ? "Corriendo" : "Detenido";
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            segundosTimer2 = 2;
            timer2.Interval = 1000;
            timer2.Enabled = true;
            timer2.Start();
            lbl_status.Text = "Capturando 2 s";
        }

        private void listBox_DrawItem(object sender, DrawItemEventArgs e)
        {

            if (chk_preview.Checked)
            {
                if (chk_modo2.Checked)
                {
                    e.DrawBackground();
                    ListBox lb = (ListBox)sender;
                    RGBPoint pnt = (RGBPoint)lb.Items[e.Index];
                    Color cc = pnt.getc();

                    Graphics g = e.Graphics;
                    g.FillRectangle(new SolidBrush(Color.White), e.Bounds);

                    SizeF ss = g.MeasureString(pnt.ToString(), e.Font);
                    g.DrawString(pnt.ToString(), e.Font, new SolidBrush(Color.Black), new PointF(e.Bounds.X, e.Bounds.Y));
                    g.FillRectangle(new SolidBrush(cc), e.Bounds.X + ss.Width + 5, e.Bounds.Y, 18, e.Bounds.Height);
                    g.DrawString("R (" + cc.R + ")", e.Font, new SolidBrush(Color.FromArgb(cc.R, 0, 0)), new PointF(e.Bounds.X + ss.Width + 25, e.Bounds.Y));
                    g.DrawString("G (" + cc.G + ")", e.Font, new SolidBrush(Color.FromArgb(0, cc.G, 0)), new PointF(e.Bounds.X + ss.Width + 65, e.Bounds.Y));
                    g.DrawString("B (" + cc.B + ")", e.Font, new SolidBrush(Color.FromArgb(0, 0, cc.B)), new PointF(e.Bounds.X + ss.Width + 105, e.Bounds.Y));
                    g.DrawString("A (" + cc.B + ")", e.Font, new SolidBrush(Color.Black), new PointF(e.Bounds.X + ss.Width + 145, e.Bounds.Y));
                    e.DrawFocusRectangle();
                }
                else
                {
                    e.DrawBackground();
                    ListBox lb = (ListBox)sender;
                    RGBPoint pnt = (RGBPoint)lb.Items[e.Index];
                    Color cc = pnt.getc();

                    Graphics g = e.Graphics;
                    g.FillRectangle(new SolidBrush(cc), e.Bounds);

                    if ((cc.R + cc.G + cc.B) > 186)
                    {
                        cc = Color.Black;
                    }
                    else
                    {
                        cc = Color.White;
                    }

                    g.DrawString(pnt.ToString(), e.Font, new SolidBrush(cc), new PointF(e.Bounds.X, e.Bounds.Y));
                    e.DrawFocusRectangle();
                }
            }
            else
            {
                e.DrawBackground();
                e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);
                e.Graphics.DrawString(((RGBPoint)((ListBox)sender).Items[e.Index]).ToString(), e.Font, new SolidBrush(Color.Black), new PointF(e.Bounds.X, e.Bounds.Y));
                e.DrawFocusRectangle();
            }

        }

    }
}
