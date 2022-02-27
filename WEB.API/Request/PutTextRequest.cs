namespace Web.API.Request
{
    public class PutTextRequest
    {
        //при вызове метода PutTextRequest() можно заменить 1 или несколько атрибутов у сущности Text
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public double Size { get; set; }
        public DateTime DateOfCreate { get; set; }
        public decimal Price { get; set; }
        public double NumberOfSales { get; set; }
        public int AuthorId { get; set; }
       
    }
}
