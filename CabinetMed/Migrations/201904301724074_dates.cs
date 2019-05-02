namespace CabinetMed.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Meetings", "dateM", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Meetings", "dateM", c => c.DateTime(nullable: false));
        }
    }
}
