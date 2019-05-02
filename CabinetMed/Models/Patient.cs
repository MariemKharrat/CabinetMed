using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CabinetMed.Models
{
    public class Patient
    {
        public int ID { get; set; }
        [DisplayName("Nom")]
        public String nom_Pat { get; set; }
        [DisplayName("Adresse")]
        public String adr_Pat { get; set; }
        [DisplayName("Tel")]
        public String tel_Pat { get; set; }
    }
}