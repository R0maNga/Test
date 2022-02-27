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
    public class AuthorFinder : Finder<Author>, IAuthorFinder
    {
        
        public AuthorFinder(WebContext context) : base(context)
        {

        }
        //метод для получения всех авторов
        public Task<List<Author>> Get()
        {

            return Find().ToListAsync();
        }
        // метод для получения всех сущностей
        public Task<List<Author>> GetFullInfo()
        {
            return Find().Include(t=>t.Photos).Include(t=>t.Texts).ToListAsync();
        }
    }
}
