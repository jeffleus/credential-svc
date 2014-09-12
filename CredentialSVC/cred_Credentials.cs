namespace CredentialSVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cred_Credentials
    {
        public cred_Credentials()
        {
            cred_Invites = new HashSet<cred_Invites>();
        }

        [Key]
        public int CredentialID { get; set; }

        public int EventID { get; set; }

        [Required]
        [StringLength(3)]
        public string AccessCode { get; set; }

        [Required]
        [StringLength(5)]
        public string SequenceNumber { get; set; }

        public virtual cred_AccessCodes cred_AccessCodes { get; set; }

        public virtual cred_Events cred_Events { get; set; }

        public virtual ICollection<cred_Invites> cred_Invites { get; set; }
    }
}
