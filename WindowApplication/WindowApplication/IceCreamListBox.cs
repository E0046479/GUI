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
    public partial class IceCreamListBox : Form
    {
        public IceCreamListBox()
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

            if (lboTopping.SelectedItems.Count == 0)
            {
                strTopping = "with no topping";
            }
            else
            {
                strTopping = "with topping: ";
                //for (int i = 0; i < lboTopping.SelectedItems.Count; i++)
                //{
                //    strTopping += " " + lboTopping.SelectedItems[i].ToString();
                //}

                foreach (Object sl in lboTopping.SelectedItems)
                {
                    strTopping += sl.ToString();
                }
            }
            MessageBox.Show("A " + strSize + " " + strFlavor + " flavored ice cream " + strTopping + " is selected");
       
        }
    }
}
