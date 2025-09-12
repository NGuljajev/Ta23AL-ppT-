using System;

namespace Ta23ALõppTöö.Models
{
    public class FoodItem
    {
        public int Id { get; set; }
        public int? CinemaId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
