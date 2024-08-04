namespace Teste53
{
    partial class F_TreeView
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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("370z");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("GT-R");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Nissan", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("RX-8 R3");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("RX-7");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Mazda", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_delSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode13.Name = "370z";
            treeNode13.Tag = "https://www.google.com/search?q=370z";
            treeNode13.Text = "370z";
            treeNode14.Name = "GT-R";
            treeNode14.Tag = "https://www.google.com/search?q=gt-r";
            treeNode14.Text = "GT-R";
            treeNode15.Name = "Nissan";
            treeNode15.Text = "Nissan";
            treeNode16.Name = "RX-8_R3";
            treeNode16.Tag = "https://www.google.com/search?q=RX-8+R3";
            treeNode16.Text = "RX-8 R3";
            treeNode17.Name = "RX-7";
            treeNode17.Tag = "https://www.google.com/search?q=RX-7";
            treeNode17.Text = "RX-7";
            treeNode18.Name = "Mazda";
            treeNode18.Text = "Mazda";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode18});
            this.treeView1.Size = new System.Drawing.Size(199, 263);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(218, 13);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(148, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(218, 43);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(148, 23);
            this.btn_remove.TabIndex = 2;
            this.btn_remove.Text = "Remover";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(218, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 20);
            this.textBox2.TabIndex = 4;
            // 
            // btn_delSelected
            // 
            this.btn_delSelected.Location = new System.Drawing.Point(386, 43);
            this.btn_delSelected.Name = "btn_delSelected";
            this.btn_delSelected.Size = new System.Drawing.Size(125, 23);
            this.btn_delSelected.TabIndex = 5;
            this.btn_delSelected.Text = "remover selecionado";
            this.btn_delSelected.UseVisualStyleBackColor = true;
            this.btn_delSelected.Click += new System.EventHandler(this.btn_delSelected_Click);
            // 
            // F_TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_delSelected);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.treeView1);
            this.Name = "F_TreeView";
            this.Text = "TreeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_delSelected;
    }
}