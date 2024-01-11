using Microsoft.EntityFrameworkCore;
using SampleCoreWebApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
/////////////////////////Add the DbContext Dependencies/////////////////////////////////
var dbHost = Environment.GetEnvironmentVariable("DB_HOST");//Server name of the database
var dbName = Environment.GetEnvironmentVariable("DB_NAME");
var dbPwd = Environment.GetEnvironmentVariable("DB_PWD");
var dbUser = Environment.GetEnvironmentVariable("DB_USER");
var connection = $"Data Source={dbHost}; Initial Catalog={dbName}; User Id=sa; Password={dbPwd}; Encrypt=false";
builder.Services.AddDbContext<EmployeeDbContext>(options => options.UseSqlServer(connection));
////////////////////////////////////////////////////////////////////////////////////////


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
