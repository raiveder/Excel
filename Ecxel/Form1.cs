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

        private void cb_okrug_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}