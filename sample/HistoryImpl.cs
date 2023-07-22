using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class HistoryImpl : BrowserInter<HistoryDataBaseT>
    {
        BrowserDbContext context = new BrowserDbContext();
        public void Delete(int Id)
        {
            var hist=context.Historys.SingleOrDefault(delHist => delHist.Id == (int)Id);
            if (hist != null)
            {
                context.Historys.Remove(hist);
                context.SaveChanges();
            }
            
        }

       

        public IList<HistoryDataBaseT> GetList()
        {
            return context.Historys.Select(hist => hist).OrderByDescending(hi => hi.Date).ToList();
        }

        public void Save(HistoryDataBaseT obj)
        {
            var record=context.Historys.SingleOrDefault(h => h.Query == (string)obj.Query);
            if (record == null)
            {
                context.Historys.Add(obj);
                context.SaveChanges();

            }
            else
            {
                record.Date = obj.Date;
                context.SaveChanges();
            }

           
        }

        public void DeleteAll()
        {
            var result=context.Historys.Select(hist => hist).ToList();
            foreach(var res in result)
            {
                context.Historys.Remove(res);
                context.SaveChanges();
            }

        }
    }
}
