using BLL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        WebContext db;
        public UnitOfWork(WebContext context)
        {
            db = context;
        }
        //паттерн для сохранения инфы в бд
        public Task<int> Save()
        {
            return db.SaveChangesAsync();
        }
    }
}
