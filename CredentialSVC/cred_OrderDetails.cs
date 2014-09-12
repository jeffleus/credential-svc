namespace CredentialSVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cred_OrderDetails
    {
        public cred_OrderDetails()
        {
            cred_Requests = new HashSet<cred_Requests>();
        }

        [Key]
        public int OrderDetailID { get; set; }

        public Guid OrderID { get; set; }

        public int GuestID { get; set; }

        public bool isParkingRequested { get; set; }

        [StringLength(3)]
        public string SuggestedAccess { get; set; }

        [StringLength(1000)]
        public string Comments { get; set; }

        public virtual cred_Guests cred_Guests { get; set; }

        public virtual cred_Orders cred_Orders { get; set; }

        public virtual ICollection<cred_Requests> cred_Requests { get; set; }
    }
}
