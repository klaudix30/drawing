namespace drawing
{
    partial class Drawing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.bLine = new System.Windows.Forms.Button();
            this.bRectangle = new System.Windows.Forms.Button();
            this.bFree = new System.Windows.Forms.Button();
            this.bColor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(7, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 312);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // bLine
            // 
            this.bLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bLine.Location = new System.Drawing.Point(465, 31);
            this.bLine.Name = "bLine";
            this.bLine.Size = new System.Drawing.Size(75, 23);
            this.bLine.TabIndex = 1;
            this.bLine.Text = "linia";
            this.bLine.UseVisualStyleBackColor = true;
            this.bLine.Click += new System.EventHandler(this.bLine_Click);
            // 
            // bRectangle
            // 
            this.bRectangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bRectangle.Location = new System.Drawing.Point(465, 60);
            this.bRectangle.Name = "bRectangle";
            this.bRectangle.Size = new System.Drawing.Size(75, 23);
            this.bRectangle.TabIndex = 2;
            this.bRectangle.Text = "prostokat";
            this.bRectangle.UseVisualStyleBackColor = true;
            this.bRectangle.Click += new System.EventHandler(this.bRectangle_Click);
            // 
            // bFree
            // 
            this.bFree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bFree.Location = new System.Drawing.Point(465, 89);
            this.bFree.Name = "bFree";
            this.bFree.Size = new System.Drawing.Size(75, 23);
            this.bFree.TabIndex = 3;
            this.bFree.Text = "swobodne";
            this.bFree.UseVisualStyleBackColor = true;
            this.bFree.Click += new System.EventHandler(this.bFree_Click);
            // 
            // bColor
            // 
            this.bColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bColor.Location = new System.Drawing.Point(465, 118);
            this.bColor.Name = "bColor";
            this.bColor.Size = new System.Drawing.Size(75, 23);
            this.bColor.TabIndex = 4;
            this.bColor.Text = "kolor";
            this.bColor.UseVisualStyleBackColor = true;
            this.bColor.Click += new System.EventHandler(this.bColor_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(465, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "wczytaj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.bLoadImg);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(465, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "zapisz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.bSaveImg);
            // 
            // drawing
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(571, 356);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bColor);
            this.Controls.Add(this.bFree);
            this.Controls.Add(this.bRectangle);
            this.Controls.Add(this.bLine);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "drawing";
            this.Text = "drawing";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bLine;
        private System.Windows.Forms.Button bRectangle;
        private System.Windows.Forms.Button bFree;
        private System.Windows.Forms.Button bColor;
        private System.Windows.Forms.Button saveImg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}