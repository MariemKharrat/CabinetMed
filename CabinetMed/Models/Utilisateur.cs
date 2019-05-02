using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CabinetMed.Models
{
        public class Utilisateur
        {
            [Key]
        public int ID { get; set; }
        [DisplayName("Nom")]
        public String nom_Uti { get; set; }
        [DisplayName("Adress")]
        public String adr_Uti { get; set; }
        [DisplayName("Email")]
        public String email_Uti { get; set; }
        [DisplayName("Password")]
        public String pass_Uti{ get; set; }
        [DisplayName("Tel")]
        public String tel_Uti { get; set; }
    }
}