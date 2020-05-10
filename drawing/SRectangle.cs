using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawing
{ 
    public class SRectangle:Shape
    {
        private int startX, startY;
        private Point dimensions;

        public SRectangle(Pen p):base(p){ }

        public override void Paint()
        {

            e.Graphics.DrawRectangle(p, new Rectangle(endPos, new Size(dimensions)));

        }

        public override void MouseMove(object sender, MouseEventArgs i)
        {
            
            int x = Math.Min(startX, i.X);
            int y = Math.Min(startY, i.Y);
            int width = Math.Max(startX, i.X) - Math.Min(startX, i.X);
            int height = Math.Max(startY, i.Y) - Math.Min(startY, i.Y);
            currentPos=new Point(x,y);
            dimensions = new Point(width, height);

        }
        public override void MouseDown(object sender, MouseEventArgs i)
        {

            startX = i.X;
            startY = i.Y;
            currentPos = i.Location;
            endPos = currentPos;

        }
     
        public override void MouseUp(object sender, MouseEventArgs i)
        {
            endPos = i.Location;

        }

     
   

        public override PaintEventArgs E

        {
            set
            {
                e=value;
            }
        }
   

    }
}
