namespace DBContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizacionnoticias : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.News", "Image", c => c.String(nullable: false, maxLength: 400));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.News", "Image", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
