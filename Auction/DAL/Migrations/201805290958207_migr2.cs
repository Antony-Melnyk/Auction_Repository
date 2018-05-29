namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migr2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "ImgPath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "ImgPath");
        }
    }
}
