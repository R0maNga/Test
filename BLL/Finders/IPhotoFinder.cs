using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Finders
{
    //интерфейс по поиску фото
    public interface IPhotoFinder
    {
        Task<List<Photo>> Get();
        Task<Photo?> GetById(int id);

    }
}
