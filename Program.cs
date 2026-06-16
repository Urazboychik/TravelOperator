using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using TravelOperator.Data;

var builder = WebApplication.CreateBuilder(args);

var port = Environment.GetEnvironmentVariable("PORT");
if (!string.IsNullOrWhiteSpace(port))
{
    builder.WebHost.UseUrls($"http://0.0.0.0:{port}");
}

builder.Services.Configure<ForwardedHeadersOptions>(options =>
{
    options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
    options.KnownNetworks.Clear();
    options.KnownProxies.Clear();
});

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? "Data Source=traveloperator.db";
if (!builder.Environment.IsDevelopment())
{
    var sqliteConnection = new SqliteConnectionStringBuilder(connectionString);
    if (!string.Equals(sqliteConnection.DataSource, ":memory:", StringComparison.OrdinalIgnoreCase) &&
        !Path.IsPathRooted(sqliteConnection.DataSource))
    {
        var sourcePath = Path.Combine(AppContext.BaseDirectory, sqliteConnection.DataSource);
        var targetPath = Path.Combine(Path.GetTempPath(), Path.GetFileName(sqliteConnection.DataSource));

        if (File.Exists(sourcePath) && !File.Exists(targetPath))
        {
            File.Copy(sourcePath, targetPath);
        }

        sqliteConnection.DataSource = targetPath;
        connectionString = sqliteConnection.ToString();
    }
}

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<TravelOperatorDbContext>(options =>
    options.UseSqlite(connectionString));
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromHours(2);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<TravelOperatorDbContext>();
    db.Database.EnsureCreated();
    DemoData.Seed(db);
}

if (!app.Environment.IsDevelopment())
{
    app.UseForwardedHeaders();
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
    app.UseHttpsRedirection();
}
app.UseStaticFiles();
app.UseRouting();
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
