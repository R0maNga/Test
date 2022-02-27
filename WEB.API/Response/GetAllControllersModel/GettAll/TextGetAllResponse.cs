namespace Web.API.Response.GetAllControllersModel.GettAll
{
    public class TextGetAllResponse
    {
        //при вызове метода GetAllResponse() будут отображаться следующие атрибуты для текста
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
