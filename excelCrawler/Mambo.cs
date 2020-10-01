using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excelCrawler
{
    public sealed class Mambo : IManagementBoardExcel
    {
		public List<InsertEntity> GetOptimisationData(DataTableCollection dataTableCollection)
		{
			var list = new List<InsertEntity>();

			foreach (DataTable table in dataTableCollection)
			{
				// 'table' --> Excelの1シート
				// 'table.TableName' --> Excelのシート名
				if (table.TableName == "Sheet1")
				{
					// 'table.Rows' --> Excelのシート内の行データ
					foreach (DataRow row in table.Rows)
					{
						// 'table.Rows.ItemArray' --> Excelののシート内1行内の列データ
						// NOTE: シート内で1番右にデータが存在するセルまでの数分存在する
						StringBuilder sb = new StringBuilder();
						foreach (object item in row.ItemArray)
						{
							if (0 < item.ToString().Length)
							{
								// 文字列が何もない(セルの文字列)
								sb.Append(item.ToString());
								list.Add(new InsertEntity(1));
							}
							else
							{
								// 文字列が何もない(空白セル)
								sb.Append("(n/a)");
							}
							sb.Append(" ");
						}
						// コンソールに表示します
						Console.WriteLine(sb.ToString());
					}
					break;
				}
			}
			return list;
		}
    }
}
