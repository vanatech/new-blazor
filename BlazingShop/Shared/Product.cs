using System;
namespace BlazingShop.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Image { get; set; } = "https://via.placeholder.com/300x300";
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public bool IsPublic { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public DateTime DatCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; }
    }
}

