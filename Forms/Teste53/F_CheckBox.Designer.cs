namespace Teste53
{
    partial class F_CheckBox
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
            this.cb_carro = new System.Windows.Forms.CheckBox();
            this.cb_aviao = new System.Windows.Forms.CheckBox();
            this.cb_moto = new System.Windows.Forms.CheckBox();
            this.cb_onibus = new System.Windows.Forms.CheckBox();
            this.btn_checkedTransportes = new System.Windows.Forms.Button();
            this.cb_bicicleta = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_carro
            // 
            this.cb_carro.AutoSize = true;
            this.cb_carro.Location = new System.Drawing.Point(13, 13);
            this.cb_carro.Name = "cb_carro";
            this.cb_carro.Size = new System.Drawing.Size(51, 17);
            this.cb_carro.TabIndex = 0;
            this.cb_carro.Text = "Carro";
            this.cb_carro.UseVisualStyleBackColor = true;
            // 
            // cb_aviao
            // 
            this.cb_aviao.AutoSize = true;
            this.cb_aviao.Location = new System.Drawing.Point(13, 37);
            this.cb_aviao.Name = "cb_aviao";
            this.cb_aviao.Size = new System.Drawing.Size(53, 17);
            this.cb_aviao.TabIndex = 1;
            this.cb_aviao.Text = "Avião";
            this.cb_aviao.UseVisualStyleBackColor = true;
            // 
            // cb_moto
            // 
            this.cb_moto.AutoSize = true;
            this.cb_moto.Location = new System.Drawing.Point(13, 61);
            this.cb_moto.Name = "cb_moto";
            this.cb_moto.Size = new System.Drawing.Size(50, 17);
            this.cb_moto.TabIndex = 2;
            this.cb_moto.Text = "Moto";
            this.cb_moto.UseVisualStyleBackColor = true;
            // 
            // cb_onibus
            // 
            this.cb_onibus.AutoSize = true;
            this.cb_onibus.Location = new System.Drawing.Point(13, 85);
            this.cb_onibus.Name = "cb_onibus";
            this.cb_onibus.Size = new System.Drawing.Size(59, 17);
            this.cb_onibus.TabIndex = 3;
            this.cb_onibus.Text = "Onibus";
            this.cb_onibus.UseVisualStyleBackColor = true;
            // 
            // btn_checkedTransportes
            // 
            this.btn_checkedTransportes.Location = new System.Drawing.Point(303, 13);
            this.btn_checkedTransportes.Name = "btn_checkedTransportes";
            this.btn_checkedTransportes.Size = new System.Drawing.Size(189, 23);
            this.btn_checkedTransportes.TabIndex = 4;
            this.btn_checkedTransportes.Text = "Transportes marcados";
            this.btn_checkedTransportes.UseVisualStyleBackColor = true;
            this.btn_checkedTransportes.Click += new System.EventHandler(this.btn_checkedTransportes_Click);
            // 
            // cb_bicicleta
            // 
            this.cb_bicicleta.AutoSize = true;
            this.cb_bicicleta.Location = new System.Drawing.Point(13, 193);
            this.cb_bicicleta.Name = "cb_bicicleta";
            this.cb_bicicleta.Size = new System.Drawing.Size(66, 17);
            this.cb_bicicleta.TabIndex = 5;
            this.cb_bicicleta.Text = "Bicicleta";
            this.cb_bicicleta.UseVisualStyleBackColor = true;
            this.cb_bicicleta.CheckedChanged += new System.EventHandler(this.cb_bicicleta_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Abrir form filho";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_bicicleta);
            this.Controls.Add(this.btn_checkedTransportes);
            this.Controls.Add(this.cb_onibus);
            this.Controls.Add(this.cb_moto);
            this.Controls.Add(this.cb_aviao);
            this.Controls.Add(this.cb_carro);
            this.Name = "F_CheckBox";
            this.Text = "CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_checkedTransportes;
        private System.Windows.Forms.CheckBox cb_bicicleta;
        public System.Windows.Forms.CheckBox cb_carro;
        public System.Windows.Forms.CheckBox cb_aviao;
        public System.Windows.Forms.CheckBox cb_moto;
        public System.Windows.Forms.CheckBox cb_onibus;
        private System.Windows.Forms.Button button1;
    }
}