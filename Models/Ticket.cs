using System;

namespace Ta23ALõppTöö.Models
{
    public class Ticket
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public int ScreeningId { get; set; }
        public int? SeatId { get; set; }
        public decimal Price { get; set; }
        public string TicketType { get; set; } // adult, child, senior, student, vip
        public string Status { get; set; } // active, cancelled, used
        public string? QrCode { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
