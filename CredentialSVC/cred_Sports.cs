namespace CredentialSVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cred_Sports
    {
        [Key]
        [StringLength(3)]
        public string SportCode { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }
    }
}
