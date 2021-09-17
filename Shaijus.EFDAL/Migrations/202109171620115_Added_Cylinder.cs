namespace Shaijus.EFDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Cylinder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cylinders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Radius = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cylinders");
        }
    }
}
