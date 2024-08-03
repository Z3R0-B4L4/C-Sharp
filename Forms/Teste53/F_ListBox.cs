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

    public partial class F_ListBox : Form
    {
        private void update()
        {
            lb_carros.DataSource = null;
            lb_carros.DataSource = carros;
        }
        /*
        private void update(ListBox lb, List<string> L)
        {
            lb.DataSource = null;
            lb.DataSource = L;
        }
        */
        List<string> carros = new List<string>();

        public F_ListBox()
        {
            InitializeComponent();

            carros.Add("Mustang");
            carros.Add("GT-R NISMO");
            carros.Add("Mazda rx8");
            carros.Add("Supra");

            lb_carros.DataSource = carros;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_carro.Text == "")
            {
                MessageBox.Show("Preencha o campo com o nome do carro");
                tb_carro.Focus();
            }
            else
            {
                carros.Add(tb_carro.Text);
                update();
                //update(lb_carros, carros);
                tb_carro.Clear();
                tb_carro.Focus();
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            carros.RemoveAt(lb_carros.SelectedIndex);
            update();
            //update(lb_carros, carros);
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            tb_carro.Text = carros[lb_carros.SelectedIndex];

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            carros.Clear();
            update();
            //update(lb_carros, carros);
            tb_carro.Clear();
        }
    }
}
