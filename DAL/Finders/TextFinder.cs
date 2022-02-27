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
    public class TextFinder : Finder<Text>, ITextFinder
    {
        public TextFinder(WebContext context) : base(context)
        {

        }
        // получение сущностей Text
        public Task<List<Text>> Get()
        {
            return Find().ToListAsync();
        }
    }
}
