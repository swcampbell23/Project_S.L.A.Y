using System;
using System.ComponentModel.DataAnnotations;

namespace Project_S.L.A.Y.Models
{

    public class Supplier
    {
        public Int32 SupplierID { get; set; }

        [Display(Name = "Supplier Name:")]
        [Required(ErrorMessage = "Supplier Name is Required")]
        public String SupplierName { get; set; }

        [Display(Name = "Supplier Email:")]
        [Required(ErrorMessage = "Supplier Email is Required")]
        public String Email { get; set; }

        [Display(Name = "Supplier Phone Number:")]
        [Required(ErrorMessage = "Supplier Phone Number is Required")]
        public String PhoneNumber { get; set; }

        public List<Product> Products { get; set; }

        public Supplier()
        {
            if (Products == null)
            {
                Products = new List<Product>();
            }
        }
    }
}