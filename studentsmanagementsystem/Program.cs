using Microsoft.EntityFrameworkCore;
using studentsmanagementsystem.Context;
using Microsoft.Extensions.Configuration;
using System;


// Add services to the container.
builder.Services.AddControllersWithViews();
var builder = WebApplication.CreateBuilder(args);


//Register DBContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{


    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
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
    pattern: "{controller=Students}/{action=Index}/{id?}");

app.Run();
