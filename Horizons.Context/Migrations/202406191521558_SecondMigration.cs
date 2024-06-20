namespace Horizons.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TourOrderExcursions", "TourOrder_Id", "dbo.TourOrders");
            DropForeignKey("dbo.TourOrderExcursions", "Excursion_Id", "dbo.Excursions");
            DropIndex("dbo.TourOrderExcursions", new[] { "TourOrder_Id" });
            DropIndex("dbo.TourOrderExcursions", new[] { "Excursion_Id" });
            AddColumn("dbo.TourOrders", "Excursions", c => c.String());
            AddColumn("dbo.TourOrders", "Excursion_Id", c => c.Long());
            CreateIndex("dbo.TourOrders", "Excursion_Id");
            AddForeignKey("dbo.TourOrders", "Excursion_Id", "dbo.Excursions", "Id");
            DropTable("dbo.TourOrderExcursions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TourOrderExcursions",
                c => new
                    {
                        TourOrder_Id = c.Long(nullable: false),
                        Excursion_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.TourOrder_Id, t.Excursion_Id });
            
            DropForeignKey("dbo.TourOrders", "Excursion_Id", "dbo.Excursions");
            DropIndex("dbo.TourOrders", new[] { "Excursion_Id" });
            DropColumn("dbo.TourOrders", "Excursion_Id");
            DropColumn("dbo.TourOrders", "Excursions");
            CreateIndex("dbo.TourOrderExcursions", "Excursion_Id");
            CreateIndex("dbo.TourOrderExcursions", "TourOrder_Id");
            AddForeignKey("dbo.TourOrderExcursions", "Excursion_Id", "dbo.Excursions", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TourOrderExcursions", "TourOrder_Id", "dbo.TourOrders", "Id", cascadeDelete: true);
        }
    }
}
