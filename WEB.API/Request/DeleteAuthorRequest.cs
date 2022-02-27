namespace Web.API.Request
{
    public class DeleteAuthorRequest
    {
        //Атрибуты нужные для удаления сущности Author
        public int Id { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
    
    }
}
