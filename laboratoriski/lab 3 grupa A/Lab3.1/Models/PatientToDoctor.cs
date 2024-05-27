using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3._1.Models
{
    public class PatientToDoctor
    {
        public int SelectedPatientId { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public List<Patient> Patients { get; set; }
        public PatientToDoctor()
        {
            Patients = new List<Patient>();
        }
    }
}