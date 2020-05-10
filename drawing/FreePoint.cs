using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawing
{
    public class FreePoint:Shape
    {
        private List<Point> Points = new List<Point>();
        public FreePoint(Pen p):base(p){}

        public override void Paint()
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            foreach (Point point in Points)
                e.Graphics.DrawLines(p, Points.ToArray());
           
        }
        public override void MouseMove(object sender, MouseEventArgs i)
        {

            Points.Add(i.Location);

        }
        public override void MouseDown(object sender, MouseEventArgs i)
        {
            Points.Add(i.Location);

        }

        public override void MouseUp(object sender, MouseEventArgs i)
        {

            Points.Add(i.Location);

        }
    

        public override PaintEventArgs E

        {
            set
            {
                e = value;
            }
        }
    }
}
