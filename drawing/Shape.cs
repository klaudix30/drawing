using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawing
{
    public abstract class Shape
    {

       protected Point currentPos;
       protected Point endPos;
       protected PaintEventArgs e;
       protected Pen p;

    
        public Shape(Pen p)
        {
            this.p = p;
        }

       
        public abstract PaintEventArgs E { set; }



        public abstract void MouseMove(object sender, MouseEventArgs e);
        public abstract void MouseDown(object sender, MouseEventArgs e);
        public abstract void MouseUp(object sender, MouseEventArgs e);
        public abstract void Paint();
    }
}

    
