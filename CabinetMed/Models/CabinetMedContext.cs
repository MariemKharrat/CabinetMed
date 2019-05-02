using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CabinetMed.Models
{
    public class CabinetMedContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CabinetMedContext() : base("name=CabinetMedContext")
        {
        }

        public System.Data.Entity.DbSet<CabinetMed.Models.Utilisateur> Utilisateurs { get; set; }

        public System.Data.Entity.DbSet<CabinetMed.Models.Patient> Patients { get; set; }

        public System.Data.Entity.DbSet<CabinetMed.Models.Medicament> Medicaments { get; set; }

        public System.Data.Entity.DbSet<CabinetMed.Models.FamilleMed> FamilleMeds { get; set; }

        public System.Data.Entity.DbSet<CabinetMed.Models.Meeting> Meetings { get; set; }
    }
}
