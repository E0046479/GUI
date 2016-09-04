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
    public partial class IceCreamGroupBox : Form
    {
        //string strSize = "Small";
        //string strFlavor = "Chocolate";

        public IceCreamGroupBox()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string strSize = optSmall.Text;
            string strFlavor = optChocolate.Text;
            string strTopping = "";

            if (optSmall.Checked)
            {
                strSize = optSmall.Text;
            }
            else if (optMedium.Checked)
            {
                strSize = optMedium.Text;
            }
            else
            {
                strSize = optBig.Text;
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