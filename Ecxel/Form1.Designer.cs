﻿
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
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.cb_pol = new System.Windows.Forms.ComboBox();
            this.lb_pol = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(20, 238);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(1506, 539);
            this.dataGridView.TabIndex = 0;
            // 
            // lb_class
            // 
            this.lb_class.AutoSize = true;
            this.lb_class.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_class.Location = new System.Drawing.Point(693, 135);
            this.lb_class.Name = "lb_class";
            this.lb_class.Size = new System.Drawing.Size(77, 27);
            this.lb_class.TabIndex = 1;
            this.lb_class.Text = "Класс";
            // 
            // cb_class
            // 
            this.cb_class.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_class.FormattingEnabled = true;
            this.cb_class.Location = new System.Drawing.Point(776, 131);
            this.cb_class.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_class.Name = "cb_class";
            this.cb_class.Size = new System.Drawing.Size(138, 35);
            this.cb_class.Sorted = true;
            this.cb_class.TabIndex = 2;
            // 
            // cb_okrug
            // 
            this.cb_okrug.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_okrug.FormattingEnabled = true;
            this.cb_okrug.Location = new System.Drawing.Point(209, 185);
            this.cb_okrug.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_okrug.Name = "cb_okrug";
            this.cb_okrug.Size = new System.Drawing.Size(473, 35);
            this.cb_okrug.Sorted = true;
            this.cb_okrug.TabIndex = 4;
            // 
            // lb_okrug
            // 
            this.lb_okrug.AutoSize = true;
            this.lb_okrug.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_okrug.Location = new System.Drawing.Point(20, 193);
            this.lb_okrug.Name = "lb_okrug";
            this.lb_okrug.Size = new System.Drawing.Size(183, 27);
            this.lb_okrug.TabIndex = 3;
            this.lb_okrug.Text = "Муниципалитет";
            // 
            // cb_uchenik
            // 
            this.cb_uchenik.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_uchenik.FormattingEnabled = true;
            this.cb_uchenik.Location = new System.Drawing.Point(209, 77);
            this.cb_uchenik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_uchenik.Name = "cb_uchenik";
            this.cb_uchenik.Size = new System.Drawing.Size(473, 35);
            this.cb_uchenik.Sorted = true;
            this.cb_uchenik.TabIndex = 6;
            // 
            // lb_uchenik
            // 
            this.lb_uchenik.AutoSize = true;
            this.lb_uchenik.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_uchenik.Location = new System.Drawing.Point(20, 85);
            this.lb_uchenik.Name = "lb_uchenik";
            this.lb_uchenik.Size = new System.Drawing.Size(90, 27);
            this.lb_uchenik.TabIndex = 5;
            this.lb_uchenik.Text = "Ученик";
            // 
            // cb_organiz
            // 
            this.cb_organiz.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_organiz.FormattingEnabled = true;
            this.cb_organiz.Location = new System.Drawing.Point(880, 77);
            this.cb_organiz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_organiz.Name = "cb_organiz";
            this.cb_organiz.Size = new System.Drawing.Size(564, 35);
            this.cb_organiz.Sorted = true;
            this.cb_organiz.TabIndex = 14;
            // 
            // lb_organiz
            // 
            this.lb_organiz.AutoSize = true;
            this.lb_organiz.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_organiz.Location = new System.Drawing.Point(693, 85);
            this.lb_organiz.Name = "lb_organiz";
            this.lb_organiz.Size = new System.Drawing.Size(156, 27);
            this.lb_organiz.TabIndex = 13;
            this.lb_organiz.Text = "Организация";
            // 
            // cb_status
            // 
            this.cb_status.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(1026, 132);
            this.cb_status.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(175, 35);
            this.cb_status.Sorted = true;
            this.cb_status.TabIndex = 20;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_status.Location = new System.Drawing.Point(933, 135);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(87, 27);
            this.lb_status.TabIndex = 19;
            this.lb_status.Text = "Статус";
            // 
            // cb_nastavnik
            // 
            this.cb_nastavnik.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_nastavnik.FormattingEnabled = true;
            this.cb_nastavnik.Location = new System.Drawing.Point(209, 131);
            this.cb_nastavnik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_nastavnik.Name = "cb_nastavnik";
            this.cb_nastavnik.Size = new System.Drawing.Size(473, 35);
            this.cb_nastavnik.Sorted = true;
            this.cb_nastavnik.TabIndex = 22;
            // 
            // lb_nastavnik
            // 
            this.lb_nastavnik.AutoSize = true;
            this.lb_nastavnik.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_nastavnik.Location = new System.Drawing.Point(20, 139);
            this.lb_nastavnik.Name = "lb_nastavnik";
            this.lb_nastavnik.Size = new System.Drawing.Size(128, 27);
            this.lb_nastavnik.TabIndex = 21;
            this.lb_nastavnik.Text = "Наставник";
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_open.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_open.Location = new System.Drawing.Point(14, 11);
            this.btn_open.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(216, 47);
            this.btn_open.TabIndex = 32;
            this.btn_open.Text = "Открыть в Excel";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_find.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_find.Location = new System.Drawing.Point(1247, 183);
            this.btn_find.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(197, 47);
            this.btn_find.TabIndex = 33;
            this.btn_find.Text = "Поиск";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // cb_pol
            // 
            this.cb_pol.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_pol.FormattingEnabled = true;
            this.cb_pol.Location = new System.Drawing.Point(1306, 132);
            this.cb_pol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_pol.Name = "cb_pol";
            this.cb_pol.Size = new System.Drawing.Size(138, 35);
            this.cb_pol.Sorted = true;
            this.cb_pol.TabIndex = 35;
            // 
            // lb_pol
            // 
            this.lb_pol.AutoSize = true;
            this.lb_pol.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_pol.Location = new System.Drawing.Point(1227, 134);
            this.lb_pol.Name = "lb_pol";
            this.lb_pol.Size = new System.Drawing.Size(55, 27);
            this.lb_pol.TabIndex = 34;
            this.lb_pol.Text = "Пол";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1547, 840);
            this.Controls.Add(this.cb_pol);
            this.Controls.Add(this.lb_pol);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.btn_open);
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.ComboBox cb_pol;
        private System.Windows.Forms.Label lb_pol;
    }
}

