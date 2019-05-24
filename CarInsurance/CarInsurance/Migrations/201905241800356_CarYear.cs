namespace CarInsurance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarYear : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "CarYear");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CarYear", c => c.DateTime(nullable: false));
        }
    }
}
