using Bibliotheque.Api;
using Bibliotheque.Business.Abstract;
using Bibliotheque.Business.Concrete;
using Bibliotheque.Entity;
using Bibliotheque.Repository;
using Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApiContext>(opts =>
    {
        var connectionString = builder.Configuration.GetConnectionString("Database");
        opts.UseMySQL(connectionString, mySqlOption =>
            mySqlOption.MigrationsAssembly(typeof(ApiContext).Assembly.FullName));
    })
    .AddTransient<IClientRepository, ClientRepository>()
    .AddTransient<IClientService, ClientService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapEndpoint();

app.Run();



