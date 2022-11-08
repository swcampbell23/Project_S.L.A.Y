using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Project_SLAY.Models
{

    public class OrderDetail
    {
        public Int32 OrderDetailID { get; set; }

        [Required(ErrorMessage = "You must specify the number of orders")]
        [Display(Name = "Number of orders to fill")]
        [Range(1, 1000, ErrorMessage = "Number of students must be between 1 and 1000")]
        public Int32 Quantity { get; set; }

        [Display(Name = "Product Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal ProductPrice { get; set; }

        [Display(Name = "Extended Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal ExtendedPrice { get; set; }


        public Order Order { get; set; }
        public Product Product { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public AppUser User { get; set; }

    }
}

