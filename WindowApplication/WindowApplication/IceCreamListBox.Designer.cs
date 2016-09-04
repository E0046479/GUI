namespace WindowApplication
{
    partial class IceCreamListBox
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
            this.gBoTopping = new System.Windows.Forms.GroupBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.gboFlavor = new System.Windows.Forms.GroupBox();
            this.optStrawberry = new System.Windows.Forms.RadioButton();
            this.optChocolate = new System.Windows.Forms.RadioButton();
            this.gBoxSize = new System.Windows.Forms.GroupBox();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.lboTopping = new System.Windows.Forms.ListBox();
            this.gBoTopping.SuspendLayout();
            this.gboFlavor.SuspendLayout();
            this.gBoxSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoTopping
            // 
            this.gBoTopping.Controls.Add(this.lboTopping);
            this.gBoTopping.Location = new System.Drawing.Point(142, 234);
            this.gBoTopping.Name = "gBoTopping";
            this.gBoTopping.Size = new System.Drawing.Size(200, 100);
            this.gBoTopping.TabIndex = 7;
            this.gBoTopping.TabStop = false;
            this.gBoTopping.Text = "Topping";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(193, 420);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Get Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // gboFlavor
            // 
            this.gboFlavor.Controls.Add(this.optStrawberry);
            this.gboFlavor.Controls.Add(this.optChocolate);
            this.gboFlavor.Location = new System.Drawing.Point(142, 124);
            this.gboFlavor.Name = "gboFlavor";
            this.gboFlavor.Size = new System.Drawing.Size(200, 100);
            this.gboFlavor.TabIndex = 5;
            this.gboFlavor.TabStop = false;
            this.gboFlavor.Text = "Flavor";
            // 
            // optStrawberry
            // 
            this.optStrawberry.AutoSize = true;
            this.optStrawberry.Location = new System.Drawing.Point(32, 56);
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
            this.optChocolate.Location = new System.Drawing.Point(32, 19);
            this.optChocolate.Name = "optChocolate";
            this.optChocolate.Size = new System.Drawing.Size(73, 17);
            this.optChocolate.TabIndex = 3;
            this.optChocolate.TabStop = true;
            this.optChocolate.Text = "Chocolate";
            this.optChocolate.UseVisualStyleBackColor = true;
            // 
            // gBoxSize
            // 
            this.gBoxSize.Controls.Add(this.cboSize);
            this.gBoxSize.Location = new System.Drawing.Point(142, 20);
            this.gBoxSize.Name = "gBoxSize";
            this.gBoxSize.Size = new System.Drawing.Size(200, 100);
            this.gBoxSize.TabIndex = 4;
            this.gBoxSize.TabStop = false;
            this.gBoxSize.Text = "Size";
            // 
            // cboSize
            // 
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Big"});
            this.cboSize.Location = new System.Drawing.Point(32, 19);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(121, 21);
            this.cboSize.TabIndex = 4;
            // 
            // lboTopping
            // 
            this.lboTopping.FormattingEnabled = true;
            this.lboTopping.Items.AddRange(new object[] {
            "Nuts",
            "Raisins",
            "Chocolate Chips"});
            this.lboTopping.Location = new System.Drawing.Point(32, 29);
            this.lboTopping.MultiColumn = true;
            this.lboTopping.Name = "lboTopping";
            this.lboTopping.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lboTopping.Size = new System.Drawing.Size(107, 56);
            this.lboTopping.TabIndex = 8;
            // 
            // IceCreamListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 463);
            this.Controls.Add(this.gBoTopping);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.gboFlavor);
            this.Controls.Add(this.gBoxSize);
            this.Name = "IceCreamListBox";
            this.Text = "IceCreamListBox";
            this.gBoTopping.ResumeLayout(false);
            this.gboFlavor.ResumeLayout(false);
            this.gboFlavor.PerformLayout();
            this.gBoxSize.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoTopping;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.GroupBox gboFlavor;
        private System.Windows.Forms.RadioButton optStrawberry;
        private System.Windows.Forms.RadioButton optChocolate;
        private System.Windows.Forms.GroupBox gBoxSize;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.ListBox lboTopping;
    }
}