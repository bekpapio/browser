using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    
    class BookMarkImpl : BrowserInter<BookMarkDatabaseT>
    {
        BrowserDbContext context = new BrowserDbContext();
        public void Delete(int Id)
        {
            var bookMark = context.BookMarks.SingleOrDefault(del => del.Id == (int)Id);
            context.BookMarks.Remove(bookMark);
            context.SaveChanges();
        }

        
        public IList<BookMarkDatabaseT> GetList()
        {
            return context.BookMarks.Select(hist => hist).OrderByDescending(hi => hi.Date).ToList();
        }

        public void Save(BookMarkDatabaseT obj)
        {
            var record = context.BookMarks.SingleOrDefault(h => h.Query == (string)obj.Query);
            if (record == null)
            {
                context.BookMarks.Add(obj);
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
            var result = context.BookMarks.Select(hist => hist).ToList();
            foreach (var res in result)
            {
                context.BookMarks.Remove(res);
                context.SaveChanges();
            }
        }
    }
}
