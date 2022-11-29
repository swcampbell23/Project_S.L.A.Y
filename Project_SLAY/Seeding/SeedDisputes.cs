using Microsoft.AspNetCore.Identity;
using Project_SLAY.DAL;
using Project_SLAY.Models;
using Project_SLAY.Utilities;
using System.Text;

namespace Project_SLAY.Seeding
{
	public static class SeedDisputes
	{
		public static void SeedAllDisputes(AppDbContext context)
		{
		List<Dispute> AllDisputes = new List<Dispute>();
		AllDisputes.Add(new Dispute
		{
				Status = Status.Submitted,
				Transaction = context.Transactions.FirstOrDefault(l => l.TransactionNo == Convert.ToInt32(8)),
				Amount = 300m,
				Comments = "I don�t remember buying so many snacks",
		});
		AllDisputes.Add(new Dispute
		{
				Status = Status.Submitted,
				Transaction = context.Transactions.FirstOrDefault(l => l.TransactionNo == Convert.ToInt32(10)),
				Amount = 0m,
				Comments = "You rapscallions are trying to steal my money!!!",
		});
		Int32 intDisputeID = 0;
		try
		{
			foreach (Dispute seedDispute in AllDisputes)
			{
				intDisputeID = seedDispute.DisputeID;
				Dispute dbDispute = context.Disputes.FirstOrDefault(r => r.DisputeID == seedDispute.DisputeID);
				if (dbDispute == null)
				{
					context.Disputes.Add(seedDispute);
					context.SaveChanges();
				}
				else
				{
					dbDispute.Status = seedDispute.Status;
					dbDispute.Transaction = seedDispute.Transaction;
					dbDispute.Amount = seedDispute.Amount;
					dbDispute.Comments = seedDispute.Comments;
					context.SaveChanges();
				}
			}
		}
		catch (Exception ex)
		{
			StringBuilder msg = new StringBuilder();
			msg.Append("There was a problem adding the Dispute with the title: ");
			msg.Append("(DisputeID: ");
			msg.Append(intDisputeID);
			msg.Append(")");
			throw new Exception(msg.ToString(), ex);
		}
	}
}
}
