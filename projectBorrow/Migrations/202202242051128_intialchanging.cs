namespace projectBorrow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intialchanging : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        SND = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        warranty = c.String(),
                        TypePremium = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SND);
            
            CreateTable(
                "dbo.premium_long",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LoanAmount = c.Single(nullable: false),
                        LoanPercentage = c.Single(nullable: false),
                        PremiumAmountMonthly = c.Single(nullable: false),
                        StartMonth = c.Int(nullable: false),
                        SND = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.SND)
                .Index(t => t.SND);
            
            CreateTable(
                "dbo.premium_monthly",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LoanAmount = c.Single(nullable: false),
                        LoanPercentage = c.Single(nullable: false),
                        TotalReturnMoney = c.Single(nullable: false),
                        NumberOfMonth = c.Int(nullable: false),
                        PremiumAmountMonthly = c.Single(nullable: false),
                        NumberOfMonthPay = c.Int(nullable: false),
                        NumberOfMonthNotPay = c.Int(nullable: false),
                        StartMonth = c.Int(nullable: false),
                        EndMonth = c.Int(nullable: false),
                        SND = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.SND)
                .Index(t => t.SND);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.premium_monthly", "SND", "dbo.Customers");
            DropForeignKey("dbo.premium_long", "SND", "dbo.Customers");
            DropIndex("dbo.premium_monthly", new[] { "SND" });
            DropIndex("dbo.premium_long", new[] { "SND" });
            DropTable("dbo.Users");
            DropTable("dbo.premium_monthly");
            DropTable("dbo.premium_long");
            DropTable("dbo.Customers");
        }
    }
}
