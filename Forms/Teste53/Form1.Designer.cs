namespace Teste53
{
    partial class F_Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Main));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tb_listaNomes = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_valNum = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DateTimerPickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LinkLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MaskedTextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MonthCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NumericUpDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgressBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RadioButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrackBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_Restaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Mensagem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.componentes2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableLayoutPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundworkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.MenuNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um Nome:";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(12, 84);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(154, 20);
            this.tb_nome.TabIndex = 1;
            this.tb_nome.TextChanged += new System.EventHandler(this.tb_nome_TextChanged);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(172, 82);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar.TabIndex = 2;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // tb_listaNomes
            // 
            this.tb_listaNomes.Location = new System.Drawing.Point(12, 110);
            this.tb_listaNomes.Multiline = true;
            this.tb_listaNomes.Name = "tb_listaNomes";
            this.tb_listaNomes.ReadOnly = true;
            this.tb_listaNomes.Size = new System.Drawing.Size(235, 235);
            this.tb_listaNomes.TabIndex = 3;
            this.tb_listaNomes.TextChanged += new System.EventHandler(this.tb_listaNomes_TextChanged);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(12, 352);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(235, 23);
            this.btn_limpar.TabIndex = 4;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(12, 382);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(235, 23);
            this.btn_show.TabIndex = 5;
            this.btn_show.Text = "Mostrar Nomes";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_valNum
            // 
            this.btn_valNum.Location = new System.Drawing.Point(12, 412);
            this.btn_valNum.Name = "btn_valNum";
            this.btn_valNum.Size = new System.Drawing.Size(235, 23);
            this.btn_valNum.TabIndex = 6;
            this.btn_valNum.Text = "Valor da variavel num";
            this.btn_valNum.UseVisualStyleBackColor = true;
            this.btn_valNum.Click += new System.EventHandler(this.btn_valNum_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem,
            this.componentes2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(264, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkboxToolStripMenuItem,
            this.checkedlistToolStripMenuItem,
            this.ComboBoxToolStripMenuItem,
            this.DateTimerPickerToolStripMenuItem,
            this.LinkLabelToolStripMenuItem,
            this.ListBoxToolStripMenuItem,
            this.ListViewToolStripMenuItem,
            this.MaskedTextBoxToolStripMenuItem,
            this.MonthCalendarToolStripMenuItem,
            this.NumericUpDownToolStripMenuItem,
            this.PictureBoxToolStripMenuItem,
            this.ProgressBarToolStripMenuItem,
            this.RadioButtonToolStripMenuItem,
            this.TrackBarToolStripMenuItem,
            this.TreeViewToolStripMenuItem,
            this.SplitContainerToolStripMenuItem});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.componentesToolStripMenuItem.Text = "Componentes";
            // 
            // checkboxToolStripMenuItem
            // 
            this.checkboxToolStripMenuItem.Name = "checkboxToolStripMenuItem";
            this.checkboxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkboxToolStripMenuItem.Text = "Checkbox";
            this.checkboxToolStripMenuItem.Click += new System.EventHandler(this.checkboxToolStripMenuItem_Click);
            // 
            // checkedlistToolStripMenuItem
            // 
            this.checkedlistToolStripMenuItem.Name = "checkedlistToolStripMenuItem";
            this.checkedlistToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkedlistToolStripMenuItem.Text = "Checkedlistbox";
            this.checkedlistToolStripMenuItem.Click += new System.EventHandler(this.checkedlistToolStripMenuItem_Click);
            // 
            // ComboBoxToolStripMenuItem
            // 
            this.ComboBoxToolStripMenuItem.Name = "ComboBoxToolStripMenuItem";
            this.ComboBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ComboBoxToolStripMenuItem.Text = "ComboBox";
            this.ComboBoxToolStripMenuItem.Click += new System.EventHandler(this.ComboBoxToolStripMenuItem_Click);
            // 
            // DateTimerPickerToolStripMenuItem
            // 
            this.DateTimerPickerToolStripMenuItem.Name = "DateTimerPickerToolStripMenuItem";
            this.DateTimerPickerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DateTimerPickerToolStripMenuItem.Text = "DateTimerPicker";
            this.DateTimerPickerToolStripMenuItem.Click += new System.EventHandler(this.DateTimerPickerToolStripMenuItem_Click);
            // 
            // LinkLabelToolStripMenuItem
            // 
            this.LinkLabelToolStripMenuItem.Name = "LinkLabelToolStripMenuItem";
            this.LinkLabelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LinkLabelToolStripMenuItem.Text = "LinkLabel";
            this.LinkLabelToolStripMenuItem.Click += new System.EventHandler(this.LinkLabelToolStripMenuItem_Click);
            // 
            // ListBoxToolStripMenuItem
            // 
            this.ListBoxToolStripMenuItem.Name = "ListBoxToolStripMenuItem";
            this.ListBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ListBoxToolStripMenuItem.Text = "ListBox";
            this.ListBoxToolStripMenuItem.Click += new System.EventHandler(this.ListBoxToolStripMenuItem_Click);
            // 
            // ListViewToolStripMenuItem
            // 
            this.ListViewToolStripMenuItem.Name = "ListViewToolStripMenuItem";
            this.ListViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ListViewToolStripMenuItem.Text = "ListView";
            this.ListViewToolStripMenuItem.Click += new System.EventHandler(this.ListViewToolStripMenuItem_Click);
            // 
            // MaskedTextBoxToolStripMenuItem
            // 
            this.MaskedTextBoxToolStripMenuItem.Name = "MaskedTextBoxToolStripMenuItem";
            this.MaskedTextBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.MaskedTextBoxToolStripMenuItem.Text = "MaskedTextBox";
            this.MaskedTextBoxToolStripMenuItem.Click += new System.EventHandler(this.MaskedTextBoxToolStripMenuItem_Click);
            // 
            // MonthCalendarToolStripMenuItem
            // 
            this.MonthCalendarToolStripMenuItem.Name = "MonthCalendarToolStripMenuItem";
            this.MonthCalendarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.MonthCalendarToolStripMenuItem.Text = "MonthCalendar";
            this.MonthCalendarToolStripMenuItem.Click += new System.EventHandler(this.MonthCalendarToolStripMenuItem_Click);
            // 
            // NumericUpDownToolStripMenuItem
            // 
            this.NumericUpDownToolStripMenuItem.Name = "NumericUpDownToolStripMenuItem";
            this.NumericUpDownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NumericUpDownToolStripMenuItem.Text = "NumericUpDown";
            this.NumericUpDownToolStripMenuItem.Click += new System.EventHandler(this.NumericUpDownToolStripMenuItem_Click);
            // 
            // PictureBoxToolStripMenuItem
            // 
            this.PictureBoxToolStripMenuItem.Name = "PictureBoxToolStripMenuItem";
            this.PictureBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PictureBoxToolStripMenuItem.Text = "PictureBox";
            this.PictureBoxToolStripMenuItem.Click += new System.EventHandler(this.PictureBoxToolStripMenuItem_Click);
            // 
            // ProgressBarToolStripMenuItem
            // 
            this.ProgressBarToolStripMenuItem.Name = "ProgressBarToolStripMenuItem";
            this.ProgressBarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ProgressBarToolStripMenuItem.Text = "ProgressBar";
            this.ProgressBarToolStripMenuItem.Click += new System.EventHandler(this.ProgressBarToolStripMenuItem_Click);
            // 
            // RadioButtonToolStripMenuItem
            // 
            this.RadioButtonToolStripMenuItem.Name = "RadioButtonToolStripMenuItem";
            this.RadioButtonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RadioButtonToolStripMenuItem.Text = "RadioButton";
            this.RadioButtonToolStripMenuItem.Click += new System.EventHandler(this.RadioButtonToolStripMenuItem_Click);
            // 
            // TrackBarToolStripMenuItem
            // 
            this.TrackBarToolStripMenuItem.Name = "TrackBarToolStripMenuItem";
            this.TrackBarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TrackBarToolStripMenuItem.Text = "TrackBar";
            this.TrackBarToolStripMenuItem.Click += new System.EventHandler(this.TrackBarToolStripMenuItem_Click);
            // 
            // TreeViewToolStripMenuItem
            // 
            this.TreeViewToolStripMenuItem.Name = "TreeViewToolStripMenuItem";
            this.TreeViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TreeViewToolStripMenuItem.Text = "TreeView";
            this.TreeViewToolStripMenuItem.Click += new System.EventHandler(this.TreeViewToolStripMenuItem_Click);
            // 
            // SplitContainerToolStripMenuItem
            // 
            this.SplitContainerToolStripMenuItem.Name = "SplitContainerToolStripMenuItem";
            this.SplitContainerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SplitContainerToolStripMenuItem.Text = "SplitContainer";
            this.SplitContainerToolStripMenuItem.Click += new System.EventHandler(this.SplitContainerToolStripMenuItem_Click);
            // 
            // MenuNotify
            // 
            this.MenuNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Restaurar,
            this.tsmi_Mensagem,
            this.tsmi_Close});
            this.MenuNotify.Name = "MenuNotify";
            this.MenuNotify.Size = new System.Drawing.Size(134, 70);
            this.MenuNotify.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuNotify_ItemClicked);
            // 
            // tsmi_Restaurar
            // 
            this.tsmi_Restaurar.Name = "tsmi_Restaurar";
            this.tsmi_Restaurar.Size = new System.Drawing.Size(133, 22);
            this.tsmi_Restaurar.Text = "Restaurar";
            // 
            // tsmi_Mensagem
            // 
            this.tsmi_Mensagem.Name = "tsmi_Mensagem";
            this.tsmi_Mensagem.Size = new System.Drawing.Size(133, 22);
            this.tsmi_Mensagem.Text = "Mensagem";
            // 
            // tsmi_Close
            // 
            this.tsmi_Close.Name = "tsmi_Close";
            this.tsmi_Close.Size = new System.Drawing.Size(133, 22);
            this.tsmi_Close.Text = "Fechar";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.MenuNotify;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Teste53";
            this.notifyIcon1.Visible = true;
            // 
            // componentes2ToolStripMenuItem
            // 
            this.componentes2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TabControlToolStripMenuItem,
            this.TableLayoutPanelToolStripMenuItem,
            this.ToolStripContainerToolStripMenuItem,
            this.BackgroundworkerToolStripMenuItem,
            this.TimerToolStripMenuItem});
            this.componentes2ToolStripMenuItem.Name = "componentes2ToolStripMenuItem";
            this.componentes2ToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.componentes2ToolStripMenuItem.Text = "Componentes 2";
            // 
            // TabControlToolStripMenuItem
            // 
            this.TabControlToolStripMenuItem.Name = "TabControlToolStripMenuItem";
            this.TabControlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TabControlToolStripMenuItem.Text = "TabControl";
            this.TabControlToolStripMenuItem.Click += new System.EventHandler(this.TabControlToolStripMenuItem_Click);
            // 
            // TableLayoutPanelToolStripMenuItem
            // 
            this.TableLayoutPanelToolStripMenuItem.Name = "TableLayoutPanelToolStripMenuItem";
            this.TableLayoutPanelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TableLayoutPanelToolStripMenuItem.Text = "TableLayoutPanel";
            this.TableLayoutPanelToolStripMenuItem.Click += new System.EventHandler(this.TableLayoutPanelToolStripMenuItem_Click);
            // 
            // ToolStripContainerToolStripMenuItem
            // 
            this.ToolStripContainerToolStripMenuItem.Name = "ToolStripContainerToolStripMenuItem";
            this.ToolStripContainerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ToolStripContainerToolStripMenuItem.Text = "ToolStripContainer";
            this.ToolStripContainerToolStripMenuItem.Click += new System.EventHandler(this.ToolStripContainerToolStripMenuItem_Click);
            // 
            // BackgroundworkerToolStripMenuItem
            // 
            this.BackgroundworkerToolStripMenuItem.Name = "BackgroundworkerToolStripMenuItem";
            this.BackgroundworkerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BackgroundworkerToolStripMenuItem.Text = "Backgroundworker";
            this.BackgroundworkerToolStripMenuItem.Click += new System.EventHandler(this.BackgroundworkerToolStripMenuItem_Click);
            // 
            // TimerToolStripMenuItem
            // 
            this.TimerToolStripMenuItem.Name = "TimerToolStripMenuItem";
            this.TimerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TimerToolStripMenuItem.Text = "Timer";
            this.TimerToolStripMenuItem.Click += new System.EventHandler(this.TimerToolStripMenuItem_Click);
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 450);
            this.Controls.Add(this.btn_valNum);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.tb_listaNomes);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MenuNotify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_valNum;
        public System.Windows.Forms.TextBox tb_listaNomes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ComboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DateTimerPickerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LinkLabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MaskedTextBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MonthCalendarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip MenuNotify;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Restaurar;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Mensagem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Close;
        private System.Windows.Forms.ToolStripMenuItem NumericUpDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PictureBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProgressBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RadioButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TrackBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TreeViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SplitContainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componentes2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TabControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TableLayoutPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripContainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackgroundworkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimerToolStripMenuItem;
    }
}

