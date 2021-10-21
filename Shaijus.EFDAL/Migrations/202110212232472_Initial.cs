namespace Shaijus.EFDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colleges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                        StudyClassId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StudyClasses", t => t.StudyClassId, cascadeDelete: true)
                .Index(t => t.StudyClassId);
            
            CreateTable(
                "dbo.StudyClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                        TeachesInId = c.Int(nullable: false),
                        GraduatedFromCollegeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Colleges", t => t.GraduatedFromCollegeId, cascadeDelete: true)
                .ForeignKey("dbo.StudyClasses", t => t.TeachesInId, cascadeDelete: true)
                .Index(t => t.TeachesInId)
                .Index(t => t.GraduatedFromCollegeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "TeachesInId", "dbo.StudyClasses");
            DropForeignKey("dbo.Teachers", "GraduatedFromCollegeId", "dbo.Colleges");
            DropForeignKey("dbo.Students", "StudyClassId", "dbo.StudyClasses");
            DropIndex("dbo.Teachers", new[] { "GraduatedFromCollegeId" });
            DropIndex("dbo.Teachers", new[] { "TeachesInId" });
            DropIndex("dbo.Students", new[] { "StudyClassId" });
            DropTable("dbo.Teachers");
            DropTable("dbo.StudyClasses");
            DropTable("dbo.Students");
            DropTable("dbo.Colleges");
        }
    }
}
