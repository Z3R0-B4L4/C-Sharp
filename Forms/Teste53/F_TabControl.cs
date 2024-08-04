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
    public partial class F_TabControl : Form
    {
        public F_TabControl()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_nome.Text != "")
            {
                TabPage tp = new TabPage();
                tp.Text = tb_nome.Text;
                tp.Name = tb_nome.Text;
                tabControl1.TabPages.Add(tp);
                tb_nome.Clear();
                max();
            }
            else
            {
                MessageBox.Show("Digite o nome para adicionar uma nova aba");
                tb_nome.Focus();
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            max();
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
                tabControl1.SelectedIndex = (int)numericUpDown1.Value;
        }
        private void max()
        {
            numericUpDown1.Maximum = tabControl1.TabPages.Count -1;
        }

        private void F_TabControl_Load(object sender, EventArgs e)
        {
            max();
        }
    }
}
