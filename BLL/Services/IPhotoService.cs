using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IPhotoService
    {
        //вызов методов из PhotoService
        Task Create(Photo photo);
        Task<IEnumerable<Photo>> Get();
        Task Update(Photo photo);
        Task Delete(Photo photo);
        Task<Photo> GetById(int id);
    }
}
