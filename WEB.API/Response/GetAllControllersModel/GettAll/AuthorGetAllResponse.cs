namespace Web.API.Response.GetAllControllersModel.GettAll
{
    public class AuthorGetAllResponse
    {
        //при вызове метода GetAllResponse() будут отображаться следующие атрибуты для автора
        public int Id { get; set; }

        public string Name { get; set; }
        public string NickName { get; set; }
        public int Age { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<PhotoGetAllResponse> Photos { get; set; } = new List<PhotoGetAllResponse>();
        public List<TextGetAllResponse> Texts { get; set; } = new List<TextGetAllResponse>();
    }
}
