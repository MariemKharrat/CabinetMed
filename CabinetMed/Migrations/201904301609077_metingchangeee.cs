namespace CabinetMed.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class metingchangeee : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Meetings", "patient_ID", "dbo.Patients");
            DropIndex("dbo.Meetings", new[] { "patient_ID" });
            RenameColumn(table: "dbo.Meetings", name: "patient_ID", newName: "PatientId");
            AlterColumn("dbo.Meetings", "PatientId", c => c.Int(nullable: false));
            CreateIndex("dbo.Meetings", "PatientId");
            AddForeignKey("dbo.Meetings", "PatientId", "dbo.Patients", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Meetings", "PatientId", "dbo.Patients");
            DropIndex("dbo.Meetings", new[] { "PatientId" });
            AlterColumn("dbo.Meetings", "PatientId", c => c.Int());
            RenameColumn(table: "dbo.Meetings", name: "PatientId", newName: "patient_ID");
            CreateIndex("dbo.Meetings", "patient_ID");
            AddForeignKey("dbo.Meetings", "patient_ID", "dbo.Patients", "ID");
        }
    }
}
