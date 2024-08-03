using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste53
{
    public partial class F_PictureBox : Form
    {
        public F_PictureBox()
        {
            InitializeComponent();
        }

        private void F_PictureBox_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.NomeGit;
            label2.Text = Properties.Resources.EndereçoGit;
        }

        private void btn_image1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Crazy_Vegeta73;
        }

        private void btn_image2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.demon_iphone_bwc46tn5gdgmf4sx;
        }
    }
}
