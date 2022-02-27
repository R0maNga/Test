using Web.API.Response;
using Web.API.Response.AuthorController.Get;

namespace Web.API.Request
{
    public class DeletePhotoRequest
    {
        //Атрибуты нужные для удаления сущности Photo
        public int Id { get; set; }
        public string Name { get; set; }
        
    }
}
