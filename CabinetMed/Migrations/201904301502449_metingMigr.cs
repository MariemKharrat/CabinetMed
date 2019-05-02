namespace CabinetMed.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class metingMigr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Meetings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        dateM = c.DateTime(nullable: false),
                        Notes = c.String(),
                        patient_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Patients", t => t.patient_ID)
                .Index(t => t.patient_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Meetings", "patient_ID", "dbo.Patients");
            DropIndex("dbo.Meetings", new[] { "patient_ID" });
            DropTable("dbo.Meetings");
        }
    }
}
