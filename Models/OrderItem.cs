using System;

namespace Ta23ALõppTöö.Models
{
    public class OrderItem
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public string ItemType { get; set; } // ticket, food, gift_card
        public long? ReferenceId { get; set; }
        public string? Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal LineTotal { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
