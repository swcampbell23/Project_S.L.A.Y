using Microsoft.AspNetCore.Identity;
using Project_SLAY.DAL;
using Project_SLAY.Models;
using Project_SLAY.Utilities;
using System.Text;

namespace Project_SLAY.Seeding
{
	public static class SeedStockPortfolios
	{
		public static void SeedAllStockPortfolios(AppDbContext context)
		{
			List<StockPortfolio> AllStockPortfolios = new List<StockPortfolio>();
			AllStockPortfolios.Add(new StockPortfolio
			{
				AccountNo = Convert.ToInt64(2290000001),
				User = context.Users.FirstOrDefault(l => l.UserName == "Dixon@aool.com"),
				PortfolioName = "Shan's Stock",
				Balance = 0m,
			});
			AllStockPortfolios.Add(new StockPortfolio
			{
				AccountNo = Convert.ToInt64(2290000009),
				User = context.Users.FirstOrDefault(l => l.UserName == "mb@aool.com"),
				PortfolioName = "Michelle's Stock",
				Balance = 0m,
			});
			AllStockPortfolios.Add(new StockPortfolio
			{
				AccountNo = Convert.ToInt64(2290000011),
				User = context.Users.FirstOrDefault(l => l.UserName == "nelson.Kelly@aool.com"),
				PortfolioName = "Kelly's Stock",
				Balance = 0m,
			});
			AllStockPortfolios.Add(new StockPortfolio
			{
				AccountNo = Convert.ToInt64(2290000018),
				User = context.Users.FirstOrDefault(l => l.UserName == "johnsmith187@aool.com"),
				PortfolioName = "John's Stock",
				Balance = 0m,
			});
			AllStockPortfolios.Add(new StockPortfolio
			{
				AccountNo = Convert.ToInt64(2290000024),
				User = context.Users.FirstOrDefault(l => l.UserName == "cbaker@freezing.co.uk"),
				PortfolioName = "CBaker's Stock",
				Balance = 1m,
			});
			Int32 intStockPortfolioID = 0;
			String strStockPortfolioName = "Start";
			try
			{
				foreach (StockPortfolio seedStockPortfolio in AllStockPortfolios)
				{
					intStockPortfolioID = seedStockPortfolio.StockPortfolioID;
					strStockPortfolioName = seedStockPortfolio.PortfolioName;
					StockPortfolio dbStockPortfolio = context.StockPortfolios.FirstOrDefault(r => r.PortfolioName == seedStockPortfolio.PortfolioName);
					if (dbStockPortfolio == null)
					{
						context.StockPortfolios.Add(seedStockPortfolio);
						context.SaveChanges();
					}
					else
					{
						dbStockPortfolio.PortfolioName = seedStockPortfolio.PortfolioName;
						dbStockPortfolio.AccountNo = seedStockPortfolio.AccountNo;
						dbStockPortfolio.Balance = seedStockPortfolio.Balance;
						dbStockPortfolio.User = seedStockPortfolio.User;
						context.SaveChanges();
					}
				}
			}
			catch (Exception ex)
			{
				StringBuilder msg = new StringBuilder();
				msg.Append("There was a problem adding the StockPortfolio with the title: ");
				msg.Append(strStockPortfolioName);
				msg.Append("(StockPortfolioID: ");
				msg.Append(intStockPortfolioID);
				msg.Append(")");
				throw new Exception(msg.ToString(), ex);
			}
		}
	}
}