namespace drawing
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveImage = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.minimalize = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.maxNorm = new System.Windows.Forms.Button();
            this.addTab = new System.Windows.Forms.Button();
            this.exitTab = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveImage
            // 
            this.saveImage.Location = new System.Drawing.Point(0, 0);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(75, 23);
            this.saveImage.TabIndex = 9;
            // 
            // exit
            // 
            this.exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit.Location = new System.Drawing.Point(570, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(26, 33);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // minimalize
            // 
            this.minimalize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.minimalize.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimalize.Location = new System.Drawing.Point(519, 0);
            this.minimalize.Name = "minimalize";
            this.minimalize.Size = new System.Drawing.Size(24, 33);
            this.minimalize.TabIndex = 2;
            this.minimalize.Text = "_";
            this.minimalize.UseVisualStyleBackColor = true;
            this.minimalize.Click += new System.EventHandler(this.minimalize_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel3.Controls.Add(this.minimalize);
            this.panel3.Controls.Add(this.maxNorm);
            this.panel3.Controls.Add(this.exit);
            this.panel3.Location = new System.Drawing.Point(-1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(596, 33);
            this.panel3.TabIndex = 7;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown_1);
            // 
            // maxNorm
            // 
            this.maxNorm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.maxNorm.Dock = System.Windows.Forms.DockStyle.Right;
            this.maxNorm.Location = new System.Drawing.Point(543, 0);
            this.maxNorm.Name = "maxNorm";
            this.maxNorm.Size = new System.Drawing.Size(27, 33);
            this.maxNorm.TabIndex = 1;
            this.maxNorm.Text = "[]";
            this.maxNorm.UseVisualStyleBackColor = true;
            this.maxNorm.Click += new System.EventHandler(this.maxNorm_Click);
            // 
            // addTab
            // 
            this.addTab.Location = new System.Drawing.Point(12, 39);
            this.addTab.Name = "addTab";
            this.addTab.Size = new System.Drawing.Size(26, 28);
            this.addTab.TabIndex = 1;
            this.addTab.Text = "+";
            this.addTab.UseVisualStyleBackColor = true;
            this.addTab.Click += new System.EventHandler(this.addTab_Click);
            // 
            // exitTab
            // 
            this.exitTab.Location = new System.Drawing.Point(44, 39);
            this.exitTab.Name = "exitTab";
            this.exitTab.Size = new System.Drawing.Size(26, 28);
            this.exitTab.TabIndex = 8;
            this.exitTab.Text = "-";
            this.exitTab.UseVisualStyleBackColor = true;
            this.exitTab.Click += new System.EventHandler(this.exitTab_Click_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(467, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(76, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(475, 339);
            this.tabControl1.TabIndex = 10;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(595, 390);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.exitTab);
            this.Controls.Add(this.addTab);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.saveImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
      //  private System.Windows.Forms.Button bLine;
      //  private System.Windows.Forms.Button bColor;
      //  private System.Windows.Forms.Button bRectangle;
      //  private System.Windows.Forms.Button bFree;
        private System.Windows.Forms.Button saveImage;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button minimalize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button maxNorm;
        private System.Windows.Forms.Button addTab;
        private System.Windows.Forms.Button exitTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

