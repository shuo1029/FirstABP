namespace FirstABP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialData1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.T_User", "IsEnabled", c => c.Boolean());
            AlterColumn("dbo.T_User", "IsDeleted", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.T_User", "IsDeleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.T_User", "IsEnabled", c => c.Boolean(nullable: false));
        }
    }
}
