﻿namespace WindowApplication
{
    partial class IceCreamGroupBox
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
            this.gBoxSize = new System.Windows.Forms.GroupBox();
            this.optSmall = new System.Windows.Forms.RadioButton();
            this.optBig = new System.Windows.Forms.RadioButton();
            this.optMedium = new System.Windows.Forms.RadioButton();
            this.gboFlavor = new System.Windows.Forms.GroupBox();
            this.optStrawberry = new System.Windows.Forms.RadioButton();
            this.optChocolate = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.gBoTopping = new System.Windows.Forms.GroupBox();
            this.chBoxChocolate = new System.Windows.Forms.CheckBox();
            this.chBoxRaisins = new System.Windows.Forms.CheckBox();
            this.chBoxNuts = new System.Windows.Forms.CheckBox();
            this.gBoxSize.SuspendLayout();
            this.gboFlavor.SuspendLayout();
            this.gBoTopping.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxSize
            // 
            this.gBoxSize.Controls.Add(this.optSmall);
            this.gBoxSize.Controls.Add(this.optBig);
            this.gBoxSize.Controls.Add(this.optMedium);
            this.gBoxSize.Location = new System.Drawing.Point(84, 2);
            this.gBoxSize.Name = "gBoxSize";
            this.gBoxSize.Size = new System.Drawing.Size(200, 100);
            this.gBoxSize.TabIndex = 0;
            this.gBoxSize.TabStop = false;
            this.gBoxSize.Text = "Size";
            // 
            // optSmall
            // 
            this.optSmall.AutoSize = true;
            this.optSmall.Checked = true;
            this.optSmall.Location = new System.Drawing.Point(51, 20);
            this.optSmall.Name = "optSmall";
            this.optSmall.Size = new System.Drawing.Size(50, 17);
            this.optSmall.TabIndex = 3;
            this.optSmall.TabStop = true;
            this.optSmall.Text = "Small";
            this.optSmall.UseVisualStyleBackColor = true;
            // 
            // optBig
            // 
            this.optBig.AutoSize = true;
            this.optBig.Location = new System.Drawing.Point(51, 76);
            this.optBig.Name = "optBig";
            this.optBig.Size = new System.Drawing.Size(40, 17);
            this.optBig.TabIndex = 2;
            this.optBig.Text = "Big";
            this.optBig.UseVisualStyleBackColor = true;
            // 
            // optMedium
            // 
            this.optMedium.AutoSize = true;
            this.optMedium.Location = new System.Drawing.Point(51, 44);
            this.optMedium.Name = "optMedium";
            this.optMedium.Size = new System.Drawing.Size(62, 17);
            this.optMedium.TabIndex = 1;
            this.optMedium.Text = "Medium";
            this.optMedium.UseVisualStyleBackColor = true;
            // 
            // gboFlavor
            // 
            this.gboFlavor.Controls.Add(this.optStrawberry);
            this.gboFlavor.Controls.Add(this.optChocolate);
            this.gboFlavor.Location = new System.Drawing.Point(84, 106);
            this.gboFlavor.Name = "gboFlavor";
            this.gboFlavor.Size = new System.Drawing.Size(200, 100);
            this.gboFlavor.TabIndex = 1;
            this.gboFlavor.TabStop = false;
            this.gboFlavor.Text = "Flavor";
            // 
            // optStrawberry
            // 
            this.optStrawberry.AutoSize = true;
            this.optStrawberry.Location = new System.Drawing.Point(51, 62);
            this.optStrawberry.Name = "optStrawberry";
            this.optStrawberry.Size = new System.Drawing.Size(75, 17);
            this.optStrawberry.TabIndex = 5;
            this.optStrawberry.Text = "Strawberry";
            this.optStrawberry.UseVisualStyleBackColor = true;
            // 
            // optChocolate
            // 
            this.optChocolate.AutoSize = true;
            this.optChocolate.Checked = true;
            this.optChocolate.Location = new System.Drawing.Point(51, 25);
            this.optChocolate.Name = "optChocolate";
            this.optChocolate.Size = new System.Drawing.Size(73, 17);
            this.optChocolate.TabIndex = 3;
            this.optChocolate.TabStop = true;
            this.optChocolate.Text = "Chocolate";
            this.optChocolate.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(135, 402);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Get Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // gBoTopping
            // 
            this.gBoTopping.Controls.Add(this.chBoxChocolate);
            this.gBoTopping.Controls.Add(this.chBoxRaisins);
            this.gBoTopping.Controls.Add(this.chBoxNuts);
            this.gBoTopping.Location = new System.Drawing.Point(84, 216);
            this.gBoTopping.Name = "gBoTopping";
            this.gBoTopping.Size = new System.Drawing.Size(200, 100);
            this.gBoTopping.TabIndex = 3;
            this.gBoTopping.TabStop = false;
            this.gBoTopping.Text = "Topping";
            // 
            // chBoxChocolate
            // 
            this.chBoxChocolate.AutoSize = true;
            this.chBoxChocolate.Location = new System.Drawing.Point(51, 77);
            this.chBoxChocolate.Name = "chBoxChocolate";
            this.chBoxChocolate.Size = new System.Drawing.Size(74, 17);
            this.chBoxChocolate.TabIndex = 2;
            this.chBoxChocolate.Text = "Chocolate";
            this.chBoxChocolate.UseVisualStyleBackColor = true;
            // 
            // chBoxRaisins
            // 
            this.chBoxRaisins.AutoSize = true;
            this.chBoxRaisins.Location = new System.Drawing.Point(51, 47);
            this.chBoxRaisins.Name = "chBoxRaisins";
            this.chBoxRaisins.Size = new System.Drawing.Size(60, 17);
            this.chBoxRaisins.TabIndex = 1;
            this.chBoxRaisins.Text = "Raisins";
            this.chBoxRaisins.UseVisualStyleBackColor = true;
            // 
            // chBoxNuts
            // 
            this.chBoxNuts.AutoSize = true;
            this.chBoxNuts.Location = new System.Drawing.Point(51, 20);
            this.chBoxNuts.Name = "chBoxNuts";
            this.chBoxNuts.Size = new System.Drawing.Size(48, 17);
            this.chBoxNuts.TabIndex = 0;
            this.chBoxNuts.Text = "Nuts";
            this.chBoxNuts.UseVisualStyleBackColor = true;
            // 
            // IceCreamGroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 463);
            this.Controls.Add(this.gBoTopping);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.gboFlavor);
            this.Controls.Add(this.gBoxSize);
            this.Name = "IceCreamGroupBox";
            this.Text = "IceCreamGroupBox";
            this.gBoxSize.ResumeLayout(false);
            this.gBoxSize.PerformLayout();
            this.gboFlavor.ResumeLayout(false);
            this.gboFlavor.PerformLayout();
            this.gBoTopping.ResumeLayout(false);
            this.gBoTopping.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxSize;
        private System.Windows.Forms.RadioButton optBig;
        private System.Windows.Forms.RadioButton optMedium;
        private System.Windows.Forms.GroupBox gboFlavor;
        private System.Windows.Forms.RadioButton optStrawberry;
        private System.Windows.Forms.RadioButton optChocolate;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.GroupBox gBoTopping;
        private System.Windows.Forms.CheckBox chBoxChocolate;
        private System.Windows.Forms.CheckBox chBoxRaisins;
        private System.Windows.Forms.CheckBox chBoxNuts;
        private System.Windows.Forms.RadioButton optSmall;
    }
}