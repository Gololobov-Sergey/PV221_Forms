using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV221_Forms
{
    public partial class GDI : Form
    {
        List<Point> points = new List<Point>();

        public GDI()
        {
            InitializeComponent();


        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    using (Graphics g = this.CreateGraphics())
        //    {
        //        Font f = new Font("Comic Sans MS", 30, FontStyle.Bold | FontStyle.Italic);
        //        g.DrawString("Hello Win Forms", f, Brushes.Magenta, 50, 320);
        //    }
        //}

        private void GDI_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            Color c = new Color();
            
            Pen p = new Pen(Color.FromName("Red"), 10);

            g.DrawBezier(p, 12, 456, 23, 57, 79, 5, 677, 454);



            //p.StartCap = LineCap.ArrowAnchor;
            //p.EndCap = LineCap.RoundAnchor;

            //for (int i = 0; i < 10; i++)
            //{
            //    g.DrawLine(p, 50+10*i, 50, 250, 250);
            //    Thread.Sleep(1000);
            //    g.Clear(BackColor);
            //}

            //g.Clear(BackColor);

            //Graphics g = e.Graphics;
            //foreach (Point p in points)
            //{
            //    g.FillEllipse(Brushes.Red, p.X, p.Y, 10, 10);
            //}


            //Graphics g = CreateGraphics();
            //Pen p = new Pen(Color.Blue, 5);
            //Brush b = Brushes.Blue;
            //p.DashStyle = DashStyle.Solid;
            //g.FillEllipse(b, 200, 100, 400, 100);

            //Bitmap b = new Bitmap("qqqq.bmp");
            //Graphics g = e.Graphics;
            //g.DrawImage(b, 0, 0);
            //b.Dispose();
            //g.Dispose();


            //Graphics g = e.Graphics;
            //Pen p = new Pen(Color.Blue, 5);
            //Brush b = Brushes.Blue;
            //p.DashStyle = DashStyle.Solid;
            //g.FillEllipse(b, 200, 100, 400, 100);

            //Rectangle r = new Rectangle(0, 20, 800, 80);
            //LinearGradientBrush lg = new LinearGradientBrush(r, Color.Red, Color.Blue, 0f);
            //g.FillRectangle(lg, r);

            //Rectangle r1 = new Rectangle(0, 110, 800, 80);
            //HatchBrush hb = new HatchBrush(HatchStyle.Cross, Color.Blue, Color.Yellow);
            //g.FillRectangle(hb, r1);

            //Rectangle r2 = new Rectangle(0, 200, 800, 80);
            //TextureBrush tb = new TextureBrush(new Bitmap("arduino5804.jpg"));
            //g.FillRectangle(tb, r2);


            //Font f = new Font("Comic Sans MS", 30, FontStyle.Bold | FontStyle.Italic);
            //g.DrawString("Hello Win Forms", f, Brushes.Magenta, 50, 320);


            //Rectangle r1 = new Rectangle(50, 50, 200, 200);
            //Rectangle r2 = new Rectangle(150, 150, 200, 200);

            //Region reg1 = new Region(r1);
            //Region reg2 = new Region(r2);

            //g.DrawRectangle(Pens.Blue, r1);
            //g.DrawRectangle(Pens.Green, r2);

            ////reg1.Exclude(reg2);
            ////reg1.Intersect(reg2);
            ////reg1.Union(reg2);
            //reg1.Xor(reg2);
            //g.FillRegion(Brushes.Red, reg1);

            //g.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Bitmap b = new Bitmap("8769_800x600_Maidan-2.jpg");
            //Size s = b.Size;
            //Graphics g = Graphics.FromImage(b);
            //string d = DateTime.Now.ToShortDateString();
            //Font f = new Font("Comic Sans MS", 10, FontStyle.Bold | FontStyle.Italic);
            //SizeF sf = g.MeasureString(d, f);
            //g.DrawString(d, f, Brushes.Magenta, s.Width-sf.Width-20, s.Height-sf.Height-20);
            //b.Save("qqqq.bmp");

        }

        private void GDI_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(new Point(e.X, e.Y));
            Invalidate(); 
        }
    }
}
