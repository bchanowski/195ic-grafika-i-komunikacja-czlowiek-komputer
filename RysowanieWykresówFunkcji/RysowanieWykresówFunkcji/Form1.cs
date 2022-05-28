using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RysowanieWykresówFunkcji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private float F(float x)
        {
            float a = float.Parse(aText.Text);
            float b = float.Parse(bText.Text);
            float c = float.Parse(cText.Text);
            return (float)((a * x * x) + (b * x) + c);
        }
        private void MakeGraph()
        {
            // Pobranie granic.
            float xmin = float.Parse(Xmin.Text);
            float xmax = float.Parse(Xmax.Text);
            float ymin = float.Parse(Ymin.Text);
            float ymax = float.Parse(Ymax.Text);

            // Tworzenie bitmapy.
            int wid = pictureBox1.ClientSize.Width;
            int hgt = pictureBox1.ClientSize.Height;
            Bitmap bm = new Bitmap(wid, hgt);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;

                RectangleF rect = new RectangleF(
                    xmin, ymin, xmax - xmin, ymax - ymin);
                PointF[] pts =
                {
            new PointF(0, hgt),
            new PointF(wid, hgt),
            new PointF(0, 0),
        };
                gr.Transform = new Matrix(rect, pts);

                // Rysowanie funkcji.
                using (Pen graph_pen = new Pen(Color.Blue, 0))
                {
                    // Rysowanie wykresu.
                    gr.DrawLine(graph_pen, xmin, 0, xmax, 0);
                    gr.DrawLine(graph_pen, 0, ymin, 0, ymax);
                    for (int x = (int)xmin; x <= xmax; x++)
                    {
                        gr.DrawLine(graph_pen, x, -0.1f, x, 0.1f);
                    }
                    for (int y = (int)ymin; y <= ymax; y++)
                    {
                        gr.DrawLine(graph_pen, -0.1f, y, 0.1f, y);
                    }
                    graph_pen.Color = Color.Red;

                    
                    Matrix inverse = gr.Transform;
                    inverse.Invert();
                    PointF[] pixel_pts =
                    {
                new PointF(0, 0),
                new PointF(1, 0)
            };
                    inverse.TransformPoints(pixel_pts);
                    float dx = pixel_pts[1].X - pixel_pts[0].X;
                    dx /= 2;

                   
                    List<PointF> points = new List<PointF>();
                    for (float x = xmin; x <= xmax; x += dx)
                    {
                        bool valid_point = false;
                        try
                        {
                            float y = F(x);

                            if (points.Count == 0) valid_point = true;
                            else
                            {
                                float dy = y - points[points.Count - 1].Y;
                                if (Math.Abs(dy / dx) < 1000)
                                    valid_point = true;
                            }
                            if (valid_point) points.Add(new PointF(x, y));
                        }
                        catch
                        {
                        }

                        if (!valid_point)
                        {
                            if (points.Count > 1)
                                gr.DrawLines(graph_pen, points.ToArray());
                            points.Clear();
                        }

                    }

                    if (points.Count > 1)
                        gr.DrawLines(graph_pen, points.ToArray());
                }
            }

            pictureBox1.Image = bm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeGraph();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
