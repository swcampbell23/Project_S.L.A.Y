using Microsoft.AspNetCore.Identity;
using Project_SLAY.DAL;
using Project_SLAY.Models;
using Project_SLAY.Utilities;
using System.Text;

namespace Project_SLAY.Seeding
{
	public static class seedAccounts
	{
		public static void SeedAllAccounts(AppDbContext context)
		{
			List<Account> AllAccounts = new List<Account>();
			//Start For Loop
			AllAccounts.Add(new Account
			{
				AccountNo = Convert.ToInt64(2290000002),
				User = context.Users.FirstOrDefault(l => l.UserName == "willsheff@email.com"),
				AccountName = "William's Savings",
				AccountType = AccountType.Savings,
				Balance = 40035.5m,
			});
			AllAccounts.Add(new Account
			{
				AccountNo = Convert.ToInt64(2290000003),
				User = context.Users.FirstOrDefault(l => l.UserName == "smartinmartin.Martin@aool.com"),
				AccountName = "Gregory's Checking",
				AccountType = AccountType.Checking,
				Balance = 39779.49m,
			});
			AllAccounts.Add(new Account
			{
				AccountNo = Convert.ToInt64(2290000004),
				User = context.Users.FirstOrDefault(l => l.UserName == "avelasco@yaho.com"),
				AccountName = "Allen's Checking",
				AccountType = AccountType.Checking,
				Balance = 47277.33m,
			});
			AllAccounts.Add(new Account
			{
				AccountNo = Convert.ToInt64(2290000005),
				User = context.Users.FirstOrDefault(l => l.UserName == "rwood@voyager.net"),
				AccountName = "Reagan's Checking",
				AccountType = AccountType.Checking,
				Balance = 70812.15m,
			});
			AllAccounts.Add(new Account
			{
				AccountNo = Convert.ToInt64(2290000006),
				User = context.Users.FirstOrDefault(l => l.UserName == "nelson.Kelly@aool.com"),
				AccountName = "Kelly's Savings",
				AccountType = AccountType.Savings,
				Balance = 21901.97m,
			});
			AllAccounts.Add(new Account
			{
				AccountNo = Convert.ToInt64(2290000007),
				User = context.Users.FirstOrDefault(l => l.UserName == "erynrice@aool.com"),
				AccountName = "Eryn's Checking",
				AccountType = AccountType.Checking,
				Balance = 70480.99m,
			});
			AllAccounts.Add(new Account
			{
				AccountNo = Convert.ToInt64(2290000008),
				User = context.Users.FirstOrDefault(l => l.UserName == "westj@pioneer.net"),
				AccountName = "Jake's Savings",
				AccountType = AccountType.Savings,
				Balance = 7916.4m,
			});
			AllAccounts.Add(new Account
			{
				AccountNo = Convert.ToInt64(2290000010),
				User = context.Users.FirstOrDefault(l => l.UserName == "jeff@ggmail.com"),
				AccountName = "Jeffrey's Savings",
				AccountType = AccountType.Savings,
				Balance = 69576.83m,
			});
			AllAccounts.Add(new Account
			{
				AccountNo = Convert.ToInt64(2290000012),
				User = context.Users.FirstOrDefault(l => l.UserName == "erynrice@aool.com"),
				AccountName = "Eryn's Checking 2",
				AccountType = AccountType.Checking,
				Balance = 30279.33m,
			});
			AllAccounts.Add(new Account
			{
				AccountNo = Convert.ToInt64(2290000013),
				User = context.Users.FirstOrDefault(l => l.UserName == "mackcloud@pimpdaddy.com"),
				AccountName = "Jennifer's IRA",
				AccountType = AccountType.IRA,
				Balance = 53177.21m,
			});
			AllAccounts.Add(new Account
			{
				AccountNo = Convert.ToInt64(2290000014),
				User = context.Users.FirstOrDefault(l => l.UserName == "ss34@ggmail.com"),
				AccountName = "Sarah's Savings",
				AccountType = AccountType.Savings,
				Balance = 11958.08m,
			});
			AllAccounts.Add(new Account
			{
				AccountNo = Convert.ToInt64(2290000015),
				User = context.Users.FirstOrDefault(l => l.UserName == "tanner@ggmail.com"),
				AccountName = "Jeremy's Savings",
				AccountType = AccountType.Savings,
				Balance = 72990.47m,
			});
			AllAccounts.Add(new Account
			{
				AccountNo = Convert.ToInt64(2290000016),
				User = context.Users.FirstOrDefault(l => l.UserName == "liz@ggmail.com"),
				AccountName = "Elizabeth's Savings",
				AccountType = AccountType.Savings,
				Balance = 7417.2m,
			});
			AllAccounts.Add(new Account
			{
				AccountNo = Convert.ToInt64(2290000017),
				User = context.Users.FirstOrDefault(l => l.UserName == "ra@aoo.com"),
				AccountName = "Allen's IRA",
				AccountType = AccountType.IRA,
				Balance = 75866.69m,
			});
			AllAccounts.Add(new Account
			{
				AccountNo = Convert.ToInt64(2290000019),
				User = context.Users.FirstOrDefault(l => l.UserName == "mclarence@aool.com"),
				AccountName = "Clarence's Savings",
				AccountType = AccountType.Savings,
				Balance = 1642.82m,
			});
			AllAccounts.Add(new Account
			{
				AccountNo = Convert.ToInt64(2290000020),
				User = context.Users.FirstOrDefault(l => l.UserName == "ss34@ggmail.com"),
				AccountName = "Sarah's Checking",
				AccountType = AccountType.Checking,
				Balance = 84421.45m,
			});
			AllAccounts.Add(new Account
			{
				AccountNo = Convert.ToInt64(2290000021),
				User = context.Users.FirstOrDefault(l => l.UserName == "cbaker@freezing.co.uk"),
				AccountName = "CBaker's Checking",
				AccountType = AccountType.Checking,
				Balance = 4523m,
			});
			AllAccounts.Add(new Account
			{
				AccountNo = Convert.ToInt64(2290000022),
				User = context.Users.FirstOrDefault(l => l.UserName == "cbaker@freezing.co.uk"),
				AccountName = "CBaker's Savings",
				AccountType = AccountType.Savings,
				Balance = 1000m,
			});
			AllAccounts.Add(new Account
			{
				AccountNo = Convert.ToInt64(2290000023),
				User = context.Users.FirstOrDefault(l => l.UserName == "cbaker@freezing.co.uk"),
				AccountName = "CBaker's IRA",
				AccountType = AccountType.IRA,
				Balance = 1000m,
			});
			AllAccounts.Add(new Account
			{
				AccountNo = Convert.ToInt64(2290000025),
				User = context.Users.FirstOrDefault(l => l.UserName == "chaley@thug.com"),
				AccountName = "C-dawg's Checking",
				AccountType = AccountType.Checking,
				Balance = 4.04m,
			});
			AllAccounts.Add(new Account
			{
				AccountNo = Convert.ToInt64(2290000026),
				User = context.Users.FirstOrDefault(l => l.UserName == "chaley@thug.com"),
				AccountName = "C-dawg's Savings",
				AccountType = AccountType.Savings,
				Balance = 350m,
			});
			AllAccounts.Add(new Account
			{
				AccountNo = Convert.ToInt64(2290000027),
				User = context.Users.FirstOrDefault(l => l.UserName == "mgar@aool.com"),
				AccountName = "Margaret's IRA",
				AccountType = AccountType.IRA,
				Balance = 3500m,
			});
            AllAccounts.Add(new Account
            {
                AccountNo = Convert.ToInt64(2290000028),
                User = context.Users.FirstOrDefault(l => l.UserName == "Dixon@aool.com"),
                AccountName = "Shan's Checking",
                AccountType = AccountType.Checking,
                Balance =  2657.81m,
            });
            //create some counters to help debug problems
            Int32 intAccountID = 0;
            String strAccountName = "Start";

            //loop through the list to add or update the Repository
            try
            {
                foreach (Account seedAccount in AllAccounts)
                {
                    //update the counters
                    intAccountID = seedAccount.AccountID;
                    strAccountName = seedAccount.AccountName;
                    //see if the Repository is already in the database using the RepositoryName
                    Account dbAccount = context.Accounts.FirstOrDefault(r => r.AccountName == seedAccount.AccountName);

                    //if repository is null, repository is not in database
                    if (dbAccount == null)
                    {
                        //Add the repository to the database
                        context.Accounts.Add(seedAccount);
                        context.SaveChanges();
                    }
                    else //the repository is in the database - reset all fields except name
                    {
                        dbAccount.AccountName = seedAccount.AccountName;
                        dbAccount.AccountNo = seedAccount.AccountNo;
                        dbAccount.AccountType = seedAccount.AccountType;
                        dbAccount.Balance = seedAccount.Balance;
						dbAccount.User = seedAccount.User;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex) //throw error if there is a problem in the database
            {
                StringBuilder msg = new StringBuilder();
                msg.Append("There was a problem adding the Account with the title: ");
                msg.Append(strAccountName);
                msg.Append(" (AccountID: ");
                msg.Append(intAccountID);
                msg.Append(")");
                throw new Exception(msg.ToString(), ex);
            }
        }
    }
}
