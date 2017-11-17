using System;
using System.ComponentModel.DataAnnotations;

namespace ExamApp.Models
{
    public class Car
    {
        [MaxLength(7)]
        [Key]
        public string Plate { get; set; }
        public string Car_brand { get; set; }
        public string Car_model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
    }
}
