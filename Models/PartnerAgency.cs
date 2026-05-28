using System.ComponentModel.DataAnnotations;

namespace TravelOperator.Models;

public class PartnerAgency
{
    public int Id { get; set; }

    [Required, MaxLength(120)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(80)]
    public string City { get; set; } = string.Empty;

    [MaxLength(120)]
    public string ContactPerson { get; set; } = string.Empty;

    [MaxLength(120)]
    public string Email { get; set; } = string.Empty;

    public decimal CommissionRate { get; set; }

    public int ActiveRequests { get; set; }
}
