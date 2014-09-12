namespace CredentialSVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cred_Orders
    {
        public cred_Orders()
        {
            cred_OrderDetails = new HashSet<cred_OrderDetails>();
        }

        [Key]
        public Guid OrderID { get; set; }

        public int CustomerID { get; set; }

        public DateTime? Started { get; set; }

        public DateTime? Reviewed { get; set; }

        public DateTime? Fulfilled { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(1000)]
        public string Reason { get; set; }

        [StringLength(1000)]
        public string AltInstructions { get; set; }

        [StringLength(1000)]
        public string Comments { get; set; }

        public virtual cred_Customers cred_Customers { get; set; }

        public virtual ICollection<cred_OrderDetails> cred_OrderDetails { get; set; }
    }
}
