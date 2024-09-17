
using College.Core.Implementation;
using College.Core.Interface;
using CollegeDetails.Core.Implementation;
using CollegeDetails.Infra.DataContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
string connections = builder.Configuration.GetConnectionString("CollegeDb");
builder.Services.AddDbContext <CollegeDbContext> (Options=>Options.UseSqlServer(connections));
builder.Services.AddScoped<ICollegeCreator, CollegeCreator>();
builder.Services.AddScoped<IFeesCreator, FeesCreator>();
builder.Services.AddScoped<ICollegeGetter, CollegeGetter>();
builder.Services.AddScoped<ICollegeUpdator, CollegeUpdator>();
builder.Services.AddScoped<ICollegeDeletor, CollegeDeletor>();





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
