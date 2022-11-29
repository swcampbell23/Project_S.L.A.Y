using Microsoft.AspNetCore.Identity;
using Project_SLAY.DAL;
using Project_SLAY.Models;
using Project_SLAY.Utilities;
using System.Text;

namespace Project_SLAY.Seeding
{
	public static class SeedTransactions
	{
		public static void SeedAllTransactions(AppDbContext context)
		{
		List<Transaction> AllTransactions = new List<Transaction>();
		AllTransactions.Add(new Transaction
		{
			TransactionNo= Convert.ToInt32(1),
				TransactionType = TransactionType.Deposit,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000021)),
				Amount = 4000m,
				Notes = "",
				ApprovedType = ApprovedType.Yes,
				Date = new DateTime(2022,1,15),
		});
		AllTransactions.Add(new Transaction
		{
			TransactionNo= Convert.ToInt32(2),
				TransactionType = TransactionType.Deposit,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000022)),
				Amount = 2200m,
				Notes = "This transaction went so well! I will be using this bank again for sure!!",
				ApprovedType = ApprovedType.Yes,
				Date = new DateTime(2022,3,5),
		});
		AllTransactions.Add(new Transaction
		{
			TransactionNo= Convert.ToInt32(3),
				TransactionType = TransactionType.Deposit,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000022)),
				Amount = 6000m,
				Notes = "",
				ApprovedType = ApprovedType.Yes,
				Date = new DateTime(2022,3,9),
		});
		AllTransactions.Add(new Transaction
		{
			TransactionNo= Convert.ToInt32(4),
				TransactionType = TransactionType.Withdraw,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000022)),
				Amount = 1200m,
				Notes = "Jacob Foster has a GPA of 1.92. LOL",
				ApprovedType = ApprovedType.Yes,
				Date = new DateTime(2022,4,14),
		});
		AllTransactions.Add(new Transaction
		{
			TransactionNo= Convert.ToInt32(5),
				TransactionType = TransactionType.Withdraw,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000022)),
				Amount = 352m,
				Notes = "Longhorn Bank is my favorite bank! I couldn't dream of putting my money anywhere else.",
				ApprovedType = ApprovedType.Yes,
				Date = new DateTime(2022,4,21),
		});
		AllTransactions.Add(new Transaction
		{
			TransactionNo= Convert.ToInt32(6),
				TransactionType = TransactionType.Deposit,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000023)),
				Amount = 1500m,
				Notes = "",
				ApprovedType = ApprovedType.Yes,
				Date = new DateTime(2022,3,8),
		});
		AllTransactions.Add(new Transaction
		{
			TransactionNo= Convert.ToInt32(7),
				TransactionType = TransactionType.Deposit,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000021)),
				Amount = 3000m,
				Notes = "",
				ApprovedType = ApprovedType.Yes,
				Date = new DateTime(2022,4,20),
		});
		AllTransactions.Add(new Transaction
		{
			TransactionNo= Convert.ToInt32(8),
				TransactionType = TransactionType.Withdraw,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000021)),
				Amount = 578.12m,
				Notes = "K project snack expenses",
				ApprovedType = ApprovedType.Yes,
				Date = new DateTime(2022,4,19),
		});
		AllTransactions.Add(new Transaction
		{
			TransactionNo= Convert.ToInt32(9),
				TransactionType = TransactionType.Withdraw,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000026)),
				Amount = 52m,
				Notes = "",
				ApprovedType = ApprovedType.Yes,
				Date = new DateTime(2022,4,29),
		});
		AllTransactions.Add(new Transaction
		{
			TransactionNo= Convert.ToInt32(7),
				TransactionType = TransactionType.Withdraw,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000024)),
				Amount = 3000m,
				Notes = "",
				ApprovedType = ApprovedType.Yes,
				Date = new DateTime(2022,4,20),
		});
		AllTransactions.Add(new Transaction
		{
			TransactionNo= Convert.ToInt32(4),
				TransactionType = TransactionType.Deposit,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000021)),
				Amount = 1200m,
				Notes = "Jacob Foster has a GPA of 1.92. LOL",
				ApprovedType = ApprovedType.Yes,
				Date = new DateTime(2022,4,14),
		});
		AllTransactions.Add(new Transaction
		{
			TransactionNo= Convert.ToInt32(9),
				TransactionType = TransactionType.Deposit,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000025)),
				Amount = 52m,
				Notes = "",
				ApprovedType = ApprovedType.Yes,
				Date = new DateTime(2022,4,29),
		});
		AllTransactions.Add(new Transaction
		{
			TransactionNo= Convert.ToInt32(10),
				TransactionType = TransactionType.Withdraw,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000020)),
				Amount = 4000m,
				Notes = "This is totally not fraudulent 0_o",
				ApprovedType = ApprovedType.Yes,
				Date = new DateTime(2022,5,1),
		});
		AllTransactions.Add(new Transaction
		{
			TransactionNo= Convert.ToInt32(11),
				TransactionType = TransactionType.Deposit,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000016)),
				Amount = 6000m,
				Notes = "I got this money from my new business at the Blue Cat Lodge",
				ApprovedType = ApprovedType.No,
				Date = new DateTime(2022,5,1),
		});
		Int32 intTransactionID = 0;
		try
		{
			foreach (Transaction SeedTransactions in AllTransactions)
			{
				intTransactionID = SeedTransactions.TransactionID;
				Transaction dbTransaction = context.Transactions.FirstOrDefault(r => r.TransactionNo == SeedTransactions.TransactionNo);
				if (dbTransaction == null)
				{
					context.Transactions.Add(SeedTransactions);
					context.SaveChanges();
				}
				else
				{
					dbTransaction.TransactionNo = SeedTransactions.TransactionNo;
					dbTransaction.TransactionType = SeedTransactions.TransactionType;
					dbTransaction.Account = SeedTransactions.Account;
					dbTransaction.Amount = SeedTransactions.Amount;
                    dbTransaction.Notes = SeedTransactions.Notes;
					dbTransaction.ApprovedType = SeedTransactions.ApprovedType;
                    dbTransaction.Date= SeedTransactions.Date;
                    context.SaveChanges();
				}
			}
		}
		catch (Exception ex)
		{
			StringBuilder msg = new StringBuilder();
			msg.Append("There was a problem adding the Transaction with the title: ");
			msg.Append("(TransactionID: ");
			msg.Append(intTransactionID);
			msg.Append(")");
			throw new Exception(msg.ToString(), ex);
		}
	}
}
}
