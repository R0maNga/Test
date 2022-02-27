using Web.API.Response;
using Web.API.Response.AuthorController.Get;

namespace Web.API.Request
{
    public class DeleteTextRequest
    {
        //Атрибуты нужные для удаления сущности Text
        public int  Id { get; set; }
        public string Name { get; set; }
        
    }
}
