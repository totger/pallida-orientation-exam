using System;
using System.Collections.Generic;
using System.Linq;
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

        public ICollection<Car> GetPoliceCars()
        {
            //return repo.GetByPlate("RB");
            return repo.GetAllCars().Where(p => p.Plate.StartsWith("RB")).ToList();
        }

        public ICollection<Car> GetDiplomatCars()
        {
            return repo.GetAllCars().Where(p => p.Plate.StartsWith("DT")).ToList();
        }
    }
}
