using System;

namespace Ta23ALõppTöö.Models
{
    public class Promotion
    {
        public int Id { get; set; }
        public int? EventId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? PromoCode { get; set; }
        public string DiscountType { get; set; } // percent, amount
        public decimal DiscountValue { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int? UsageLimit { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
