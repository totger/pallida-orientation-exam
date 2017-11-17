using System;
using Microsoft.EntityFrameworkCore;

namespace ExamApp.Entities
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {
        }
    }
}
