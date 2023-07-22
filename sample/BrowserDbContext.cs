using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;


namespace sample
{
    class BrowserDbContext : DbContext
    {
        public DbSet<HistoryDataBaseT> Historys { get; set; }
        public DbSet<BookMarkDatabaseT> BookMarks { get; set; }
    }
}
