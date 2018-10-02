namespace EFModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version1_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CreditCards",
                c => new
                    {
                        CardNumber = c.String(nullable: false, maxLength: 128),
                        ExpirationDate = c.DateTime(nullable: false),
                        CardHolderName = c.String(),
                        EmployeeID = c.Int(),
                    })
                .PrimaryKey(t => t.CardNumber)
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .Index(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CreditCards", "EmployeeID", "dbo.Employees");
            DropIndex("dbo.CreditCards", new[] { "EmployeeID" });
            DropTable("dbo.CreditCards");
        }
    }
}
