using System;
using System.ComponentModel.DataAnnotations;

namespace Project_SLAY.Models
{
    public enum IsBalanced { Balanced, Unbalance }
    public class StockPortfolio
    {
        public Int32 StockPortfolioID { get; set; }
        public String PortfolioName { get; set; }
        public Decimal Gains { get; set; }
        public Decimal Bonuses { get; set; }
        public IsBalanced IsBalanced { get; set; }
        public AppUser User { get; set; }
        public List<StockTransaction> Transactions { get; set; }

        public StockPortfolio()
        {
            if (Transactions == null)
            {
                Transactions = new List<StockTransaction>();
            }
        }
    }
}