

namespace Web.API.Response.AuthorController.Get
{
    public class GetAuthorResponse
    {//при вызове метода GetAuthorResponse() будут отображаться следующие атрибуты 
        public int Id { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public int Age { get; set; }
        public DateTime CreatedDate { get; set; }
    
    }
}
