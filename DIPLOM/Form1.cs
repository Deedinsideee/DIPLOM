using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using Microsoft.Office.Interop;
using Excel = Microsoft.Office.Interop.Excel;


namespace DIPLOM
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        private void button_download_one_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();

            if (OPF.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = OPF.FileName;
            string xlFileName = filename;
            var p=Path.GetDirectoryName(OPF.FileName);
            var way = p + "\\";
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Open(filename);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = wb.Sheets[1];
            wb.SaveAs(@way  + "kek.csv", Microsoft.Office.Interop.Excel.XlFileFormat.xlCSVWindows,Local:true);
            wb.Close(false);
            app.Quit();

            


            string whole_file = System.IO.File.ReadAllText(@way + "kek.csv");

            // Разделение на строки.
            whole_file = whole_file.Replace('\n', '\r');
            string[] lines = whole_file.Split(new char[] { '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            // Посмотрим, сколько строк и столбцов есть.
            int num_rows = lines.Length;
            int num_cols = lines[0].Split(';').Length;

            // Выделите массив данных.
            string[,] values = new string[num_rows, num_cols];

            // Загрузите массив.
            for (int r = 0; r < num_rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < num_cols; c++)
                {   
                    values[r, c] = line_r[c];
                }
            }



            bool kk=false;
           
            int m = values.GetLength(0);
            int n = values.GetLength(1);
            dataGridView1.ColumnCount = n;
            dataGridView1.RowCount = m;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = values[i, j];
                }
            }


            List<string> sh = new List<string>();

            List<string> t = new List<string>();


            for (int j = 0; j < n; j++)
                {
                    if(dataGridView1.Rows[0].Cells[j].Value.ToString() =="Sh")
                    {
                        for (int r=1;r<m;r++)
                        {
                            sh.Add(dataGridView1.Rows[r].Cells[j].Value.ToString());
                        }

                    }
                    if (dataGridView1.Rows[0].Cells[j].Value.ToString() == "t")
                    {
                        for (int r = 1; r < m; r++)
                        {
                            t.Add(dataGridView1.Rows[r].Cells[j].Value.ToString());
                        }

                    }
                }
            

          



            File.Delete(@way + "kek.csv");
            








        }
    }
}
