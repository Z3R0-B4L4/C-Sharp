﻿namespace Teste53
{
    partial class F_ListBox
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
            this.lb_carros = new System.Windows.Forms.ListBox();
            this.tb_carro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_obter = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_carros
            // 
            this.lb_carros.FormattingEnabled = true;
            this.lb_carros.Location = new System.Drawing.Point(13, 13);
            this.lb_carros.Name = "lb_carros";
            this.lb_carros.Size = new System.Drawing.Size(120, 134);
            this.lb_carros.TabIndex = 0;
            // 
            // tb_carro
            // 
            this.tb_carro.Location = new System.Drawing.Point(140, 35);
            this.tb_carro.Name = "tb_carro";
            this.tb_carro.Size = new System.Drawing.Size(100, 20);
            this.tb_carro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Carro:";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(140, 61);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(140, 92);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(100, 23);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "Remover";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_obter
            // 
            this.btn_obter.Location = new System.Drawing.Point(140, 122);
            this.btn_obter.Name = "btn_obter";
            this.btn_obter.Size = new System.Drawing.Size(100, 23);
            this.btn_obter.TabIndex = 5;
            this.btn_obter.Text = "Obter";
            this.btn_obter.UseVisualStyleBackColor = true;
            this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(13, 154);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(227, 23);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Limpar Tudo";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // F_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_obter);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_carro);
            this.Controls.Add(this.lb_carros);
            this.Name = "F_ListBox";
            this.Text = "F_ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_carros;
        private System.Windows.Forms.TextBox tb_carro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_obter;
        private System.Windows.Forms.Button btn_clear;
    }
}