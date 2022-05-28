using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using System.Drawing;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
namespace SzescianTK18
{
    class okno : GameWindow
    {
        int obr = 0;
        int obrx = 0, obry = 0, obrz = 0;
        bool rodz = true;
        public okno(int width, int height)
            : base(width, height, GraphicsMode.Default, "OpenGL")
        {
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

        }
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
            var keyboard = OpenTK.Input.Keyboard.GetState();
            if (keyboard[OpenTK.Input.Key.Escape])
            {
                this.Exit();
            }

            if (keyboard[OpenTK.Input.Key.A])
            {
                obr += 5;
            }
            if (keyboard[OpenTK.Input.Key.D])
            {
                obr -= 5;
            }
            if (keyboard[OpenTK.Input.Key.W])
            {
                obrx += 5;
            }
            if (keyboard[OpenTK.Input.Key.S])
            {
                obry += 5;
            }
            if (keyboard[OpenTK.Input.Key.Z])
            {
                obrz += 5;
            }
            if (keyboard[OpenTK.Input.Key.Number1])
            {
                rodz = true;
                OnResize(e);
            }
            if (keyboard[OpenTK.Input.Key.Number2])
            {
                rodz = false;
                OnResize(e);
            }
        }


        void rysProstop(float dx, float dy, float dz, bool koloruj)
        {
            float dx_2 = dx / 2.0f;
            float dy_2 = dy / 2.0f;
            float dz_2 = dz / 2.0f;
            GL.Begin(PrimitiveType.Quads);
            if (koloruj) GL.Color3(1.0f, 0.0f, 0.0f);
            //tylna
            GL.Vertex3(-dx_2, -dy_2, -dz_2);
            GL.Vertex3(-dx_2, dy_2, -dz_2);
            GL.Vertex3(dx_2, dy_2, -dz_2);
            GL.Vertex3(dx_2, -dy_2, -dz_2);
            //przednia
            GL.Vertex3(-dx_2, -dy_2, dz_2);
            GL.Vertex3(-dx_2, dy_2, dz_2);
            GL.Vertex3(dx_2, dy_2, dz_2);
            GL.Vertex3(dx_2, -dy_2, dz_2);
            if (koloruj) GL.Color3(0.0f, 1.0f, 0.0f);
            //prawa
            GL.Vertex3(dx_2, -dy_2, dz_2);
            GL.Vertex3(dx_2, dy_2, dz_2);
            GL.Vertex3(dx_2, dy_2, -dz_2);
            GL.Vertex3(dx_2, -dy_2, -dz_2);
            //lewa
            GL.Vertex3(-dx_2, -dy_2, dz_2);
            GL.Vertex3(-dx_2, dy_2, dz_2);
            GL.Vertex3(-dx_2, dy_2, -dz_2);
            GL.Vertex3(-dx_2, -dy_2, -dz_2);
            if (koloruj) GL.Color3(0.0f, 0.0f, 1.0f);
            //górna
            GL.Vertex3(-dx_2, dy_2, dz_2);
            GL.Vertex3(dx_2, dy_2, dz_2);
            GL.Vertex3(dx_2, dy_2, -dz_2);
            GL.Vertex3(-dx_2, dy_2, -dz_2);
            //dolna
            GL.Vertex3(-dx_2, -dy_2, dz_2);
            GL.Vertex3(dx_2, -dy_2, dz_2);
            GL.Vertex3(dx_2, -dy_2, -dz_2);
            GL.Vertex3(-dx_2, -dy_2, -dz_2);

            GL.End();

        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.ClearColor(Color.CornflowerBlue);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.Translate(0, 0, -3.0);
            GL.Rotate(obrx, 1, 0, 0);
            GL.Rotate(obry, 0, 1, 0);
            GL.Rotate(obrz, 0, 0, 1);
            GL.Rotate(obr, 1, 0, 0);
            rysProstop(2, 2, 2, true);
            GL.Flush();
            this.SwapBuffers();
        }
        protected override void OnResize(EventArgs e)
        {
            // obszar renderingu - całe okno
            GL.Viewport(ClientRectangle);
            // wybór macierzy rzutowania
            GL.MatrixMode(MatrixMode.Projection);
            // macierz rzutowania = macierz jednostkowa
            GL.LoadIdentity();
            if (rodz)
                GL.Frustum(-2.0, 2.0, -2.0, 2.0, 1.0, 5.0);
            else
                GL.Ortho(-2.0, 2.0, -2.0, 2.0, 1.0, 5.0);
            GL.Enable(EnableCap.DepthTest);
        }
    }
}
