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
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        [DllImport("User32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("User32.dll")]
        public static extern void ReleaseDC(IntPtr hwnd, IntPtr dc);

        Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
        //List<Point> posiciones = new List<Point>();
        int segundosTimer2 = 3;
        int ancho_px = 1;
        int alto_px = 1;
        int temp_r = 0;
        int temp_g = 0;
        int temp_b = 0;
        int temp_a = 0;
        int temp_t = 0;
        Color temp_c;
        public Form1()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Tick += timer1_Tick;
            timer1 = new Timer();
            timer1.Tick += timer1_Tick;
            lst_puntos.DrawMode = DrawMode.OwnerDrawFixed;
            lst_puntos.DrawItem += listBox_DrawItem;
        }

        private void btn_probar_Click(object sender, EventArgs e)
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;

            lbl_ancho.Text = width + " px";
            lbl_alto.Text = height + " px";
        }

        public Color GetColorAt(Point location)
        {
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, ancho_px, alto_px, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                     gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            IntPtr desktopPtr = GetDC(IntPtr.Zero);
            Graphics g = Graphics.FromHdc(desktopPtr);
            g.DrawRectangle(new Pen(Color.Orange), new Rectangle(location.X, location.Y, ancho_px, alto_px));
            g.Dispose();
            ReleaseDC(IntPtr.Zero, desktopPtr);

            temp_r = 0;
            temp_g = 0;
            temp_b = 0;
            temp_a = 0;

            for (int px_x = 0; px_x < ancho_px; px_x++)
            {
                for (int px_y = 0; px_y < alto_px; px_y++)
                {
                    temp_c = screenPixel.GetPixel(px_x, px_y);
                    temp_r += temp_c.R;
                    temp_g += temp_c.G;
                    temp_b += temp_c.B;
                    temp_a += temp_c.A;
                }
            }
            temp_t = (ancho_px * alto_px);
            return Color.FromArgb(temp_a / temp_t, temp_r / temp_t, temp_g / temp_t, temp_b / temp_t);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            foreach (RGBPoint pnt in lst_puntos.Items)
            {
                var c = GetColorAt(pnt.getpnt());
                pnt.setc(c);

            }
            lbl_status.Text = timer1.Enabled ? "Corriendo" : "Detenido";
            lst_puntos.Refresh();
        }

        //iniciar
        private void button1_Click(object sender, EventArgs e)
        {
            ancho_px = (int)inpt_px_ancho.Value;
            alto_px = (int)inpt_px_largo.Value;
            screenPixel = new Bitmap(ancho_px, alto_px, PixelFormat.Format32bppArgb);
            if (!timer1.Enabled)
            {
                timer1.Interval = (int)inpt_delay.Value;
                timer1.Enabled = true;
                timer1.Start();
            }
            lbl_status.Text = timer1.Enabled ? "Corriendo" : "Detenido";
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

        private void addPunto(Point pnt)
        {
            lst_puntos.Items.Add(new RGBPoint(pnt, Color.White));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            segundosTimer2--;
            lbl_status.Text = "Capturando " + segundosTimer2 + " s";
            if (segundosTimer2 == 0)
            {
                timer2.Enabled = false;
                timer2.Stop();
                Point cursor = new Point();
                GetCursorPos(ref cursor);
                addPunto(cursor);
                lbl_status.Text = "listo.";
            }
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

    public class RGBPoint
    {
        private Point pnt;
        private Color c;

        public RGBPoint(Point pnt, Color c)
        {
            this.pnt = pnt;
            this.c = c;
        }

        public void setc(Color c) { this.c = c; }

        public Point getpnt() { return this.pnt; }

        public Color getc() { return this.c; }

        public string ToString()
        {
            return "X: " + pnt.X + " - Y: " + pnt.Y;
        }
    }
}
