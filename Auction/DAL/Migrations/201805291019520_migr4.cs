namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migr4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "ImgPath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "ImgPath");
        }
    }
}
