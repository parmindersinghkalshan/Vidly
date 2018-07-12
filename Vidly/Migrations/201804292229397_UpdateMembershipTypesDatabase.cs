namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypesDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name ='Monthly' where Id=2");
        }

        public override void Down()
        {
        }
    }
}
