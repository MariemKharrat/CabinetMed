namespace CabinetMed.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FamilleMeds",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Designation = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Medicaments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Designation = c.String(),
                        Desc = c.String(),
                        FamileMe_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FamilleMeds", t => t.FamileMe_ID)
                .Index(t => t.FamileMe_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medicaments", "FamileMe_ID", "dbo.FamilleMeds");
            DropIndex("dbo.Medicaments", new[] { "FamileMe_ID" });
            DropTable("dbo.Medicaments");
            DropTable("dbo.FamilleMeds");
        }
    }
}
