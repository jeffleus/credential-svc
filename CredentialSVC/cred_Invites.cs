namespace CredentialSVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cred_Invites
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

        public virtual cred_Credentials cred_Credentials { get; set; }

        public virtual cred_Guests cred_Guests { get; set; }
    }
}
