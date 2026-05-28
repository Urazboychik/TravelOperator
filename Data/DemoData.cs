using TravelOperator.Models;

namespace TravelOperator.Data;

public static class DemoData
{
    public static void Seed(TravelOperatorDbContext db)
    {
        if (db.Tours.Any())
        {
            return;
        }

        var tours = new[]
        {
            new TourPackage
            {
                Name = "Золотое кольцо Премиум",
                Destination = "Россия, Золотое кольцо",
                TourType = "Культурный",
                StartDate = DateOnly.FromDateTime(DateTime.Today.AddDays(18)),
                EndDate = DateOnly.FromDateTime(DateTime.Today.AddDays(25)),
                PricePerPerson = 92000,
                Capacity = 36,
                BookedSeats = 21,
                Status = "Активен"
            },
            new TourPackage
            {
                Name = "Алтай Adventure",
                Destination = "Россия, Алтай",
                TourType = "Активный",
                StartDate = DateOnly.FromDateTime(DateTime.Today.AddDays(42)),
                EndDate = DateOnly.FromDateTime(DateTime.Today.AddDays(51)),
                PricePerPerson = 146000,
                Capacity = 24,
                BookedSeats = 19,
                Status = "Горящий"
            },
            new TourPackage
            {
                Name = "Сочи для семьи",
                Destination = "Россия, Сочи",
                TourType = "Семейный",
                StartDate = DateOnly.FromDateTime(DateTime.Today.AddDays(30)),
                EndDate = DateOnly.FromDateTime(DateTime.Today.AddDays(40)),
                PricePerPerson = 118000,
                Capacity = 48,
                BookedSeats = 32,
                Status = "Активен"
            }
        };

        var agencies = new[]
        {
            new PartnerAgency
            {
                Name = "Travel North",
                City = "Moscow",
                ContactPerson = "Anna Petrova",
                Email = "agency-north@example.com",
                CommissionRate = 8.5m,
                ActiveRequests = 14
            },
            new PartnerAgency
            {
                Name = "Sun Route",
                City = "Kazan",
                ContactPerson = "Dmitry Volkov",
                Email = "sunroute@example.com",
                CommissionRate = 7.0m,
                ActiveRequests = 9
            },
            new PartnerAgency
            {
                Name = "Siberia Trip",
                City = "Novosibirsk",
                ContactPerson = "Elena Smirnova",
                Email = "siberiatrip@example.com",
                CommissionRate = 9.0m,
                ActiveRequests = 6
            }
        };

        var requests = new[]
        {
            new BookingRequest
            {
                CustomerName = "Ivan Sokolov",
                TourName = "Altai Adventure",
                AgencyName = "Siberia Trip",
                Travelers = 4,
                TotalAmount = 584000,
                Stage = "Confirmed",
                CreatedAt = DateTime.UtcNow.AddDays(-2)
            },
            new BookingRequest
            {
                CustomerName = "Maria Orlova",
                TourName = "Black Sea Family",
                AgencyName = "Sun Route",
                Travelers = 3,
                TotalAmount = 354000,
                Stage = "Negotiation",
                CreatedAt = DateTime.UtcNow.AddDays(-1)
            },
            new BookingRequest
            {
                CustomerName = "Corporate Group Meridian",
                TourName = "Золотое кольцо Премиум",
                AgencyName = "Travel North",
                Travelers = 12,
                TotalAmount = 1104000,
                Stage = "New",
                CreatedAt = DateTime.UtcNow.AddHours(-8)
            }
        };

        db.Tours.AddRange(tours);
        db.Agencies.AddRange(agencies);
        db.BookingRequests.AddRange(requests);
        db.SaveChanges();
    }
}
