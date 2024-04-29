
using Data.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//ChatAppDBContext
var contextOptions = new DbContextOptionsBuilder<ChatAppDBContext>()
             .UseSqlServer("Data Source=DESKTOP-R40RRQ6;Initial Catalog=ChatApp;User ID=sa;Password=root;MultipleActiveResultSets=True")
             .Options;
builder.Services.AddScoped(s => new ChatAppDBContext(contextOptions));

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
