using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Project_SLAY.Models
{
    public class Stock
    {
        public Int32 StockID { get; set; }
        public String StockName { get; set; }
        public String TickerSymbol { get; set; }
        public Decimal Price { get; set; }
        public StockType StockType { get; set; }
        public List<StockTransaction> StockTransactions {get; set; }
        public Stock()
        {
            if(StockTransactions == null)
            {
                StockTransactions = new List<StockTransaction>();
            }
        }

    }
}

