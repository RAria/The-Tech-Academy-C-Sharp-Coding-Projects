namespace CarInsurance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFullCoverage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "FullCoverage", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "FullCoverage");
        }
    }
}
