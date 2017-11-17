﻿using System;
using System.Collections.Generic;
using System.Linq;
using ExamApp.Entities;
using ExamApp.Models;

namespace ExamApp.Repositories
{
    public class CarRepository
    {
        readonly CarContext carContext;

        public CarRepository(CarContext carContext)
        {
            this.carContext = carContext;
        }

        public ICollection<Car> GetByPlate(string plateNumber)
        {
            return carContext.licence_plates.Where(c => c.Plate.Contains(plateNumber)).ToList();
        }

        public ICollection<Car> ListByBrand(string brand)
        {
            return carContext.licence_plates.Where(c => c.Car_brand == brand).ToList();
        }
    }
}
