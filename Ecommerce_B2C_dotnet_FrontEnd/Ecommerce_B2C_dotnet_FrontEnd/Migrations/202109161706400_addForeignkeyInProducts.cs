namespace Ecommerce_B2C_dotnet_FrontEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addForeignkeyInProducts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "UserId", c => c.Long(nullable: false));
            CreateIndex("dbo.Products", "UserId");
            AddForeignKey("dbo.Products", "UserId", "dbo.Accounts", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "UserId", "dbo.Accounts");
            DropIndex("dbo.Products", new[] { "UserId" });
            DropColumn("dbo.Products", "UserId");
        }
    }
}
