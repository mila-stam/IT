using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3._1.Models
{
    public class Patient
    {
        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; }
        public string Gender { get; set; }
        //[RegularExpression(@"^\d{5}$", ErrorMessage = "The code must be 5 digits")]
        [Display(Name = "Kod na pacientot")]
        public int PatientCode { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
        public Patient() {
            Doctors = new List<Doctor>();
        }
    }
}