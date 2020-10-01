using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excelCrawler
{
    interface IManagementBoardExcel
    {
        List<InsertEntity> GetOptimisationData(DataTableCollection dataTableCollection);
    }
}
