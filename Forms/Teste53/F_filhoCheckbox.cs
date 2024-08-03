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
    public partial class F_filhoCheckbox : Form
    {
        public F_CheckBox f_checkbox;
        public F_filhoCheckbox()
        {
            InitializeComponent();
            f_checkbox = Application.OpenForms["F_CheckBox"] as F_CheckBox;
            cb_carro.Checked = f_checkbox.cb_carro.Checked;
            cb_aviao.Checked = f_checkbox.cb_aviao.Checked;
            cb_onibus.Checked = f_checkbox.cb_onibus.Checked;
            cb_moto.Checked = f_checkbox.cb_moto.Checked;
        }

        private void cb_carro_CheckedChanged(object sender, EventArgs e)
        {
            f_checkbox.cb_carro.Checked = cb_carro.Checked;
        }

        private void cb_aviao_CheckedChanged(object sender, EventArgs e)
        {
            f_checkbox.cb_aviao.Checked = cb_aviao.Checked;
        }

        private void cb_moto_CheckedChanged(object sender, EventArgs e)
        {
            f_checkbox.cb_moto.Checked = cb_moto.Checked;
        }

        private void cb_onibus_CheckedChanged(object sender, EventArgs e)
        {
            f_checkbox.cb_onibus.Checked = cb_onibus.Checked;
        }
    }
}
