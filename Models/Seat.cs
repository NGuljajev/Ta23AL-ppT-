using System;

namespace Ta23ALõppTöö.Models
{
    public class Seat
    {
        public int Id { get; set; }
        public int HallId { get; set; }
        public string? RowLabel { get; set; }
        public int? SeatNumber { get; set; }
        public string? SeatCode { get; set; }
        public string SeatType { get; set; } // standard, vip, couple, handicap
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
