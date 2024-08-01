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
    public partial class F_CheckBox : Form
    {
        List<CheckBox> transp = new List<CheckBox>();
        public F_CheckBox()
        {
            InitializeComponent();
            transp.Add(cb_aviao);
            transp.Add(cb_carro);
            transp.Add(cb_onibus);
            transp.Add(cb_moto);
        }

        private void btn_checkedTransportes_Click(object sender, EventArgs e)
        {
            string txt = "";
            if (cb_aviao.Checked)
            {
                txt += cb_aviao.Text + Environment.NewLine;
            }
            if (cb_carro.Checked)
            {
                txt += cb_carro.Text + Environment.NewLine;
            }
            if (cb_onibus.Checked)
            {
                txt += cb_onibus.Text + Environment.NewLine;
            }
            if (cb_moto.Checked)
            {
                txt += cb_moto.Text + Environment.NewLine;
            }
            MessageBox.Show(txt);
        }

        private void cb_bicicleta_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_bicicleta.Checked)
            {
                MessageBox.Show(cb_bicicleta.Text);
            }
        }
    }
}
