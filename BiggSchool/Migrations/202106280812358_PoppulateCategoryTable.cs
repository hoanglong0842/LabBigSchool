namespace BiggSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PoppulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (1, 'Development')");
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (2, 'Business')");
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (3, 'Maketing')");
        }
        
        public override void Down()
        {
        }
    }
}
