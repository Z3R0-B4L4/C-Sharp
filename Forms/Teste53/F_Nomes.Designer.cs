namespace Teste53
{
    partial class F_Nomes
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
            this.tb_ListaNomes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_ListaNomes
            // 
            this.tb_ListaNomes.Location = new System.Drawing.Point(23, 39);
            this.tb_ListaNomes.Multiline = true;
            this.tb_ListaNomes.Name = "tb_ListaNomes";
            this.tb_ListaNomes.Size = new System.Drawing.Size(331, 238);
            this.tb_ListaNomes.TabIndex = 0;
            this.tb_ListaNomes.TextChanged += new System.EventHandler(this.tb_ListaNomes_TextChanged);
            // 
            // F_Nomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_ListaNomes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Nomes";
            this.Text = "Lista de nomes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Nomes_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ListaNomes;
    }
}