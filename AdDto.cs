using System;

namespace Ta23ALõppTöö.DTOs
{
    public class AdDto
    {
        public long Id { get; set; }
        public long? CinemaId { get; set; }
        public string Title { get; set; }
        public string ClientName { get; set; }
        public string MediaUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Placement { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
