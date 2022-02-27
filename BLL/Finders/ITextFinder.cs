using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.Finders
{
    //интерфейс по поиску текста
    public interface ITextFinder
    {
        Task<List<Text>> Get();

    }
}
