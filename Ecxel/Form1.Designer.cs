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
            this.cb_surnameUch = new System.Windows.Forms.ComboBox();
            this.lb_surnameUch = new System.Windows.Forms.Label();
            this.cb_nameUch = new System.Windows.Forms.ComboBox();
            this.lb_nameUch = new System.Windows.Forms.Label();
            this.cb_patronymicUch = new System.Windows.Forms.ComboBox();
            this.lb_patronymicUch = new System.Windows.Forms.Label();
            this.cb_birthdatee = new System.Windows.Forms.ComboBox();
            this.lb_birthdate = new System.Windows.Forms.Label();
            this.cb_organiz = new System.Windows.Forms.ComboBox();
            this.lb_organiz = new System.Windows.Forms.Label();
            this.cb_adres = new System.Windows.Forms.ComboBox();
            this.lb_adres = new System.Windows.Forms.Label();
            this.lb_ballOt = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.cb_patronymicNast = new System.Windows.Forms.ComboBox();
            this.lb_patronymicNast = new System.Windows.Forms.Label();
            this.cb_nameNast = new System.Windows.Forms.ComboBox();
            this.lb_nameNast = new System.Windows.Forms.Label();
            this.cb_surnameNast = new System.Windows.Forms.ComboBox();
            this.lb_surnameNast = new System.Windows.Forms.Label();
            this.tb_ballOt = new System.Windows.Forms.TextBox();
            this.tb_ballDo = new System.Windows.Forms.TextBox();
            this.lb_ballDo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 466);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(1389, 204);
            this.dataGridView.TabIndex = 0;
            // 
            // lb_class
            // 
            this.lb_class.AutoSize = true;
            this.lb_class.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_class.Location = new System.Drawing.Point(329, 262);
            this.lb_class.Name = "lb_class";
            this.lb_class.Size = new System.Drawing.Size(61, 22);
            this.lb_class.TabIndex = 1;
            this.lb_class.Text = "Класс";
            // 
            // cb_class
            // 
            this.cb_class.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_class.FormattingEnabled = true;
            this.cb_class.Location = new System.Drawing.Point(396, 259);
            this.cb_class.Name = "cb_class";
            this.cb_class.Size = new System.Drawing.Size(121, 30);
            this.cb_class.TabIndex = 2;
            // 
            // cb_okrug
            // 
            this.cb_okrug.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_okrug.FormattingEnabled = true;
            this.cb_okrug.Location = new System.Drawing.Point(12, 180);
            this.cb_okrug.Name = "cb_okrug";
            this.cb_okrug.Size = new System.Drawing.Size(254, 30);
            this.cb_okrug.Sorted = true;
            this.cb_okrug.TabIndex = 4;
            this.cb_okrug.SelectedIndexChanged += new System.EventHandler(this.cb_okrug_SelectedIndexChanged);
            // 
            // lb_okrug
            // 
            this.lb_okrug.AutoSize = true;
            this.lb_okrug.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_okrug.Location = new System.Drawing.Point(-1, 155);
            this.lb_okrug.Name = "lb_okrug";
            this.lb_okrug.Size = new System.Drawing.Size(140, 22);
            this.lb_okrug.TabIndex = 3;
            this.lb_okrug.Text = "Муниципалитет";
            // 
            // cb_surnameUch
            // 
            this.cb_surnameUch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_surnameUch.FormattingEnabled = true;
            this.cb_surnameUch.Location = new System.Drawing.Point(396, 76);
            this.cb_surnameUch.Name = "cb_surnameUch";
            this.cb_surnameUch.Size = new System.Drawing.Size(121, 30);
            this.cb_surnameUch.TabIndex = 6;
            // 
            // lb_surnameUch
            // 
            this.lb_surnameUch.AutoSize = true;
            this.lb_surnameUch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_surnameUch.Location = new System.Drawing.Point(286, 84);
            this.lb_surnameUch.Name = "lb_surnameUch";
            this.lb_surnameUch.Size = new System.Drawing.Size(87, 22);
            this.lb_surnameUch.TabIndex = 5;
            this.lb_surnameUch.Text = "Фамилия";
            // 
            // cb_nameUch
            // 
            this.cb_nameUch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_nameUch.FormattingEnabled = true;
            this.cb_nameUch.Location = new System.Drawing.Point(396, 122);
            this.cb_nameUch.Name = "cb_nameUch";
            this.cb_nameUch.Size = new System.Drawing.Size(121, 30);
            this.cb_nameUch.TabIndex = 8;
            // 
            // lb_nameUch
            // 
            this.lb_nameUch.AutoSize = true;
            this.lb_nameUch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_nameUch.Location = new System.Drawing.Point(286, 130);
            this.lb_nameUch.Name = "lb_nameUch";
            this.lb_nameUch.Size = new System.Drawing.Size(47, 22);
            this.lb_nameUch.TabIndex = 7;
            this.lb_nameUch.Text = "Имя";
            // 
            // cb_patronymicUch
            // 
            this.cb_patronymicUch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_patronymicUch.FormattingEnabled = true;
            this.cb_patronymicUch.Location = new System.Drawing.Point(396, 168);
            this.cb_patronymicUch.Name = "cb_patronymicUch";
            this.cb_patronymicUch.Size = new System.Drawing.Size(121, 30);
            this.cb_patronymicUch.TabIndex = 10;
            // 
            // lb_patronymicUch
            // 
            this.lb_patronymicUch.AutoSize = true;
            this.lb_patronymicUch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_patronymicUch.Location = new System.Drawing.Point(286, 176);
            this.lb_patronymicUch.Name = "lb_patronymicUch";
            this.lb_patronymicUch.Size = new System.Drawing.Size(93, 22);
            this.lb_patronymicUch.TabIndex = 9;
            this.lb_patronymicUch.Text = "Отчество";
            // 
            // cb_birthdatee
            // 
            this.cb_birthdatee.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_birthdatee.FormattingEnabled = true;
            this.cb_birthdatee.Location = new System.Drawing.Point(396, 213);
            this.cb_birthdatee.Name = "cb_birthdatee";
            this.cb_birthdatee.Size = new System.Drawing.Size(121, 30);
            this.cb_birthdatee.TabIndex = 12;
            // 
            // lb_birthdate
            // 
            this.lb_birthdate.AutoSize = true;
            this.lb_birthdate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_birthdate.Location = new System.Drawing.Point(246, 221);
            this.lb_birthdate.Name = "lb_birthdate";
            this.lb_birthdate.Size = new System.Drawing.Size(144, 22);
            this.lb_birthdate.TabIndex = 11;
            this.lb_birthdate.Text = "Дата рождения";
            // 
            // cb_organiz
            // 
            this.cb_organiz.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_organiz.FormattingEnabled = true;
            this.cb_organiz.Location = new System.Drawing.Point(396, 305);
            this.cb_organiz.Name = "cb_organiz";
            this.cb_organiz.Size = new System.Drawing.Size(121, 30);
            this.cb_organiz.TabIndex = 14;
            // 
            // lb_organiz
            // 
            this.lb_organiz.AutoSize = true;
            this.lb_organiz.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_organiz.Location = new System.Drawing.Point(256, 308);
            this.lb_organiz.Name = "lb_organiz";
            this.lb_organiz.Size = new System.Drawing.Size(123, 22);
            this.lb_organiz.TabIndex = 13;
            this.lb_organiz.Text = "Организация";
            // 
            // cb_adres
            // 
            this.cb_adres.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_adres.FormattingEnabled = true;
            this.cb_adres.Location = new System.Drawing.Point(396, 347);
            this.cb_adres.Name = "cb_adres";
            this.cb_adres.Size = new System.Drawing.Size(121, 30);
            this.cb_adres.TabIndex = 16;
            // 
            // lb_adres
            // 
            this.lb_adres.AutoSize = true;
            this.lb_adres.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_adres.Location = new System.Drawing.Point(286, 350);
            this.lb_adres.Name = "lb_adres";
            this.lb_adres.Size = new System.Drawing.Size(66, 22);
            this.lb_adres.TabIndex = 15;
            this.lb_adres.Text = "Адрес";
            // 
            // lb_ballOt
            // 
            this.lb_ballOt.AutoSize = true;
            this.lb_ballOt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ballOt.Location = new System.Drawing.Point(286, 394);
            this.lb_ballOt.Name = "lb_ballOt";
            this.lb_ballOt.Size = new System.Drawing.Size(76, 22);
            this.lb_ballOt.TabIndex = 17;
            this.lb_ballOt.Text = "Балл от";
            // 
            // cb_status
            // 
            this.cb_status.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(396, 420);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(121, 30);
            this.cb_status.TabIndex = 20;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_status.Location = new System.Drawing.Point(286, 423);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(69, 22);
            this.lb_status.TabIndex = 19;
            this.lb_status.Text = "Статус";
            // 
            // cb_patronymicNast
            // 
            this.cb_patronymicNast.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_patronymicNast.FormattingEnabled = true;
            this.cb_patronymicNast.Location = new System.Drawing.Point(657, 168);
            this.cb_patronymicNast.Name = "cb_patronymicNast";
            this.cb_patronymicNast.Size = new System.Drawing.Size(121, 30);
            this.cb_patronymicNast.TabIndex = 26;
            // 
            // lb_patronymicNast
            // 
            this.lb_patronymicNast.AutoSize = true;
            this.lb_patronymicNast.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_patronymicNast.Location = new System.Drawing.Point(556, 176);
            this.lb_patronymicNast.Name = "lb_patronymicNast";
            this.lb_patronymicNast.Size = new System.Drawing.Size(93, 22);
            this.lb_patronymicNast.TabIndex = 25;
            this.lb_patronymicNast.Text = "Отчество";
            // 
            // cb_nameNast
            // 
            this.cb_nameNast.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_nameNast.FormattingEnabled = true;
            this.cb_nameNast.Location = new System.Drawing.Point(657, 122);
            this.cb_nameNast.Name = "cb_nameNast";
            this.cb_nameNast.Size = new System.Drawing.Size(121, 30);
            this.cb_nameNast.TabIndex = 24;
            // 
            // lb_nameNast
            // 
            this.lb_nameNast.AutoSize = true;
            this.lb_nameNast.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_nameNast.Location = new System.Drawing.Point(556, 130);
            this.lb_nameNast.Name = "lb_nameNast";
            this.lb_nameNast.Size = new System.Drawing.Size(47, 22);
            this.lb_nameNast.TabIndex = 23;
            this.lb_nameNast.Text = "Имя";
            // 
            // cb_surnameNast
            // 
            this.cb_surnameNast.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_surnameNast.FormattingEnabled = true;
            this.cb_surnameNast.Location = new System.Drawing.Point(657, 76);
            this.cb_surnameNast.Name = "cb_surnameNast";
            this.cb_surnameNast.Size = new System.Drawing.Size(121, 30);
            this.cb_surnameNast.TabIndex = 22;
            // 
            // lb_surnameNast
            // 
            this.lb_surnameNast.AutoSize = true;
            this.lb_surnameNast.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_surnameNast.Location = new System.Drawing.Point(556, 84);
            this.lb_surnameNast.Name = "lb_surnameNast";
            this.lb_surnameNast.Size = new System.Drawing.Size(87, 22);
            this.lb_surnameNast.TabIndex = 21;
            this.lb_surnameNast.Text = "Фамилия";
            // 
            // tb_ballOt
            // 
            this.tb_ballOt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ballOt.Location = new System.Drawing.Point(396, 386);
            this.tb_ballOt.Name = "tb_ballOt";
            this.tb_ballOt.Size = new System.Drawing.Size(100, 29);
            this.tb_ballOt.TabIndex = 27;
            // 
            // tb_ballDo
            // 
            this.tb_ballDo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ballDo.Location = new System.Drawing.Point(568, 386);
            this.tb_ballDo.Name = "tb_ballDo";
            this.tb_ballDo.Size = new System.Drawing.Size(100, 29);
            this.tb_ballDo.TabIndex = 28;
            // 
            // lb_ballDo
            // 
            this.lb_ballDo.AutoSize = true;
            this.lb_ballDo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ballDo.Location = new System.Drawing.Point(502, 389);
            this.lb_ballDo.Name = "lb_ballDo";
            this.lb_ballDo.Size = new System.Drawing.Size(32, 22);
            this.lb_ballDo.TabIndex = 29;
            this.lb_ballDo.Text = "до";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(895, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Через чекбоксы сделать выбор полей для показа";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1428, 726);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_ballDo);
            this.Controls.Add(this.tb_ballDo);
            this.Controls.Add(this.tb_ballOt);
            this.Controls.Add(this.cb_patronymicNast);
            this.Controls.Add(this.lb_patronymicNast);
            this.Controls.Add(this.cb_nameNast);
            this.Controls.Add(this.lb_nameNast);
            this.Controls.Add(this.cb_surnameNast);
            this.Controls.Add(this.lb_surnameNast);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.lb_ballOt);
            this.Controls.Add(this.cb_adres);
            this.Controls.Add(this.lb_adres);
            this.Controls.Add(this.cb_organiz);
            this.Controls.Add(this.lb_organiz);
            this.Controls.Add(this.cb_birthdatee);
            this.Controls.Add(this.lb_birthdate);
            this.Controls.Add(this.cb_patronymicUch);
            this.Controls.Add(this.lb_patronymicUch);
            this.Controls.Add(this.cb_nameUch);
            this.Controls.Add(this.lb_nameUch);
            this.Controls.Add(this.cb_surnameUch);
            this.Controls.Add(this.lb_surnameUch);
            this.Controls.Add(this.cb_okrug);
            this.Controls.Add(this.lb_okrug);
            this.Controls.Add(this.cb_class);
            this.Controls.Add(this.lb_class);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
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
        private System.Windows.Forms.ComboBox cb_surnameUch;
        private System.Windows.Forms.Label lb_surnameUch;
        private System.Windows.Forms.ComboBox cb_nameUch;
        private System.Windows.Forms.Label lb_nameUch;
        private System.Windows.Forms.ComboBox cb_patronymicUch;
        private System.Windows.Forms.Label lb_patronymicUch;
        private System.Windows.Forms.ComboBox cb_birthdatee;
        private System.Windows.Forms.Label lb_birthdate;
        private System.Windows.Forms.ComboBox cb_organiz;
        private System.Windows.Forms.Label lb_organiz;
        private System.Windows.Forms.ComboBox cb_adres;
        private System.Windows.Forms.Label lb_adres;
        private System.Windows.Forms.Label lb_ballOt;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.ComboBox cb_patronymicNast;
        private System.Windows.Forms.Label lb_patronymicNast;
        private System.Windows.Forms.ComboBox cb_nameNast;
        private System.Windows.Forms.Label lb_nameNast;
        private System.Windows.Forms.ComboBox cb_surnameNast;
        private System.Windows.Forms.Label lb_surnameNast;
        private System.Windows.Forms.TextBox tb_ballOt;
        private System.Windows.Forms.TextBox tb_ballDo;
        private System.Windows.Forms.Label lb_ballDo;
        private System.Windows.Forms.Label label1;
    }
}

