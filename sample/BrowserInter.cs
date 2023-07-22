using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    interface BrowserInter<T>
    {
        IList<T> GetList();
       
        void Save(T obj);
        void Delete(int Id);
        void DeleteAll();
    }
}
