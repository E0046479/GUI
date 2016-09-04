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
    public partial class KillARabbit : Form
    {
        public KillARabbit()
        {
            InitializeComponent();
        }

        private void btn_Rabbit_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_Rabbit.ForeColor = Color.Red;
            this.btn_Rabbit.Image = Image.FromFile(@"D:\ISS\ISS-GUI\Ykchia\Dip SA\UIVSC\Images\sadRabbit.GIF");
        
        }

        private void btn_Rabbit_MouseUp(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            int x = random.Next(400);
            int y = random.Next(400);
            this.btn_Rabbit.ForeColor = Color.Black;
            this.btn_Rabbit.Image = Image.FromFile(@"D:\ISS\ISS-GUI\Ykchia\Dip SA\UIVSC\Images\happyRabbit.GIF");
        
            this.btn_Rabbit.Location = new System.Drawing.Point(x, y);
        }
    }
}
