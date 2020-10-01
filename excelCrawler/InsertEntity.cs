using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excelCrawler
{
    public sealed class InsertEntity
    {
        public InsertEntity(int id)
        {
            Id = id;
        }
        public int Id { get; }
    }
}
