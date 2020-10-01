using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excelCrawler
{
    internal static class ExcelReaderHelper
    {
        internal static DataTableCollection Query(string filePath)
        {
			// 現在実行しているアセンブリのファイル情報を取得する
			if (!File.Exists(filePath))
			{
				// ファイルが存在しない
				//return; 例外
			}
			FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);

			// Excelファイル読み込む(2007 format; *.xlsx)
			IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

			System.Data.DataSet result = null;
			result = excelReader.AsDataSet();
			// Excelファイルを閉じる
			excelReader.Close();
			return result.Tables;
		}
    }
}
