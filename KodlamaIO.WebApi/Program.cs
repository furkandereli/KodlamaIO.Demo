using KodlamaIO.Business.Abstract;
using KodlamaIO.Business.Concrete;
using KodlamaIO.DataAccess.Abstract;
using KodlamaIO.DataAccess.Concrete;
using KodlamaIO.DataAccess.EntityFramework;
using KodlamaIO.DataAccess.ServiceCollections;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<KodlamaIOContext>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.MyCollections();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
