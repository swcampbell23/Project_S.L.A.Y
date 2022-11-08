using System;
using System.ComponentModel.DataAnnotations;

namespace Project_SLAY.Models
{
    public class Transaction
    {
        public Int32 TransactionID { get; set; }
        public Decimal Amount { get; set; }
        public Account Account { get; set; }
        public DateTime Date { get; set; }
        public String Notes { get; set; }
        public List<Dispute> Disputes { get; set; }
        public Transaction()
        {
            if (Disputes == null)
            {
                Disputes = new List<Dispute>();
            }
        }
    }
}