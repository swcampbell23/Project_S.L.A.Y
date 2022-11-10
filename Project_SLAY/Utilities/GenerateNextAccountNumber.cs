using Project_SLAY.DAL;
using System;
using System.Linq;


namespace Project_SLAY.Utilities
{
    public static class GenerateNextAccountNumber
    {
        public static Int64 GetNextAccountNumber(AppDbContext _context)
        {
            //set a constant to designate where the registration numbers 
            //should start
            const Int64 START_NUMBER = 2290000000;

            Int64 intMaxAccountNumber; //the current maximum product number
            Int64 intNextAccountNumber; //the product number for the next class

            Int64 intMaxBankAccount;
            Int64 intMaxStockPortfolio;

            if (_context.Accounts != null && _context.Accounts.Count() != 0)
            {
                intMaxBankAccount = _context.Accounts.Max(c => c.AccountNo);
            }
            else
            {
                intMaxBankAccount = START_NUMBER;
            }


            if (_context.StockPortfolios != null && _context.StockPortfolios.Count() != 0)
            {
                intMaxStockPortfolio = _context.StockPortfolios.Max(c => c.AccountNo);
            }
            else
            {
                intMaxStockPortfolio = START_NUMBER;
            }



            if (intMaxBankAccount != intMaxStockPortfolio)
            {
                intMaxAccountNumber = Math.Max(intMaxBankAccount, intMaxStockPortfolio);
            }
            else  //values are the same
            {
                intMaxAccountNumber = START_NUMBER;
            }
            

            //add one to the current max to find the next one
            intNextAccountNumber = intMaxAccountNumber + 1;

            //return the value
            return intNextAccountNumber;
        }

    }
}