namespace Teste53
{
    partial class F_LinkLabel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ll_git = new System.Windows.Forms.LinkLabel();
            this.ll_calc = new System.Windows.Forms.LinkLabel();
            this.ll_mutiplosLinks = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ll_git
            // 
            this.ll_git.AutoSize = true;
            this.ll_git.Location = new System.Drawing.Point(44, 29);
            this.ll_git.Name = "ll_git";
            this.ll_git.Size = new System.Drawing.Size(40, 13);
            this.ll_git.TabIndex = 0;
            this.ll_git.TabStop = true;
            this.ll_git.Text = "GitHub";
            this.ll_git.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_git_LinkClicked);
            // 
            // ll_calc
            // 
            this.ll_calc.AutoSize = true;
            this.ll_calc.Location = new System.Drawing.Point(44, 79);
            this.ll_calc.Name = "ll_calc";
            this.ll_calc.Size = new System.Drawing.Size(63, 13);
            this.ll_calc.TabIndex = 1;
            this.ll_calc.TabStop = true;
            this.ll_calc.Text = "Calculadora";
            this.ll_calc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_calc_LinkClicked);
            // 
            // ll_mutiplosLinks
            // 
            this.ll_mutiplosLinks.AutoSize = true;
            this.ll_mutiplosLinks.Location = new System.Drawing.Point(47, 146);
            this.ll_mutiplosLinks.Name = "ll_mutiplosLinks";
            this.ll_mutiplosLinks.Size = new System.Drawing.Size(136, 13);
            this.ll_mutiplosLinks.TabIndex = 2;
            this.ll_mutiplosLinks.TabStop = true;
            this.ll_mutiplosLinks.Text = "Google / GitHub / Youtube";
            this.ll_mutiplosLinks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_mutiplosLinks_LinkClicked);
            // 
            // F_LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ll_mutiplosLinks);
            this.Controls.Add(this.ll_calc);
            this.Controls.Add(this.ll_git);
            this.Name = "F_LinkLabel";
            this.Text = "LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel ll_git;
        private System.Windows.Forms.LinkLabel ll_calc;
        private System.Windows.Forms.LinkLabel ll_mutiplosLinks;
    }
}