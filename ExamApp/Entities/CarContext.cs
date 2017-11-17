using System;
using ExamApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamApp.Entities
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {
        }

        public DbSet<Car> licence_plates { get; set; }
    }
}
