using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SmartSchool_WebAPI.Models;

namespace SmartSchool_WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Excel> Excel { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Excel>()
                .HasData(new List<Excel>(){
                    new Excel(1, "20/04/2020", "Descrição 1", 1, 10.10),
                    new Excel(2, "21/04/2020", "Descrição 2", 2, 11.10),
                    new Excel(3, "22/04/2020", "Descrição 3", 3, 12.10),
                    new Excel(4, "23/04/2020", "Descrição 4", 4, 13.10),
                    new Excel(5, "24/04/2020", "Descrição 5", 5, 14.10),
                    new Excel(6, "25/04/2020", "Descrição 6", 6, 15.10)
                });         
           
        }
    }
}