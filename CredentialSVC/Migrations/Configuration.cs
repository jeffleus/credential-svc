namespace CredentialSVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CredentialSVC.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        //protected override void Seed(CredentialSVC.Models.ApplicationDbContext context)
        //{
        //    //  This method will be called after migrating to the latest version.

        //    //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
        //    //  to avoid creating duplicate seed data. E.g.
        //    //
        //    //    context.People.AddOrUpdate(
        //    //      p => p.FullName,
        //    //      new Person { FullName = "Andrew Peters" },
        //    //      new Person { FullName = "Brice Lambson" },
        //    //      new Person { FullName = "Rowan Miller" }
        //    //    );
        //    //
        //    context.Credentials.AddOrUpdate(c => c.CredentialID,
        //        new CredentialSVC.Models.Credential
        //        {
        //            CredentialID = 14001,
        //            EventiID = 1401, 
        //            AccessCode = "ALL",
        //            SequenceNumber = "5491"
        //        },
        //        new CredentialSVC.Models.Credential
        //        {
        //            CredentialID = 14002,
        //            EventiID = 1402, 
        //            AccessCode = "ALL",
        //            SequenceNumber = "5481"
        //        });
        //}
    }
}
