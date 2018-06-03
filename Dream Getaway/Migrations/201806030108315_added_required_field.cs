namespace Dream_Getaway.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_required_field : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Tours.Packages", "PackageTitle", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("Tours.Packages", "PackageTitle", c => c.String());
        }
    }
}
