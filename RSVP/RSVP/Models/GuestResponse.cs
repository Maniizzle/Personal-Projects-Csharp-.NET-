using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RSVP.Models
{
    public class GuestResponse
    {
        [Required]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter your Email")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="Please enter a Valid email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="PLEase enter your Phone No")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Please specify whether you will attend")]
        public bool? WillAttend { get; set; }
    }   
}
