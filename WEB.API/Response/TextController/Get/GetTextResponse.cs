using Web.API.Response.AuthorController.Get;

namespace Web.API.Response.TextController.Get
{
    public class GetTextResponse 
    {
        //при вызове метода GetTextResponse() будут отображаться следующие атрибуты
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int Size { get; set; }
        public DateTime DateOfCreate { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPurchase { get; set; }
        public int Raiting { get; set; }
        public int AuthorId { get; set; }
    }
    

}
