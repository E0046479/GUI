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
    public partial class MenuToolContextScript : Form
    {
        public MenuToolContextScript()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File");
        }

        private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Windows");
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerMaintenance customerForm = new CustomerMaintenance();
            customerForm.MdiParent = this; // Mdi parent lote tar
            //customerForm.ShowDialog();
            //customerForm.Dispose();
            customerForm.Show();
        }

        private void dogFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DogContextMenuForm dogForm = new DogContextMenuForm();
            dogForm.Show();
        }
    }
}
