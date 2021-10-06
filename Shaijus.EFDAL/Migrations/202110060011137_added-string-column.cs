namespace Shaijus.EFDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedstringcolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Boxes", "Description", c => c.String());
            AddColumn("dbo.Cylinders", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cylinders", "Description");
            DropColumn("dbo.Boxes", "Description");
        }
    }
}
