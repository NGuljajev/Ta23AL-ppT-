using System;

namespace Ta23ALõppTöö.Models
{
    public class Payment
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public decimal Amount { get; set; }
        public string? Currency { get; set; }
        public string? Method { get; set; }
        public string? ProviderPaymentId { get; set; }
        public string Status { get; set; } // initiated, completed, failed, refunded
        public DateTime? PaidAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
