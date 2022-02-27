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
    public class PhotoService : IPhotoService
    {
        IRepository<Photo> _photoRespository { get; set; }
        IPhotoFinder _photoFinder { get; set; }
        IUnitOfWork _unitOfWork { get; set; }

        public PhotoService(IRepository<Photo> photoRepository, IPhotoFinder photoFinder, IUnitOfWork unitOfWork)
        {
            this._photoRespository = photoRepository;
            this._photoFinder = photoFinder;
            this._unitOfWork = unitOfWork;

        }
        // метод для созданию фото
        public Task Create(Photo photo)
        {
            _photoRespository.Create(photo);
            return _unitOfWork.Save();

        }
        // метод для изменения фото
        public Task Update(Photo photo)
        {
            _photoRespository.Update(photo);
            return _unitOfWork.Save();
        }
        // метод для удаления фото
        public Task Delete(Photo photo)
        {
            _photoRespository.Delete(photo);
            return _unitOfWork.Save();
        }
        // метод для получения фото по Id
        public async Task<Photo> GetById(int id)
        {
            return await _photoFinder.GetById(id);
        }
        // метод для получения фото
        public async Task<IEnumerable<Photo>> Get()
        {
            return await _photoFinder.Get();
        }

    }
}
