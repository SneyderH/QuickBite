using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickBite.Models;
using QuickBite.Context;

namespace QuickBite.Services
{
    public class TableService
    {
        public List<Table> GetTables()
        {
            using var context = new QuickBiteContext();
            return context.Tables.OrderBy(p => p.Status).ToList();

        }

        public void AddTable(Table tables)
        {
            using var context = new QuickBiteContext();
            context.Tables.Add(tables);
            //context.SaveChanges();
        }
    }
}
