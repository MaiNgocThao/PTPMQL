using Microsoft.EntityFrameworkCore;
using DemoMVC.Data;

var builder = WebApplication.CreateBuilder(args);

// 👇 THÊM DÒNG NÀY
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews();

var app = builder.Build();