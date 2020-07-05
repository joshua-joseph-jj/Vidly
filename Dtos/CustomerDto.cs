using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }



        // Data Annotations - overwrites default conventions

        [Required(ErrorMessage = "Please enter customer's name")] // with this attribute 'Name' will no longer be nullable
        [StringLength(255)] // will limit the length of the string to 255 characters
        public string Name { get; set; }


        public bool IsSubscribedToNewsletter { get; set; }


        public byte MembershipTypeID { get; set; }


        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}