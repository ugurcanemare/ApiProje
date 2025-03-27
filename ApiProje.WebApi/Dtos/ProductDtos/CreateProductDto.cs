﻿using ApiProje.WebApi.Entities;

namespace ApiProje.WebApi.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public string ImegeUrl { get; set; }
        public int CategoryId { get; set; }
    }
}
