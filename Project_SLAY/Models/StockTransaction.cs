namespace Project_SLAY.Models
{
    public enum StockTransactionType { Purchase, Sale}
    public class StockTransaction
    {
        public Int32 StockTransactionID { get; set; }
        public Decimal CurrentPrice { get; set; }
        public Int32 Quantity { get; set; }
        public DateTime DateTime { get; set; }
        public Decimal Fees { get; set; }
        public StockTransactionType TransactionType { get; set; }
        public StockPortfolio StockPortfolio { get; set; }
        public Stock Stock { get; set; }
    }
}
