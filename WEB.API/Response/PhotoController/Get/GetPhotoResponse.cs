
using Web.API.Response.AuthorController.Get;

namespace Web.API.Response.PhotoController.Get
{
    public class GetPhotoResponse 
    {
        //при вызове метода GetPhotoResponse() будут отображаться следующие атрибуты
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhotoLink { get; set; }
        public DateTime DateCreate { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPurchase { get; set; }
        public int Raiting { get; set; }
        public int AuthorId { get; set; }
    }
   
}
