namespace InventoryMNG.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InventoryM : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.admin",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        password = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("public.admin");
        }
    }
}
