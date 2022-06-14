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
        SD.DataTable table;
        static FileStream stream;

        private void Form1_Load(object sender, EventArgs e)
        {
            //try
            //{
            openExcelFile();
            table = tableCollection["лист"];
            dataGridView.DataSource = table;
            //foreach (DataGridViewColumn column in dataGridView.Columns)
            //{
            //    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //}
            //dataGridView.Columns.RemoveAt(1);

            count = dataGridView.Rows.Count - 1;
            fillOkrug();
            fillClass();
            fillOrganiz();
            fillStatus();
            fillUchenik();
            fillNast();
            cb_pol.Items.Add("");
            cb_pol.Items.Add("Мужской");
            cb_pol.Items.Add("Женский");
            // }
            //catch
            //{
            //MessageBox.Show();
            // }
        }

        public static void openFile()
        {
            string path = Environment.CurrentDirectory;
            path = path.Substring(0, path.Length - 23);
            path += "Таблица.xlsx";

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            stream = File.Open(path, FileMode.Open, FileAccess.Read);
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
            for (int i = 0; i < count; i++)
            {
                bool check = false;
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

        private void fillStatus()
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

        private void fillUchenik()
        {
            cb_uchenik.Items.Add("");
            for (int i = 0; i < count; i++)
            {
                cb_uchenik.Items.Add(dataGridView[2, i].Value);
            }
        }

        private void fillNast()
        {
            cb_nastavnik.Items.Add("");

            bool unspecified = false;
            bool unspecifiedFill = true;

            for (int i = 0; i < count; i++)
            {
                bool check = false;

                if (Convert.ToString(dataGridView[10, i].Value) == "" && unspecifiedFill)
                {
                    unspecified = true;
                }

                for (int j = 0; j < cb_nastavnik.Items.Count; j++)
                {
                    if (unspecified)
                    {
                        cb_nastavnik.Items.Add("Не указано");
                        check = true;
                        unspecified = false;
                        unspecifiedFill = false;
                        break;
                    }

                    if (Convert.ToString(cb_nastavnik.Items[j]).ToLower() == Convert.ToString(dataGridView[10, i].Value).ToLower())
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
                    cb_nastavnik.Items.Add(dataGridView[10, i].Value);
                }
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
            exApp.Visible = true;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            openExcelFile();
            table = tableCollection["лист"];
            dataGridView.DataSource = table;

            for (int i = dataGridView.Rows.Count - 1; i >= 0; i--)
            {
                if (cb_okrug.Text == "")
                {
                    break;
                }

                if (Convert.ToString(dataGridView[1, i].Value) != cb_okrug.Text)
                {
                    dataGridView.Rows.RemoveAt(i);
                }
            }

            for (int i = dataGridView.Rows.Count - 1; i >= 0; i--)
            {
                if (cb_uchenik.Text == "")
                {
                    break;
                }

                if (Convert.ToString(dataGridView[2, i].Value) != cb_uchenik.Text)
                {
                    dataGridView.Rows.RemoveAt(i);
                }
            }

            for (int i = dataGridView.Rows.Count - 1; i >= 0; i--)
            {
                if (cb_class.Text == "")
                {
                    break;
                }

                if (Convert.ToString(dataGridView[4, i].Value) != cb_class.Text)
                {
                    dataGridView.Rows.RemoveAt(i);
                }
            }

            for (int i = dataGridView.Rows.Count - 1; i >= 0; i--)
            {
                if (cb_organiz.Text == "")
                {
                    break;
                }

                if (Convert.ToString(dataGridView[5, i].Value) != cb_organiz.Text)
                {
                    dataGridView.Rows.RemoveAt(i);
                }
            }

            for (int i = dataGridView.Rows.Count - 1; i >= 0; i--)
            {
                if (cb_status.Text == "")
                {
                    break;
                }

                if (Convert.ToString(dataGridView[8, i].Value) != cb_status.Text)
                {
                    dataGridView.Rows.RemoveAt(i);
                }
            }

            for (int i = dataGridView.Rows.Count - 1; i >= 0; i--)
            {
                if (cb_nastavnik.Text == "")
                {
                    break;
                }

                if (cb_nastavnik.Text == "Не указано")
                {
                    if (Convert.ToString(dataGridView[10, i].Value) != "")
                    {
                        dataGridView.Rows.RemoveAt(i);
                    }
                }
                else if(Convert.ToString(dataGridView[10, i].Value) != cb_nastavnik.Text)
                {
                    dataGridView.Rows.RemoveAt(i);
                }
            }

            for (int i = dataGridView.Rows.Count - 1; i >= 0; i--)
            {
                if (cb_pol.Text == "")
                {
                    break;
                }

                if (cb_pol.Text == "Мужской")
                {
                    if (Convert.ToString(dataGridView[11, i].Value) != "м")
                    {
                        dataGridView.Rows.RemoveAt(i);
                    }
                }
                else
                {
                    if (Convert.ToString(dataGridView[11, i].Value) != "ж")
                    {
                        dataGridView.Rows.RemoveAt(i);
                    }
                }
            }
        }
    }
}