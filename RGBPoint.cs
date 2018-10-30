using System.Drawing;

namespace RGBCatcher
{
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
