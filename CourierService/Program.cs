
using CourierService.Core.Contracts;
using CourierService.Core.Services;
using CourierService.Infrastructure.Data;
using CourierService.Infrastructure.Data.Common.Order;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));


builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

var orderConnectionString = builder.Configuration.GetConnectionString("OrderConnection");
builder.Services.AddDbContext<OrderDbContext>(options =>
    options.UseSqlServer(orderConnectionString));




var trackingConnectionString = builder.Configuration.GetConnectionString("TrackingConnection");
builder.Services.AddDbContext<TrackingDbContext>(options =>
    options.UseSqlServer(trackingConnectionString));



var administrationConnectionString = builder.Configuration.GetConnectionString("AdministrationConnection");
builder.Services.AddDbContext<AdministrationDbContext>(options =>
    options.UseSqlServer(administrationConnectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
