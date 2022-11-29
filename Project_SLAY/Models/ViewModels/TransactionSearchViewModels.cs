using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;


namespace Project_SLAY.Models
{
    public class SearchViewModel
    {
        [Display(Name = "Search by Description: ")]
        public String? Description { get; set; } 

        [Display(Name = "Search by Type: ")]
        public TransactionType? Type { get; set; }

        //Implement Range Function//
        [Display(Name = "Search by Amount Range: ")]
        //[Range(0,1, ErrorMessage = "Quantity must be greater than or equal to zero!")]
        public Decimal? Amount { get; set; }

        [Display(Name = "Search by Transaction Number: ")]
        public Int32? TransactionNo { get; set; }

        [Display(Name = "Search by Date: ")]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy")]
        public DateTime? Date { get; set; }
    }
}
