namespace th_task.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class theatre : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.movies", "theatres_th_name", "dbo.theatres");
            DropIndex("dbo.movies", new[] { "theatres_th_name" });
            CreateTable(
                "dbo.theatremovies",
                c => new
                    {
                        theatre_th_name = c.String(nullable: false, maxLength: 128),
                        movie_movie_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.theatre_th_name, t.movie_movie_id })
                .ForeignKey("dbo.theatres", t => t.theatre_th_name, cascadeDelete: true)
                .ForeignKey("dbo.movies", t => t.movie_movie_id, cascadeDelete: true)
                .Index(t => t.theatre_th_name)
                .Index(t => t.movie_movie_id);
            
            DropColumn("dbo.movies", "theatres_th_name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.movies", "theatres_th_name", c => c.String(maxLength: 128));
            DropForeignKey("dbo.theatremovies", "movie_movie_id", "dbo.movies");
            DropForeignKey("dbo.theatremovies", "theatre_th_name", "dbo.theatres");
            DropIndex("dbo.theatremovies", new[] { "movie_movie_id" });
            DropIndex("dbo.theatremovies", new[] { "theatre_th_name" });
            DropTable("dbo.theatremovies");
            CreateIndex("dbo.movies", "theatres_th_name");
            AddForeignKey("dbo.movies", "theatres_th_name", "dbo.theatres", "th_name");
        }
    }
}
