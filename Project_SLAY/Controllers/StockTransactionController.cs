using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project_SLAY.DAL;
using Project_SLAY.Models;

namespace Project_SLAY.Controllers
{
    public class StockTransactionController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public StockTransactionController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: StockTransaction/Create
        public IActionResult Create()
        {
            ViewBag.AllStocks = GetAllStocksSelectList();
            return View();
        }

        // POST: StockTransaction/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> Create(StockTransaction stockTransaction, int SelectedStock)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (user.StockPortfolio != null)
            {
                if (ModelState.IsValid == false)
                {
                    ViewBag.AllProducts = GetAllStocksSelectList();
                    return View(stockTransaction);
                }

                //find the product to be associated with this order
                Stock dbStock = _context.Stocks.Find(SelectedStock);

                StockPortfolio stockPortfolio = _context.StockPortfolios.FirstOrDefault(sp => sp.User.UserName == User.Identity.Name);

                stockTransaction.StockPortfolio = stockPortfolio;

                //set the order detail's product to be equal to the one we just found
                stockTransaction.Stock = dbStock;

                //set the order detail's price equal to the product price
                //this will allow us to to store the price that the user paid
                stockTransaction.CurrentPrice = dbStock.Price;
                stockTransaction.DateTime = DateTime.Now;

                stockTransaction.CalcTotals();

                //add the order detail to the database
                _context.Add(stockTransaction);
                await _context.SaveChangesAsync();

                //send the user to the details page for this order
                return RedirectToAction("Index", "Home");
            }

            return View("Error", new String[] { "You don't have a StockPortfolio" });
        }

        private SelectList GetAllStocksSelectList()
        {
            //Get the list of months from the database
            List<Stock> stockList = _context.Stocks.ToList();

            //convert the list to a SelectList by calling SelectList constructor
            //MonthID and MonthName are the names of the properties on the Month class
            //MonthID is the primary key
            SelectList stockSelectList = new SelectList(stockList.OrderBy(m => m.StockID), "StockID", "StockName");

            //return the electList
            return stockSelectList;
        }
    }
}
