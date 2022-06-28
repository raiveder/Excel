using System;
using System.Data;
using SD = System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ExcelDataReader;
using System.Linq;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace Ecxel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string fileName = string.Empty;
        private DataTableCollection tableCollection = null;
        private int count;
        private static FileStream stream;
        private string path;
        private bool valid;
        private Process[] proc = new Process[0];

        /// <summary>
        /// Графическое оформление dataGridView
        /// </summary>
        private void design()
        {
            int max;
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                max = dataGridView.Columns[i].HeaderText.Length;
                for (int j = 0; j < dataGridView.Rows.Count; j++)
                {
                    if (dataGridView[i, j].Value.ToString().Length > max)
                    {
                        max = dataGridView[i, j].Value.ToString().Length;
                    }
                }
                if (max < 6)
                {
                    dataGridView.Columns[i].Width = max * 12;
                }
                else
                {
                    dataGridView.Columns[i].Width = max * 8;
                }
            }

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (Convert.ToString(dataGridView[3, i].Value) != "")
                {
                    dataGridView[3, i].Value = Convert.ToString(dataGridView[3, i].Value).Substring(0, 10);
                }
            }

            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        /// <summary>
        /// Открытие Excel файла и заполнение значений DataGridView
        /// </summary>
        private void fillData()
        {
            IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);
            DataSet db = reader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (x) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });

            tableCollection = db.Tables;
            SD.DataTable table = tableCollection[0];
            if (table.Columns.Count != 11 || table.Columns[10].ColumnName != "Пол")
            {
                valid = false;
                return;
            }
            else
            {
                valid = true;
                dataGridView.DataSource = table;
            }
        }

        /// <summary>
        /// Заполнение муниципалитета
        /// </summary>
        private void fillOkrug()
        {
            string[] array = new string[2];
            array[0] = "";
            array[1] = "Не указано";
            bool check;

            for (int i = 0; i < count; i++)
            {
                check = false;

                if (Convert.ToString(dataGridView[1, i].Value) == "")
                {
                    continue;
                }

                for (int j = 0; j < array.Length; j++)
                {
                    if (Convert.ToString(array[j]).ToLower() == Convert.ToString(dataGridView[1, i].Value).ToLower())
                    {
                        check = true;
                        break;
                    }
                }
                if (check)
                {
                    continue;
                }
                else
                {
                    Array.Resize(ref array, array.Length + 1);
                    array[array.Length - 1] = Convert.ToString(dataGridView[1, i].Value);
                }
            }

            Array.Sort(array, 2, array.Length - 2);
            foreach (string item in array)
            {
                cb_okrug.Items.Add(item);
            }
        }

        /// <summary>
        /// Заполнение класса
        /// </summary>
        private void fillClass()
        {
            string[] array = new string[2];
            array[0] = "";
            array[1] = "Не указано";
            bool check;

            for (int i = 0; i < count; i++)
            {
                check = false;

                if (Convert.ToString(dataGridView[4, i].Value) == "")
                {
                    continue;
                }

                int.TryParse(string.Join("", Convert.ToString(dataGridView[4, i].Value).Where(c => char.IsDigit(c))), out int klass); //Запись в klass только цифры из названия класса

                for (int j = 2; j < array.Length; j++)
                {
                    if (Convert.ToInt32(array[j]) == klass)
                    {
                        check = true;
                        break;
                    }
                }

                if (check)
                {
                    continue;
                }
                else
                {
                    Array.Resize(ref array, array.Length + 1);
                    array[array.Length - 1] = Convert.ToString(dataGridView[4, i].Value);
                }
            }

            Array.Sort(array, 2, array.Length - 2);
            foreach (string item in array)
            {
                cb_class.Items.Add(item);
            }
        }

        /// <summary>
        /// Заполнение организации
        /// </summary>
        private void fillOrganiz()
        {
            string[] array = new string[2];
            array[0] = "";
            array[1] = "Не указано";

            bool check;

            for (int i = 0; i < count; i++)
            {
                check = false;

                if (Convert.ToString(dataGridView[5, i].Value) == "")
                {
                    continue;
                }

                for (int j = 0; j < array.Length; j++)
                {
                    if (Convert.ToString(array[j]).ToLower() == Convert.ToString(dataGridView[5, i].Value).ToLower())
                    {
                        check = true;
                        break;
                    }
                }

                if (check)
                {
                    continue;
                }
                else
                {
                    Array.Resize(ref array, array.Length + 1);
                    array[array.Length - 1] = Convert.ToString(dataGridView[5, i].Value);
                }
            }

            Array.Sort(array, 2, array.Length - 2);
            foreach (string item in array)
            {
                cb_organiz.Items.Add(item);
            }

            int width = cb_organiz.Items[0].ToString().Length;
            foreach (var item in cb_organiz.Items)
            {
                if (item.ToString().Length > width)
                {
                    width = item.ToString().Length;
                }
            }
            cb_organiz.Size = new System.Drawing.Size(Convert.ToInt32(width * 10.5), 30);
        }

        /// <summary>
        /// Заполнение статуса
        /// </summary>
        private void fillStatus()
        {
            string[] array = new string[2];
            array[0] = "";
            array[1] = "Не указано";

            bool check;

            for (int i = 0; i < count; i++)
            {
                check = false;

                if (Convert.ToString(dataGridView[8, i].Value) == "")
                {
                    continue;
                }

                for (int j = 0; j < array.Length; j++)
                {
                    if (Convert.ToString(array[j]) == Convert.ToString(dataGridView[8, i].Value))
                    {
                        check = true;
                        break;
                    }
                }

                if (check)
                {
                    continue;
                }
                else
                {
                    Array.Resize(ref array, array.Length + 1);
                    array[array.Length - 1] = Convert.ToString(dataGridView[8, i].Value);
                }
            }

            Array.Sort(array, 2, array.Length - 2);
            foreach (string item in array)
            {
                cb_status.Items.Add(item);
            }
        }

        /// <summary>
        /// Заполнение учеников
        /// </summary>
        private void fillUchenik()
        {
            string[] array = new string[2];
            array[0] = "";
            array[1] = "Не указано";

            for (int i = 0; i < count; i++)
            {
                if (Convert.ToString(dataGridView[2, i].Value) == "")
                {
                    continue;
                }

                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = Convert.ToString(dataGridView[2, i].Value);
            }

            Array.Sort(array, 2, array.Length - 2);
            foreach (string item in array)
            {
                cb_uchenik.Items.Add(item);
            }
        }

        /// <summary>
        /// Заполнение наставников
        /// </summary>
        private void fillNast()
        {
            string[] array = new string[2];
            array[0] = "";
            array[1] = "Не указано";

            bool check;

            for (int i = 0; i < count; i++)
            {
                check = false;

                if (Convert.ToString(dataGridView[9, i].Value) == "")
                {
                    continue;
                }

                for (int j = 0; j < array.Length; j++)
                {
                    if (Convert.ToString(array[j]) == Convert.ToString(dataGridView[9, i].Value))
                    {
                        check = true;
                        break;
                    }
                }

                if (check)
                {
                    continue;
                }
                else
                {
                    Array.Resize(ref array, array.Length + 1);
                    array[array.Length - 1] = Convert.ToString(dataGridView[9, i].Value);
                }
            }

            Array.Sort(array, 2, array.Length - 2);
            foreach (string item in array)
            {
                cb_nastavnik.Items.Add(item);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            Array.Resize(ref proc, proc.Length + 1);
            proc[proc.Length - 1] = Process.GetProcessesByName("EXCEL").Last();
            exApp.Workbooks.Add();
            Worksheet workSheet = (Worksheet)exApp.ActiveSheet;
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                workSheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
            }

            int rowExcel = 2;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                workSheet.Cells[rowExcel, "A"] = dataGridView.Rows[i].Cells[0].Value;
                workSheet.Cells[rowExcel, "B"] = dataGridView.Rows[i].Cells[1].Value;
                workSheet.Cells[rowExcel, "C"] = dataGridView.Rows[i].Cells[2].Value;
                workSheet.Cells[rowExcel, "D"] = dataGridView.Rows[i].Cells[3].Value;
                workSheet.Cells[rowExcel, "E"] = dataGridView.Rows[i].Cells[4].Value;
                workSheet.Cells[rowExcel, "F"] = dataGridView.Rows[i].Cells[5].Value;
                workSheet.Cells[rowExcel, "G"] = dataGridView.Rows[i].Cells[6].Value;
                workSheet.Cells[rowExcel, "H"] = dataGridView.Rows[i].Cells[7].Value;
                workSheet.Cells[rowExcel, "I"] = dataGridView.Rows[i].Cells[8].Value;
                workSheet.Cells[rowExcel, "J"] = dataGridView.Rows[i].Cells[9].Value;
                workSheet.Cells[rowExcel, "K"] = dataGridView.Rows[i].Cells[10].Value;
                rowExcel++;
            }
            exApp.Visible = true;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            fillData();

            bool okrug;
            bool klass;
            bool organiz;
            bool status;
            bool uchenik;
            bool nastavnik;
            bool pol;

            for (int i = dataGridView.Rows.Count - 1; i >= 0; i--)
            {
                okrug = false;
                klass = false;
                organiz = false;
                status = false;
                uchenik = false;
                nastavnik = false;
                pol = false;

                if (cb_okrug.Text == "Не указано")
                {
                    if (Convert.ToString(dataGridView[1, i].Value) != "")
                    {
                        okrug = true;
                    }
                }
                else if (cb_okrug.Text == "")
                {

                }
                else if (Convert.ToString(dataGridView[1, i].Value) != cb_okrug.Text)
                {
                    okrug = true;
                }

                if (cb_class.Text == "Не указано")
                {
                    if (Convert.ToString(dataGridView[4, i].Value) != "")
                    {
                        klass = true;
                    }
                }
                else if (cb_class.Text == "")
                {

                }
                else if (Convert.ToString(dataGridView[4, i].Value) != cb_class.Text)
                {
                    klass = true;
                }

                if (cb_organiz.Text == "Не указано")
                {
                    if (Convert.ToString(dataGridView[5, i].Value) != "")
                    {
                        organiz = true;
                    }
                }
                else if (cb_organiz.Text == "")
                {

                }
                else if (Convert.ToString(dataGridView[5, i].Value) != cb_organiz.Text)
                {
                    organiz = true;
                }

                if (cb_status.Text == "Не указано")
                {
                    if (Convert.ToString(dataGridView[8, i].Value) != "")
                    {
                        status = true;
                    }
                }
                else if (cb_status.Text == "")
                {

                }
                else if (Convert.ToString(dataGridView[8, i].Value) != cb_status.Text)
                {
                    status = true;
                }

                if (cb_uchenik.Text == "Не указано")
                {
                    if (Convert.ToString(dataGridView[2, i].Value) != "")
                    {
                        uchenik = true;
                    }
                }
                else if (cb_uchenik.Text == "")
                {

                }
                else if (Convert.ToString(dataGridView[2, i].Value) != cb_uchenik.Text)
                {
                    uchenik = true;
                }

                if (cb_nastavnik.Text == "Не указано")
                {
                    if (Convert.ToString(dataGridView[9, i].Value) != "")
                    {
                        nastavnik = true;
                    }
                }
                else if (cb_nastavnik.Text == "")
                {

                }
                else if (Convert.ToString(dataGridView[9, i].Value) != cb_nastavnik.Text)
                {
                    nastavnik = true;
                }

                if (cb_pol.Text == "Не указано")
                {
                    if (Convert.ToString(dataGridView[10, i].Value) != "")
                    {
                        pol = true;
                    }
                }
                else if (cb_pol.Text == "")
                {

                }
                else if (cb_pol.Text == "Мужской")
                {
                    if (Convert.ToString(dataGridView[10, i].Value) != "м")
                    {
                        pol = true;
                    }
                }
                else if (cb_pol.Text == "Женский")
                {
                    if (Convert.ToString(dataGridView[10, i].Value) != "ж")
                    {
                        pol = true;
                    }
                }

                if (okrug || klass || organiz || status || uchenik || nastavnik || pol)
                {
                    dataGridView.Rows.RemoveAt(i);
                }
            }

            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Подходящих данному условию строк не найдено", "Фильтр", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillData();
            }
            lb_count.Text = "Количество строк: " + dataGridView.Rows.Count;
            design();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Process item in proc)
            {
                if (item != null)
                {
                    item.Kill();
                }
            }
        }

        private void cb_uchenik_Click(object sender, EventArgs e)
        {
            cb_uchenik.DroppedDown = true;
        }

        private void cb_nastavnik_Click(object sender, EventArgs e)
        {
            cb_nastavnik.DroppedDown = true;
        }

        private void cb_okrug_Click(object sender, EventArgs e)
        {
            cb_okrug.DroppedDown = true;
        }

        private void cb_organiz_Click(object sender, EventArgs e)
        {
            cb_organiz.DroppedDown = true;
        }

        private void cb_class_Click(object sender, EventArgs e)
        {
            cb_class.DroppedDown = true;
        }

        private void cb_status_Click(object sender, EventArgs e)
        {
            cb_status.DroppedDown = true;
        }

        private void cb_pol_Click(object sender, EventArgs e)
        {
            cb_pol.DroppedDown = true;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cb_class.Text = "";
            cb_nastavnik.Text = "";
            cb_okrug.Text = "";
            cb_organiz.Text = "";
            cb_pol.Text = "";
            cb_status.Text = "";
            cb_uchenik.Text = "";
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            path = string.Empty;

            if (stream != null)
            {
                stream.Close();
            }

            try
            {
                DialogResult res = openFileDialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                    Text = path;
                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                    stream = File.Open(path, FileMode.Open, FileAccess.Read);
                    fillData();
                    if (!valid)
                    {
                        MessageBox.Show("Данная таблица не подходит для приложения. Выберите другую таблицу", "Выбор файла данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    count = dataGridView.Rows.Count - 1;

                    design();

                    cb_okrug.Items.Clear();
                    cb_class.Items.Clear();
                    cb_organiz.Items.Clear();
                    cb_status.Items.Clear();
                    cb_uchenik.Items.Clear();
                    cb_nastavnik.Items.Clear();
                    cb_pol.Items.Clear();

                    fillOkrug();
                    fillClass();
                    fillOrganiz();
                    fillStatus();
                    fillUchenik();
                    fillNast();
                    cb_pol.Items.Add("");
                    cb_pol.Items.Add("Не указано");
                    cb_pol.Items.Add("Мужской");
                    cb_pol.Items.Add("Женский");

                    lb_count.Visible = true;
                    lb_count.Text = "Количество строк: " + dataGridView.Rows.Count;
                }
                else
                {
                    MessageBox.Show("Файл не выбран", "Выбор файла данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Выбранный файл уже открыт. Закройте файл и повторите попытку", "Выбор файла данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}