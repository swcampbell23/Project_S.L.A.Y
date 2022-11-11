using Microsoft.AspNetCore.Identity;
using Project_SLAY.DAL;
using Project_SLAY.Models;
using Project_SLAY.Utilities;
using System.Text;

namespace Project_SLAY.Seeding
{
	public static class SeedStockTypes
	{
		public static void SeedAllTypes(AppDbContext context)
		{
		List<StockType> AllStockTypes= new List<StockType>();
		AllStockTypes.Add(new StockType
		{
				TypeName = "Ordinary",
		});
		AllStockTypes.Add(new StockType
		{
				TypeName = "ETF",
		});
		AllStockTypes.Add(new StockType
		{
				TypeName = "Futures",
		});
		AllStockTypes.Add(new StockType
		{
				TypeName = "Mutual Fund",
		});
		AllStockTypes.Add(new StockType
		{
				TypeName = "Index Fund",
		});
		Int32 intStockTypeID = 0;
		String strStockTypeName = "Start";
		try
		{
			foreach (StockType seedStockType in AllStockTypes)
			{
				intStockTypeID = seedStockType.StockTypeID;
				strStockTypeName = seedStockType.TypeName;
				StockType dbStockType = context.StockTypes.FirstOrDefault(r => r.TypeName == seedStockType.TypeName);
				if (dbStockType == null)
				{
					context.StockTypes.Add(seedStockType);
					context.SaveChanges();
				}
				else
				{
					dbStockType.TypeName = seedStockType.TypeName;
					context.SaveChanges();
				}
			}
		}
		catch (Exception ex)
		{
			StringBuilder msg = new StringBuilder();
			msg.Append("There was a problem adding the StockType with the title: ");
			msg.Append(strStockTypeName);
			msg.Append("(StockTypeID: ");
			msg.Append(intStockTypeID);
			msg.Append(")");
			throw new Exception(msg.ToString(), ex);
		}
	}
}
}
