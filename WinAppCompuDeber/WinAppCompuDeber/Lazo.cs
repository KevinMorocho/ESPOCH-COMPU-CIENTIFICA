using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppCompuDeber
{
    class Lazo:Vector
    {
        public Lazo() { }
        public double Radio;
        public override void Encender(Bitmap lienzo)
        {
            double t, dt;
            //int a = 26;
            //int b = 39;
            //int c = 47;
            Vector objVector = new Vector();

            t = 0;
            dt = 0.002;
            do
            {
                objVector.x0 = x0 + Radio *(Math.Sin(2 * t));
                objVector.y0 = y0 + Radio *(Math.Cos(3 * t));
                /*objVector.x0 = (Math.Cos(5 * t)) * (Math.Sin(a * t));
                objVector.y0 = (Math.Sin(2 * t)) * (Math.Cos(b * t));*/
                objVector.color0 = color0;
                objVector.Encender(lienzo);
                t = t + dt;

            }
            while (t <= 2 * Math.PI);
            //while (t <= c);
        }
    }
}
