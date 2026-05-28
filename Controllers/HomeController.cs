using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelOperator.Data;
using TravelOperator.Models;

namespace TravelOperator.Controllers;

public class HomeController(TravelOperatorDbContext db) : Controller
{
    private const string AdminPassword = "1254";
    private const string AdminSessionKey = "AdminAuthenticated";

    public async Task<IActionResult> Index()
    {
        ViewData["Shell"] = "Public";
        return View(await BuildDashboardModel());
    }

    public async Task<IActionResult> Customer()
    {
        ViewData["Shell"] = "Public";
        return View(await BuildDashboardModel());
    }

    public async Task<IActionResult> Business()
    {
        ViewData["Shell"] = "Public";
        return View(await BuildDashboardModel());
    }

    public async Task<IActionResult> Offers()
    {
        ViewData["Shell"] = "Public";
        return View(await BuildDashboardModel());
    }

    public IActionResult Tour(string id)
    {
        ViewData["Shell"] = "Public";
        var tour = TourCatalog.Items.FirstOrDefault(item => item.Slug == id) ?? TourCatalog.Items.First();
        return View(tour);
    }

    public async Task<IActionResult> Admin()
    {
        if (HttpContext.Session.GetString(AdminSessionKey) != "true")
        {
            return RedirectToAction(nameof(Index));
        }

        ViewData["Shell"] = "Admin";
        return View(await BuildDashboardModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult AdminLogin(string password)
    {
        if (password == AdminPassword)
        {
            HttpContext.Session.SetString(AdminSessionKey, "true");
            return RedirectToAction(nameof(Admin));
        }

        TempData["Toast"] = "Неверный пароль администратора";
        return RedirectToAction(nameof(Index));
    }

    private async Task<DashboardViewModel> BuildDashboardModel()
    {
        return new DashboardViewModel
        {
            Tours = await db.Tours.OrderBy(tour => tour.StartDate).ToListAsync(),
            Requests = await db.BookingRequests.OrderByDescending(request => request.CreatedAt).ToListAsync(),
            Agencies = await db.Agencies.OrderByDescending(agency => agency.ActiveRequests).ToListAsync()
        };
    }
}
