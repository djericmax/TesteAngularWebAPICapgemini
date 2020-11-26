using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TesteCapgeminiWebApi.Models;

namespace TesteCapgeminiWebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Excel> Excel { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Excel>()
                .HasData(new List<Excel>(){
                    new Excel(1, Convert.ToDateTime("20-04-2020"), "Descrição 1", 1, 10),
                    new Excel(2, Convert.ToDateTime("21/04/2020"), "Descrição 2", 2, 11),
                    new Excel(3, Convert.ToDateTime("22/04/2020"), "Descrição 3", 3, 12),
                    new Excel(4, Convert.ToDateTime("23/04/2020"), "Descrição 4", 4, 13),
                    new Excel(5, Convert.ToDateTime("24/04/2020"), "Descrição 5", 5, 14),
                    new Excel(6, Convert.ToDateTime("25/04/2020"), "Descrição 6", 6, 15)
                });         
           
        }
    }
}