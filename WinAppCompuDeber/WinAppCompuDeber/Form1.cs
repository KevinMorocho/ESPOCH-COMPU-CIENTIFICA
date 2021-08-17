using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WinAppCompuDeber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap lienzo = new Bitmap(700, 500);

        //  Btn Segmentos
        private void button1_Click(object sender, EventArgs e)
        {
            Segmento S = new Segmento();
            S.x0 = -5;
            S.xf = 2;
            S.y0 = -3;
            S.yf = 6;
            S.color0 = Color.Black;
            S.Encender(lienzo);
            S.x0 = 6;
            S.y0 = 2;
            S.xf = 2;
            S.yf = 6;
            S.color0 = Color.Black;
            S.Encender(lienzo);
            S.x0 = 6;
            S.y0 = 2;
            S.xf = -5;
            S.yf = -3;
            S.color0 = Color.Black;
            S.Encender(lienzo);
            EspacioT.Image = lienzo;
        }

        //Btn Eje x/ Eje y
        private void button2_Click(object sender, EventArgs e)
        {
            Segmento S = new Segmento();
            S.x0 = -10;
            S.xf = 10;
            S.y0 = 0;
            S.yf = 0;
            S.color0 = Color.Red;
            S.Encender(lienzo);
            S.x0 = 0;
            S.xf = 0;
            S.y0 = -7;
            S.yf = 7;
            S.color0 = Color.Red;
            S.Encender(lienzo);
            EspacioT.Image = lienzo;

        }

        //Btn Lazo
        private void button3_Click(object sender, EventArgs e)
        {
            Lazo L = new Lazo();
            L.x0 = 2;
            L.y0 = 2;
            L.Radio = 1.2;
            L.color0 = Color.Black;
            L.Encender(lienzo);
            L.x0 = 4;
            L.y0 = -5;
            L.Radio = 1.5;
            L.color0 = Color.Black;
            L.Encender(lienzo);
            L.x0 = -7;
            L.y0 = 4;
            L.Radio = 2.5;
            L.color0 = Color.Black;
            L.Encender(lienzo);

            EspacioT.Image = lienzo;
        }

        //Btn Circunferencia
        private void button4_Click(object sender, EventArgs e)
        {
            Circunferencia c = new Circunferencia();
            c.Radio = 1.0;
            c.x0 = -8;
            c.y0 = 0;
            do
            {
                c.color0 = Color.Blue;
                c.Encender(lienzo);
                c.x0 = c.x0 + 0.2;
            } while (c.x0<=8);
            
            EspacioT.Image = lienzo;
        }


        //Btn Curvas
        private void button5_Click(object sender, EventArgs e)
        {
            Vector v = new Vector();
            double t, dt;
            t = -10;
            dt = 0.05;
            do
            {
                v.x0 = t;
                v.y0 = ((t * t) - 5)/10;
                v.color0 = Color.Black;
                v.Encender(lienzo);
                v.y0 = Math.Sin(t);
                v.color0 = Color.Blue;
                v.Encender(lienzo);
                v.y0 = Math.Cos(t);
                v.color0 = Color.Green;
                v.Encender(lienzo);
                t = t + dt;
            } while (t <= 10);
            EspacioT.Image = lienzo;
        }

        //Btn Bandera Bicolor
        private void button6_Click(object sender, EventArgs e)
        {
            int sx = 50;
            int sy = 60;

            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    
                    lienzo.SetPixel(i, j, Color.Gray);
                    if (j >= 251)
                    {
                        lienzo.SetPixel(i, j, Color.LightBlue);
                    }
                }
            }
            EspacioT.Image = lienzo;
        }

        //Btn Degradado de Bandera Bicolor
        private void button7_Click(object sender, EventArgs e)
        {
            int sx = 50;
            int sy = 60;
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                
                    lienzo.SetPixel(i, j, Color.FromArgb((int)((180 - 0.36 * (j))+(0.162*j)),(int)((180 - 0.36 * (j)) + (0.418 * (j))), (int)((180-0.36*(j))+(0.492*j))));
                    EspacioT.Image = lienzo;
                }
            }
        }

        //Btn Tapices o Paleta
        private void button8_Click(object sender, EventArgs e)
        {
                Color[] paleta1 = new Color[16];
                paleta1[0] = Color.Black;
                paleta1[1] = Color.Navy;
                paleta1[2] = Color.Green;
                paleta1[3] = Color.Aqua;
                paleta1[4] = Color.Red;
                paleta1[5] = Color.Purple;
                paleta1[6] = Color.Maroon;
                paleta1[7] = Color.LightGray;
                paleta1[8] = Color.DarkGray;
                paleta1[9] = Color.Blue;
                paleta1[10] = Color.Lime;
                paleta1[11] = Color.Silver;
                paleta1[12] = Color.Teal;
                paleta1[13] = Color.Fuchsia;
                paleta1[14] = Color.Yellow;
                paleta1[15] = Color.White;
               
            int colorT;
            Color c;
                for (int i = 0; i < 700; i++)
                {
                    for (int j = 0; j < 500; j++)
                    {
                        colorT = (i * 5+j*6) % 15;
                        c = paleta1[colorT];
                        lienzo.SetPixel(i, j, c);
                        EspacioT.Image = lienzo;
                    }

                }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //Btn Tapiz 1 
        private void button9_Click(object sender, EventArgs e)
        {
            Color[] paleta1 = new Color[16];
            paleta1[0] = Color.Black;
            paleta1[1] = Color.Navy;
            paleta1[2] = Color.Green;
            paleta1[3] = Color.Aqua;
            paleta1[4] = Color.Red;
            paleta1[5] = Color.Purple;
            paleta1[6] = Color.Maroon;
            paleta1[7] = Color.LightGray;
            paleta1[8] = Color.DarkGray;
            paleta1[9] = Color.Blue;
            paleta1[10] = Color.Lime;
            paleta1[11] = Color.Silver;
            paleta1[12] = Color.Teal;
            paleta1[13] = Color.Fuchsia;
            paleta1[14] = Color.Yellow;
            paleta1[15] = Color.White;

            int colorT;
            Color c;
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    colorT = (int)(((Math.Sin(i * Math.E + 1) + 1) * (Math.Sqrt(Math.Pow(j * 6.8, 1.4)) + 1)) % 16);
                    c = paleta1[colorT];
                    lienzo.SetPixel(i, j, c);
                    EspacioT.Image = lienzo;
                }

            }
        }

        //Btn Tapiz 2
        private void button10_Click(object sender, EventArgs e)
        {
            Color[] paleta1 = new Color[16];
            paleta1[0] = Color.Black;
            paleta1[1] = Color.Navy;
            paleta1[2] = Color.Green;
            paleta1[3] = Color.Aqua;
            paleta1[4] = Color.Red;
            paleta1[5] = Color.Purple;
            paleta1[6] = Color.Maroon;
            paleta1[7] = Color.LightGray;
            paleta1[8] = Color.DarkGray;
            paleta1[9] = Color.Blue;
            paleta1[10] = Color.Lime;
            paleta1[11] = Color.Silver;
            paleta1[12] = Color.Teal;
            paleta1[13] = Color.Fuchsia;
            paleta1[14] = Color.Yellow;
            paleta1[15] = Color.White;

            int colorT;
            Color c;
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    colorT = (int)(((Math.Sin(i + Math.PI) * Math.Cos(j * 0.3)) + Math.Pow(i, 1.7)) % 15);
                    c = paleta1[colorT];
                    lienzo.SetPixel(i, j, c);
                    EspacioT.Image = lienzo;
                }

            }
        }

        //Btn Tapiz 3
        private void button11_Click(object sender, EventArgs e)
        {
            Color[] paleta1 = new Color[16];
            paleta1[0] = Color.Black;
            paleta1[1] = Color.Navy;
            paleta1[2] = Color.Green;
            paleta1[3] = Color.Aqua;
            paleta1[4] = Color.Red;
            paleta1[5] = Color.Purple;
            paleta1[6] = Color.Maroon;
            paleta1[7] = Color.LightGray;
            paleta1[8] = Color.DarkGray;
            paleta1[9] = Color.Blue;
            paleta1[10] = Color.Lime;
            paleta1[11] = Color.Silver;
            paleta1[12] = Color.Teal;
            paleta1[13] = Color.Fuchsia;
            paleta1[14] = Color.Yellow;
            paleta1[15] = Color.White;

            int colorT;
            Color c;
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    colorT = (int)((Math.Cos(i + j) + 5) * (7.5)%15);
                    c = paleta1[colorT];
                    lienzo.SetPixel(i, j, c);
                    EspacioT.Image = lienzo;
                }

            }
        }

        //Btn Tapiz 4
        private void button12_Click(object sender, EventArgs e)
        {
            Color[] paleta1 = new Color[16];
            paleta1[0] = Color.Black;
            paleta1[1] = Color.Navy;
            paleta1[2] = Color.Green;
            paleta1[3] = Color.Aqua;
            paleta1[4] = Color.Red;
            paleta1[5] = Color.Purple;
            paleta1[6] = Color.Maroon;
            paleta1[7] = Color.LightGray;
            paleta1[8] = Color.DarkGray;
            paleta1[9] = Color.Blue;
            paleta1[10] = Color.Lime;
            paleta1[11] = Color.Silver;
            paleta1[12] = Color.Teal;
            paleta1[13] = Color.Fuchsia;
            paleta1[14] = Color.Yellow;
            paleta1[15] = Color.White;

            int colorT;
            Color c;
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    colorT = (int)(((i * j) + (20 * i) * (Math.Pow(Math.E, 10.9))) % 15);
                    c = paleta1[colorT];
                    lienzo.SetPixel(i, j, c);
                    EspacioT.Image = lienzo;
                }

            }
        }

        //Btn Tapiz 5
        private void button13_Click(object sender, EventArgs e)
        {
            Color[] paleta1 = new Color[16];
            paleta1[0] = Color.Black;
            paleta1[1] = Color.Navy;
            paleta1[2] = Color.Green;
            paleta1[3] = Color.Aqua;
            paleta1[4] = Color.Red;
            paleta1[5] = Color.Purple;
            paleta1[6] = Color.Maroon;
            paleta1[7] = Color.LightGray;
            paleta1[8] = Color.DarkGray;
            paleta1[9] = Color.Blue;
            paleta1[10] = Color.Lime;
            paleta1[11] = Color.Silver;
            paleta1[12] = Color.Teal;
            paleta1[13] = Color.Fuchsia;
            paleta1[14] = Color.Yellow;
            paleta1[15] = Color.White;

            int colorT;
            Color c;
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    colorT = (int)(((i * 10) * (Math.Pow(Math.E, 10.9))) % 15);
                    c = paleta1[colorT];
                    lienzo.SetPixel(i, j, c);
                    EspacioT.Image = lienzo;
                }

            }
        }

        //Btn Mezcla Tapiz
        private void button14_Click(object sender, EventArgs e)
        {
            Color[] paleta1 = new Color[16];
            paleta1[0] = Color.Black;
            paleta1[1] = Color.Navy;
            paleta1[2] = Color.Green;
            paleta1[3] = Color.Aqua;
            paleta1[4] = Color.Red;
            paleta1[5] = Color.Purple;
            paleta1[6] = Color.Maroon;
            paleta1[7] = Color.LightGray;
            paleta1[8] = Color.DarkGray;
            paleta1[9] = Color.Blue;
            paleta1[10] = Color.Lime;
            paleta1[11] = Color.Silver;
            paleta1[12] = Color.Teal;
            paleta1[13] = Color.Fuchsia;
            paleta1[14] = Color.Yellow;
            paleta1[15] = Color.White;

            int colorT;
            Color c;

            for (int sx = 0; sx < 233; sx++)
            {
                for (int sy = 0; sy < 250; sy++)
                {
                    colorT = (int)(((Math.Sin(sx * Math.E + 1) + 1) * (Math.Sqrt(Math.Pow(sy * 6.8, 1.4)) + 1)) % 16);
                    c = paleta1[colorT];
                    lienzo.SetPixel(sx, sy, c);
                    EspacioT.Image = lienzo;
                }
            }
            for (int sx = 233; sx < 466; sx++)
            {
                for (int sy = 0; sy < 250; sy++)
                {
                    colorT = (int)(((Math.Sin(sx + Math.PI) * Math.Cos(sy * 0.3)) + Math.Pow(sy, 1.7)) % 15);

                    c = paleta1[colorT];
                    lienzo.SetPixel(sx, sy, c);
                    EspacioT.Image = lienzo;
                }
            }
            for (int sx = 466; sx < 700; sx++)
            {
                for (int sy = 0; sy < 250; sy++)
                {
                    colorT = (int)((Math.Cos(sx + sy) + 5) * (7.5) % 15);
                    c = paleta1[colorT];
                    lienzo.SetPixel(sx, sy, c);
                    EspacioT.Image = lienzo;
                }
            }
            for (int sx = 0; sx < 233; sx++)
            {
                for (int sy = 250; sy < 500; sy++)
                {
                    colorT = (int)(((sx * sy) + (20 * sy) * (Math.Pow(Math.E, 10.9))) % 15);
                    c = paleta1[colorT];
                    lienzo.SetPixel(sx, sy, c);
                    EspacioT.Image = lienzo;
                }
            }
            for (int sx = 233; sx < 466; sx++)
            {
                for (int sy = 250; sy < 500; sy++)
                {
                    colorT = (int)(((Math.Sqrt(sx * sy / 10)) + Math.Cos(sx * sy)) % 15);
                    c = paleta1[colorT];
                    lienzo.SetPixel(sx, sy, c);
                    EspacioT.Image = lienzo;
                }
            }
            for (int sx = 466; sx < 700; sx++)
            {
                for (int sy = 250; sy < 500; sy++)
                {
                    colorT = (int)(((sx * 10) * (Math.Pow(Math.E, 10.9))) % 15);
                    c = paleta1[colorT];
                    lienzo.SetPixel(sx, sy, c);
                    EspacioT.Image = lienzo;
                }
            }
        }

        //Btn Tapiz Madera
        private void button15_Click(object sender, EventArgs e)
        {
            Color[] paleta2 = new Color[16];
            int colorT;
            Color c;
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    for(int a=0; a <= 15; a++)
                    {
                        paleta2[a] = Color.FromArgb((int)((4.06 * a) + 139), (int)(69 + (4.26 * a)), (int)(19 + (1.4 * a)));
                        colorT = (int)(((Math.Sqrt(i * j / 10)) + Math.Cos(i * j)) % 15);
                        c = paleta2[colorT];
                        lienzo.SetPixel(i, j, c);
                    }                    
                    EspacioT.Image = lienzo;
                }
                   
            }
            
           

        }

        //Btn Tapiz Piedra
        private void button16_Click(object sender, EventArgs e)
        {
            Color[] paleta2 = new Color[16];
            int colorT;
            Color c;
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    for (int a = 0; a <= 15; a++)
                    {
                        paleta2[a] = Color.FromArgb((int)(130-(3.53*a)), (int)(130 - (2.93 * a)), (int)(130 -(4.4 * a)));
                        colorT = (int)((Math.Cos(i * j) + 20) * (10) % 15);
                        c = paleta2[colorT];
                        lienzo.SetPixel(i, j, c);
                    }
                    EspacioT.Image = lienzo;
                }

            }
        }

        //Btn Tapiz Jean
        private void button17_Click(object sender, EventArgs e)
        {
            Color[] paleta2 = new Color[16];
            int colorT;
            Color c;
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    for (int a = 0; a <= 15; a++)
                    {
                        paleta2[a] = Color.FromArgb((int)(52 - (3.47 * a)), (int)(63 - (3.6 * a)), (int)(81 - (3.2 * a)));
                        colorT = (int)(((Math.Sin(i + Math.PI) % 16 - Math.Cos(j % 16)) + Math.Pow(i, 1.7)) % 16);
                        c = paleta2[colorT];
                        lienzo.SetPixel(i, j, c);
                    }
                    EspacioT.Image = lienzo;
                }

            }
        }

        //Btn Tapiz Cesped
        private void button18_Click(object sender, EventArgs e)
        {
            Color[] paleta2 = new Color[16];
            int colorT;
            Color c;
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    for (int a = 0; a <= 15; a++)
                    {
                        paleta2[a] = Color.FromArgb((int)(126 - (4.87 * a)), (int)(217 - (7.53 * a)), (int)(87 - (2.8 * a)));
                        colorT = (int)((Math.Pow(i / 4, 3) + Math.Pow(j / 2.5, 2)) % 15 + 1) * (int)((Math.Sqrt(Math.Pow(i * 3.7, 2) + Math.Pow(j * 3.7, 2))) + (i * i * 4 + j +j * 2.7)) % 15;
                        c = paleta2[colorT];
                        lienzo.SetPixel(i, j, c);
                    }
                    EspacioT.Image = lienzo;
                }

            }
        }

        //Btn Dinamico Se mueve circulito
        private void button19_Click(object sender, EventArgs e)
        {
            Circunferencia c = new Circunferencia();
            double x = -8;
            c.x0 = -8;
            c.Radio = 2;
            do
            {
                c.x0 = x;
                c.y0 = Math.Sqrt(Math.Pow(x, 2) + Math.Cos(x)) / Math.Sin(x + 1);
                c.color0 = Color.Blue;
                c.Encender(lienzo);
                EspacioT.Image = lienzo;
                EspacioT.Refresh();
                Thread.Sleep(25);
                x = x + 0.2;
                c.apagar(lienzo);
                EspacioT.Image = lienzo;
            } while (x <= 8);
        }

        private void EspacioT_Click(object sender, EventArgs e)
        {

        }

        //Btn Graáfica Vector estilo 3D
        private void button20_Click(object sender, EventArgs e)
        {
            double t = 0;
            Vector3D v3d = new Vector3D();
            do
            {
                v3d.x0 = 2 + 3 * Math.Cos(t);
                v3d.y0 = 1 + Math.Sin(t);
                v3d.z0 = 0;
                v3d.color0 = Color.Red;
                v3d.Encender(lienzo);
                EspacioT.Image = lienzo;
                t= t + 0.01;
            } while (t <= 6.3);
        }

        //Btn Prueba Parcial 2
        private void button21_Click(object sender, EventArgs e)
        {
            Vector v = new Vector();
            Segmento S = new Segmento();
            S.x0 = 2;
            S.xf = 4.5;
            S.y0 = -5;
            S.yf = 7;
            S.color0 = Color.Black;
            S.Encender(lienzo);
            double t, dt;
            t = -5;
            dt = 0.01;
            do
            {
                v.x0 = ((t * t) - 5) / 10;
                v.y0 = t;
                v.color0 = Color.Red;
                v.Encender(lienzo);
                t = t + dt;
            } while (t <= 7);
            EspacioT.Image = lienzo;
        }


        //Btn Prueba Reloj inversa
        private void button22_Click(object sender, EventArgs e)
        {
            Circunferencia c = new Circunferencia();
            Segmento s = new Segmento();
            c.x0 = 2;
            c.y0 = 3;
            c.Radio = 4;
            c.color0 = Color.Blue;
            c.Encender(lienzo);
            double t=0;

            do
            {
                s.x0 = 2;
                s.y0 = 3;
                s.xf = (2 + 3.5 * Math.Cos(t));
                s.yf = (2 + 3.5 * Math.Sin(t));
                s.color0 = Color.Red;
                s.Encender(lienzo);
                EspacioT.Image = lienzo;
                EspacioT.Refresh();
                Thread.Sleep(25);
                t = t + 0.2;
                s.apagar(lienzo);
                EspacioT.Image = lienzo;
            } while (t < 2 * Math.PI);

        }


        //Btn Cubo en 3D
        private void button23_Click(object sender, EventArgs e)
        {
            Segmento3D s3d = new Segmento3D();
            s3d.x0 = 0;
            s3d.y0 = 0;
            s3d.z0 = 0;
            s3d.xf = 0;
            s3d.yf = 6;
            s3d.zf = 0;
            s3d.color0 = Color.Red;
            s3d.Encender(lienzo);

            //EspacioT.Image = lienzo;
            s3d.xf = 4;
            s3d.yf = 0;
            s3d.color0 = Color.Blue;
            s3d.Encender(lienzo);
            //EspacioT.Image = lienzo;
            s3d.zf = 4;
            s3d.xf = 0;
            s3d.color0 = Color.Green;
            s3d.Encender(lienzo);
            EspacioT.Image = lienzo;
            //3
            s3d.x0 = 0;
            s3d.y0 = 6;
            s3d.z0 = 0;
            s3d.xf = 4;
            s3d.yf = 6;
            s3d.zf = 0;
            s3d.color0 = Color.Coral;
            s3d.Encender(lienzo);
            //4
            s3d.x0 = 4;
            s3d.y0 = 6;
            s3d.z0 = 0;
            s3d.xf = 4;
            s3d.yf = 0;
            s3d.zf = 0;
            s3d.color0 = Color.BlueViolet;
            s3d.Encender(lienzo);
            // 5
            s3d.x0 = 4;
            s3d.y0 = 6;
            s3d.z0 = 0;
            s3d.xf = 4;
            s3d.yf = 6;
            s3d.zf = 4;
            s3d.color0 = Color.Blue;
            s3d.Encender(lienzo);
            //6
            s3d.x0 = 0;
            s3d.y0 = 6;
            s3d.z0 = 4;
            s3d.color0 = Color.Aqua;
            s3d.Encender(lienzo);
            //7
            s3d.x0 = 0;
            s3d.y0 = 6;
            s3d.z0 = 0;
            s3d.xf = 0;
            s3d.yf = 6;
            s3d.zf = 4;
            s3d.color0 = Color.Black;
            s3d.Encender(lienzo);
            //8
            s3d.x0 = 0;
            s3d.y0 = 6;
            s3d.z0 = 4;
            s3d.xf = 0;
            s3d.yf = 0;
            s3d.zf = 4;
            s3d.color0 = Color.Black;
            s3d.Encender(lienzo);
        }

        //Btn Paraboloide Hoja
        private void button24_Click(object sender, EventArgs e)
        {
            double t = -5;
            double h, dh;
            double dt = 0.03;
            Vector3D v3d = new Vector3D();
            v3d.color0 = Color.Blue;
            do
            {
                h = -6;
                dh = 0.3;
                do
                {
                    v3d.x0 = t;
                    v3d.y0 = h;
                    v3d.z0 = ((t * t) - 2) / 5;
                    v3d.Encender(lienzo);
                    EspacioT.Image = lienzo;
                    h = h + dh;
                } while (h <= 4);
                t = t + dt;
            } while (t <= 5);
        }

        //Btn Paraboloide
        private void button25_Click(object sender, EventArgs e)
        {
            double t = -5;
            double h, dh;
            double dt = 0.01;
            Vector3D v3d = new Vector3D();
            v3d.color0 = Color.Blue;
            do
            {
                h = -4;
                dh = 0.1;
                do
                {
                    v3d.x0 = t;
                    v3d.y0 = h;
                    v3d.z0 = ((Math.Pow(t, 2) + Math.Pow(h, 2)) - 15) / 6;
                    v3d.Encender(lienzo);
                    EspacioT.Image = lienzo;
                    h = h + dh;
                } while (h <= 4);
                t = t + dt;
            } while (t <= 5);
        }

        //Btn Paraboloide Hiperbolico
        private void button26_Click(object sender, EventArgs e)
        {
            double t = -5;
            double h, dh;
            double dt = 0.01;
            Vector3D v3d = new Vector3D();
            v3d.color0 = Color.Blue;
            do
            {
                h = -4;
                dh = 0.1;
                do
                {
                    v3d.x0 = t;
                    v3d.y0 = h;
                    v3d.z0 = ((Math.Pow(t, 2) - Math.Pow(h, 2)) - 15) / 6;
                    v3d.Encender(lienzo);
                    EspacioT.Image = lienzo;
                    h = h + dh;
                } while (h <= 4);
                t = t + dt;
            } while (t <= 5);
        }

        //Btn Cilindro 
        private void button27_Click(object sender, EventArgs e)
        {
            double t = 0;
            double h, dh;
            double dt = 0.01;
            Vector3D v3d = new Vector3D();
            v3d.color0 = Color.Blue;
            do
            {
                h = -2;
                dh = 0.1;
                do
                {
                    v3d.x0 = 0+2*Math.Cos(t);
                    v3d.y0 = 0 + 2 * Math.Sin(t); ;
                    v3d.z0 = h;
                    v3d.Encender(lienzo);
                    EspacioT.Image = lienzo;
                    h = h + dh;
                } while (h <= 3);
                t = t + dt;
            } while (t <= 2*Math.PI);
        }

        //Btn Esfera
        private void button28_Click(object sender, EventArgs e)
        {
            double t = 0;
            double h, dh;
            double dt = 0.03;
            Vector3D v3d = new Vector3D();
            v3d.color0 = Color.Blue;
            do
            {
                h = -6;
                dh = 0.1;
                do
                {
                    v3d.x0 =  2 * Math.Sin(h) * Math.Cos(t);
                    v3d.y0 = 2 * Math.Cos(h) * Math.Cos(t);
                    v3d.z0 = 2 * Math.Sin(t);
                    //v3d.z0 = ((t * t) - 2) / 5;
                    v3d.Encender(lienzo);
                    EspacioT.Image = lienzo;
                    h = h + dh;
                } while (h <= 4);
                t = t + dt;
            } while (t <= 5);
        }

        //Btn Figura Inventada
        private void button29_Click(object sender, EventArgs e)
        {
            double t = 0;
            double h, dh;
            double dt = 0.03;
            Vector3D v3d = new Vector3D();
            v3d.color0 = Color.Blue;
            do
            {
                h = -6;
                dh = 0.1;
                do
                {
                    v3d.x0 = 2 * Math.Sin(h+1) * Math.Cos(t);
                    v3d.y0 = 2 * Math.Cos(h + 1);
                    v3d.z0 = 2 * Math.Sin(t);
                    //v3d.z0 = ((t * t) - 2) / 5;
                    v3d.Encender(lienzo);
                    EspacioT.Image = lienzo;
                    h = h + dh;
                } while (h <= 4);
                t = t + dt;
            } while (t <= 5);
        }

        //Btn ejemplo choques
        private void button30_Click(object sender, EventArgs e)
        {
            Segmento s = new Segmento();
            s.x0 = -2;
            s.xf = 3;
            s.y0 = 0;
            s.yf = 7.1;
            s.color0 = Color.Black;
            s.Encender(lienzo);
            Segmento s1 = new Segmento();
            s1.x0 = 3;
            s1.xf = 10;
            s1.y0 = 7.1;
            s1.yf = 0;
            s1.color0 = Color.Black;
            s1.Encender(lienzo);
            Segmento s2 = new Segmento();
            s2.x0 = 10;
            s2.xf = 3;
            s2.y0 = 0;
            s2.yf = -7.1;
            s2.color0 = Color.Black;
            s2.Encender(lienzo);
            EspacioT.Image = lienzo;
            Circunferencia c = new Circunferencia();
            c.Radio = 0.5;
            double t = 0;
            do
            {
                c.x0 = (-2 * (1 - t)) + (3 * t);
                c.y0 = (0 * (1 - t)) + (7.1 * t);
                c.color0 = Color.Red;
                c.Encender(lienzo);
                EspacioT.Image = lienzo;
                EspacioT.Refresh();
                Thread.Sleep(20);
                c.apagar(lienzo);
                EspacioT.Image = lienzo;
                t += 0.2;
            } while (t <= 1);
            c.Radio = 0.5;
            t = 0;
            do
            {
                c.x0 = (3 * (1 - t)) + (10 * t);
                c.y0 = (7.1 * (1 - t)) + (0 * t);
                c.color0 = Color.Red;
                c.Encender(lienzo);
                EspacioT.Image = lienzo;
                EspacioT.Refresh();
                Thread.Sleep(20);
                c.apagar(lienzo);
                EspacioT.Image = lienzo;
                t += 0.2;
            } while (t <= 1);
            c.Radio = 0.5;
            t = 0;
            do
            {
                c.x0 = (10 * (1 - t)) + (3 * t);
                c.y0 = (0 * (1 - t)) + (-7.1 * t);
                c.color0 = Color.Red;
                c.Encender(lienzo);
                EspacioT.Image = lienzo;
                EspacioT.Refresh();
                Thread.Sleep(200);
                c.apagar(lienzo);
                EspacioT.Image = lienzo;
                t += 0.3;
            } while (t <= 1);
        }

        //Btn 1 Onda
        private void button31_Click(object sender, EventArgs e)
        {
            
            Onda o = new Onda();
            double t = 0;
            //Sin animacion
            /*o.v = 9.3;
            o.w = 1.5;
            o.t = 0;
            o.graf(lienzo);
            EspacioT.Image = lienzo;*/

           //Con animacion
            do
            {
                o.v = 9.3;
                o.w = 1.5;
                o.graf(lienzo);
                EspacioT.Image = lienzo;
                EspacioT.Refresh();
                t = t + 0.1;
                o.t = t;
            } while (t <= 4);
        }

        //Btn Limpiar
        private void button32_Click(object sender, EventArgs e)
        {
            Vector v = new Vector();
            Bitmap lienzo = new Bitmap(700, 500);
            v.apagar(lienzo);
            EspacioT.Image = lienzo;
        }

        //Btn 2 ondas

        private void button33_Click(object sender, EventArgs e)
        {
            Onda o = new Onda();
            double t = 0;
            //sin animacion
            /*o.v = 9.3;
            o.w = 1.5;
            o.t = 0;
            o.interferencia(lienzo);
            EspacioT.Image = lienzo;*/

            //Con animacion
            do
            {
                o.v = 9.3;
                o.w = 1.5;
                o.interferencia(lienzo);
                EspacioT.Image = lienzo;
                EspacioT.Refresh();
                t = t + 0.1;
                o.t = t;
            } while (t <= 4);
        }

        //Btn onda 3D
        private void button34_Click(object sender, EventArgs e)
        {
            Onda o = new Onda();
            double t = 0;
            //Sin animacion
            /*o.v = 9.3;
            o.w = 2.5;
            o.t = 0;
            o.grafOnda3d(lienzo);
            EspacioT.Image = lienzo;*/

            //Animacion
            do
            {
                o.v = 9.3;
                o.w = 1.5;
                o.t = t;
                o.grafOnda3d(lienzo);
                EspacioT.Image = lienzo;
                Refresh();
                lienzo = null;
                lienzo = new Bitmap(700, 500);
                Thread.Sleep(5);
                t = t + 0.01;
            } while (t <= 4);
        }

        //Btn Animacion de 2 ondas 3D
        private void button35_Click(object sender, EventArgs e)
        {
            Onda o = new Onda();
            double t = 0;
            do
            {
                o.v = 9.3;
                o.w = 2.5;
                o.t = t;
                o.ondaMoverx2(lienzo);
                EspacioT.Image = lienzo;
                Refresh();
                lienzo = null;
                lienzo = new Bitmap(700, 500);
                Thread.Sleep(5);
                t = t + 0.01;
            } while (t <= 4);
        }
    }
}
