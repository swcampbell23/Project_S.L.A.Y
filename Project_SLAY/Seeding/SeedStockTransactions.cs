using Microsoft.AspNetCore.Identity;
using Project_SLAY.DAL;
using Project_SLAY.Models;
using Project_SLAY.Utilities;
using System.Text;

namespace Project_SLAY.Seeding
{
    public static class SeedStockTransactions
    {
        public static void SeedAllStockTransactions(AppDbContext context)
        {
            List<StockTransaction> AllStockTransactions = new List<StockTransaction>();
            AllStockTransactions.Add(new StockTransaction
            {
                TransactionType = StockTransactionType.Purchase,
                StockPortfolio = context.StockPortfolios.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000024)),
                CurrentPrice = 145.03m,
                Quantity = 10,
                DateTime = new DateTime(2022, 4, 1),
                Stock = context.Stocks.FirstOrDefault(l => l.TickerSymbol == "AAPL"),

            });
            AllStockTransactions.Add(new StockTransaction
            {
                TransactionType = StockTransactionType.Purchase,
                StockPortfolio = context.StockPortfolios.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000024)),
                CurrentPrice = 321.36m,
                Quantity = 5,
                DateTime = new DateTime(2022, 4, 3),
                Stock = context.Stocks.FirstOrDefault(l => l.TickerSymbol == "DIA"),
            });
            AllStockTransactions.Add(new StockTransaction
            {
                TransactionType = StockTransactionType.Purchase,
                StockPortfolio = context.StockPortfolios.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000024)),
                CurrentPrice = 18.1m,
                Quantity = 2,
                DateTime = new DateTime(2022, 4, 28),
                Stock = context.Stocks.FirstOrDefault(l => l.TickerSymbol == "FLCEX"),
            });
            Int32 intStockTransactionID = 0;
            try
            {
                foreach (StockTransaction SeedStockTransactions in AllStockTransactions)
                {
                    intStockTransactionID = SeedStockTransactions.StockTransactionID;
                    StockTransaction dbStockTransaction = context.StockTransactions.FirstOrDefault(r => r.StockTransactionID == SeedStockTransactions.StockTransactionID);
                    if (dbStockTransaction == null)
                    {
                        context.StockTransactions.Add(SeedStockTransactions);
                        context.SaveChanges();
                    }
                    else
                    {
                        dbStockTransaction.StockTransactionID = SeedStockTransactions.StockTransactionID;
                        dbStockTransaction.StockPortfolio = SeedStockTransactions.StockPortfolio;
                        dbStockTransaction.CurrentPrice = SeedStockTransactions.CurrentPrice;
                        dbStockTransaction.Quantity = SeedStockTransactions.Quantity;
                        dbStockTransaction.DateTime = SeedStockTransactions.DateTime;
                        dbStockTransaction.Stock = SeedStockTransactions.Stock;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                StringBuilder msg = new StringBuilder();
                msg.Append("There was a problem adding the StockTransaction with the title: ");
                msg.Append("(StockTransactionID: ");
                msg.Append(intStockTransactionID);
                msg.Append(")");
                throw new Exception(msg.ToString(), ex);
            }
        }
    }
}
