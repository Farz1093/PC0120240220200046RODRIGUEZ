using Microsoft.EntityFrameworkCore;
using PC0120240220200046RODRIGUEZ.DOMAIN.Core.Interfaces;
using PC0120240220200046RODRIGUEZ.DOMAIN.Infrastructure.Data;
using PC0120240220200046RODRIGUEZ.DOMAIN.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var _config = builder.Configuration;
var cnx = _config.GetConnectionString("DevConnection");
builder.Services
    .AddDbContext<EventManagementDbContext>
    (options => options.UseSqlServer(cnx));

builder.Services.AddTransient<IAttendeesRepository, AttendeesRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
