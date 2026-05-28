using System.ComponentModel.DataAnnotations;

namespace TravelOperator.Models;

public class BookingRequest
{
    public int Id { get; set; }

    [Required, MaxLength(120)]
    public string CustomerName { get; set; } = string.Empty;

    [Required, MaxLength(120)]
    public string TourName { get; set; } = string.Empty;

    [MaxLength(120)]
    public string AgencyName { get; set; } = string.Empty;

    public int Travelers { get; set; }

    public decimal TotalAmount { get; set; }

    [MaxLength(40)]
    public string Stage { get; set; } = "New";

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
