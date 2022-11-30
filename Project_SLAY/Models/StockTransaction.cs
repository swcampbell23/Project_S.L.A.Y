using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Project_SLAY.Models
{
    public enum StockTransactionType { Purchase, Sale}

    public class StockTransaction
    {
        Decimal PURCHASE_FEE = 10.00m;
        Decimal SELLING_FEE = 15.00m;

        public Int32 StockTransactionID { get; set; }
        public Decimal CurrentPrice { get; set; }
        public Int32 Quantity { get; set; }
        public DateTime DateTime { get; set; }
        public StockTransactionType TransactionType { get; set; }
        public StockPortfolio StockPortfolio { get; set; }
        public Stock Stock { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TotalTransactionPrice { get; set; }

        public void CalcTotals()
        {
            if (TransactionType == StockTransactionType.Purchase)
            {
                TotalTransactionPrice = (Quantity * CurrentPrice) + PURCHASE_FEE;
                if (TotalTransactionPrice > StockPortfolio.Balance)
                {
                    throw new Exception("Not enough funds for purchase");
                }
            }

            if (TransactionType == StockTransactionType.Sale)
            {
                TotalTransactionPrice = (Quantity * CurrentPrice) + SELLING_FEE;
            }

        }
    }
}
