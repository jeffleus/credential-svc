namespace CredentialSVC.Models.Credentials
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cred_Events")]
    public partial class Event
    {
        public Event()
        {
            //Credentials = new HashSet<Credential>();
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

        //public virtual ICollection<Credential> Credentials { get; set; }
    }
}
