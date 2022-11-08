using System;
using System.ComponentModel.DataAnnotations;

namespace Project_SLAY.Models
{
    public enum OrderStatus { Pending, Completed }
    public class Order
    {
        private const Decimal TAX_RATE = .0825m;

        public Int32 OrderID { get; set; }

        [Display(Name = "Order Number:")]
        [Required(ErrorMessage = "Order Number is Required")]
        public Int32 OrderNumber { get; set; }

        [Display(Name = "Order Date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "OrderNotes:")]
        public String? OrderNotes { get; set; }

        [Display(Name = "Order Status:")]
        public OrderStatus Status { get; set; }

        [Display(Name = "Order Subtotal")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderSubtotal
        {
            get { return OrderDetails.Sum(rd => rd.ExtendedPrice); }
        }

        [Display(Name = "Tax Rate (15%)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TaxRate
        {
            get { return OrderSubtotal * TAX_RATE; }
        }

        [Display(Name = "Order Total")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderTotal
        {
            get { return OrderSubtotal + TaxRate; }
        }

        public List<OrderDetail> OrderDetails { get; set; }

        public AppUser User { get; set; }

        public Order()
        {
            if (OrderDetails == null)
            {
                OrderDetails = new List<OrderDetail>();
            }
        }

    }
}