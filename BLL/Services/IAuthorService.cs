using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IAuthorService
    {
        //вызов методов из AuthorService
        Task Create(Author author);
        Task Update(Author author);
        Task Delete(Author author);
        Task <IEnumerable<Author>> Get();
        Task<IEnumerable<Author>> GetFullInfo();
    }
}
