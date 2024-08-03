using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Teste53
{
    public partial class F_ProgressBar : Form
    {
        public F_ProgressBar()
        {
            InitializeComponent();
        }

        private void btn_defValue_Click(object sender, EventArgs e)
        {
            if(int.Parse(textBox1.Text) >= progressBar1.Minimum & int.Parse(textBox1.Text) <= progressBar1.Maximum)
            {
                progressBar1.Value = int.Parse(textBox1.Text);
            }
        }

        private void btn_preencher_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;
            progressBar1.Maximum = int.Parse(textBox1.Text);

            for (int i = progressBar1.Minimum; i <= int.Parse(textBox1.Text); i++)
            {
                progressBar1.Value = i;
                //Thread.Sleep(100);
            }
        }
    }
}
