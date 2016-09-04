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
    public partial class IceCreamComboBox : Form
    {
        //string strSize = "Small";
        //string strFlavor = "Chocolate";

        public IceCreamComboBox()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string strSize = "Small";
            string strFlavor = optChocolate.Text;
            string strTopping = "";

            if (cboSize.Text == "Small")
            {
                strSize = "Small";
            }
            else if (cboSize.Text == "Medium")
            {
                strSize = "Medium";
            }
            else
            {
                strSize = "Big";
            }

            if (optChocolate.Checked)
            {
                strFlavor = optChocolate.Text;
            }
            else
            {
                strFlavor = optStrawberry.Text;
            }

            if (!chBoxNuts.Checked && !chBoxRaisins.Checked && !chBoxChocolate.Checked)
            {
                strTopping = "with no topping";
            }
            else
            {
                strTopping = "with topping: ";
                if (chBoxNuts.Checked)
                    strTopping += " " + chBoxNuts.Text ;
                if (chBoxRaisins.Checked)
                    strTopping += " " + chBoxRaisins.Text;
                if (chBoxChocolate.Checked)
                    strTopping += " " + chBoxChocolate.Text; 
            }
            MessageBox.Show("A " + strSize + " " + strFlavor + " flavored ice cream "+ strTopping + " is selected");
        }

        //private void optSmall_CheckedChanged(object sender, EventArgs e)
        //{
        //    strSize = optSmall.Text;
        //}

        //private void optMedium_CheckedChanged(object sender, EventArgs e)
        //{
        //    strSize = optMedium.Text;
        //}

        //private void optBig_CheckedChanged(object sender, EventArgs e)
        //{
        //    strSize = optBig.Text;
        //}

        //private void optChocolate_CheckedChanged(object sender, EventArgs e)
        //{
        //    strFlavor = optChocolate.Text;
        //}

        //private void optStrawberry_CheckedChanged(object sender, EventArgs e)
        //{
        //    strFlavor = optStrawberry.Text;
        //}

       


    }
}