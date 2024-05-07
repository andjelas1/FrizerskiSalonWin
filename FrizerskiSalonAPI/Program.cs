using Microsoft.EntityFrameworkCore;
using FrizerskiSalonAPI.FSPristupBazi;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<fzDbContext>(options => options.UseSqlServer("Server=saloni.ckprmyrhcxdh.eu-west-1.rds.amazonaws.com; Database=frizerskisalon;User=admin;Password=mojaSifra2024!;TrustServerCertificate=True;"));
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
