using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppCompuDeber
{
    class Circunferencia:Lazo
    {

        public Circunferencia()
        {
        }

        public override void Encender(Bitmap lienzo)
        {
            Vector objVector = new Vector();
            double t, dt;
            t = 0;
            dt = 0.002;
            do
            {
                objVector.x0 = x0 + (Radio * (Math.Cos(t)));
                objVector.y0 = y0 + (Radio * (Math.Sin(t)));
                objVector.color0 = color0;
                objVector.Encender(lienzo);
                t = t + dt;
            } while (t <= 6.2832);
        }
    }
}
