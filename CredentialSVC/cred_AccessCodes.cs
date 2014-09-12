namespace CredentialSVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cred_AccessCodes
    {
        public cred_AccessCodes()
        {
            cred_Credentials = new HashSet<cred_Credentials>();
        }

        [Key]
        [StringLength(3)]
        public string AccessCode { get; set; }

        [StringLength(50)]
        public string AccessTitle { get; set; }

        public virtual ICollection<cred_Credentials> cred_Credentials { get; set; }
    }
}
