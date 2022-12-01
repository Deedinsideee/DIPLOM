using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            Database.SetInitializer(
        new DropCreateDatabaseIfModelChanges<MyDbContext>());
        }
        
        private void showform()
            {
            using (var context = new MyDbContext())
                {
                dataGridView1.DataSource = context.Dannies.ToList();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                }
                
            }
        private void button_download_one_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            if (OPF.ShowDialog() == DialogResult.Cancel)
                return;


            string filename = OPF.FileName;
            
            var values = Funcii.ImportExcel(filename);


            








        }

        private void button_downloadmany_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            

            List<string> file=null;
            while (true)
            {
                DialogResult result = folderBrowser.ShowDialog();
                if (!string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    string[] files = Directory.GetFiles(folderBrowser.SelectedPath);
                    file = files.ToList();
                }
                if (file.Count==0)
                {
                    DialogResult result1 = MessageBox.Show("Вы выбрали пустую папку, хотите выбрать другую ?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result1==DialogResult.No)
                    {
                        break;
                    }
                }
                else
                {
                    foreach (var s in file)
                    {
                        Funcii.ImportExcel(s);
                    }
                    break;
                }
            }
            




        }

        private void button1_Click(object sender, EventArgs e)
        {
            showform();
        }
    }
}
