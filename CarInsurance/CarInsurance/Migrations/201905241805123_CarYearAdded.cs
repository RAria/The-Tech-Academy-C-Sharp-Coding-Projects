namespace CarInsurance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarYearAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CarYear", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "CarYear");
        }
    }
}
