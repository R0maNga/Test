
namespace Web.API.Request
{
    public class PostPhotoRequest
    {
        //при вызове метода PostPhotoRequest() добавление сущности Photo со следующими атрибутами
        public string Name { get; set; }
        public int Size { get; set; }
        public DateTime DateCreate { get; set; }
        public String PhotoLink { get; set; }

        public PostAuthorRequest Author { get; set; }
        public decimal Price { get; set; }
        public double AmountOfPurchase { get; set; }
    }
}
