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
        int count;
        static FileStream stream;
        Process proc;

        private void Form1_Load(object sender, EventArgs e)
        {
            openExcelFile();
            SD.DataTable table = tableCollection["лист"];
            dataGridView.DataSource = table;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            count = dataGridView.Rows.Count - 1;
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
        }

        public static void openFile()
        {
            string path = string.Empty;
            try
            {
                path = Environment.CurrentDirectory;
                path = path.Substring(0, path.Length - 23);
                path += "Таблица.xlsx";

                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                stream = File.Open(path, FileMode.Open, FileAccess.Read);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show($"Файл 'Таблица.xlsx' не найден. Проверьте наличие данного файла по следующему пути:\n{path}");
                Process.GetCurrentProcess().Kill();
            }
            catch (IOException)
            {
                MessageBox.Show("Закройте файл 'Таблица.xlsx'\nи запустите приложение повторно");
                Process.GetCurrentProcess().Kill();
            }
        }

        private void openExcelFile()
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
        }

        private void fillOkrug()
        {
            cb_okrug.Items.Add("");
            cb_okrug.Items.Add("Не указано");

            bool check;

            for (int i = 0; i < count; i++)
            {
                check = false;

                if (Convert.ToString(dataGridView[1, i].Value) == "")
                {
                    continue;
                }

                for (int j = 0; j < cb_okrug.Items.Count; j++)
                {
                    if (Convert.ToString(cb_okrug.Items[j]).ToLower() == Convert.ToString(dataGridView[1, i].Value).ToLower())
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
                    cb_okrug.Items.Add(dataGridView[1, i].Value);
                }
            }
        }

        private void fillClass()
        {
            cb_class.Items.Add("");
            cb_class.Items.Add("Не указано");

            bool check;

            for (int i = 0; i < count; i++)
            {
                check = false;

                if (Convert.ToString(dataGridView[4, i].Value) == "")
                {
                    continue;
                }

                int.TryParse(string.Join("", Convert.ToString(dataGridView[4, i].Value).Where(c => char.IsDigit(c))), out int klass); //Запись в klass только цифры из названия класса

                for (int j = 2; j < cb_class.Items.Count; j++)
                {
                    if (Convert.ToInt32(cb_class.Items[j]) == klass)
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
                    cb_class.Items.Add(Convert.ToString(klass));
                }
            }
        }

        private void fillOrganiz()
        {
            cb_organiz.Items.Add("");
            cb_organiz.Items.Add("Не указано");

            bool check;

            for (int i = 0; i < count; i++)
            {
                check = false;

                if (Convert.ToString(dataGridView[5, i].Value) == "")
                {
                    continue;
                }

                for (int j = 0; j < cb_organiz.Items.Count; j++)
                {
                    if (Convert.ToString(cb_organiz.Items[j]).ToLower() == Convert.ToString(dataGridView[5, i].Value).ToLower())
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
                    cb_organiz.Items.Add(dataGridView[5, i].Value);
                }
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

        private void fillStatus()
        {
            cb_status.Items.Add("");
            cb_status.Items.Add("Не указано");

            bool check;

            for (int i = 0; i < count; i++)
            {
                check = false;

                if (Convert.ToString(dataGridView[8, i].Value) == "")
                {
                    continue;
                }

                for (int j = 0; j < cb_status.Items.Count; j++)
                {
                    if (Convert.ToString(cb_status.Items[j]) == Convert.ToString(dataGridView[8, i].Value))
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
                    cb_status.Items.Add(dataGridView[8, i].Value);
                }
            }
        }

        private void fillUchenik()
        {
            cb_uchenik.Items.Add("");
            cb_uchenik.Items.Add("Не указано");
            for (int i = 0; i < count; i++)
            {
                cb_uchenik.Items.Add(dataGridView[2, i].Value);
            }
        }

        private void fillNast()
        {
            cb_nastavnik.Items.Add("");
            cb_nastavnik.Items.Add("Не указано");

            bool check;

            for (int i = 0; i < count; i++)
            {
                check = false;

                if (Convert.ToString(dataGridView[9, i].Value) == "")
                {
                    continue;
                }

                for (int j = 0; j < cb_nastavnik.Items.Count; j++)
                {
                    if (Convert.ToString(cb_nastavnik.Items[j]) == Convert.ToString(dataGridView[9, i].Value))
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
                    cb_nastavnik.Items.Add(dataGridView[9, i].Value);
                }
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            proc = Process.GetProcessesByName("EXCEL").Last();
            exApp.Workbooks.Add();
            Worksheet workSheet = (Worksheet)exApp.ActiveSheet;
            workSheet.Cells[1, 1] = "№ п/п";
            workSheet.Cells[1, 2] = "Муниципалитет";
            workSheet.Cells[1, 3] = "ФИО ученика";
            workSheet.Cells[1, 4] = "Дата рождения";
            workSheet.Cells[1, 5] = "Класс";
            workSheet.Cells[1, 6] = "ОО";
            workSheet.Cells[1, 7] = "Адрес ОО";
            workSheet.Cells[1, 8] = "Балл";
            workSheet.Cells[1, 9] = "Статус";
            workSheet.Cells[1, 10] = "ФИО наставника";
            workSheet.Cells[1, 11] = "Пол";

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
            openExcelFile();
            SD.DataTable table = tableCollection["лист"];
            dataGridView.DataSource = table;

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
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            proc.Kill();
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
    }
}