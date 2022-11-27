using EnocaAssigment.Domain.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaAssignment.Application.Context
{
    public class MasterContext:DbContext
    {
        public MasterContext()
        {

        }
        public DbSet<FilmModel> FilmModels { get; set; }
        public DbSet<FilmHallModel> FilmHallModels { get; set; }
        public DbSet<FilmSessionModel> FilmSeassionModels { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=MSI\\MSSQLSERVER01;Database=moviedb;Trusted_Connection=True;");
        }
    }
}
