namespace suppliers_backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserModels", "FirstName", c => c.String());
            AddColumn("dbo.UserModels", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserModels", "LastName");
            DropColumn("dbo.UserModels", "FirstName");
        }
    }
}
