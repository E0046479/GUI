﻿namespace WindowApplication
{
    partial class IceCreamRadio
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
            this.optSmall = new System.Windows.Forms.RadioButton();
            this.optMedium = new System.Windows.Forms.RadioButton();
            this.optBig = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // optSmall
            // 
            this.optSmall.AutoSize = true;
            this.optSmall.Checked = true;
            this.optSmall.Location = new System.Drawing.Point(144, 70);
            this.optSmall.Name = "optSmall";
            this.optSmall.Size = new System.Drawing.Size(50, 17);
            this.optSmall.TabIndex = 0;
            this.optSmall.TabStop = true;
            this.optSmall.Text = "Small";
            this.optSmall.UseVisualStyleBackColor = true;
            this.optSmall.CheckedChanged += new System.EventHandler(this.optSmall_CheckedChanged);
            // 
            // optMedium
            // 
            this.optMedium.AutoSize = true;
            this.optMedium.Location = new System.Drawing.Point(144, 140);
            this.optMedium.Name = "optMedium";
            this.optMedium.Size = new System.Drawing.Size(62, 17);
            this.optMedium.TabIndex = 1;
            this.optMedium.Text = "Medium";
            this.optMedium.UseVisualStyleBackColor = true;
            this.optMedium.CheckedChanged += new System.EventHandler(this.optMedium_CheckedChanged);
            // 
            // optBig
            // 
            this.optBig.AutoSize = true;
            this.optBig.Location = new System.Drawing.Point(144, 214);
            this.optBig.Name = "optBig";
            this.optBig.Size = new System.Drawing.Size(40, 17);
            this.optBig.TabIndex = 2;
            this.optBig.Text = "Big";
            this.optBig.UseVisualStyleBackColor = true;
            this.optBig.CheckedChanged += new System.EventHandler(this.optBig_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(144, 349);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Get Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // IceCreamRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 463);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.optBig);
            this.Controls.Add(this.optMedium);
            this.Controls.Add(this.optSmall);
            this.Name = "IceCreamRadio";
            this.Text = "IceCreamRadio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optSmall;
        private System.Windows.Forms.RadioButton optMedium;
        private System.Windows.Forms.RadioButton optBig;
        private System.Windows.Forms.Button btnOrder;
    }
}