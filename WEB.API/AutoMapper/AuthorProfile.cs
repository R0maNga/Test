using AutoMapper;
using Web.API.Request;
using Web.API.Response;
using Web.API.Response.AuthorController.Get;
using Web.API.Response.GetAllControllersModel.GettAll;

namespace Web.API.AutoMapper
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
            {
                //конфигурация Mapper для Author
                CreateMap<PostAuthorRequest, BLL.Entities.Author>();
                CreateMap<DeleteAuthorRequest, BLL.Entities.Author>();
                CreateMap<BLL.Entities.Author, GetAuthorResponse>();
                CreateMap<BLL.Entities.Author, AuthorGetAllResponse>();
            }
    }
}
