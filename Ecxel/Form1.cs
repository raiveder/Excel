using System;
using System.Data;
using SD = System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ExcelDataReader;
using System.Text.RegularExpressions;
using System.Linq;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            //try
            //{
            fileName = Environment.CurrentDirectory;
            fileName = fileName.Substring(0, fileName.Length - 23);
            fileName += "Таблица.xlsx";
            openExcelFile(fileName);

            SD.DataTable table = tableCollection["лист"];
            dataGridView.DataSource = table;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            //dataGridView.Columns.RemoveAt(1);

            count = dataGridView.Rows.Count - 1;
            fillOkrug();
            fillClass();
            fillOrganiz();
            fillAdres();
            fillStatus();
            fillPeople();
            // }
            //catch
            //{
            //MessageBox.Show();
            // }
        }

        private void openExcelFile(string path)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read);
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
            for (int i = 0; i < count; i++)
            {
                int index = -1;

                for (int j = 0; j < cb_okrug.Items.Count; j++)
                {
                    if (Convert.ToString(cb_okrug.Items[j]).ToLower() == Convert.ToString(dataGridView[1, i].Value).ToLower())
                    {
                        index = 0;
                        break;
                    }
                }

                if (index != -1)
                {
                    continue;
                }
                else
                {
                    bool bor = true;
                    index = Convert.ToString(dataGridView[1, i].Value).ToLower().IndexOf("бор");
                    for (int j = 0; j < cb_okrug.Items.Count; j++)
                    {
                        if (index != -1)
                        {
                            if (Regex.IsMatch(Convert.ToString(cb_okrug.Items[j]).ToLower(), @"бор"))
                            {
                                bor = false;
                            }
                        }
                    }

                    bool arz = true;
                    index = -1;
                    index = Convert.ToString(dataGridView[1, i].Value).ToLower().IndexOf("арзамас");
                    for (int j = 0; j < cb_okrug.Items.Count; j++)
                    {
                        if (index != -1)
                        {
                            if (Regex.IsMatch(Convert.ToString(cb_okrug.Items[j]).ToLower(), @"арзамас"))
                            {
                                arz = false;
                            }
                        }
                    }

                    bool len = true;
                    index = -1;
                    index = Convert.ToString(dataGridView[1, i].Value).ToLower().IndexOf("ленинский");
                    for (int j = 0; j < cb_okrug.Items.Count; j++)
                    {
                        if (index != -1)
                        {
                            if (Regex.IsMatch(Convert.ToString(cb_okrug.Items[j]).ToLower(), @"ленинский"))
                            {
                                len = false;
                            }
                        }
                    }

                    bool kan = true;
                    index = -1;
                    index = Convert.ToString(dataGridView[1, i].Value).ToLower().IndexOf("канавинский");
                    for (int j = 0; j < cb_okrug.Items.Count; j++)
                    {
                        if (index != -1)
                        {
                            if (Regex.IsMatch(Convert.ToString(cb_okrug.Items[j]).ToLower(), @"канавинский"))
                            {
                                kan = false;
                            }
                        }
                    }

                    if (bor && arz && len && kan)
                    {
                        if (Regex.IsMatch(Convert.ToString(dataGridView[1, i].Value).ToLower(), @"канавинский"))
                        {
                            cb_okrug.Items.Add("Канавинский");
                        }
                        else
                        {
                            cb_okrug.Items.Add(dataGridView[1, i].Value);
                        }
                    }
                }
            }
        }

        private void fillClass()
        {
            cb_class.Items.Add("");
            for (int i = 0; i < count; i++)
            {
                bool check = false;
                int.TryParse(string.Join("", Convert.ToString(dataGridView[4, i].Value).Where(c => char.IsDigit(c))), out int klass); //Запись в klass только цифры из названия класса

                for (int j = 0; j < cb_class.Items.Count; j++)
                {
                    if (j == 0)
                    {
                        continue;
                    }

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
            for (int i = 0; i < count; i++)
            {
                bool check = false;
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
        }

        private void fillAdres()
        {
            cb_adres.Items.Add("");
            for (int i = 0; i < count; i++)
            {
                bool check = false;
                for (int j = 0; j < cb_adres.Items.Count; j++)
                {
                    if (Convert.ToString(cb_adres.Items[j]).ToLower() == Convert.ToString(dataGridView[6, i].Value).ToLower())
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
                    cb_adres.Items.Add(dataGridView[6, i].Value);
                }
            }
        }

        private void fillStatus() //Участник и участник
        {
            cb_status.Items.Add("");

            bool unspecified = false;
            bool unspecifiedFill = true;

            for (int i = 0; i < count; i++)
            {
                bool check = false;

                if (Convert.ToString(dataGridView[8, i].Value) == "" && unspecifiedFill)
                {
                    unspecified = true;
                }

                for (int j = 0; j < cb_status.Items.Count; j++)
                {
                    if (unspecified)
                    {
                        cb_status.Items.Add("Не указано");
                        check = true;
                        unspecified = false;
                        unspecifiedFill = false;
                        break;
                    }

                    if (Convert.ToString(cb_status.Items[j]).ToLower() == Convert.ToString(dataGridView[8, i].Value).ToLower())
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

        private void fillPeople()
        {
            cb_uchenik.Items.Add("");
            cb_nastavnik.Items.Add("");
            for (int i = 0; i < count; i++)
            {
                cb_nastavnik.Items.Add(dataGridView[10, i].Value);
                cb_uchenik.Items.Add(dataGridView[2, i].Value);
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
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
            workSheet.Cells[1, 10] = "Непонятный столбец";
            workSheet.Cells[1, 11] = "ФИО наставника";

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

            string location = Environment.CurrentDirectory;
            location = location.Remove(location.Length - 29, 29);
            location = location.Insert(location.Length, "Отчёт.xlsx");
            exApp.Visible = true;
        }
    }
}