namespace CredentialSVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cred_Guests
    {
        public cred_Guests()
        {
            cred_Invites = new HashSet<cred_Invites>();
            cred_OrderDetails = new HashSet<cred_OrderDetails>();
            cred_Requests = new HashSet<cred_Requests>();
        }

        [Key]
        public int GuestID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public DateTime DOB { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(255)]
        public string Affiliation { get; set; }

        public bool isMedia { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public int? CustomerID { get; set; }

        public int? FootballStaffID { get; set; }

        public virtual ICollection<cred_Invites> cred_Invites { get; set; }

        public virtual ICollection<cred_OrderDetails> cred_OrderDetails { get; set; }

        public virtual ICollection<cred_Requests> cred_Requests { get; set; }
    }
}
