namespace CredentialSVC.Models.Credentials
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cred_Credentials")]
    public partial class Credential
    {
        public Credential()
        {
            //Invites = new HashSet<Invite>();
        }

        [Key]
        public int CredentialID { get; set; }

        public int EventID { get; set; }

        [Required]
        [StringLength(3), Column("AccessCode")]
        public string Code { get; set; }

        [Required]
        [StringLength(5)]
        public string SequenceNumber { get; set; }

        public virtual AccessCode AccessCode { get; set; }

        public virtual Event Event { get; set; }

        //public virtual ICollection<Invite> Invites { get; set; }
    }
}
