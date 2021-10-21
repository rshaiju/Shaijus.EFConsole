namespace Shaijus.EFDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedcity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 1000, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Colleges", "CityId", c => c.Int(nullable: false));
            CreateIndex("dbo.Colleges", "CityId");
            AddForeignKey("dbo.Colleges", "CityId", "dbo.Cities", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Colleges", "CityId", "dbo.Cities");
            DropIndex("dbo.Colleges", new[] { "CityId" });
            DropColumn("dbo.Colleges", "CityId");
            DropTable("dbo.Cities");
        }
    }
}
