namespace Shaijus.EFDAL.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 1000, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Colleges",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 1000, storeType: "nvarchar"),
                        CityId = c.Long(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_College_ActiveCollege", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 1000, storeType: "nvarchar"),
                        StudyClassId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StudyClasses", t => t.StudyClassId, cascadeDelete: true)
                .Index(t => t.StudyClassId);
            
            CreateTable(
                "dbo.StudyClasses",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 1000, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 1000, storeType: "nvarchar"),
                        TeachesInId = c.Long(nullable: false),
                        GraduatedFromCollegeId = c.Long(nullable: false),
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
            DropForeignKey("dbo.Colleges", "CityId", "dbo.Cities");
            DropIndex("dbo.Teachers", new[] { "GraduatedFromCollegeId" });
            DropIndex("dbo.Teachers", new[] { "TeachesInId" });
            DropIndex("dbo.Students", new[] { "StudyClassId" });
            DropIndex("dbo.Colleges", new[] { "CityId" });
            DropTable("dbo.Teachers");
            DropTable("dbo.StudyClasses");
            DropTable("dbo.Students");
            DropTable("dbo.Colleges",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_College_ActiveCollege", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.Cities");
        }
    }
}
