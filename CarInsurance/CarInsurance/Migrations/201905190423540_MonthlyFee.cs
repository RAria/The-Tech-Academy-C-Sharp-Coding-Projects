namespace CarInsurance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MonthlyFee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MonthlyFee", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "MonthlyFee");
        }
    }
}
