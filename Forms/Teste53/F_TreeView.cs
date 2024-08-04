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
    public partial class F_TreeView : Form
    {
        public F_TreeView()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox2.Clear();
            textBox1.Text = treeView1.SelectedNode.Text;
            if(treeView1.SelectedNode.Tag != null)
            {
                textBox2.Text = treeView1.SelectedNode.Tag.ToString();
            }
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            TreeNode raizLamborghini = treeView1.Nodes.Add("Lamborghini");
            raizLamborghini.Name = "Lamborghini";

            TreeNode L1 = raizLamborghini.Nodes.Add("Lamborghini Urus");
            L1.Name = "Lamborghini Urus";

            TreeNode L2 = raizLamborghini.Nodes.Add("Lamborghini Huracan");
            L2.Name = "Lamborghini Huracan";

            TreeNode raizPorche = treeView1.Nodes.Add("Porche");
            raizPorche.Name = "Porche";

            TreeNode P1 = raizPorche.Nodes.Add("Porche 911");
            P1.Name = "Porche 911";

            TreeNode P2 = raizPorche.Nodes.Add("Porche Cayman");
            P2.Name = "Porche Cayman";
            
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Remove(treeView1.Nodes["Lamborghini"]);
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao remover nó "+ex.ToString());

            }
        }

        private void btn_delSelected_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }
    }
}
