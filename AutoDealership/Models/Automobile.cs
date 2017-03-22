using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoDealership.Models
{
    public enum Colors { Red, Orange, Green, White, Silver, Black, LightBlue, DarkBlue, Maroon }
    public enum Makes { Toyota, Ford, Hyundai, Chevrolet, Audi, Acura, Honda, BMW }

    public class Automobile
    {
        [Key]
        public int AutoId { get; set; }
        [Display(Name="Make")]
        public Makes CarMake { get; set; }
        public string Model { get; set; }
        [Display(Name = "Year Released")]
        public int Year { get; set; }
        public Colors Color { get; set; }
    }
}