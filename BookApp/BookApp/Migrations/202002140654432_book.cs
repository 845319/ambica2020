namespace BookApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class book : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Author",
                c => new
                    {
                        aid = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        address = c.String(),
                    })
                .PrimaryKey(t => t.aid);
            
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        bid = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        price = c.Double(nullable: false),
                        aid_aid = c.Int(),
                    })
                .PrimaryKey(t => t.bid)
                .ForeignKey("dbo.Author", t => t.aid_aid)
                .Index(t => t.aid_aid);
            
            CreateTable(
                "dbo.Detail",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        bid = c.Int(nullable: false),
                        aid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Author", t => t.aid, cascadeDelete: true)
                .ForeignKey("dbo.Book", t => t.bid, cascadeDelete: true)
                .Index(t => t.bid)
                .Index(t => t.aid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Detail", "bid", "dbo.Book");
            DropForeignKey("dbo.Detail", "aid", "dbo.Author");
            DropForeignKey("dbo.Book", "aid_aid", "dbo.Author");
            DropIndex("dbo.Detail", new[] { "aid" });
            DropIndex("dbo.Detail", new[] { "bid" });
            DropIndex("dbo.Book", new[] { "aid_aid" });
            DropTable("dbo.Detail");
            DropTable("dbo.Book");
            DropTable("dbo.Author");
        }
    }
}
