namespace Ecommerce_B2C_dotnet_FrontEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addProductsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductDetail = c.String(),
                        ProductType = c.String(),
                        ProductImage = c.String(),
                        AddingDate = c.DateTime(nullable: false),
                        AvailableStock = c.Long(nullable: false),
                        ProductPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsActive = c.Boolean(),
                        IsDelete = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
