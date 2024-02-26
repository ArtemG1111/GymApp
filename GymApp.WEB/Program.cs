using GymApp.BusinessLogic.Interfaces;
using GymApp.BusinessLogic.Services;
using GymApp.DataAccess.Data;
using GymApp.DataAccess.Interfaces;
using GymApp.DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using GymApp.WEB.Common.Mapping;
using AutoMapper;
using GymApp.DataAccess.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;
using GymApp.WEB.Infrastructure.Middleware.ErrorHandling;
using Hangfire;
using Hangfire.Storage.SQLite;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DeffaultConnection");
builder.Services.AddTransient<IClientRepository, ClientRepository>()
    .AddTransient<IClientService, ClientService>()
    .AddTransient<IFinancialOperationRepository, FinancialOperationRepository>()
    .AddTransient<IFinancialOperationService, FinancialOperationService>()
    .AddTransient<ISectionRepository, SectionRepository>()
    .AddTransient<ISectionService, SectionService>()
    .AddTransient<ISubscriptionRepository, SubscriptionRepository>()
    .AddTransient<ISubscriptionService, SubsctiptionService>()
    .AddDbContext<GymAppContext>(options => options.UseSqlite(connectionString));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(ClientMappingProfile));
builder.Services.AddIdentity<Client, IdentityRole>(opts =>
{
    opts.Password.RequireNonAlphanumeric = false;
    opts.Password.RequireLowercase = false;
    opts.Password.RequireUppercase = false;
    opts.Password.RequireDigit = false;
    opts.Password.RequiredLength = 3;
})
    .AddEntityFrameworkStores<GymAppContext>();
builder.Services.AddHangfire(h => h.UseSQLiteStorage(connectionString));
builder.Services.AddHangfireServer();

var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseRouting();

app.UseHangfireDashboard("/dashboard");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseToken();
app.Run();