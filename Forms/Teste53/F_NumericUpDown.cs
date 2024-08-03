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
    public partial class F_NumericUpDown : Form
    {
        public F_NumericUpDown()
        {
            InitializeComponent();
        }

        private void btn_SetValue_Click(object sender, EventArgs e)
        {
            if (int.Parse(tb_valor.Text) >= numericUpDown1.Minimum & int.Parse(tb_valor.Text) <= numericUpDown1.Maximum)
            {
                numericUpDown1.Value = int.Parse(tb_valor.Text);
            }else if(int.Parse(tb_valor.Text) < numericUpDown1.Minimum) 
            { 
                numericUpDown1.Value = numericUpDown1.Minimum; 
            }else if(int.Parse(tb_valor.Text) > numericUpDown1.Maximum) 
            { 
                numericUpDown1.Value = numericUpDown1.Maximum;
            }
            
                
            
        }

        private void tb_valor_TextChanged(object sender, EventArgs e)
        {
            if (tb_valor.Text == "")
            {
                numericUpDown1.Value = numericUpDown1.Minimum;
            }
            else
            {
                if (int.Parse(tb_valor.Text) >= numericUpDown1.Minimum & int.Parse(tb_valor.Text) <= numericUpDown1.Maximum)
                {
                    numericUpDown1.Value = int.Parse(tb_valor.Text);
                }
                else if (int.Parse(tb_valor.Text) < numericUpDown1.Minimum)
                {
                    numericUpDown1.Value = numericUpDown1.Minimum;
                }
                else if (int.Parse(tb_valor.Text) > numericUpDown1.Maximum)
                {
                    numericUpDown1.Value = numericUpDown1.Maximum;
                }
            }
        }
    }
}
