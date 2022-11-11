using Microsoft.AspNetCore.Identity;
using Project_SLAY.DAL;
using Project_SLAY.Models;
using Project_SLAY.Utilities;
using System.Text;

namespace Project_SLAY.Seeding
{
	public static class SeedStocks
	{
		public static void SeedAllStocks(AppDbContext context)
		{
		List<Stock> AllStocks= new List<Stock>();
		AllStocks.Add(new Stock
		{
				TickerSymbol= "GOOG",
				StockType = context.StockTypes.FirstOrDefault(l => l.TypeName == "Ordinary"),
				StockName = "Alphabet Inc.",
				Price = 87.07m,
		});
		AllStocks.Add(new Stock
		{
				TickerSymbol= "AAPL",
				StockType = context.StockTypes.FirstOrDefault(l => l.TypeName == "Ordinary"),
				StockName = "Apple Inc.",
				Price = 145.03m,
		});
		AllStocks.Add(new Stock
		{
				TickerSymbol= "AMZN",
				StockType = context.StockTypes.FirstOrDefault(l => l.TypeName == "Ordinary"),
				StockName = "Amazon.com Inc.",
				Price = 92.12m,
		});
		AllStocks.Add(new Stock
		{
				TickerSymbol= "LUV",
				StockType = context.StockTypes.FirstOrDefault(l => l.TypeName == "Ordinary"),
				StockName = "Southwest Airlines",
				Price = 36.5m,
		});
		AllStocks.Add(new Stock
		{
				TickerSymbol= "TXN",
				StockType = context.StockTypes.FirstOrDefault(l => l.TypeName == "Ordinary"),
				StockName = "Texas Instruments",
				Price = 158.49m,
		});
		AllStocks.Add(new Stock
		{
				TickerSymbol= "HSY",
				StockType = context.StockTypes.FirstOrDefault(l => l.TypeName == "Ordinary"),
				StockName = "The Hershey Company",
				Price = 235.11m,
		});
		AllStocks.Add(new Stock
		{
				TickerSymbol= "V",
				StockType = context.StockTypes.FirstOrDefault(l => l.TypeName == "Ordinary"),
				StockName = "Visa Inc.",
				Price = 200.95m,
		});
		AllStocks.Add(new Stock
		{
				TickerSymbol= "NKE",
				StockType = context.StockTypes.FirstOrDefault(l => l.TypeName == "Ordinary"),
				StockName = "Nike",
				Price = 90.3m,
		});
		AllStocks.Add(new Stock
		{
				TickerSymbol= "VWO",
				StockType = context.StockTypes.FirstOrDefault(l => l.TypeName == "ETF"),
				StockName = "Vanguard Emerging Markets ETF",
				Price = 35.77m,
		});
		AllStocks.Add(new Stock
		{
				TickerSymbol= "CORN",
				StockType = context.StockTypes.FirstOrDefault(l => l.TypeName == "Futures"),
				StockName = "Corn",
				Price = 27.35m,
		});
		AllStocks.Add(new Stock
		{
				TickerSymbol= "FXAIX",
				StockType = context.StockTypes.FirstOrDefault(l => l.TypeName == "Mutual Fund"),
				StockName = "Fidelity 500 Index Fund",
				Price = 133.88m,
		});
		AllStocks.Add(new Stock
		{
				TickerSymbol= "F",
				StockType = context.StockTypes.FirstOrDefault(l => l.TypeName == "Ordinary"),
				StockName = "Ford Motor Company",
				Price = 13.06m,
		});
		AllStocks.Add(new Stock
		{
				TickerSymbol= "BAC",
				StockType = context.StockTypes.FirstOrDefault(l => l.TypeName == "Ordinary"),
				StockName = "Bank of America Corporation",
				Price = 36.09m,
		});
		AllStocks.Add(new Stock
		{
				TickerSymbol= "VNQ",
				StockType = context.StockTypes.FirstOrDefault(l => l.TypeName == "ETF"),
				StockName = "Vanguard REIT ETF",
				Price = 80.67m,
		});
		AllStocks.Add(new Stock
		{
				TickerSymbol= "NSDQ",
				StockType = context.StockTypes.FirstOrDefault(l => l.TypeName == "Index Fund"),
				StockName = "Nasdaq Index Fund",
				Price = 10524.8m,
		});
		AllStocks.Add(new Stock
		{
				TickerSymbol= "KMX",
				StockType = context.StockTypes.FirstOrDefault(l => l.TypeName == "Ordinary"),
				StockName = "CarMax, Inc.",
				Price = 62.36m,
		});
		AllStocks.Add(new Stock
		{
				TickerSymbol= "DIA",
				StockType = context.StockTypes.FirstOrDefault(l => l.TypeName == "Index Fund"),
				StockName = "Dow Jones Industrial Average Index Fund",
				Price = 321.36m,
		});
		AllStocks.Add(new Stock
		{
				TickerSymbol= "SPY",
				StockType = context.StockTypes.FirstOrDefault(l => l.TypeName == "Index Fund"),
				StockName = "S&P 500 Index Fund",
				Price = 374.87m,
		});
		AllStocks.Add(new Stock
		{
				TickerSymbol= "BEN",
				StockType = context.StockTypes.FirstOrDefault(l => l.TypeName == "Ordinary"),
				StockName = "Franklin Resources, Inc.",
				Price = 22.56m,
		});
		AllStocks.Add(new Stock
		{
				TickerSymbol= "FLCEX",
				StockType = context.StockTypes.FirstOrDefault(l => l.TypeName == "Mutual Fund"),
				StockName = "Fidelity Large Cap Core Enhanced Index Fund",
				Price = 18.1m,
		});
		Int32 intStockID = 0;
		String strStockName = "Start";
		try
		{
			foreach (Stock seedStock in AllStocks)
			{
				intStockID = seedStock.StockID;
				strStockName = seedStock.StockName;
				Stock dbStock = context.Stocks.FirstOrDefault(r => r.StockName == seedStock.StockName);
				if (dbStock == null)
				{
					context.Stocks.Add(seedStock);
					context.SaveChanges();
				}
				else
				{
					dbStock.StockName = seedStock.StockName;
					context.SaveChanges();
				}
			}
		}
		catch (Exception ex)
		{
			StringBuilder msg = new StringBuilder();
			msg.Append("There was a problem adding the Stock with the title: ");
			msg.Append(strStockName);
			msg.Append("(StockID: ");
			msg.Append(intStockID);
			msg.Append(")");
			throw new Exception(msg.ToString(), ex);
		}
	}
}
}
