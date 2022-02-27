using BLL.Entities;
using BLL.Finders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Finders
{
    public class PhotoFinder : Finder<Photo>, IPhotoFinder
    {
        public PhotoFinder(WebContext context) : base(context)
        {

        }
        //получение сущностей фото
        public Task<List<Photo>> Get()
        {
            return Find().ToListAsync();
        }
        //получение фотографий по Id
        public Task <Photo?> GetById(int id)
        {
            return Find().FirstOrDefaultAsync(t => t.Id == id);
        }

        
    }
}
