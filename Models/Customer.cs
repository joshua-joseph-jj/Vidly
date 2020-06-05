using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }


        // Data Annotations - overwrites default conventions

        [Required] // with this attribute 'Name' will no longer be nullable
        [StringLength(255)] // will limit the length of the string to 255 characters
        public string Name { get; set; }


        public bool IsSubscribedToNewsletter { get; set; }


        public MembershipType MembershipType { get; set; }


        [Display(Name = "Membership Type")]
        public byte MembershipTypeID { get; set; }


        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }
    }
}