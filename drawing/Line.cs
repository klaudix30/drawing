using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace drawing
{
    public class Line:Shape
    {
        
        public Line(Pen p):base(p){ }

        public override void Paint()
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawLine(p, currentPos, endPos);
            

        }
        public override void MouseMove(object sender, MouseEventArgs i)
        {

             currentPos=i.Location;
             
          
        }
        public override void MouseDown(object sender, MouseEventArgs i)
        {

           currentPos  = i.Location;
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
                e = value;
            }
        }


    }
}
