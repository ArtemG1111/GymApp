﻿
using GymApp.DataAccess.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GymApp.DataAccess.Data
{
    public class GymAppContext : IdentityDbContext<Client>
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<FinancialOperation> FinancialOperations { get; set; }
        public GymAppContext(DbContextOptions<GymAppContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
