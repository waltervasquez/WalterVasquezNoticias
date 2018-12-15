namespace DBContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizacionnoticias1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.News", "Content", c => c.String(nullable: false, maxLength: 400));
            AlterColumn("dbo.News", "Image", c => c.String(nullable: false, maxLength: 300));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.News", "Image", c => c.String(nullable: false, maxLength: 400));
            AlterColumn("dbo.News", "Content", c => c.String(nullable: false, maxLength: 300));
        }
    }
}
