using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace WinAppCompuDeber
{
    class CuerdaV : Vector
    {
        public double tp;
        public Color c;
        public CuerdaV()
        {

        }
        ~CuerdaV()
        { }
        public void Fourier(double x, out double fou)
        {
            double an, bn, sumF = 0, c;
            c = 2;
            int n = 0;

            do
            {
                n = n + 1;
                an = (0.5 / 6) * (4 * 0.25 * Math.Sin(n * 3.14 * 0.5) + 0.5 * Math.Sin(n * 3.14));
                an = an * (4);
                bn = (1) * (4 * 1 * Math.Sin(n * 3.14 * 0.5) + 1 * Math.Sin(n * 3.14));
                bn = bn * 2 / (n * 3.14 * c);
                sumF = sumF + (an * Math.Cos((n * 3.14 * c * tp)) + bn * Math.Sin((n * 3.14 * c * tp))) * Math.Sin(n * 3.14 * x / 0.5);

            } while (n <= 18);

            fou = sumF;

        }

        public void Grafico(Bitmap pantalla)
        {
            double t = 0;
            double dt = 0.6;
            Vector v = new Vector();
            Segmento s = new Segmento();
            do
            {
                v.x0 = t;
                Fourier(t, out double fou);
                v.y0 = fou;
                s.xf = t;
                s.yf = fou;
                v.color0 = Color.Blue;
                v.Encender(pantalla);
                s.color0 = Color.Blue;
                s.Encender(pantalla);
                s.x0 = t;
                s.y0 = fou;
                t += dt;
            } while (t <= 6);
        }
    }
}
