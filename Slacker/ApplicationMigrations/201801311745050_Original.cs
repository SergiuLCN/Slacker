namespace Slacker.ApplicationMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Original : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FinancialTracker",
                c => new
                    {
                        TransactionId = c.Long(nullable: false, identity: true),
                        InputValue = c.Int(nullable: false),
                        CurrentDate = c.DateTime(nullable: false, defaultValue:DateTime.Now),
                        SpentGainedStatus = c.Boolean(nullable: false),
                        SpentGainedSource = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FinancialTracker");
        }
    }
}
