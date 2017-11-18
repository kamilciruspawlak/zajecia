namespace shoping_list.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nazwaMigracji : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TestDBmodels", "OstatniaModyfikacja", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TestDBmodels", "OstatniaModyfikacja");
        }
    }
}
