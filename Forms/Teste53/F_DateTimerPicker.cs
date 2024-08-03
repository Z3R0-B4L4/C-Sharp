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
    public partial class F_DateTimerPicker : Form
    {
        public F_DateTimerPicker()
        {
            InitializeComponent();
        }

        private void btn_obterData_Click(object sender, EventArgs e)
        {
            tb_data.Text = dtp_data.Text;

            tb_dia.Text = dtp_data.Value.Day.ToString();
            tb_mes.Text = dtp_data.Value.Month.ToString();
            tb_ano.Text = dtp_data.Value.Year.ToString();
        }

        private void btn_setData_Click(object sender, EventArgs e)
        {
            int d, m, a;

            d = int.Parse(tb_dia.Text);
            m = int.Parse(tb_mes.Text);
            a = int.Parse(tb_ano.Text);

            dtp_data.Value = new DateTime(a, m, d);
        }

        private void btn_today_Click(object sender, EventArgs e)
        {
            dtp_data.Value = DateTime.Today;
        }
    }
}
