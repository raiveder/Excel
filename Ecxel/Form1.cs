using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                fileName = "C:\\Users\\Админ\\Desktop\\Рабочий стол\\Ecxel\\Ecxel\\Таблица.xlsx";
                openExcelFile(fileName);

                DataTable table = tableCollection["лист"];
                dataGridView1.DataSource = table;
            fillComboBox();
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

        private void fillComboBox()
        {
            count = dataGridView1.Rows.Count - 1;
            for (int i = 0; i < count; i++)
            {
                int index = -1;

                for (int j = 0; j < cb_okrug.Items.Count; j++)
                {
                    if (Convert.ToString(cb_okrug.Items[j]).ToLower() == Convert.ToString(dataGridView1[1, i].Value).ToLower())
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
                    index = Convert.ToString(dataGridView1[1, i].Value).ToLower().IndexOf("бор");
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
                    index = Convert.ToString(dataGridView1[1, i].Value).ToLower().IndexOf("арзамас");
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
                    index = Convert.ToString(dataGridView1[1, i].Value).ToLower().IndexOf("ленинский");
                    for (int j = 0; j < cb_okrug.Items.Count; j++)
                    {
                        if (index != -1)
                        {
                            if (Regex.IsMatch(Convert.ToString(cb_okrug.Items[j]).ToLower(), @"ленинский"))
                            {
                                arz = false;
                            }
                        }
                    }

                    if (bor && arz && len)
                    {
                        //bool kan = true;
                        //for (int j = 0; j < cb_okrug.Items.Count; j++)
                        //{
                        //    if (Regex.IsMatch(Convert.ToString(cb_okrug.Items[j]).ToLower(), @"канавинский"))
                        //    {
                        //        cb_okrug.Items.Add("канавинский");
                        //        kan = false;
                        //    }
                        //}
                        //if (kan)
                        //{
                            cb_okrug.Items.Add(dataGridView1[1, i].Value);
                        //}
                    }
                }
            }
        }

        private void cb_okrug_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}