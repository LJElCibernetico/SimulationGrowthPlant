namespace SimulationGrowthPlant
{
    partial class PicturesViewer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PicturesViewer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonPrevious = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Change = new System.Windows.Forms.Timer(this.components);
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ButtonNext);
            this.panel1.Controls.Add(this.ButtonPrevious);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 439);
            this.panel1.TabIndex = 0;
            // 
            // ButtonNext
            // 
            this.ButtonNext.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonNext.Image = ((System.Drawing.Image)(resources.GetObject("ButtonNext.Image")));
            this.ButtonNext.Location = new System.Drawing.Point(439, 383);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(75, 44);
            this.ButtonNext.TabIndex = 2;
            this.ButtonNext.UseVisualStyleBackColor = false;
            this.ButtonNext.Visible = false;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonPrevious
            // 
            this.ButtonPrevious.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonPrevious.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPrevious.Image")));
            this.ButtonPrevious.Location = new System.Drawing.Point(277, 383);
            this.ButtonPrevious.Name = "ButtonPrevious";
            this.ButtonPrevious.Size = new System.Drawing.Size(75, 44);
            this.ButtonPrevious.TabIndex = 1;
            this.ButtonPrevious.UseVisualStyleBackColor = false;
            this.ButtonPrevious.Visible = false;
            this.ButtonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PictureBox);
            this.panel2.Location = new System.Drawing.Point(20, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 357);
            this.panel2.TabIndex = 0;
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(0, 0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(727, 357);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // Change
            // 
            this.Change.Enabled = true;
            this.Change.Interval = 1;
            this.Change.Tick += new System.EventHandler(this.Change_Tick);
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "Day 1.PNG");
            this.ImageList.Images.SetKeyName(1, "Day 2.PNG");
            this.ImageList.Images.SetKeyName(2, "Day 3.PNG");
            this.ImageList.Images.SetKeyName(3, "Day 4.PNG");
            this.ImageList.Images.SetKeyName(4, "Day 5.PNG");
            this.ImageList.Images.SetKeyName(5, "Day 6.PNG");
            this.ImageList.Images.SetKeyName(6, "Day 7.PNG");
            this.ImageList.Images.SetKeyName(7, "Day 8.PNG");
            this.ImageList.Images.SetKeyName(8, "Day 9.PNG");
            this.ImageList.Images.SetKeyName(9, "Day 10.PNG");
            this.ImageList.Images.SetKeyName(10, "Day 11.PNG");
            this.ImageList.Images.SetKeyName(11, "Day 12.PNG");
            this.ImageList.Images.SetKeyName(12, "Day 13.PNG");
            this.ImageList.Images.SetKeyName(13, "Day 14.PNG");
            this.ImageList.Images.SetKeyName(14, "Day 15.PNG");
            this.ImageList.Images.SetKeyName(15, "Day 16.PNG");
            this.ImageList.Images.SetKeyName(16, "Day 17.PNG");
            this.ImageList.Images.SetKeyName(17, "Day 18.PNG");
            this.ImageList.Images.SetKeyName(18, "Day 19.PNG");
            this.ImageList.Images.SetKeyName(19, "Day 20.PNG");
            this.ImageList.Images.SetKeyName(20, "Day 21.PNG");
            this.ImageList.Images.SetKeyName(21, "Day 22.PNG");
            this.ImageList.Images.SetKeyName(22, "Day 23.PNG");
            this.ImageList.Images.SetKeyName(23, "Day 24.PNG");
            this.ImageList.Images.SetKeyName(24, "Day 25.PNG");
            // 
            // PicturesViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 464);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PicturesViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulacion del crecimiento de una planta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonPrevious;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Timer Change;
        private System.Windows.Forms.ImageList ImageList;
    }
}

