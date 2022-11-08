namespace Project_SLAY.Models
{
    public enum TransactionType { Purchase, Sale}
    public class StockTransaction
    {
        public Int32 StockTransactionID { get; set; }
        public Decimal CurrentPrice { get; set; }
        public Int32 Quantity { get; set; }
        public DateTime DateTime { get; set; }
        public Decimal Fees { get; set; }
        public TransactionType TransactionType { get; set; }
        public StockPortfolio StockPortfolio { get; set; }
        public Stock Stock { get; set; }
    }
}
