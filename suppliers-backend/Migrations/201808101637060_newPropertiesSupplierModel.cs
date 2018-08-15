namespace suppliers_backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newPropertiesSupplierModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SupplierModels", "LastName", c => c.String(nullable: false));
            AddColumn("dbo.SupplierModels", "Address", c => c.String());
            AddColumn("dbo.SupplierModels", "Count", c => c.String());
            DropColumn("dbo.SupplierModels", "LasstName");
            DropColumn("dbo.SupplierModels", "Address1");
            DropColumn("dbo.SupplierModels", "Address2");
            DropColumn("dbo.SupplierModels", "PostalCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SupplierModels", "PostalCode", c => c.String());
            AddColumn("dbo.SupplierModels", "Address2", c => c.String());
            AddColumn("dbo.SupplierModels", "Address1", c => c.String());
            AddColumn("dbo.SupplierModels", "LasstName", c => c.String(nullable: false));
            DropColumn("dbo.SupplierModels", "Count");
            DropColumn("dbo.SupplierModels", "Address");
            DropColumn("dbo.SupplierModels", "LastName");
        }
    }
}
