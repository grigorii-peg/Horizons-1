namespace Horizons.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TourOrders", "Excursion_Id", "dbo.Excursions");
            DropIndex("dbo.TourOrders", new[] { "Excursion_Id" });
            RenameColumn(table: "dbo.TourOrders", name: "Excursion_Id", newName: "ExcursionsId");
            AlterColumn("dbo.TourOrders", "ExcursionsId", c => c.Long(nullable: false));
            CreateIndex("dbo.TourOrders", "ExcursionsId");
            AddForeignKey("dbo.TourOrders", "ExcursionsId", "dbo.Excursions", "Id", cascadeDelete: true);
            DropColumn("dbo.TourOrders", "Excursions");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TourOrders", "Excursions", c => c.String());
            DropForeignKey("dbo.TourOrders", "ExcursionsId", "dbo.Excursions");
            DropIndex("dbo.TourOrders", new[] { "ExcursionsId" });
            AlterColumn("dbo.TourOrders", "ExcursionsId", c => c.Long());
            RenameColumn(table: "dbo.TourOrders", name: "ExcursionsId", newName: "Excursion_Id");
            CreateIndex("dbo.TourOrders", "Excursion_Id");
            AddForeignKey("dbo.TourOrders", "Excursion_Id", "dbo.Excursions", "Id");
        }
    }
}
