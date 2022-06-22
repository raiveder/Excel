
namespace Ecxel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lb_class = new System.Windows.Forms.Label();
            this.cb_class = new System.Windows.Forms.ComboBox();
            this.cb_okrug = new System.Windows.Forms.ComboBox();
            this.lb_okrug = new System.Windows.Forms.Label();
            this.cb_uchenik = new System.Windows.Forms.ComboBox();
            this.lb_uchenik = new System.Windows.Forms.Label();
            this.cb_organiz = new System.Windows.Forms.ComboBox();
            this.lb_organiz = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.cb_nastavnik = new System.Windows.Forms.ComboBox();
            this.lb_nastavnik = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.cb_pol = new System.Windows.Forms.ComboBox();
            this.lb_pol = new System.Windows.Forms.Label();
            this.lb_count = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_open = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(21, 281);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(1359, 435);
            this.dataGridView.TabIndex = 0;
            // 
            // lb_class
            // 
            this.lb_class.AutoSize = true;
            this.lb_class.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_class.Location = new System.Drawing.Point(854, 21);
            this.lb_class.Name = "lb_class";
            this.lb_class.Size = new System.Drawing.Size(77, 27);
            this.lb_class.TabIndex = 1;
            this.lb_class.Text = "Класс";
            // 
            // cb_class
            // 
            this.cb_class.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_class.DropDownHeight = 400;
            this.cb_class.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_class.FormattingEnabled = true;
            this.cb_class.IntegralHeight = false;
            this.cb_class.Location = new System.Drawing.Point(947, 17);
            this.cb_class.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_class.Name = "cb_class";
            this.cb_class.Size = new System.Drawing.Size(138, 35);
            this.cb_class.TabIndex = 2;
            this.cb_class.Click += new System.EventHandler(this.cb_class_Click);
            // 
            // cb_okrug
            // 
            this.cb_okrug.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_okrug.DropDownHeight = 400;
            this.cb_okrug.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_okrug.FormattingEnabled = true;
            this.cb_okrug.IntegralHeight = false;
            this.cb_okrug.Location = new System.Drawing.Point(222, 121);
            this.cb_okrug.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_okrug.Name = "cb_okrug";
            this.cb_okrug.Size = new System.Drawing.Size(473, 35);
            this.cb_okrug.TabIndex = 4;
            this.cb_okrug.Click += new System.EventHandler(this.cb_okrug_Click);
            // 
            // lb_okrug
            // 
            this.lb_okrug.AutoSize = true;
            this.lb_okrug.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_okrug.Location = new System.Drawing.Point(35, 125);
            this.lb_okrug.Name = "lb_okrug";
            this.lb_okrug.Size = new System.Drawing.Size(183, 27);
            this.lb_okrug.TabIndex = 3;
            this.lb_okrug.Text = "Муниципалитет";
            // 
            // cb_uchenik
            // 
            this.cb_uchenik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_uchenik.DropDownHeight = 400;
            this.cb_uchenik.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_uchenik.FormattingEnabled = true;
            this.cb_uchenik.IntegralHeight = false;
            this.cb_uchenik.Location = new System.Drawing.Point(222, 13);
            this.cb_uchenik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_uchenik.Name = "cb_uchenik";
            this.cb_uchenik.Size = new System.Drawing.Size(473, 35);
            this.cb_uchenik.TabIndex = 6;
            this.cb_uchenik.Click += new System.EventHandler(this.cb_uchenik_Click);
            // 
            // lb_uchenik
            // 
            this.lb_uchenik.AutoSize = true;
            this.lb_uchenik.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_uchenik.Location = new System.Drawing.Point(34, 21);
            this.lb_uchenik.Name = "lb_uchenik";
            this.lb_uchenik.Size = new System.Drawing.Size(90, 27);
            this.lb_uchenik.TabIndex = 5;
            this.lb_uchenik.Text = "Ученик";
            // 
            // cb_organiz
            // 
            this.cb_organiz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_organiz.DropDownHeight = 400;
            this.cb_organiz.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_organiz.FormattingEnabled = true;
            this.cb_organiz.IntegralHeight = false;
            this.cb_organiz.Location = new System.Drawing.Point(222, 176);
            this.cb_organiz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_organiz.MaximumSize = new System.Drawing.Size(746, 0);
            this.cb_organiz.Name = "cb_organiz";
            this.cb_organiz.Size = new System.Drawing.Size(564, 35);
            this.cb_organiz.TabIndex = 14;
            this.cb_organiz.Click += new System.EventHandler(this.cb_organiz_Click);
            // 
            // lb_organiz
            // 
            this.lb_organiz.AutoSize = true;
            this.lb_organiz.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_organiz.Location = new System.Drawing.Point(34, 180);
            this.lb_organiz.Name = "lb_organiz";
            this.lb_organiz.Size = new System.Drawing.Size(156, 27);
            this.lb_organiz.TabIndex = 13;
            this.lb_organiz.Text = "Организация";
            // 
            // cb_status
            // 
            this.cb_status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_status.DropDownHeight = 400;
            this.cb_status.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_status.FormattingEnabled = true;
            this.cb_status.IntegralHeight = false;
            this.cb_status.Location = new System.Drawing.Point(947, 67);
            this.cb_status.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(175, 35);
            this.cb_status.TabIndex = 20;
            this.cb_status.Click += new System.EventHandler(this.cb_status_Click);
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_status.Location = new System.Drawing.Point(854, 71);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(87, 27);
            this.lb_status.TabIndex = 19;
            this.lb_status.Text = "Статус";
            // 
            // cb_nastavnik
            // 
            this.cb_nastavnik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_nastavnik.DropDownHeight = 400;
            this.cb_nastavnik.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_nastavnik.FormattingEnabled = true;
            this.cb_nastavnik.IntegralHeight = false;
            this.cb_nastavnik.Location = new System.Drawing.Point(222, 67);
            this.cb_nastavnik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_nastavnik.Name = "cb_nastavnik";
            this.cb_nastavnik.Size = new System.Drawing.Size(473, 35);
            this.cb_nastavnik.TabIndex = 22;
            this.cb_nastavnik.Click += new System.EventHandler(this.cb_nastavnik_Click);
            // 
            // lb_nastavnik
            // 
            this.lb_nastavnik.AutoSize = true;
            this.lb_nastavnik.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_nastavnik.Location = new System.Drawing.Point(34, 75);
            this.lb_nastavnik.Name = "lb_nastavnik";
            this.lb_nastavnik.Size = new System.Drawing.Size(128, 27);
            this.lb_nastavnik.TabIndex = 21;
            this.lb_nastavnik.Text = "Наставник";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_save.Location = new System.Drawing.Point(1173, 211);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(207, 47);
            this.btn_save.TabIndex = 32;
            this.btn_save.Text = "Открыть в Excel";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_find.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_find.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_find.Location = new System.Drawing.Point(1173, 81);
            this.btn_find.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(207, 47);
            this.btn_find.TabIndex = 33;
            this.btn_find.Text = "Поиск";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // cb_pol
            // 
            this.cb_pol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_pol.DropDownHeight = 400;
            this.cb_pol.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_pol.FormattingEnabled = true;
            this.cb_pol.IntegralHeight = false;
            this.cb_pol.Location = new System.Drawing.Point(947, 121);
            this.cb_pol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_pol.Name = "cb_pol";
            this.cb_pol.Size = new System.Drawing.Size(138, 35);
            this.cb_pol.TabIndex = 35;
            this.cb_pol.Click += new System.EventHandler(this.cb_pol_Click);
            // 
            // lb_pol
            // 
            this.lb_pol.AutoSize = true;
            this.lb_pol.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_pol.Location = new System.Drawing.Point(854, 125);
            this.lb_pol.Name = "lb_pol";
            this.lb_pol.Size = new System.Drawing.Size(55, 27);
            this.lb_pol.TabIndex = 34;
            this.lb_pol.Text = "Пол";
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_count.Location = new System.Drawing.Point(854, 221);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(208, 27);
            this.lb_count.TabIndex = 36;
            this.lb_count.Text = "Количество строк";
            this.lb_count.Visible = false;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.Location = new System.Drawing.Point(1173, 146);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(207, 47);
            this.btn_clear.TabIndex = 37;
            this.btn_clear.Text = "Очистить";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Excel|*.xlsx";
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_open.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_open.Location = new System.Drawing.Point(1173, 17);
            this.btn_open.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(207, 47);
            this.btn_open.TabIndex = 38;
            this.btn_open.Text = "Открыть файл";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1402, 733);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lb_count);
            this.Controls.Add(this.cb_pol);
            this.Controls.Add(this.lb_pol);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cb_nastavnik);
            this.Controls.Add(this.lb_nastavnik);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.cb_organiz);
            this.Controls.Add(this.lb_organiz);
            this.Controls.Add(this.cb_uchenik);
            this.Controls.Add(this.lb_uchenik);
            this.Controls.Add(this.cb_okrug);
            this.Controls.Add(this.lb_okrug);
            this.Controls.Add(this.cb_class);
            this.Controls.Add(this.lb_class);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1420, 780);
            this.MinimumSize = new System.Drawing.Size(1420, 780);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЦОД";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lb_class;
        private System.Windows.Forms.ComboBox cb_class;
        private System.Windows.Forms.ComboBox cb_okrug;
        private System.Windows.Forms.Label lb_okrug;
        private System.Windows.Forms.ComboBox cb_uchenik;
        private System.Windows.Forms.Label lb_uchenik;
        private System.Windows.Forms.ComboBox cb_organiz;
        private System.Windows.Forms.Label lb_organiz;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.ComboBox cb_nastavnik;
        private System.Windows.Forms.Label lb_nastavnik;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.ComboBox cb_pol;
        private System.Windows.Forms.Label lb_pol;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btn_open;
    }
}

