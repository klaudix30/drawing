using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawing
{
    public partial class Drawing :Form
    {
        bool drawingB;
        Bitmap bmp;
        Pen p;
        Shape s;
   
        public Drawing()
        {
            InitializeComponent();
            p = new Pen(Color.Black, 5);
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            s = new FreePoint(p);
            bmp = new Bitmap(panel2.Width, panel2.Height);
            Graphics.FromImage(bmp).Clear(Color.White);
           
        }
        protected void panel2_MouseDown(object sender, MouseEventArgs e)
        {

            
            s.MouseDown(sender, e);
            drawingB = true;
            
        }
        
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                s.MouseMove(sender, e);

                if (drawingB) panel2.Invalidate();
               
            }

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
           
            s.MouseUp(sender, e);
            drawingB = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
            e.Graphics.DrawImageUnscaled(bmp, new Point(0, 0));
            
            if (drawingB)
            {      
                s.E = e;
                s.Paint();
                
                Graphics.FromImage(bmp).Clear(Color.White);
                panel2.DrawToBitmap(bmp, new Rectangle(0, 0, panel2.Width, panel2.Height));
                

            }

        }

        private void bLine_Click(object sender, EventArgs e)
        {

            s = new Line(p);
        }

        private void bColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                p.Color = cd.Color;
        }
        private void bRectangle_Click(object sender, EventArgs e)
        {

            s = new SRectangle(p);

        }

        private void bFree_Click(object sender, EventArgs e)
        {

            s = new FreePoint(p);

        }

        private void bLoadImg(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Images|*.jpg ; *.png ; *.bmp";
  
               if (d.ShowDialog() == DialogResult.OK)
                {
                    bmp = new Bitmap(d.FileName);
                }
            panel2.DrawToBitmap(bmp, new Rectangle(0, 0, panel2.Width, panel2.Height));
            panel2.Invalidate();

        }
        private void bSaveImg(object sender, EventArgs e)
        {

            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Images|*.jpg ; *.png ; *.bmp";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                panel2.DrawToBitmap(bmp, new Rectangle(0, 0, panel2.Width, panel2.Height));
                bmp.Save(sv.FileName);
            }
           

        }

    }
}

