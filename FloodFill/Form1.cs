
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Graphics rysuj;
        Bitmap przechwytywanie;
        Poligon figura = new Poligon();

        public void przygotuj()
        {
            przechwytywanie = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            rysuj = Graphics.FromImage(przechwytywanie);
        }

        //renderowanie jest wykonywane na bitmapie a następnie bitmapa jest wykorzystywana
        public void wyswietl()
        { 
            pictureBox1.Image = przechwytywanie;
        }

        public Form1()
        {
            InitializeComponent();
        }

        /// Zainicjuj formularz
        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            figura.read();
            figura.calcs();
            przygotuj();
        }

        /// Wypisz litere "A"
        private void DrawText()
        {
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            using (Font myFont = new Font("Times New Roman", 100))
            {
                g.DrawString("A", myFont, Brushes.Black, new PointF(0, 0));
            }
            g.Dispose();
            pictureBox1.Invalidate();
        }

        /// Szuka pierwszego czarnego piksela
        /// Wspolrzedne pierwszego czarnego piksela
        private Point FindFirstBlack()
        {
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            for (int y = 0; y < bitmap.Height; y++)
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color cl = bitmap.GetPixel(x, y);
                    if ((cl.R == 0) && (cl.G == 0) && (cl.B == 0)) return new Point(x, y);
                }
            return new Point(0, 0);
        }

        /// 8-kierunkowy reukrencyjny algorytm 
        private void FloodFill(int x,int y)
        {
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            if ((x < 0) || (y < 0) || (x >= bitmap.Width) || (y >= bitmap.Height)) return;  
            Color cl = bitmap.GetPixel(x,y);
            if ((cl.R != 0) || (cl.G != 0) || (cl.B != 0)) return; 
            bitmap.SetPixel(x,y,Color.FromArgb(255,255,0,0));            
            pictureBox1.Refresh();   
            FloodFill(x, y - 1);         
            FloodFill(x + 1, y - 1); 
            FloodFill(x + 1, y);    
            FloodFill(x + 1, y + 1); 
            FloodFill(x, y + 1);    
            FloodFill(x - 1, y + 1); 
            FloodFill(x - 1, y);     
            FloodFill(x - 1, y - 1); 
        }

        /// Obsluga klikniecia buttona - rozpocznij wypelnianie
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            DrawText();                 
            Point p = FindFirstBlack(); 
            FloodFill(p.X, p.Y);        
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            figura.read();
            figura.calcs();

            przygotuj();

            rysuj.Clear(Color.White);

            figura.draw(rysuj);

            rysuj.Dispose();

            wyswietl();

            przygotuj();

            rysuj.Clear(Color.White);

            figura.display(rysuj);

            rysuj.Dispose();

            wyswietl();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            przygotuj();

            rysuj.Clear(Color.White);

            rysuj.Dispose();

            wyswietl();
        }
    }
}
