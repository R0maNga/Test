using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface ITextService
    {
        //вызов методов из TextService
        Task Create(Text text);
        Task Update(Text text);
        Task Delete(Text text);
        Task<IEnumerable<Text>> Get();
    }
}
