using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excelCrawler
{
    public static class ExcelFileSearch
    {
        public static List<string> GetFileName(string path)
        {
            var list = new List<string>();
            var targetDirectorys = GetFolderPath(path);
            foreach (var directorys in targetDirectorys)
            {
                string[] fileNames = Directory.GetFiles(directorys.FullName);
                foreach (var name in fileNames)
                {
                    if (IsExcel(name))
                    {
                        list.Add(name);
                        Console.WriteLine(name);
                    }
                }
            }
            return list;
        }

        private static DirectoryInfo[] GetFolderPath(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            return di.GetDirectories("*", SearchOption.AllDirectories);
        }

        private static bool IsExcel(string fullpath)
        {
            var ext = Path.GetExtension(fullpath);
            if (ext == ".cs" || ext == ".cs")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
