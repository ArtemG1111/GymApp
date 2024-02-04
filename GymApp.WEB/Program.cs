using GymApp.BusinessLogic.Interfaces;
using GymApp.BusinessLogic.Services;
using GymApp.DataAccess.Data;
using GymApp.DataAccess.Interfaces;
using GymApp.DataAccess.Repository;
using GymApp.WEB.Controllers;
using Microsoft.EntityFrameworkCore;

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
    .AddTransient<ClientController>()
    .AddTransient<FinancialOperationController>()
    .AddTransient<SectionController>()
    .AddTransient<SubscriptionController>()
    .AddDbContext<GymAppContext>(options => options.UseSqlite(connectionString));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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