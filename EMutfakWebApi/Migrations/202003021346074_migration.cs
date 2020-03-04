namespace EMutfakWebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TCKN = c.Int(nullable: false),
                        NameSurname = c.String(),
                        Password = c.String(),
                        PasswordReply = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Rate = c.String(),
                        CalculatedValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
