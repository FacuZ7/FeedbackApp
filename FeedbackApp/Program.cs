using Business;
using Business.Interfaces;
using Business.Presenter;
using Entity.Entities;
using Infrastructure;
using Infrastructure.Data;
using Infrastructure_SQLServer.Models;
using Infrastructure_SQLServer.Presenters;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Dependencias
builder.Services.AddDbContext<FeedbackAppDbContext>(options => 
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<IRepository<Entity.Entities.Participante>, Repository>();
builder.Services.AddScoped<IPresenter<Entity.Entities.Participante, ParticipanteViewModel>, ParticipantePresenter>();
builder.Services.AddScoped<ParticipanteService<Entity.Entities.Participante, ParticipanteViewModel>>();

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
