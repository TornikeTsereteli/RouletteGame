using Microsoft.EntityFrameworkCore;
using RouletteGame.Email.Application.interfaces;
using RouletteGame.Email.Application.Services;
using RouletteGame.Email.Data.Context;
using RouletteGame.Email.Data.Repositories;
using RouletteGame.Email.Domain.Interfaces;
using RouletteGame.Email.Domain.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();


builder.Services.AddDbContext<EmailDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("EmailDBConnection"));
});

builder.Services.AddSingleton<IEmailSender, EmailSender>();
builder.Services.AddScoped<IEmailTransactionRepository, EmailTransactionRepository>();
builder.Services.AddScoped<IEmailSenderService, EmailSenderService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.UseHttpsRedirection();


app.Run();

