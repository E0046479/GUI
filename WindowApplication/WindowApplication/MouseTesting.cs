using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowApplication
{
    public partial class MouseTesting : Form
    {
        public MouseTesting()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            this.label1.Text = "Mouse Down Event";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.label1.Text = "Mouse Enter Event";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.label1.Text = "Mouse Hover Event";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.label1.Text = "Mouse Leave Event";
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = string.Format("X:{0} Y:{1}",e.X,e.Y);
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            this.label1.Text = "Mouse Up Event";
        }
    }
}
