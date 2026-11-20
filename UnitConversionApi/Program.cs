using UnitConversionApi.Middleware;
using UnitConversionApi.Repositories;
using UnitConversionApi.Repositories.Interfaces;
using UnitConversionApi.Services;
using UnitConversionApi.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IUnitRepository, UnitRepository>();


builder.Services.AddScoped<IConversionService, ConversionService>();


var app = builder.Build();

app.UseMiddleware<GlobalExceptionMiddleware>();

app.UseSwagger();

app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();