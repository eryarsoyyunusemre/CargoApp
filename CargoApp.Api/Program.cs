using CargoApp.Api.Extensions;
using CargoApp.Bll.Abstract;
using CargoApp.Bll.Concrete;
using CargoApp.Dal.Abstract;
using CargoApp.Dal.Context;
using CargoApp.Dal.EntityFramework;
using CargoApp.Dal.Repository;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddServiceExtension();

// MongoDb Connections
var mongoDatabase =
    new MongoClient(builder.Configuration.GetConnectionString("DbConneciton")).GetDatabase(builder.Configuration
        .GetSection("DatabaseName").Value);

builder.Services.AddDbContext<CargoAppContext>(option =>
{
    option.UseMongoDB(mongoDatabase.Client, mongoDatabase.DatabaseNamespace.DatabaseName);
});


// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAllOrigins"); // CORS policy is applied here

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();