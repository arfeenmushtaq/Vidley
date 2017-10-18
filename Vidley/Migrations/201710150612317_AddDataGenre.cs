namespace Vidley.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES(NAME) VALUES('Action')");
            Sql("INSERT INTO GENRES(NAME) VALUES('Comedy')");
            Sql("INSERT INTO GENRES(NAME) VALUES('Drama')");
            Sql("INSERT INTO GENRES(NAME) VALUES('Horror')");
        }
        
        public override void Down()
        {
        }
    }
}
