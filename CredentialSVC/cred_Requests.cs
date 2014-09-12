namespace CredentialSVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cred_Requests
    {
        [Key]
        public int RequestID { get; set; }

        public int OrderDetailID { get; set; }

        public int GuestID { get; set; }

        public int EventID { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(1000)]
        public string Comments { get; set; }

        public virtual cred_Events cred_Events { get; set; }

        public virtual cred_Guests cred_Guests { get; set; }

        public virtual cred_OrderDetails cred_OrderDetails { get; set; }
    }
}
