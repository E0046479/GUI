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
    public partial class DogContextMenuForm : Form
    {
        private int normalHeight, normalWidth;

        public DogContextMenuForm()
        {
            InitializeComponent();
            normalHeight = pbDog.Height;
            normalWidth = pbDog.Width;
        }

        private void makeBigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbDog.Height = normalHeight * 2;
            pbDog.Width = normalWidth * 2;
        }

        private void makeNormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbDog.Height = normalHeight;
            pbDog.Width = normalWidth;
        }

        private void makeSmalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbDog.Height = normalHeight / 2;
            pbDog.Width = normalWidth / 2;
        }
    }
}
