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
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_transportes.Text);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();
            cb_transportes.Items.AddRange(new string[] { "Carro", "Avião", "Moto", "Bicicleta" });
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cb_transportes.Text != ""){
                if (cb_transportes.FindString(tb_item.Text) < 0)
                {
                    cb_transportes.Items.Add(tb_item.Text);
                }
                else
                {
                    MessageBox.Show("Item ja existe");
                }
            }
            else
            {
                MessageBox.Show("Item não pode ser vazio");
            }
            
        }

        private void cb_transportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_item.Text = cb_transportes.Text;
        }
    }
}
