using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Teste54
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            F_login f_login = new F_login(this);
            f_login.ShowDialog();
        }

        private void LoginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_login f_login = new F_login(this);
            f_login.ShowDialog();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acess.Text = "0";
            lb_user.Text = "-";
            pb_ledLogado.Image = Properties.Resources.led_vermelho;
            Globais.acessLevel = 0;
            Globais.loginStatus = false;
        }
    }
}
