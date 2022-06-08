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

        private void Form1_Load(object sender, EventArgs e)
        {
            //try
            //{
                fileName = "C:\\Users\\Админ\\Desktop\\Рабочий стол\\Ecxel\\Ecxel\\Таблица.xlsx";
                openExcelFile(fileName);

                DataTable table = tableCollection["лист"];
                dataGridView1.DataSource = table;
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
    }
}