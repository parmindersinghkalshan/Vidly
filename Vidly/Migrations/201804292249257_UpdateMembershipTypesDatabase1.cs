namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypesDatabase1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name ='Pay as you go' where Id=1");
            Sql("UPDATE MembershipTypes SET Name ='After every 3 months' where Id=3");
            Sql("UPDATE MembershipTypes SET Name ='Yearly' where Id=4");
        }

        public override void Down()
        {
        }
    }
}
