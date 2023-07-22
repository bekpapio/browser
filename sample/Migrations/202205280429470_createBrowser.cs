namespace sample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createBrowser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HistoryDataBaseTs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Query = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HistoryDataBaseTs");
        }
    }
}
