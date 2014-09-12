namespace CredentialSVC
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

        public virtual DbSet<cred_AccessCodes> cred_AccessCodes { get; set; }
        public virtual DbSet<cred_Credentials> cred_Credentials { get; set; }
        public virtual DbSet<cred_Customers> cred_Customers { get; set; }
        public virtual DbSet<cred_Events> cred_Events { get; set; }
        public virtual DbSet<cred_Guests> cred_Guests { get; set; }
        public virtual DbSet<cred_Invites> cred_Invites { get; set; }
        public virtual DbSet<cred_OrderDetails> cred_OrderDetails { get; set; }
        public virtual DbSet<cred_Orders> cred_Orders { get; set; }
        public virtual DbSet<cred_Requests> cred_Requests { get; set; }
        public virtual DbSet<cred_Sports> cred_Sports { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cred_AccessCodes>()
                .Property(e => e.AccessCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cred_AccessCodes>()
                .HasMany(e => e.cred_Credentials)
                .WithRequired(e => e.cred_AccessCodes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cred_Credentials>()
                .Property(e => e.AccessCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cred_Credentials>()
                .Property(e => e.SequenceNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cred_Credentials>()
                .HasMany(e => e.cred_Invites)
                .WithRequired(e => e.cred_Credentials)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cred_Customers>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<cred_Customers>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<cred_Customers>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<cred_Customers>()
                .Property(e => e.Affiliation)
                .IsUnicode(false);

            modelBuilder.Entity<cred_Customers>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<cred_Customers>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<cred_Customers>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<cred_Customers>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<cred_Customers>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<cred_Customers>()
                .Property(e => e.Zip)
                .IsUnicode(false);

            modelBuilder.Entity<cred_Customers>()
                .HasMany(e => e.cred_Orders)
                .WithRequired(e => e.cred_Customers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cred_Events>()
                .Property(e => e.SportCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cred_Events>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<cred_Guests>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<cred_Guests>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<cred_Guests>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<cred_Guests>()
                .Property(e => e.Affiliation)
                .IsUnicode(false);

            modelBuilder.Entity<cred_Guests>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<cred_Guests>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<cred_Invites>()
                .Property(e => e.Status)
                .IsFixedLength();

            modelBuilder.Entity<cred_Invites>()
                .Property(e => e.InvitedBy)
                .IsUnicode(false);

            modelBuilder.Entity<cred_Invites>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<cred_OrderDetails>()
                .Property(e => e.SuggestedAccess)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cred_OrderDetails>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<cred_OrderDetails>()
                .HasMany(e => e.cred_Requests)
                .WithRequired(e => e.cred_OrderDetails)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cred_Orders>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<cred_Orders>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<cred_Orders>()
                .Property(e => e.AltInstructions)
                .IsUnicode(false);

            modelBuilder.Entity<cred_Orders>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<cred_Requests>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<cred_Requests>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<cred_Sports>()
                .Property(e => e.SportCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cred_Sports>()
                .Property(e => e.Title)
                .IsUnicode(false);
        }
    }
}
