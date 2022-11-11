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
		List<Transaction> AllTransactions= new List<Transaction>();
		AllTransactions.Add(new Transaction
		{
				TransactionID = 1,
				TransactionType = TransactionType.Deposit,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000021)), 
				Amount = 4000m,
				Date = new DateTime(2022, 1, 15),
				ApprovedType = ApprovedType.Yes,
				Notes = "",
		});
		AllTransactions.Add(new Transaction
		{
				TransactionID = 2,
				TransactionType = TransactionType.Deposit,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000022)), 
				Amount = 2200m,
				Date = new DateTime(2022, 3, 5),
				ApprovedType = ApprovedType.Yes,
				Notes = "This transaction went so well! I will be using this bank again for sure!!",
		});
		AllTransactions.Add(new Transaction
		{
				TransactionID = 3,
				TransactionType = TransactionType.Deposit,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000022)), 
				Amount = 6000m,
				Date = new DateTime(2022, 3, 9),
				ApprovedType = ApprovedType.Yes,
				Notes = "",
		});
		AllTransactions.Add(new Transaction
		{
				TransactionID = 4,
				TransactionType = TransactionType.Withdraw,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000022)), 
				Amount = 1200m,
				Date = new DateTime(2022, 4, 14),
				ApprovedType = ApprovedType.Yes,
				Notes = "Jacob Foster has a GPA of 2.63. LOL",
		});
		AllTransactions.Add(new Transaction
		{
				TransactionID = 5,
				TransactionType = TransactionType.Withdraw,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000022)), 
				Amount = 352m,
				Date = new DateTime(2022, 4, 21),
				ApprovedType = ApprovedType.Yes,
				Notes = "Longhorn Bank is my favorite bank! I couldn't dream of putting my money anywhere else.",
		});
		AllTransactions.Add(new Transaction
		{
				TransactionID = 6,
				TransactionType = TransactionType.Deposit,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000023)), 
				Amount = 1500m,
				Date = new DateTime(2022, 3, 8),
				ApprovedType = ApprovedType.Yes,
				Notes = "",
		});
		AllTransactions.Add(new Transaction
		{
				TransactionID = 7,
				TransactionType = TransactionType.Deposit,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000021)), 
				Amount = 3000m,
				Date = new DateTime(2022, 4, 20),
				ApprovedType = ApprovedType.Yes,
				Notes = "",
		});
		AllTransactions.Add(new Transaction
		{
				TransactionID = 8,
				TransactionType = TransactionType.Withdraw,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000021)), 
				Amount = 578.12m,
				Date = new DateTime(2022, 4, 19),
				ApprovedType = ApprovedType.Yes,
				Notes = "K project snack expenses",
		});
		AllTransactions.Add(new Transaction
		{
				TransactionID = 9,
				TransactionType = TransactionType.Withdraw,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000026)), 
				Amount = 52m,
				Date = new DateTime(2022, 4, 29),
				ApprovedType = ApprovedType.Yes,
				Notes = "",
		});
		AllTransactions.Add(new Transaction
		{
				TransactionID = 7,
				TransactionType = TransactionType.Withdraw,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000024)), 
				Amount = 3000m,
				Date = new DateTime(2022, 4, 20),
				ApprovedType = ApprovedType.Yes,
				Notes = "",
		});
		AllTransactions.Add(new Transaction
		{
				TransactionID = 4,
				TransactionType = TransactionType.Deposit,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000021)), 
				Amount = 1200m,
				Date = new DateTime(2022, 4, 14),
				ApprovedType = ApprovedType.Yes,
				Notes = "Jacob Foster has a GPA of 2.63. LOL",
		});
		AllTransactions.Add(new Transaction
		{
				TransactionID = 9,
				TransactionType = TransactionType.Deposit,
				Account = context.Accounts.FirstOrDefault(l => l.AccountNo == Convert.ToInt64(2290000025)), 
				Amount = 52m,
				Date = new DateTime(2022, 4, 29),
				ApprovedType = ApprovedType.Yes,
				Notes = "",
		});
		Int32 intTransactionID = 0;
		try
		{
			foreach (Transaction seedTransaction in AllTransactions)
			{
				intTransactionID = seedTransaction.TransactionID;
				Transaction dbTransaction = context.Transactions.FirstOrDefault(r => r.Account == seedTransaction.Account);
				if (dbTransaction == null)
				{
					context.Transactions.Add(seedTransaction);
					context.SaveChanges();
				}
				else
				{
					dbTransaction.Account = seedTransaction.Account;
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
