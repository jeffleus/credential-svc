using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CredentialSVC.Models
{
    public class Credential
    {
        public int CredentialID { get; set; }
        public int EventiID { get; set; }
        public string AccessCode { get; set; }
        public string SequenceNumber { get; set; }
    }
}