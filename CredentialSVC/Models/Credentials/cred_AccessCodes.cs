namespace CredentialSVC.Models.Credentials
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cred_AccessCodes")]
    public partial class AccessCode
    {
        public AccessCode()
        {
            Credentials = new HashSet<Credential>();
        }

        [Key]
        [StringLength(3), Column("AccessCode")]
        public string Code { get; set; }

        [StringLength(50)]
        public string AccessTitle { get; set; }

        public virtual ICollection<Credential> Credentials { get; set; }
    }
}
