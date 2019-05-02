using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CabinetMed.Models
{
    public class Meeting
    {
        public int ID { get; set; }
        [DisplayName("Date Rendez Vous")]
        public DateTime? dateM { get; set; }
        [DisplayName("Patient")]
        public int PatientId { get; set; }
        public virtual Patient patient { get; set; }
        [DisplayName("Remarque")]
        public string Notes { get; set; }
    }
}