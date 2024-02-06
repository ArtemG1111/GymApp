using GymApp.BusinessLogic.Interfaces;
using GymApp.BusinessLogic.Services;
using GymApp.DataAccess.Data;
using GymApp.DataAccess.Interfaces;
using GymApp.DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using GymApp.WEB.Common.Mapping;
using AutoMapper;

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


var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseRouting();
app.MapControllers();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.Run();