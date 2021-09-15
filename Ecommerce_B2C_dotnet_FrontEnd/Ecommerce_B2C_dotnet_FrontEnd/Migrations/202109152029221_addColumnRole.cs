namespace Ecommerce_B2C_dotnet_FrontEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addColumnRole : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "Gender", c => c.Int());
            AddColumn("dbo.Accounts", "Role", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accounts", "Role");
            DropColumn("dbo.Accounts", "Gender");
        }
    }
}
