namespace MoviesOnLine.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class movies_created : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MoviesId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Duration = c.Single(nullable: false),
                        Year = c.Int(nullable: false),
                        Director = c.String(),
                    })
                .PrimaryKey(t => t.MoviesId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
