using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RGBCatcher
{
    public class Nucleo
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
        Timer timer1, timer2;

        private Form1 _f;

        public Nucleo(Form1 vista)
        {
            _f = vista;
            timer1 = new Timer(timer1_Tick);
            timer2 = new Timer(timer2_Tick);           
        }

        private void timer1_Tick(object state)
        {
            foreach (RGBPoint pnt in _f.getPuntos())
            {
                var c = GetColorAt(pnt.getpnt());
                pnt.setc(c);

            }
            _f.setText(Form1.LBL_STATUS, timer1.Enabled ? "Corriendo" : "Detenido");
            _f.lst_refresh();
        }

        private void timer2_Tick(object state)
        {
            segundosTimer2--;
            _f.setText(Form1.LBL_STATUS, "Capturando " + segundosTimer2 + " s");
            if (segundosTimer2 == 0)
            {
                timer2.Enabled = false;
                timer2.Stop();
                Point cursor = new Point();
                GetCursorPos(ref cursor);
                addPunto(cursor);
                _f.setText(Form1.LBL_STATUS, "listo.");
            }
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

            //IntPtr desktopPtr = GetDC(IntPtr.Zero);
            //Graphics g = Graphics.FromHdc(desktopPtr);
            //g.DrawRectangle(new Pen(Color.Orange), new Rectangle(location.X, location.Y, ancho_px, alto_px));
            //g.Dispose();
            //ReleaseDC(IntPtr.Zero, desktopPtr);

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

        public void btn_automatico_click(int ancho, int alto, int offset_ancho, int offset_alto, int captura_ancho, int captura_alto)
        {
            _f.setText(Form1.LBL_ANCHO, ancho + " px");
            _f.setText(Form1.LBL_ALTO, alto + " px");

            addPunto(new Point(offset_ancho, offset_alto));
            addPunto(new Point(ancho - (offset_ancho + captura_ancho), offset_alto));
            addPunto(new Point(offset_ancho, alto - (offset_alto + alto)));
            addPunto(new Point(ancho - (offset_ancho + captura_ancho), alto - (offset_alto + alto)));
        }

        internal void btn_iniciar_click()
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
            _f.setText(Form1.LBL_STATUS, timer1.Enabled ? "Corriendo" : "Detenido");
        }

        private void addPunto(Point pnt)
        {
            _f.addPunto(new RGBPoint(pnt, Color.White));
        }

        private void quitarPunto(int indice)
        {
            _f.quitarPunto(indice);
        }

        private void limpiarPuntos()
        {
            _f.limpiarPuntos();
        }

    }
}