using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KolokviumskaDemekCarService.Models
{
    public class Mechanic
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Service> Services { get; set; }

        public Mechanic() { 
            Services = new List<Service>();
        }
    }
}