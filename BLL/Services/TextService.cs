using BLL.Entities;
using BLL.Finders;
using BLL.Repositories;
using BLL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class TextService : ITextService
    {
        IRepository<Text> _textRespository { get; set; }
        ITextFinder _textFinder { get; set; }
        IUnitOfWork _unitOfWork { get; set; }


        public TextService(IRepository<Text> textRepository, ITextFinder textFinder, IUnitOfWork unitOfWork)
        {
            this._textRespository = textRepository;
            this._textFinder = textFinder;
            this._unitOfWork = unitOfWork;

        }
        // метод для создания текста
        public Task Create(Text text)
        {
            _textRespository.Create(text);
            return _unitOfWork.Save();

        }
        // метод для изменения текста
        public Task Update(Text text)
        {
            _textRespository.Update(text);
            return _unitOfWork.Save();
        }
        // метод для удаления текста
        public Task Delete(Text text)
        {
            _textRespository.Delete(text);
            return _unitOfWork.Save();
        }
        // метод для получения текста
        public async Task<IEnumerable<Text>> Get()
        {
            return await _textFinder.Get();
        }

    }
}



