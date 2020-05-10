using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawing
{
    public partial class Form1 : Form
    {
        
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        Drawing firstTab;

        public Form1()
        {
            InitializeComponent();
            firstTab = new Drawing();
            addFirstTab();

        }

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(
        IntPtr hWnd, int Msg, int wParam, int lParam
        );

      
        private void addFirstTab()
        {
            
            firstTab.TopLevel = false;
            tabPage1.Controls.Add(firstTab);
            firstTab.Dock = DockStyle.Fill;
            firstTab.Show();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void minimalize_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
        }


        private void maxNorm_Click(object sender, EventArgs e)
        {
            if(WindowState.ToString()=="Maximized")
            {   
                this.WindowState = FormWindowState.Normal;

            }
            else
            {
           
                this.WindowState = FormWindowState.Maximized;
            }
            

        }

        private void panel3_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle,
            WM_NCLBUTTONDOWN, HTCAPTION, 0);

        }
        
        private void addNewTab()
        {
            Drawing frm = new Drawing();
            string title = "tabPage " + (tabControl1.TabCount + 1).ToString();
            TabPage tab = new TabPage(title);
            frm.TopLevel = false;
            tab.Controls.Add(frm);
            tabControl1.TabPages.Add(tab);
            frm.Dock = DockStyle.Fill;
            frm.Show();         
        }
        
        private void addTab_Click(object sender, EventArgs e)
        {

            addNewTab();
        }
     

        private void exitTab_Click_1(object sender, EventArgs e)
        {
            TabPage current_tab = tabControl1.SelectedTab;
            int tabCount = tabControl1.TabPages.Count;
            if (tabCount == 1)
            {
                this.tabControl1.TabPages.Remove(current_tab);
                this.Close();
            }
            else
            {
                this.tabControl1.TabPages.Remove(current_tab);
            }
        }

    }
}
