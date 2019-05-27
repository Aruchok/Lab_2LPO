using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2LPO
{
    public partial class Tniap : Form
    {

        Bitmap pic, picTemporary;
        Pen pen;
        Graphics g, gTemporary;

        int x1, y1, yCl, xCl;
        int x, y, count = 0;
        string mode;

        public Tniap()
        {
            mode = "Line";
            InitializeComponent();

            g = FieldDrawing.CreateGraphics();
            gTemporary = FieldDrawing.CreateGraphics();

            pic = new Bitmap(884, 313);
            picTemporary = new Bitmap(884, 313);

            pen = new Pen(Color.Black, 5);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = Graphics.FromImage(pic);
            gTemporary = Graphics.FromImage(picTemporary);

            x1 = y1 = 0;
        }

        private void Colour_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;

        }


        private void Square_Click(object sender, EventArgs e)
        {
            mode = "Square";
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            mode = "Circle";
        }

        private void Fill_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pic.Width; i++)
                for (int j = 0; j < pic.Height; j++)
                    pic.SetPixel(i, j, pen.Color);
            FieldDrawing.Image = pic;
        }

        private void Line_Click(object sender, EventArgs e)
        {
            mode = "Line";
        }

        private void Cleare_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            //for (int i = 0; i < pic.Width; i++)
            //    for (int j = 0; j < pic.Height; j++)
            //        pic.SetPixel(i, j, Color.White);
            FieldDrawing.Image = pic;
        }



        private void FieldDrawing_MouseUp(object sender, MouseEventArgs e)
        {

            if (mode == "Square")
            {
                g.DrawRectangle(pen, x, y, Math.Abs(e.X - xCl), Math.Abs(e.Y - yCl));
                FieldDrawing.Image = pic;
            }

            if (mode == "Circle")
            {
                g.DrawEllipse(pen, xCl, yCl, e.X - xCl, e.Y - yCl);
                FieldDrawing.Image = pic;
            }
        }

        private void FieldDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            xCl = e.X;
            yCl = e.Y;
        }

        private void FieldDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            pen.Width = Width.Value;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            if (e.Button == MouseButtons.Left)
            {
                if (mode == "Line")
                {
                    g.DrawLine(pen, x1, y1, e.X, e.Y);
                    FieldDrawing.Image = pic;
                }

                if (mode == "Square")
                {
                    gTemporary.Clear(Color.White);                    
                    x = xCl;
                    y = yCl;
                    if (x > e.X) x = e.X;
                    if (y > e.Y) y = e.Y;
                    gTemporary.DrawRectangle(pen, x, y, Math.Abs(e.X - xCl), Math.Abs(e.Y - yCl));
                    gTemporary.DrawImage(pic, 0, 0);
                    FieldDrawing.Image = picTemporary;
                }

                if (mode == "Circle")
                {
                    gTemporary.Clear(Color.White);
                    gTemporary.DrawEllipse(pen, xCl, yCl, e.X - xCl, e.Y - yCl);
                    gTemporary.DrawImage(pic, 0, 0);
                    FieldDrawing.Image = picTemporary;
                }
            }
            x1 = e.X;
            y1 = e.Y;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save.ShowDialog();
            if (Save.FileName != "")
            {
                pic.Save(Save.FileName);
            }

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open.ShowDialog();
            if (Open.FileName != "")
            {
                pic = (Bitmap)Image.FromFile(Open.FileName);
                FieldDrawing.Image = pic;
            }
        }
    }
}
