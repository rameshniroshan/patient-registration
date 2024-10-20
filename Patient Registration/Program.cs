using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Patient_Registration.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<RegisterDb>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RegisterDb") ?? throw new InvalidOperationException("Connection string 'Patient_RegistrationContext' not found.")));



// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Users}/{action=Signin}/{id?}");

app.Run();
