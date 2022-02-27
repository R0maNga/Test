using AutoMapper;
using Web.API.Request;
using Web.API.Response;
using Web.API.Response.GetAllControllersModel.GettAll;
using Web.API.Response.PhotoController.Get;

namespace Web.API.AutoMapper
{
    public class PhotoProfile: Profile
    {
        public PhotoProfile()
        {
            //конфигурация Mapper для Photo
            CreateMap<PostPhotoRequest, BLL.Entities.Photo>();
            CreateMap<PutPhotoRequest, BLL.Entities.Photo>();
            CreateMap<DeletePhotoRequest, BLL.Entities.Text>();
            CreateMap<BLL.Entities.Photo, GetPhotoResponse>();
            CreateMap<BLL.Entities.Photo, PhotoGetAllResponse>();
        }
    }
}
