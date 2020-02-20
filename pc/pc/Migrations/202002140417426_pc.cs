namespace pc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.customer",
                c => new
                    {
                        cid = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        quality = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cid);
            
            CreateTable(
                "dbo.product",
                c => new
                    {
                        pid = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        price = c.Double(nullable: false),
                        cid_cid = c.Int(),
                    })
                .PrimaryKey(t => t.pid)
                .ForeignKey("dbo.customer", t => t.cid_cid)
                .Index(t => t.cid_cid);
            
            CreateTable(
                "dbo.purchase",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        cid = c.Int(nullable: false),
                        pid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.customer", t => t.cid, cascadeDelete: true)
                .ForeignKey("dbo.product", t => t.pid, cascadeDelete: true)
                .Index(t => t.cid)
                .Index(t => t.pid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.purchase", "pid", "dbo.product");
            DropForeignKey("dbo.purchase", "cid", "dbo.customer");
            DropForeignKey("dbo.product", "cid_cid", "dbo.customer");
            DropIndex("dbo.purchase", new[] { "pid" });
            DropIndex("dbo.purchase", new[] { "cid" });
            DropIndex("dbo.product", new[] { "cid_cid" });
            DropTable("dbo.purchase");
            DropTable("dbo.product");
            DropTable("dbo.customer");
        }
    }
}
