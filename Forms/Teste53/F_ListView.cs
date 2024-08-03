using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//item = linha, subitem = coluna
namespace Teste53
{
    public partial class F_ListView : Form
    {
        public F_ListView()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            tb_id.Clear();
            tb_prod.Clear();
            tb_qtde.Clear();
            tb_preco.Clear();
            tb_id.Focus();
        }

        private void get()
        {
            tb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
            tb_prod.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
            tb_qtde.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
            tb_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_id.Text == "" || tb_prod.Text == "" || tb_qtde.Text == "" || tb_preco.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                string[] item = new string[4];

                item[0] = tb_id.Text;
                item[1] = tb_prod.Text;
                item[2] = tb_qtde.Text;
                item[3] = tb_preco.Text;
                lv_produtos.Items.Add(new ListViewItem(item));
                /*
                ListViewItem L = new ListViewItem(item);
                lv_produtos.Items.Add(L);
                */
                limpar();
            }

            /*
            if(tb_id.Text == "")
            {
                MessageBox.Show("Preencha o ID");
                tb_id.Focus();
                return;
            }else if(tb_prod.Text == "")
            {
                MessageBox.Show("Preencha o nome do produto");
                tb_prod.Focus();
                return;
            }else if(tb_qtde.Text == "")
            {
                MessageBox.Show("Preencha a quantidade");
                tb_qtde.Focus();
                return;
            }else if(tb_preco.Text == "")
            {
                MessageBox.Show("Preencha o preço");
                tb_preco.Focus();
                return;
            }
            else
            {
                string[] item = new string[4];

                item[0] = tb_id.Text;
                item[1] = tb_prod.Text;
                item[2] = tb_qtde.Text;
                item[3] = tb_preco.Text;
                lv_produtos.Items.Add(new ListViewItem(item));
                limpar();
            }
            */
            
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            lv_produtos.Items.RemoveAt(lv_produtos.SelectedIndices[0]);
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            get();
        }

        private void lv_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_produtos.SelectedIndices.Count > 0)
            {
                get();
            }
           
        }
    }
}
