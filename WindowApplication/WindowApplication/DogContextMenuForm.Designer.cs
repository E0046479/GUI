namespace WindowApplication
{
    partial class DogContextMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DogContextMenuForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.makeBigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeSmalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbDog = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeBigToolStripMenuItem,
            this.makeNormalToolStripMenuItem,
            this.makeSmalToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 70);
            this.contextMenuStrip1.Text = "Context Menu Script";
            // 
            // makeBigToolStripMenuItem
            // 
            this.makeBigToolStripMenuItem.Name = "makeBigToolStripMenuItem";
            this.makeBigToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.makeBigToolStripMenuItem.Text = "Make Big";
            this.makeBigToolStripMenuItem.Click += new System.EventHandler(this.makeBigToolStripMenuItem_Click);
            // 
            // makeNormalToolStripMenuItem
            // 
            this.makeNormalToolStripMenuItem.Name = "makeNormalToolStripMenuItem";
            this.makeNormalToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.makeNormalToolStripMenuItem.Text = "Make Normal";
            this.makeNormalToolStripMenuItem.Click += new System.EventHandler(this.makeNormalToolStripMenuItem_Click);
            // 
            // makeSmalToolStripMenuItem
            // 
            this.makeSmalToolStripMenuItem.Name = "makeSmalToolStripMenuItem";
            this.makeSmalToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.makeSmalToolStripMenuItem.Text = "Make Smal";
            this.makeSmalToolStripMenuItem.Click += new System.EventHandler(this.makeSmalToolStripMenuItem_Click);
            // 
            // pbDog
            // 
            this.pbDog.Image = ((System.Drawing.Image)(resources.GetObject("pbDog.Image")));
            this.pbDog.Location = new System.Drawing.Point(12, 12);
            this.pbDog.Name = "pbDog";
            this.pbDog.Size = new System.Drawing.Size(328, 347);
            this.pbDog.TabIndex = 0;
            this.pbDog.TabStop = false;
            // 
            // DogContextMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 464);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pbDog);
            this.Name = "DogContextMenuForm";
            this.Text = "DogContextMenuForm";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem makeBigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeNormalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeSmalToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbDog;
    }
}