using Microsoft.EntityFrameworkCore;
using SchoolController.Models;

var builder = WebApplication.CreateBuilder(args);
IConfiguration Configuration = builder.Configuration;
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<SchoolContext>(options =>
{
#pragma warning disable
    string connectstring = Configuration.GetConnectionString("SchoolContext");
#pragma warning restore
    options.UseSqlServer(connectstring);
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();