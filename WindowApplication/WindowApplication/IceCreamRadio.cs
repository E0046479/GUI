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
    public partial class IceCreamRadio : Form
    {
        string str = "Small";

        public IceCreamRadio()
        {
            InitializeComponent(); 
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // 1st approach to check which radio button is selected 
            //string str;
            //if (optSmall.Checked)
            //{
            //    str = optSmall.Text;
            //}
            //else if (optMedium.Checked)
            //{
            //    str = optMedium.Text;
            //}
            //else
            //{
            //    str = optBig.Text;
            //}
            MessageBox.Show(str + " is selected!");
        }

        private void optSmall_CheckedChanged(object sender, EventArgs e)
        {
            str = optSmall.Text;
        }

        private void optMedium_CheckedChanged(object sender, EventArgs e)
        {
            str = optMedium.Text;
        }

        private void optBig_CheckedChanged(object sender, EventArgs e)
        {
            str = optBig.Text;
        }
    }
}
