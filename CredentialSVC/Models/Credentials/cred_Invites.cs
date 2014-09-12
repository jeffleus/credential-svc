namespace CredentialSVC.Models.Credentials
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cred_Invites")]
    public partial class Invite
    {
        [Key]
        public int InviteID { get; set; }

        public int GuestID { get; set; }

        public int CredentialID { get; set; }

        [StringLength(10)]
        public string Status { get; set; }

        [StringLength(50)]
        public string InvitedBy { get; set; }

        public DateTime Entered { get; set; }

        public DateTime Modified { get; set; }

        public DateTime? Admitted { get; set; }

        [StringLength(1000)]
        public string Notes { get; set; }

        public virtual Credential Credential { get; set; }

        public virtual Guest Guest { get; set; }
    }
}
