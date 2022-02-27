using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UnitOfWork
{
    //паттерн для сохранения 
    public interface IUnitOfWork
    {
        Task<int> Save();
    }
}
