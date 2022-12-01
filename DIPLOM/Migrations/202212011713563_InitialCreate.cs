namespace DIPLOM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dannies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        expId = c.Int(nullable: false),
                        Sh = c.Int(nullable: false),
                        t = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Dannies");
        }
    }
}
