﻿using CoronaVirusCountryApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaVirusCountryApi.Data
{
    public static class MigrateDb
    {
        public static IHost MigrateDatabase<T>(this IHost host) where T : DbContext
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var db = services.GetRequiredService<T>();
                    db.Database.Migrate();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return host;
        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .HasData(new Country()
                {
                    Id = 1,
                    Name = "ایران",
                    ContinentId = 1,
                    DeathNo = 13500,
                    InfectedNo = 300000,
                    RecoveredNo = 250000,
                    RefreshDate = DateTime.UtcNow
                }, new Country()
                {
                    Id = 2,
                    Name = "ایالات متحده آمریکا",
                    ContinentId = 2,
                    DeathNo = 13500,
                    InfectedNo = 300000,
                    RecoveredNo = 250000,
                    RefreshDate = DateTime.UtcNow
                }, new Country()
                {
                    Id = 3,
                    Name = "انگلیس",
                    ContinentId = 5,
                    DeathNo = 100000,
                    InfectedNo = 2000000,
                    RecoveredNo = 1100000,
                    RefreshDate = DateTime.UtcNow
                }, new Country()
                {
                    Id = 4,
                    Name = "سیدنی",
                    ContinentId = 4,
                    DeathNo = 5000,
                    InfectedNo = 30000,
                    RecoveredNo = 20000,
                    RefreshDate = DateTime.UtcNow
                });
        }
    }
}
