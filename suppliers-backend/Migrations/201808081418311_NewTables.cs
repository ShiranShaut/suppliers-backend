namespace suppliers_backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SupplierModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LasstName = c.String(nullable: false),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        Email = c.String(),
                        Phone = c.String(nullable: false),
                        City = c.String(nullable: false),
                        PostalCode = c.String(),
                        CompanyName = c.String(nullable: false),
                        State = c.String(nullable: false),
                        Recommendations = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.MosheModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MosheModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.UserModels");
            DropTable("dbo.SupplierModels");
        }
    }
}
