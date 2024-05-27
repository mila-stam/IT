using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3._1.Models
{
    public class Doctor
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
        public Doctor () {
            Patients = new List<Patient> ();
        }
    }
}