using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using Project_SLAY.DAL;
using Project_SLAY.Models;
using Project_SLAY.Utilities;

namespace Project_SLAY.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly AppDbContext _context;
        //Stores which user?
        private readonly UserManager<AppUser> _userManager;

        public TransactionsController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }
        public async Task<IActionResult> Index()
        {
            //Set up a list of transactions to display
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            List<Transaction> transactions;
            transactions = _context.Transactions.ToList();
            if (User.IsInRole("Admin") || User.IsInRole("Employee"))
            {
                transactions = _context.Transactions.ToList();
            }
            else 
            {
                  transactions = _context.Transactions
                            .Include(r => r.Account)
                            .ThenInclude(r => r.User)
                            .Where(r => r.Account.User.UserName == User.Identity.Name)
                            .ToList();
            }
            
            return View(transactions);
        }


        //****Unsure about listTODO: Remove this
        private SelectList GetAllTransactionSelectList()
        {
            //Get the list of Languages from the database
            List<Transaction> TransactionList = _context.Transactions.ToList();

            //add a dummy entry so the user can select all Languages
            Transaction SelectNone = new Transaction() { TransactionNo = -1 }; //May be different
            TransactionList.Add(SelectNone);

            //convert the list to a SelectList by calling SelectList constructor
            //LanguageID and LanguageName are the names of the properties on the Language class
            //LanguageID is the primary key
            SelectList transactionSelectList = new SelectList(TransactionList.OrderBy(m => m.TransactionID), "TransactionID", "TransactionNo");//Is transNo necessary

            //return the selectList
            return transactionSelectList;
        }
        // HW 3 Search Code
        public IActionResult TransactionSearch()
        {
            ViewBag.AllTransactions = GetAllTransactionSelectList();
            return View("TransactionSearch");
        }

        //SEARCH FUNCTIONALITY, HW3
        public IActionResult DisplaySearchResults(TransactionSearchViewModels svm)
        {
            //start with the entire list of repositories
            var query = from r in _context.Transactions
                        select r;

            //query from each inputted variable

            //Check Description/Notes
            if (svm.Notes != null)
            {
                query = query.Where(r => r.Notes.Contains(svm.Notes));
            }

            //Check Category
            if (svm.TransactionType != null)
            {
                query = query.Where(r => r.TransactionType == svm.TransactionType);
            }
            //Check date
            if (svm.Date != null)
            {
                query = query.Where(r => r.Date == svm.Date);
            }

            //Check Amount
            if (svm.Amount != null)
            {
                query = query.Where(r => r.Amount == svm.Amount);
            }
            //Check Transaction Number
            if (svm.TransactionNo != null)
            {
                query = query.Where(r => r.TransactionNo == svm.TransactionNo);
            }

            List<Transaction> SelectedRepositories = query.Include(r => r.TransactionType).ToList();//TODO Correct what property to include by for search to work!

            //Populate the view bag with a count of all transactions
            ViewBag.AllRepositories = _context.Transactions.Count();

            //Populate the view bag with a count of selected repositories
            ViewBag.SelectedRepositories = SelectedRepositories.Count;
            return View("Index",SelectedRepositories.OrderByDescending(r => r.TransactionID)); //Might be a different property,
        }

        //FIGURE OUT HOW TO ADD ASSOCIATED ACCOUNTS
        /*
        public async Task<SelectList> GetAllUserAccountsSelectList()
        {
            List<Account> allAccounts = new List<Account>();


        }
       */

        // GET: Transactions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Transactions == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transactions
                .FirstOrDefaultAsync(m => m.TransactionID == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // GET: Transactions/Create
        /*
        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            Transaction trans = new Transaction();
            trans.User
        }
        */
        /*
        if (User.IsInRole("Customer"))
        {
            Order ord = new Order();
            ord.User = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(ord);
        }
        else
        {
            ViewBag.UserNames = await GetAllCustomerUserNamesSelectList();
            return View("SelectCustomerForOrder");
        }
    }
    */
        // POST: Transactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Create()
        {
            if (User.IsInRole("Customer"))
            {
                Transaction trans = new Transaction();
                ViewBag.AllAccounts = GetAllAccountsSelectList();
                return View(trans);
            }
            else
            {
                //ViewBag.UserNames = await GetAllCustomerUserNamesSelectList();
                return View("SelectCustomerForOrder");
            }
        }

       

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Transaction transaction)
        {
            //Int32 no = Utilities.GenerateNextTransactionNumber.GenNextTransactionNumber(_context);
            transaction.ApprovedType = ApprovedType.Yes;
            //transaction.TransactionNo = no;
            transaction.Date = DateTime.Now;
            if (ModelState.IsValid)
            {
                _context.Add(transaction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transaction);
        }

        // GET: Transactions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Transactions == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transactions.FindAsync(id);
            if (transaction == null)
            {
                return NotFound();
            }
            return View(transaction);
        }

        private SelectList GetAllAccountsSelectList()
        {
            //Get the list of months from the database
            List<Account> accountList = _context.Accounts.Include(a => a.User).Where(a => a.User.UserName == User.Identity.Name).ToList();

            //convert the list to a SelectList by calling SelectList constructor
            //MonthID and MonthName are the names of the properties on the Month class
            //MonthID is the primary key
            SelectList accountSelectList = new SelectList(accountList.OrderBy(m => m.AccountID), "AccountID", "AccountName");

            //return the electList
            return accountSelectList;
        }

        // POST: Transactions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TransactionID,TransactionNo,Amount,Date,Notes,TransactionType,ApprovedType")] Transaction transaction)
        {
            if (id != transaction.TransactionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionExists(transaction.TransactionID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(transaction);
        }

        //For users that are not customers
        /*        public async Task<SelectList> GetAllCustomerUserNamesSelectList()
        {
            //create a list to hold the customers
            List<AppUser> allCustomers = new List<AppUser>();

            //See if the user is a customer
            foreach (AppUser dbUser in _context.Users)
            {
                //if the user is a customer, add them to the list of customers
                if (await _userManager.IsInRoleAsync(dbUser, "Customer") == true)//user is a customer
                {
                    allCustomers.Add(dbUser);
                }
            }
        }
        */



            // GET: Transactions/Delete/5
            public async Task<IActionResult> Delete(int? id)
            {
            if (id == null || _context.Transactions == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transactions
                .FirstOrDefaultAsync(m => m.TransactionID == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // POST: Transactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Transactions == null)
            {
                return Problem("Entity set 'AppDbContext.Transactions'  is null.");
            }
            var transaction = await _context.Transactions.FindAsync(id);
            if (transaction != null)
            {
                _context.Transactions.Remove(transaction);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransactionExists(int id)
        {
          return _context.Transactions.Any(e => e.TransactionID == id);
        }
    }
}
