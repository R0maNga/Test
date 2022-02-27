using AutoMapper;
using Web.API.Request;
using Web.API.Response;
using Web.API.Response.GetAllControllersModel.GettAll;
using Web.API.Response.TextController.Get;

namespace Web.API.AutoMapper
{

    public class TextProfile : Profile
    {
        public TextProfile()
        {
            //конфигурация Mapper для Text
            CreateMap<PostTextRequest, BLL.Entities.Text>();
            CreateMap<PutTextRequest, BLL.Entities.Text>();
            CreateMap<DeleteTextRequest, BLL.Entities.Text>();
            CreateMap<BLL.Entities.Text, GetTextResponse>();
            CreateMap<BLL.Entities.Text, TextGetAllResponse>();
        }
    }

}
