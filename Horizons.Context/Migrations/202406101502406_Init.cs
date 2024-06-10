namespace Horizons.Context.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Excursions",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    Title = c.String(nullable: false, maxLength: 255),
                    Cost = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.TourOrders",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    StartDate = c.DateTime(nullable: false),
                    EndDate = c.DateTime(nullable: false),
                    ClientId = c.Long(nullable: false),
                    PersonCount = c.Int(nullable: false),
                    RoomTypeId = c.Long(nullable: false),
                    TransferId = c.Long(),
                    ManagerId = c.Long(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.ManagerId)
                .ForeignKey("dbo.RoomTypes", t => t.RoomTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Transfers", t => t.TransferId)
                .Index(t => t.ClientId)
                .Index(t => t.RoomTypeId)
                .Index(t => t.TransferId)
                .Index(t => t.ManagerId);

            CreateTable(
                "dbo.Users",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    Fullname = c.String(nullable: false),
                    Login = c.String(nullable: false, maxLength: 255),
                    Password = c.String(nullable: false, maxLength: 255),
                    Salt = c.String(nullable: false, maxLength: 255),
                    RoleId = c.Long(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.Login, unique: true)
                .Index(t => t.RoleId);

            CreateTable(
                "dbo.Roles",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    Title = c.String(nullable: false, maxLength: 255),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.RoomTypes",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    Title = c.String(nullable: false, maxLength: 50),
                    MaxPersonCount = c.Int(nullable: false),
                    NightCost = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Transfers",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    Title = c.String(nullable: false, maxLength: 100),
                    Cost = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.TourOrderExcursions",
                c => new
                {
                    TourOrder_Id = c.Long(nullable: false),
                    Excursion_Id = c.Long(nullable: false),
                })
                .PrimaryKey(t => new { t.TourOrder_Id, t.Excursion_Id })
                .ForeignKey("dbo.TourOrders", t => t.TourOrder_Id, cascadeDelete: true)
                .ForeignKey("dbo.Excursions", t => t.Excursion_Id, cascadeDelete: true)
                .Index(t => t.TourOrder_Id)
                .Index(t => t.Excursion_Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.TourOrders", "TransferId", "dbo.Transfers");
            DropForeignKey("dbo.TourOrders", "RoomTypeId", "dbo.RoomTypes");
            DropForeignKey("dbo.TourOrderExcursions", "Excursion_Id", "dbo.Excursions");
            DropForeignKey("dbo.TourOrderExcursions", "TourOrder_Id", "dbo.TourOrders");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.TourOrders", "ManagerId", "dbo.Users");
            DropForeignKey("dbo.TourOrders", "ClientId", "dbo.Users");
            DropIndex("dbo.TourOrderExcursions", new[] { "Excursion_Id" });
            DropIndex("dbo.TourOrderExcursions", new[] { "TourOrder_Id" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Users", new[] { "Login" });
            DropIndex("dbo.TourOrders", new[] { "ManagerId" });
            DropIndex("dbo.TourOrders", new[] { "TransferId" });
            DropIndex("dbo.TourOrders", new[] { "RoomTypeId" });
            DropIndex("dbo.TourOrders", new[] { "ClientId" });
            DropTable("dbo.TourOrderExcursions");
            DropTable("dbo.Transfers");
            DropTable("dbo.RoomTypes");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.TourOrders");
            DropTable("dbo.Excursions");
        }
    }
}
