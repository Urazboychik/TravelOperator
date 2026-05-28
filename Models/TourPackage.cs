using System.ComponentModel.DataAnnotations;

namespace TravelOperator.Models;

public class TourPackage
{
    public int Id { get; set; }

    [Required, MaxLength(140)]
    public string Name { get; set; } = string.Empty;

    [Required, MaxLength(80)]
    public string Destination { get; set; } = string.Empty;

    [MaxLength(80)]
    public string TourType { get; set; } = string.Empty;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public decimal PricePerPerson { get; set; }

    public int Capacity { get; set; }

    public int BookedSeats { get; set; }

    [MaxLength(40)]
    public string Status { get; set; } = "Active";

    public int AvailableSeats => Math.Max(0, Capacity - BookedSeats);
}
