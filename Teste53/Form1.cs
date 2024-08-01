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
    public partial class F_Main : Form
    {
        public int num;
        public F_Main()
        {
            InitializeComponent();
            num = 0;
        }

        private void tb_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            

            if(tb_nome.Text == "")
            {
                MessageBox.Show("Insira um nome");// mensagem de erro caso o campo tb_nome esteja vazio
                tb_nome.Focus();// foca no campo tb_nome
                return;
            }
            else
            {
                tb_listaNomes.Text += tb_nome.Text + "\r\n"; // adiciona o nome no campo tb_listanomes
                tb_nome.Clear();// limpa o campo tb_nome
                tb_nome.Focus();// foca no campo tb_nome
            }
        }

        private void tb_listaNomes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_listaNomes.Clear();// limpa o campo tb_listanomes
            tb_nome.Clear();// limpa o campo tb_nome
            tb_nome.Focus();// foca no campo tb_nome
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            F_Nomes f_Nomes = new F_Nomes(tb_listaNomes.Text, this); // cria uma instância da classe F_Nomes
            f_Nomes.ShowDialog();// mostra a instância da classe F_Nomes
        }

        private void btn_valNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void componenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cheToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox f_CheckBox = new F_CheckBox();
            f_CheckBox.ShowDialog();
        }

        private void checkedlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
            f_CheckedListBox.ShowDialog();
        }
    }
}
