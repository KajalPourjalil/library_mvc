var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();//injects all the services required by the Map controller method

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
