namespace Web.API.Response.GetAllControllersModel.GettAll
{
    public class PhotoGetAllResponse
    {
        //при вызове метода GetAllResponse() будут отображаться следующие атрибуты для фото
        public int Id { get; set; }
   
        public string Name { get; set; }
        public double Size { get; set; }
        public DateTime DateCreate { get; set; }
        public String PhotoLink { get; set; }
        public int AuthorId { get; set; }
        public decimal Price { get; set; }
        public double AmountOfPurchase { get; set; }

    }
}
