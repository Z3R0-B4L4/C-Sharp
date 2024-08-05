using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste54
{
    public partial class F_login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();

        public F_login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;
            if(username == "" || password == "")
            {
                MessageBox.Show("Preencha todos os campos");
                tb_username.Focus();
                return;
            }

            string sql= "SELECT * FROM tb_users WHERE username = '" + username + "' AND password = '" + password + "'";
            dt = Banco.read(sql);
            if(dt.Rows.Count == 1)
            {
                form1.lb_acess.Text = dt.Rows[0]["user_level"].ToString();
                //form1.lb_acess.Text = dt.Rows[0].ItemArray[5].ToString();
                form1.lb_user.Text = dt.Rows[0]["username"].ToString();
                //form1.lb_user.Text = dt.Rows[0].Field<string>("username");
                form1.pb_ledLogado.Image = Properties.Resources.led_verde;
                Globais.acessLevel = (int)dt.Rows[0]["user_level"];
                Globais.loginStatus = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
                tb_password.Focus();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
