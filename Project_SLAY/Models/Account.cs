using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_SLAY.Models
{
    public enum AccountType { Checking, Savings, IRA }

    public class Account
    {
        public Int32 AccountID { get; set; }
        public Int32 AccountNo { get; set; }
        public String AccountName { get; set; }
        [Display(Name = "Balance:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal Balance { get; set; }
        public AccountType AccountType { get; set; }
        public AppUser User { get; set; }
        public List<Transaction> Transactions { get; set; }
        public Account()
        {
            if(Transactions == null)
            {
                Transactions = new List<Transaction>();  
            }
        }

    }
}