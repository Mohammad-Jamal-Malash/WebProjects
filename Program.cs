using Microsoft.EntityFrameworkCore;
using $safeprojectname$.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddMemoryCache();

builder.Services.AddSession();

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BookContext>(options =>

options.UseSqlServer(

builder.Configuration.GetConnectionString("BookContext")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseSession(); //after app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
