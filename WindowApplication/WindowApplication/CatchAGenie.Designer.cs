namespace WindowApplication
{
    partial class CatchAGenie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatchAGenie));
            this.pboxLamp = new System.Windows.Forms.PictureBox();
            this.pBoxGenie = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGenie)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxLamp
            // 
            this.pboxLamp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxLamp.Image = ((System.Drawing.Image)(resources.GetObject("pboxLamp.Image")));
            this.pboxLamp.Location = new System.Drawing.Point(12, 371);
            this.pboxLamp.Name = "pboxLamp";
            this.pboxLamp.Size = new System.Drawing.Size(95, 80);
            this.pboxLamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxLamp.TabIndex = 0;
            this.pboxLamp.TabStop = false;
            this.pboxLamp.Click += new System.EventHandler(this.pboxLamp_Click);
            this.pboxLamp.DoubleClick += new System.EventHandler(this.pboxLamp_DoubleClick);
            // 
            // pBoxGenie
            // 
            this.pBoxGenie.Image = ((System.Drawing.Image)(resources.GetObject("pBoxGenie.Image")));
            this.pBoxGenie.Location = new System.Drawing.Point(225, 115);
            this.pBoxGenie.Name = "pBoxGenie";
            this.pBoxGenie.Size = new System.Drawing.Size(112, 132);
            this.pBoxGenie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxGenie.TabIndex = 1;
            this.pBoxGenie.TabStop = false;
            this.pBoxGenie.Visible = false;
            this.pBoxGenie.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBoxGenie_MouseMove);
            // 
            // CatchAGenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 463);
            this.Controls.Add(this.pBoxGenie);
            this.Controls.Add(this.pboxLamp);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "CatchAGenie";
            this.Text = "CatchAGenie";
            ((System.ComponentModel.ISupportInitialize)(this.pboxLamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGenie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxLamp;
        private System.Windows.Forms.PictureBox pBoxGenie;
    }
}