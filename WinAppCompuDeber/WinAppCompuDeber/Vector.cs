using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppCompuDeber
{
    class Vector
    {
        public double x0 { get; set; }
        public double y0 { get; set; }
        public Color color0 { get; set; }
        public Vector() { }

        public Vector(double x0, double y0, Color color0)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.color0 = color0;
        }

        public virtual void Encender(Bitmap lienzo)
        {
            int sx, sy;

            Procesos.pantalla(this.x0, this.y0, out sx, out sy);
            if (sx > 0 && sx < 700 && sy > 0 && sy < 500)
            {
                lienzo.SetPixel(sx, sy, color0);
            }

        }
        public virtual void apagar(Bitmap lienzo)
        {

            this.color0 = Color.White;
            Encender(lienzo);

        }
    }
}
