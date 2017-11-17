using System;
using System.Collections.Generic;
using ExamApp.Models;
using ExamApp.Repositories;

namespace ExamApp.Services
{
    public class CarService
    {
        readonly CarRepository repo;

        public CarService(CarRepository repo)
        {
            this.repo = repo;
        }

        public ICollection<Car> GetByPlate(string plate)
        {
            return repo.GetByPlate(plate);
        }

        public ICollection<Car> GetByBrand(string brand)
        {
            return repo.ListByBrand(brand);
        }
    }
}
