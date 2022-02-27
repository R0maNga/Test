namespace Web.API.Request
{
    public class PutPhotoRequest
    {
        //при вызове метода PutPhotoRequest() можно заменить 1 или несколько атрибутов у сущности Photo
        public int Id { get; set; }
        public string Name { get; set; }
        public String PhotoLink { get; set; }
        public double Size { get; set; }
        public DateTime DateCreate { get; set; }
        public decimal Price { get; set; }
        public double AmountOfPurchase { get; set; }
        public int AuthorId { get; set; }
        
       
    }
}
