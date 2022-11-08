using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Project_SLAY.Models
{
    public enum IsActive { Active, Inactive }
    public class AppUser : IdentityUser
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is Required!")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is Required!")]
        public String LastName { get; set; }

        [Display(Name = "Middle Initial")]
        public String MI { get; set; }

        [Display(Name = "Address")]
        public String Address { get; set; }

        [Display(Name = "City")]
        public String City { get; set; }

        [Display(Name = "State")]
        public String State { get; set; }

        [Display(Name = "ZipCode")]
        public String ZipCode { get; set; }

        [Display(Name = "Date of Birth")]
        public String DOB { get; set; }
        public IsActive IsActive { get; set; }
        public List<Account> Accounts { get; set; }
        public StockPortfolio StockPortfolio { get; set; }
        public AppUser()
        {
            if (Accounts == null)
            {
                Accounts = new List<Account>();
            }
        }
    }
}
