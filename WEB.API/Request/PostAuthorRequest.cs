namespace Web.API.Request
{
    public class PostAuthorRequest
    {
        //при вызове метода PostAuthorRequest() добавление сущности Author со следующими атрибутами
        public string Name { get; set; }
        public string NickName { get; set; }
        public int Age { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
