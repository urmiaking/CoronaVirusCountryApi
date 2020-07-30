﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoronaVirusCountryApi.Models;

namespace CoronaVirusCountryApi.Data
{
    public class CoronaVirusCountryApiContext : DbContext
    {
        public CoronaVirusCountryApiContext (DbContextOptions<CoronaVirusCountryApiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Country { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
