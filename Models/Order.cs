using System;

namespace Ta23ALõppTöö.Models
{
    public class Order
    {
        public long Id { get; set; }
        public int? UserId { get; set; }
        public string OrderReference { get; set; }
        public int? CinemaId { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } // pending, paid, cancelled, refunded
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? PaymentMethod { get; set; }
        public string? PaymentId { get; set; }
    }
}
