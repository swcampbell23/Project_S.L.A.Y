using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_SLAY.Models
{
    public enum ProductTyoe { NewHardBack, NewPaperback, UsedHardBack, UsedPaperBack, Other }

    public class Product
    {
        public Int32 ProductID { get; set; }

        [Display(Name = "Product Name:")]
        [Required(ErrorMessage ="Product Name is Required")]
        public String ProductName { get; set; }

        [Display(Name = "Description:")]
        public String ?Descrtiption { get; set; }

        [Required(ErrorMessage ="Price is Required")]
        [Display(Name = "Price:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal Price { get; set; }

        public List<Supplier> Suppliers { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

        public ProductTyoe ProductTyoe { get; set; }

        public Product()
        {
            if (Suppliers == null)
            {
                Suppliers = new List<Supplier>();
            }

            if (OrderDetails == null)
            {
                OrderDetails = new List<OrderDetail>();
            }
        }

    }
}