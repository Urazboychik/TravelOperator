using Microsoft.EntityFrameworkCore;
using TravelOperator.Models;

namespace TravelOperator.Data;

public class TravelOperatorDbContext(DbContextOptions<TravelOperatorDbContext> options) : DbContext(options)
{
    public DbSet<TourPackage> Tours => Set<TourPackage>();

    public DbSet<PartnerAgency> Agencies => Set<PartnerAgency>();

    public DbSet<BookingRequest> BookingRequests => Set<BookingRequest>();
}
