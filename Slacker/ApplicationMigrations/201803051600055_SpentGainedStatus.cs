namespace Slacker.ApplicationMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SpentGainedStatus : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FinancialTracker", "SpentGainedStatus", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FinancialTracker", "SpentGainedStatus", c => c.Boolean(nullable: false));
        }
    }
}
