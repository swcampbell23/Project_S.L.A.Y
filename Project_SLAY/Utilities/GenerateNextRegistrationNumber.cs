using Project_SLAY.DAL;
using System;
using System.Linq;


namespace Project_SLAY.Utilities
{
    public static class GenerateNextOrderNumber
    {
        public static Int32 GetNextOrderNumber(AppDbContext _context)
        {
            //set a constant to designate where the registration numbers 
            //should start
            const Int32 START_NUMBER = 70001;

            Int32 intMaxOrderNumber; //the current maximum product number
            Int32 intNextOrderNumber; //the product number for the next class

            if (_context.Orders.Count() == 0) //there are no orders in the database yet
            {
                intMaxOrderNumber = START_NUMBER; //order numbers start at 70001
            }
            else
            {
                intMaxOrderNumber = _context.Orders.Max(c => c.OrderNumber); //this is the highest number in the database right now
            }

            //You added records to the datbase before you realized 
            //that you needed this and now you have numbers less than 70000 
            //in the database
            if (intMaxOrderNumber < START_NUMBER)
            {
                intMaxOrderNumber = START_NUMBER;
            }

            //add one to the current max to find the next one
            intNextOrderNumber = intMaxOrderNumber + 1;

            //return the value
            return intNextOrderNumber;
        }

    }
}