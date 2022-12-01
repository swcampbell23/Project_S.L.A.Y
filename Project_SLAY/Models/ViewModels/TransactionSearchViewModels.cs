using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;


namespace Project_SLAY.Models
{
    public class TransactionSearchViewModels
    {
        [Display(Name = "Search by description: ")]
        public String? Notes { get; set; } 

        [Display(Name = "Search by type: ")]
        public TransactionType? TransactionType { get; set; }

        //Implement Range Function//
        [Display(Name = "Search by amount(provide a range): ")]
        //[Range(0,1, ErrorMessage = "Quantity must be greater than or equal to zero!")]
        public Decimal? Amount { get; set; }

        [Display(Name = "Search by transaction number: ")]
        public Int32? TransactionNo { get; set; }

        [Display(Name = "Search by date: ")]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy")]
        public DateTime? Date { get; set; }
    }
}
