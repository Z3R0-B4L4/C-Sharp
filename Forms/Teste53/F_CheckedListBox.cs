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
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
        {
            string txt = "";
            if(clb_transportes.CheckedItems.Count == 0)
            {
                txt = "Nenhum item selecionado";
            }
            foreach(string t in clb_transportes.CheckedItems)
            {
                txt += t + Environment.NewLine;
            }
           
            MessageBox.Show(txt);
        }

        private void btn_limparLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
            /*
            clb_transportes.Items.Add("Carro",false);
            clb_transportes.Items.Add("Avião", false);
            clb_transportes.Items.Add("Navio", false);
            clb_transportes.Items.Add("Ônibus", false);
            *******************************************
            List<string> lista = new List<string>();
            lista.Add("Carro");
            lista.Add("Aviao");
            lista.Add("Navio");
            lista.Add("Onibus");
            clb_transportes.Items.AddRange(lista.ToArray());
            */
            clb_transportes.Items.AddRange(new string[] { "Carro", "Avião", "Navio", "Ônibus"});
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_novoItem.Text != "")
            {
                clb_transportes.Items.Add(tb_novoItem.Text);
                tb_novoItem.Clear();
                tb_novoItem.Focus();
            }
            else
            {
                MessageBox.Show("Nenhum item informado");
            }
        }
    }
}
