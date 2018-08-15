namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes set Name = 'Pay as You Go' where DurationInMonths = 0");
            Sql("UPDATE MembershipTypes set Name = 'Monthly' where DurationInMonths = 1");
            Sql("UPDATE MembershipTypes set Name = 'Quaterly' where DurationInMonths = 3");
            Sql("UPDATE MembershipTypes set Name = 'Annually' where DurationInMonths = 12");
        }
        
        public override void Down()
        {
        }
    }
}
