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
    public partial class CatchARabbit : Form
    {
        public CatchARabbit()
        {
            InitializeComponent();
        }

        private void btnRabbit_Click(object sender, EventArgs e)
        {
            this.MaximumSize = new System.Drawing.Size(500, 500);
            Random random = new Random();
            int x = random.Next(400);
            int y = random.Next(400);

            this.btnRabbit.Location = new System.Drawing.Point(x, y);
            this.btnRabbit.Image = Image.FromFile(@"D:\ISS\ISS-GUI\Ykchia\Dip SA\UIVSC\Images\happyRabbit.GIF");
        }
    }
}
