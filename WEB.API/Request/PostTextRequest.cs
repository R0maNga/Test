namespace Web.API.Request
{
    public class PostTextRequest
    {
        //при вызове метода PostTextRequest() добавление сущности Text со следующими атрибутами
        public string Name { get; set; }
        public string Content { get; set; }
        public double Size { get; set; }
        public DateTime DateOfCreate { get; set; }
        public decimal Price { get; set; }
        public double NumberOfSales { get; set; }
        public PostAuthorRequest Author { get; set; }
    }
}
