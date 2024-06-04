using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KolokviumskaDemekCarService.Models
{
    public class Car
    {
        [Key] public int Id {  get; set; }
        [Required] public string Name { get; set; }
        public string ImageUrl { get; set; }

        [RegularExpression(@"^.{17}$", ErrorMessage ="Must be 17 chars")] 
        public string VIN {  get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public Car()
        {
            Services = new List<Service>();
        }

    }
}