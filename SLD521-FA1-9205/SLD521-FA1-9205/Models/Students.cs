using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SLD521_FA1_9205.Models
{
    public class Students
    {
        [Key]
        public int Id { get; set; }
        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }
        [Required] public string Address1 { get; set; }
        public string Address2 { get; set; }
        [EmailAddress][Required] public string EmailID { get; set; }
        public string Facilitator { get; set; }
    }
}