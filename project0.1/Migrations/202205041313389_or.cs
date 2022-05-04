namespace project0._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class or : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.employesses",
                c => new
                    {
                        eid = c.Int(nullable: false, identity: true),
                        ename = c.String(),
                        gender = c.String(),
                        salary = c.Int(nullable: false),
                        citys = c.String(),
                        post_id = c.Int(),
                    })
                .PrimaryKey(t => t.eid)
                .ForeignKey("dbo.posts", t => t.post_id)
                .Index(t => t.post_id);
            
            CreateTable(
                "dbo.posts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        dept = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.employesses", "post_id", "dbo.posts");
            DropIndex("dbo.employesses", new[] { "post_id" });
            DropTable("dbo.posts");
            DropTable("dbo.employesses");
        }
    }
}
