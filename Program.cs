using JavaScriptEngineSwitcher.Extensions.MsDependencyInjection;
using JavaScriptEngineSwitcher.V8;
using Microsoft.EntityFrameworkCore;
using React.AspNet;
using SchoolController.Models;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
IConfiguration Configuration = builder.Configuration;
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<SchoolContext>(options =>
{
#pragma warning disable
    string connectstring = Configuration.GetConnectionString("SchoolContext");
#pragma warning restore
    _ = options.UseSqlServer(connectstring);
});
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddReact();

// Make sure a JS engine is registered, or you will get an error!
builder.Services.AddJsEngineSwitcher(options => options.DefaultEngineName = V8JsEngine.EngineName)
  .AddV8();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    _ = app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    _ = app.UseHsts();
}

app.UseHttpsRedirection();

app.UseReact(config =>
            {
                config.AddScript("~/Scripts/HelloWorld.jsx");
            });

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
