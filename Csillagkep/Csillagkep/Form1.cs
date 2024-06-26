using Csillagkep.Models;

namespace Csillagkep
{
    public partial class Form1 : Form
    {
        HajosContext context = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Brush b = new SolidBrush(Color.Gold);

            Pen pen = new Pen(Color.Gold);

            //g.DrawEllipse(pen, 0, 0, 100, 100);

            //g.FillEllipse(b, ClientRectangle.Width / 2, ClientRectangle.Height / 2,100,100);

            var stars = (from x in context.StarData
                        select new {x.Hip,x.X,x.Y,x.Magnitude}).ToList();

            double nagyitas = 501;
            g.Clear(Color.Blue);

            float cx= ClientRectangle.Width / 2;
            float cy = ClientRectangle.Height / 2;

            foreach ( var s in stars )
            {
                float x1 = (float)(nagyitas*s.X);
                float y1 = (float)(nagyitas * s.Y);

                //g.DrawEllipse(pen,Convert.ToInt32(s.X*nagyitas)+ClientRectangle.Width/2, Convert.ToInt32(s.Y*nagyitas)+ClientRectangle.Height/2,1,1);
                if (Math.Sqrt(Math.Pow(s.X, 2) + Math.Pow(s.Y, 2)) > 1) continue;

                double size = 20 * Math.Pow(10, (s.Magnitude) / -2.5);

                if(size<1) size = 1;

                g.FillEllipse(b, x1 + cx, y1 + cy, (float)size, (float)size);
                
     

            }

            var lines = context.ConstellationLines.ToList();

            foreach (var line in lines)
            {
                var star1 = (from s in stars where s.Hip == line.Star1 select s).FirstOrDefault();
                var star2 = (from s in stars where s.Hip == line.Star2 select s).FirstOrDefault();

                if (star1 == null || star2 == null) continue;


                float x1 = (float)(nagyitas * star1.X);
                float y1 = (float)(nagyitas * star1.Y);
                float x2 = (float)(nagyitas * star2.X);
                float y2 = (float)(nagyitas * star2.Y);

                g.DrawLine(pen,x1+cx,y1+cy,x2 +cx,y2 +cy);
            }

        }
    }
}