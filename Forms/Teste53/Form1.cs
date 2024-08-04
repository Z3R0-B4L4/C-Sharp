using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
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

        private void checkboxToolStripMenuItem_Click(object sender, EventArgs e)//metodo para mostrar a janela F_CheckBox
        {
            F_CheckBox f_CheckBox = new F_CheckBox();
            f_CheckBox.Show();
        }

        private void checkedlistToolStripMenuItem_Click(object sender, EventArgs e)//metodo para mostrar a janela F_CheckedListBox
        {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
            f_CheckedListBox.Show();
        }

        private void ComboBoxToolStripMenuItem_Click(object sender, EventArgs e)//metodo para mostrar a janela F_ComboBox
        {
            F_ComboBox f_ComboBox = new F_ComboBox();
            f_ComboBox.Show();
        }

        private void DateTimerPickerToolStripMenuItem_Click(object sender, EventArgs e)//metodo para mostrar a janela F_DateTimerPicker
        {
            F_DateTimerPicker f_DateTimerPicker = new F_DateTimerPicker();
            f_DateTimerPicker.Show();
        }

        private void LinkLabelToolStripMenuItem_Click(object sender, EventArgs e)//metodo para mostrar a janela F_LinkLabel
        {
            F_LinkLabel f_LinkLabel = new F_LinkLabel();
            f_LinkLabel.Show();
        }

        private void ListBoxToolStripMenuItem_Click(object sender, EventArgs e)//metodo para mostrar a janela F_ListBox
        {
            F_ListBox f_ListBox = new F_ListBox();
            f_ListBox.Show();
        }

        private void ListViewToolStripMenuItem_Click(object sender, EventArgs e)//metodo para mostrar a janela F_ListView
        {
            F_ListView f_ListView = new F_ListView();
            f_ListView.Show();
        }

        private void MaskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)//metodo para mostrar a janela F_MaskedTextBox
        {
            F_MaskedTextBox f_MaskedTextBox = new F_MaskedTextBox();
            f_MaskedTextBox.Show();
        }

        private void MonthCalendarToolStripMenuItem_Click(object sender, EventArgs e)//metodo para mostrar a janela F_MonthCalendar
        {
            F_MonthCalendar f_MonthCalendar = new F_MonthCalendar();
            f_MonthCalendar.Show();
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

        private void NumericUpDownToolStripMenuItem_Click(object sender, EventArgs e)//metodo para mostrar a janela F_NumericUpDown
        {
            F_NumericUpDown f_NumericUpDown = new F_NumericUpDown();
            f_NumericUpDown.Show();
        }

        private void PictureBoxToolStripMenuItem_Click(object sender, EventArgs e)//metodo para mostrar a janela F_PictureBox
        {
            F_PictureBox f_PictureBox = new F_PictureBox();
            f_PictureBox.Show();
        }

        private void ProgressBarToolStripMenuItem_Click(object sender, EventArgs e)//metodo para mostrar a janela F_ProgressBar
        {
            F_ProgressBar f_ProgressBar = new F_ProgressBar();
            f_ProgressBar.Show();
        }

        private void RadioButtonToolStripMenuItem_Click(object sender, EventArgs e)//metodo para mostrar a janela F_RadioButton
        {
            F_RadioButton f_RadioButton = new F_RadioButton();
            f_RadioButton.Show();
        }

        private void TrackBarToolStripMenuItem_Click(object sender, EventArgs e)//metodo para mostrar a janela F_TrackBar
        {
            F_TrackBar f_TrackBar = new F_TrackBar();
            f_TrackBar.Show();
        }

        private void TreeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TreeView f_TreeView = new F_TreeView();
            f_TreeView.Show();
        }

        private void SplitContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_SplitContainer f_SplitContainer = new F_SplitContainer();
            f_SplitContainer.Show();
        }
    }
}
