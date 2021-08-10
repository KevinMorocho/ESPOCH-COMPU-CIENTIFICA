using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace WinAppCompuDeber
{
    class Onda : Vector
    {
        public double t;
        public int color;
        public Color c;
        public double v, w, w1, w2, x, y, z, z1, z2, z3;
        public Color[] Paleta = new Color[16];
        public Onda()
        {
            Paleta[0] = Color.Black;
            Paleta[1] = Color.Navy;
            Paleta[2] = Color.Green;
            Paleta[3] = Color.Aqua;
            Paleta[4] = Color.Red;
            Paleta[5] = Color.Purple;
            Paleta[6] = Color.Maroon;
            Paleta[7] = Color.LightGray;
            Paleta[8] = Color.DarkGray;
            Paleta[9] = Color.Blue;
            Paleta[10] = Color.Lime;
            Paleta[11] = Color.Silver;
            Paleta[12] = Color.Teal;
            Paleta[13] = Color.Fuchsia;
            Paleta[14] = Color.Yellow;
            Paleta[15] = Color.White;

            /*for (int k = 0; k < 16; k++)
            {

                int r = Convert.ToInt32((14.8 * k + 2) + 10);

                int g = Convert.ToInt32((3.8 * k + 4) + 194);

                int b = Convert.ToInt32((3.4 * k + 4) + 190);

                Paleta[k] = Color.FromArgb(r, g, b);

            }*/
        }

        //dibuja 1 onda
        public void graf(Bitmap pantalla)
        {

            double aux;
            Vector ov = new Vector();
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    transforma(i, j, out x, out y);
                    aux = w * (Math.Sqrt(x * x + y * y)) - v * t;
                    z = Math.Sin(aux) + 1;
                    color = (int)(z * 7.5);
                    c = Paleta[color];
                    pantalla.SetPixel(i, j, c);
                }
            }
        }
    }
}

