using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Project_SLAY.Models
{
    public class AppUser : IdentityUser
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage ="First Name is Required!")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is Required!")]
        public String LastName { get; set; }

        [Display(Name = "Middle Initial")]
        public String MI { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Address is Required!")]
        public String Address { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "City is Required!")]
        public String City { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "State is Required!")]
        public String State { get; set; }

        [Display(Name = "ZipCode")]
        [Required(ErrorMessage = "ZipCode is Required!")]
        public String ZipCode { get; set; }

        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "Date of Birth is Required!")]
        public String DOB { get; set; }

        [Display(Name = "Employee Type")]
        [Required(ErrorMessage = "Employee Type is Required!")]
        public String EmployeeType { get; set; }

        // terminal bs

    }
}
