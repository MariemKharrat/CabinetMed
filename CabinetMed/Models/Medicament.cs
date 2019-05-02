using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CabinetMed.Models
{
    public class Medicament
    {
        public int ID { get; set; }
        public string Designation { get; set; }
        public string Desc { get   ; set; }
        public virtual FamilleMed FamileMe { get; set; }    
    }
}