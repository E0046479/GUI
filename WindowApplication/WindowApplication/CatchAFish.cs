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
    public partial class CatchAFish : Form
    {
        public CatchAFish()
        {
            InitializeComponent();
        }

        
        private void btn_Fish_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            int x = random.Next(400);
            int y = random.Next(400);
            
            this.btn_Fish.Location = new System.Drawing.Point(x, y);
        }
    }
}
