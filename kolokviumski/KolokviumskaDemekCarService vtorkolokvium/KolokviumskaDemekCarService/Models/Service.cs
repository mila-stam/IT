using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KolokviumskaDemekCarService.Models
{
    public class Service
    {
        [Key] public int Id { get; set; }
        public string Type { get; set; }
        public virtual Mechanic Mechanic { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
        public Service() {
            Cars = new List<Car>();
        }
    }
}