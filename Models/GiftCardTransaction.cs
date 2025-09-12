using System;

namespace Ta23ALõppTöö.Models
{
    public class GiftCardTransaction
    {
        public long Id { get; set; }
        public long GiftCardId { get; set; }
        public string Type { get; set; } // issue, redeem, topup, transfer
        public decimal Amount { get; set; }
        public int? PerformedBy { get; set; }
        public DateTime? PerformedAt { get; set; }
        public long? RelatedOrderId { get; set; }
        public string? Note { get; set; }
    }
}
