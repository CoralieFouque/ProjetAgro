using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Nomenclatures
{
    public class NomenclaturesContext : DbContext
    {
        public DbSet<MatierePremiere> MatierePremiere { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.;Database=Nomenclatures;Trusted_Connection=True");
        }
    }
}