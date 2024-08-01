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
    public partial class F_Nomes : Form
    {
        F_Main fm;
        public F_Nomes(string n, F_Main fmc)
        {
            InitializeComponent();

            tb_ListaNomes.Text = n;//pega os valores da lista de nomes do f_main e coloca na tb_listanomes
            fm = fmc;//atribui a variavel fm o valor da variável fmc para que se possa utilizar a f_main de forma global aqui no f_Nomes
            fmc.num = tb_ListaNomes.Lines.Length;//pega o tamanho da lista de nomes e coloca na variável num
        }

        private void tb_ListaNomes_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void F_Nomes_FormClosed(object sender, FormClosedEventArgs e)
        {
            fm.tb_listaNomes.Text = tb_ListaNomes.Text;//coloca o valor da tb_listanomes do f_main na tb_listanomes
        }
    }
}
