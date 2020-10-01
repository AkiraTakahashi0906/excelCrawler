using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excelCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            var targetPath = @"C:\Users\akira\OneDrive\デスクトップ\C#\asynchronous_study";
            try
            {
                ExcelFileSearch.GetFileName(targetPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}
