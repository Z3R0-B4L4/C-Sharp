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

        private void ComboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ComboBox f_ComboBox = new F_ComboBox();
            f_ComboBox.ShowDialog();
        }

        private void DateTimerPickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DateTimerPicker f_DateTimerPicker = new F_DateTimerPicker();
            f_DateTimerPicker.ShowDialog();
        }

        private void LinkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_LinkLabel f_LinkLabel = new F_LinkLabel();
            f_LinkLabel.ShowDialog();
        }

        private void ListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListBox f_ListBox = new F_ListBox();
            f_ListBox.ShowDialog();
        }

        private void ListViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListView f_ListView = new F_ListView();
            f_ListView.ShowDialog();
        }

        private void MaskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MaskedTextBox f_MaskedTextBox = new F_MaskedTextBox();
            f_MaskedTextBox.ShowDialog();
        }

        private void MonthCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MonthCalendar f_MonthCalendar = new F_MonthCalendar();
            f_MonthCalendar.ShowDialog();
        }

        private void MenuNotify_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Name.ToString() == "tsmi_Close")
            {
                this.Close();
            }else if(e.ClickedItem.Name.ToString() == "tsmi_Restaurar")
            {
                this.WindowState = FormWindowState.Normal;
            }else if(e.ClickedItem.Name.ToString() == "tsmi_Mensagem")
            {
                MessageBox.Show("Mensagem");
            }
            
        }

        private void NumericUpDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NumericUpDown f_NumericUpDown = new F_NumericUpDown();
            f_NumericUpDown.ShowDialog();
        }

        private void PictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_PictureBox f_PictureBox = new F_PictureBox();
            f_PictureBox.ShowDialog();
        }
    }
}
