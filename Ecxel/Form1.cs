using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ExcelDataReader;
using System.Text.RegularExpressions;

namespace Ecxel
{
    public partial class Form1 : Form
    {
        MonthCalendar monthCalendar1 = new MonthCalendar();
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

            DataTable table = tableCollection["лист"];
            dataGridView.DataSource = table;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            fillOkrug();
            fillClass();
            fillOrganiz();
            fillAdres();
            fillStatus();
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
            count = dataGridView.Rows.Count - 1;
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
                            kan = false;
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
            count = dataGridView.Rows.Count - 1;
            for (int i = 0; i < count; i++)
            {
                int index = -1;

                for (int j = 0; j < cb_class.Items.Count; j++)
                {
                    if (Convert.ToString(cb_class.Items[j]).ToLower() == Convert.ToString(dataGridView[4, i].Value).ToLower())
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
                    bool seven = true;
                    index = -1;
                    index = Convert.ToString(dataGridView[4, i].Value).ToLower().IndexOf("7");
                    for (int j = 0; j < cb_class.Items.Count; j++)
                    {
                        if (index != -1)
                        {
                            if (Regex.IsMatch(Convert.ToString(cb_class.Items[j]).ToLower(), @"7"))
                            {
                                seven = false;
                            }
                        }
                    }

                    bool eight = true;
                    index = -1;
                    index = Convert.ToString(dataGridView[4, i].Value).ToLower().IndexOf("8");
                    for (int j = 0; j < cb_class.Items.Count; j++)
                    {
                        if (index != -1)
                        {
                            if (Regex.IsMatch(Convert.ToString(cb_class.Items[j]).ToLower(), @"8"))
                            {
                                eight = false;
                            }
                        }
                    }

                    if (seven && eight)
                    {
                        if (Regex.IsMatch(Convert.ToString(dataGridView[4, i].Value).ToLower(), @"7"))
                        {
                            cb_class.Items.Add("7");
                            seven = false;
                        }
                        else if (Regex.IsMatch(Convert.ToString(dataGridView[4, i].Value).ToLower(), @"8"))
                        {
                            cb_class.Items.Add("8");
                            eight = false;
                        }
                        else
                        {
                            cb_class.Items.Add(dataGridView[4, i].Value);
                        }
                    }
                }
            }
        }

        private void fillOrganiz() //убрать пробелы перед названиями
        {
            count = dataGridView.Rows.Count - 1;
            for (int i = 0; i < count; i++)
            {
                int index = -1;
                for (int j = 0; j < cb_organiz.Items.Count; j++)
                {
                    if (Convert.ToString(cb_organiz.Items[j]).ToLower() == Convert.ToString(dataGridView[5, i].Value).ToLower())
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
                    cb_organiz.Items.Add(dataGridView[5, i].Value);
                }
            }
        }

        private void fillAdres()
        {
            count = dataGridView.Rows.Count - 1;
            for (int i = 0; i < count; i++)
            {
                int index = -1;
                for (int j = 0; j < cb_adres.Items.Count; j++)
                {
                    if (Convert.ToString(cb_adres.Items[j]).ToLower() == Convert.ToString(dataGridView[6, i].Value).ToLower())
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
                    cb_adres.Items.Add(dataGridView[6, i].Value);
                }
            }
        }

        private void fillStatus()
        {
            count = dataGridView.Rows.Count - 1;
            for (int i = 0; i < count; i++)
            {
                int index = -1;

                for (int j = 0; j < cb_status.Items.Count; j++)
                {
                    if (Convert.ToString(cb_status.Items[j]).ToLower() == Convert.ToString(dataGridView[8, i].Value).ToLower())
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
                    bool no = true;
                    index = -1;
                    if(Convert.ToString(dataGridView[8, i].Value).ToLower()=="")
                    {
                        index = 0;
                    }
                    
                    for (int j = 0; j < cb_status.Items.Count; j++)
                    {
                        if (index != -1)
                        {
                            if (Convert.ToString(cb_status.Items[j]).ToLower()=="не указано")
                            {
                                no = false;
                            }
                        }
                    }
                    if (no)
                    {
                        if (Convert.ToString(dataGridView[8, i].Value).ToLower()=="")
                        {
                            cb_status.Items.Add("не указано");
                            no = false;
                        }
                        else
                        {
                            cb_status.Items.Add(dataGridView[8, i].Value);
                        }
                    }
                }
            }
        }
    }
}