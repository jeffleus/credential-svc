namespace CredentialSVC.Models.Credentials
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cred_Guests")]
    public partial class Guest
    {
        public Guest()
        {
            Invites = new HashSet<Invite>();
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

        public virtual ICollection<Invite> Invites { get; set; }
    }
}
