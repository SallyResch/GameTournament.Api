using GameTournament.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.Extensions.DependencyInjection;
using GameTournament.Api.Extensions;
using GameTournament.Core.Repositories;
using GameTournament.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<GameTournamentApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GameTournamentApiContext") ?? throw new InvalidOperationException("Connection string 'GameTournamentApiContext' not found.")));

// Add services to the container.

builder.Services.AddControllers(opt => opt.ReturnHttpNotAcceptable = true)
    .AddNewtonsoftJson()
    .AddXmlDataContractSerializerFormatters();

builder.Services.AddScoped<IUoWRepository,UoWRepository>();
builder.Services.AddAutoMapper(typeof(TournamentMappings));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
await app.SeedDataAsync();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
