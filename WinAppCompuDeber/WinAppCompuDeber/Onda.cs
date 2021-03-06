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
        public double v, w, w1, w2, x, y, z, z1, z2, z3,m=0.6;
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

        //Interferencia 2 Ondas
        public void interferencia(Bitmap pantalla)
        {
            int i, j, colorO;

            for (i = 0; i < 700; i++)
            {
                for (j = 0; j < 500; j++)
                {
                    Procesos.transforma(i, j, out x, out y);
                    z1 = w * (Math.Sqrt((x - 0) * (x - 0) + (y - 3) * (y - 3))) - v * t;
                    z2 = w * (Math.Sqrt((x - 0) * (x - 0) + (y + 3) * (y + 3))) - v * t;
                    z3 = w * (Math.Sqrt((x - 0.5) * (x - 0.5) + (y + 0.5) * (y + 0.5))) - v * t;//tercera onda...

                    z1 = Math.Sin(z1) + 1;
                    z2 = Math.Sin(z2) + 1;
                    z3 = Math.Sin(z3) + 1;

                    z = z1 + z2 + z3;
                    colorO = (int)(z * 1.75);
                    c = Paleta[colorO];
                    pantalla.SetPixel(i, j, c);

                }

            }
        }

        public void grafOnda3d(Bitmap pantalla) 
        {
            Vector3D v3d = new Vector3D();
            x = -7;
            do
            {
                y = -5;
                do
                {
                    v3d.x0 = x;
                    v3d.y0 = y;
                    z = w * (Math.Sqrt((x - 0) * (x - 0) + (y - 0) * (y - 0))) - v * t;
                    z = m * Math.Sin(z);
                    v3d.z0 = z;
                    v3d.color0 = Color.Blue;
                    v3d.Encender(pantalla);
                    y = y + 0.1;
                } while (y <= 5);
                x = x + 0.1;
            } while (x <= 7);

        }

        public void ondaMoverx2(Bitmap bitmap)
        {
            Vector3D v3d = new Vector3D();
            double  p, p2, z, z0;
            
            x = -10;
            do
            {
                y = -5;
                do
                {
                    v3d.x0 = x;
                    v3d.y0 = y;

                    p = w * (Math.Sqrt((x - 0) * (x - 0) + (y - 0) * (y - 0))) - v * t;
                    z = 0.2 * Math.Sin(p);
                    v3d.color0 = Color.Blue;
                    v3d.z0 = z;
                    v3d.Encender(bitmap);

                    p2 = w * (Math.Sqrt((x + 3) * (x + 3) + (y - 0) * (y - 0))) - v * t;
                    z0 = 0.2 * Math.Sin(p2);
                    v3d.z0 = z0;
                    v3d.color0 = Color.Black;
                    v3d.Encender(bitmap);

                    y = y + 0.1;
                } while (y <= 5);
                x = x + 0.1;
            } while (x <= 10);

        }
    }
}

