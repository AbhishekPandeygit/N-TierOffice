
using BusinessLayer;
using BusinessLayer.Interface;
using DataAccessLayer.Interface;
using DataAccessLayer;
using DataAccessLayer.Models;
using IdentityBhrDev.Repository.Interface;
using IdentityBhrDev.Repository.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options=> options.UseSqlServer(builder.Configuration.
    GetConnectionString("cnn")));

builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();
builder.Services.AddTransient<IEmailSender,EmailSender>();
builder.Services.AddTransient<IUserDA, UserDA>();
builder.Services.AddTransient<IUserBL, UserBL>();

builder.Services.ConfigureApplicationCookie(option =>
{
    option.AccessDeniedPath = "/Account/Login";
    option.LoginPath = "/Account/Login";
    option.LogoutPath = "/Account/Logout";
    option.Cookie.Name = "Authwebapplication";
    option.ExpireTimeSpan = TimeSpan.FromDays(30);
    option.SlidingExpiration = true;

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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();
