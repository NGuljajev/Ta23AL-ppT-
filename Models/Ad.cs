using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("ads")]
public class Ad
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public long Id { get; set; }

    [Column("cinema_id")]
    public int? CinemaId { get; set; }

    [Column("title")]
    public string Title { get; set; }

    [Column("client_name")]
    public string ClientName { get; set; }

    [Column("media_url")]
    public string MediaUrl { get; set; }

    [Column("start_date")]
    public DateTime StartDate { get; set; }

    [Column("end_date")]
    public DateTime EndDate { get; set; }

    [Column("placement")]
    public string Placement { get; set; }

    [Column("price")]
    public decimal Price { get; set; }

    [Column("status")]
    public string Status { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
}