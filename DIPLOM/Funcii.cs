using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOM
{
    public static class Funcii
    {
        public static string[,] ImportExcel(string filename)
        {
            string xlFileName = filename;
            var p = Path.GetDirectoryName(filename);
            var way = p + "\\";
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Open(filename);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = wb.Sheets[1];
            wb.SaveAs(@way + "kek.csv", Microsoft.Office.Interop.Excel.XlFileFormat.xlCSVWindows, Local: true);
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



            bool kk = false;






            List<string> sh = new List<string>();

            List<string> t = new List<string>();

            int m = values.GetLength(0);
            int n = values.GetLength(1);
            for (int j = 0; j < n; j++)
            {
                if (values[0, j] == "Sh")
                {
                    for (int r = 1; r < m; r++)
                    {
                        sh.Add(values[r, j]);
                    }

                }
                if (values[0, j] == "t")
                {
                    for (int r = 1; r < m; r++)
                    {
                        t.Add(values[r, j]);
                    }

                }
            }

            var kek = new List<Dannie>();
            var maxi = lasti() + 1;
            for (int i = 0; i < sh.Count; i++)
            {
                var c = new Dannie
                {
                    expId = maxi,
                    Sh = Convert.ToInt32(sh[i]),
                    t = Convert.ToInt32(t[i]),

                };
                kek.Add(c);
            }
            

            using (var context = new MyDbContext())
            {
                context.Dannies.AddRange(kek);
                context.SaveChanges();
            }    


                File.Delete(@way + "kek.csv");
            return values;
        }

        private static int lasti()
        {
            int max = 0;
            using (var context = new MyDbContext())
            {try
                {
                    max = context.Dannies.Max(c => c.expId);
                }

                catch
                {
                    max = 0;
                }
            }
            return max;
        }
    }
}
