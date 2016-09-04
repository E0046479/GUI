namespace WindowApplication
{
    partial class KillARabbit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KillARabbit));
            this.btn_Rabbit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Rabbit
            // 
            this.btn_Rabbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rabbit.ForeColor = System.Drawing.Color.Black;
            this.btn_Rabbit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Rabbit.Image")));
            this.btn_Rabbit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Rabbit.Location = new System.Drawing.Point(258, 217);
            this.btn_Rabbit.Name = "btn_Rabbit";
            this.btn_Rabbit.Size = new System.Drawing.Size(173, 112);
            this.btn_Rabbit.TabIndex = 0;
            this.btn_Rabbit.Text = "Rabbit";
            this.btn_Rabbit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Rabbit.UseVisualStyleBackColor = true;
            this.btn_Rabbit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Rabbit_MouseDown);
            this.btn_Rabbit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Rabbit_MouseUp);
            // 
            // KillARabbit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 463);
            this.Controls.Add(this.btn_Rabbit);
            this.Name = "KillARabbit";
            this.Text = "KillARabbit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Rabbit;
    }
}