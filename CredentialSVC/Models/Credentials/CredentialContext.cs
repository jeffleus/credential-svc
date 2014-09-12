namespace CredentialSVC.Models.Credentials
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CredentialContext : DbContext
    {
        public CredentialContext()
            : base("name=CredentialContext")
        {
        }

        public virtual DbSet<AccessCode> AccessCodes { get; set; }
        public virtual DbSet<Credential> Credentials { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public virtual DbSet<Invite> Invites { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<CredentialContext>(null);

            modelBuilder.Entity<AccessCode>()
                .HasMany(e => e.Credentials)
                .WithRequired(e => e.AccessCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Credential>()
                .HasMany(e => e.Invites)
                .WithRequired(e => e.Credential)
                .WillCascadeOnDelete(false);
        }
    }
}
