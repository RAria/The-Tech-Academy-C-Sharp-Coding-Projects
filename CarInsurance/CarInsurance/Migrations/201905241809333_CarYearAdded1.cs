namespace CarInsurance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarYearAdded1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "CarYear", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "CarYear", c => c.Byte(nullable: false));
        }
    }
}
