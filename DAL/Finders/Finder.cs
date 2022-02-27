using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Finders
{
    public class Finder<T> where T : class
    {
        private WebContext db;
        public Finder(WebContext context)
        {
            db = context;
        }
        //инициализация метода Find()
        protected IQueryable<T> Find()
        {
            return db.Set<T>().AsQueryable();
        }

    }
    
}
