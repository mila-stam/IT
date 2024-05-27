using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Razor.Editor;

namespace Lab3._1.Models
{
    public class HospitalToDoctor
    {
        public int SelectedHospitalId { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public List<Hospital> Hospitals { get; set; }
        public HospitalToDoctor()
        {
            Hospitals = new List<Hospital>();
        }
    }
}