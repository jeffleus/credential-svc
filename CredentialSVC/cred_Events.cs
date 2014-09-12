namespace CredentialSVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cred_Events
    {
        public cred_Events()
        {
            cred_Credentials = new HashSet<cred_Credentials>();
            cred_Requests = new HashSet<cred_Requests>();
        }

        [Key]
        public int EventID { get; set; }

        [Required]
        [StringLength(3)]
        public string SportCode { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool isActive { get; set; }

        public virtual ICollection<cred_Credentials> cred_Credentials { get; set; }

        public virtual ICollection<cred_Requests> cred_Requests { get; set; }
    }
}
