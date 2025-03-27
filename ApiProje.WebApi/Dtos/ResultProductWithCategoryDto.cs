using ApiProje.WebApi.Entities;

namespace ApiProje.WebApi.Dtos
{
    public class ResultProductWithCategoryDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public string ImegeUrl { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
