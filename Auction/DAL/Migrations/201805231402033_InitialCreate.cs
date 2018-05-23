namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auctions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        DateOfStart = c.DateTime(nullable: false),
                        DateOfBuy = c.DateTime(nullable: false),
                        Item_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.Item_Id, cascadeDelete: true)
                .Index(t => t.Item_Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                        Info = c.String(nullable: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NickName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        Balance = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Auctions", "Item_Id", "dbo.Items");
            DropForeignKey("dbo.Items", "User_Id", "dbo.Users");
            DropIndex("dbo.Items", new[] { "User_Id" });
            DropIndex("dbo.Auctions", new[] { "Item_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Items");
            DropTable("dbo.Auctions");
        }
    }
}
