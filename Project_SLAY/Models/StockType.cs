namespace Project_SLAY.Models
{
    public class StockType
    {
        public Int32 StockTypeID { get; set; }
        public String TypeName { get; set; }
        public List<Stock> Stocks { get; set; }
        public StockType()
        {
            if (Stocks == null)
            {
                Stocks = new List<Stock>();
            }
        }
    }
}
