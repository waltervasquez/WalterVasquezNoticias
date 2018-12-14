namespace DBContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primeraetapaconfiguracionseed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.News",
                c => new
                    {
                        IdNew = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Content = c.String(nullable: false, maxLength: 300),
                        Image = c.String(nullable: false, maxLength: 100),
                        DatePublication = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdNew);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.News");
        }
    }
}
