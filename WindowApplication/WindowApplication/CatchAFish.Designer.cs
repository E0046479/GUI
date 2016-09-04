namespace WindowApplication
{
    partial class CatchAFish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatchAFish));
            this.btn_Fish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Fish
            // 
            this.btn_Fish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fish.Image = ((System.Drawing.Image)(resources.GetObject("btn_Fish.Image")));
            this.btn_Fish.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Fish.Location = new System.Drawing.Point(201, 234);
            this.btn_Fish.Name = "btn_Fish";
            this.btn_Fish.Size = new System.Drawing.Size(120, 112);
            this.btn_Fish.TabIndex = 0;
            this.btn_Fish.Text = "Fish";
            this.btn_Fish.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Fish.UseVisualStyleBackColor = true;
            this.btn_Fish.MouseEnter += new System.EventHandler(this.btn_Fish_MouseEnter);
            // 
            // CatchAFish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 463);
            this.Controls.Add(this.btn_Fish);
            this.Name = "CatchAFish";
            this.Text = "CatchAFish";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Fish;
    }
}