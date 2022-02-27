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
    public class AuthorService : IAuthorService
    {
        IRepository<Author> _authorRespository { get; set; }
        IAuthorFinder _authorFinder { get; set; }
        IUnitOfWork _unitOfWork { get; set; }


        public AuthorService(IRepository<Author> authorRepository, IAuthorFinder authorFinder, IUnitOfWork unitOfWork)
        {
            this._authorRespository = authorRepository;
            this._authorFinder = authorFinder;
            this._unitOfWork = unitOfWork;

        }
        //метод для созданию автора
        public Task Create(Author author)
        {
            _authorRespository.Create(author);
            return _unitOfWork.Save();

        }
        //метод для изменению автора
        public Task Update(Author author)
        {
            _authorRespository.Update(author);
            return _unitOfWork.Save();
        }
        //метод для удалению автора
        public Task Delete(Author author)
        {
            _authorRespository.Delete(author);
            return _unitOfWork.Save();
        }
        //метод для получение автора
        public async Task<IEnumerable<Author>> Get()
        {
            return await _authorFinder.Get();
        }
        //метод для получения автора для списка всех сущностей
        public async Task<IEnumerable<Author>> GetFullInfo()
        {
            return await _authorFinder.GetFullInfo();
        }
    }
}



