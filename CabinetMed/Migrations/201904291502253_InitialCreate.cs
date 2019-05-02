namespace CabinetMed.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        nom_Uti = c.String(),
                        adr_Uti = c.String(),
                        email_Uti = c.String(),
                        pass_Uti = c.String(),
                        tel_Uti = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Utilisateurs");
        }
    }
}
