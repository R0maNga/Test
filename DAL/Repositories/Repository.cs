using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class Repository <T>: IRepository<T> where T : class
    {
        private WebContext db;

        public Repository (WebContext context)
        {
            this.db = context;
        }
        //методы CRUD операций
        public void Create(T entity)
        {
            db.Set<T>().AddAsync(entity);
        }
        public void Update(T entity)
        {
            db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void Delete(T entity)
        {
            db.Set<T>().Remove(entity);
        }
    }
}
