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
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();
            ll_mutiplosLinks.Links.Add(0, 6, "www.google.com");
            ll_mutiplosLinks.Links.Add(9, 6, "www.github.com/Z3R0-B4L4");
            ll_mutiplosLinks.Links.Add(18, 7, "www.youtube.com");

            ll_mutiplosLinks.Links[2].Enabled = false;
        }

        private void ll_git_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Z3R0-B4L4");
        }

        private void ll_calc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void ll_mutiplosLinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            e.Link.Visited = true;
        }
    }
}
