using Project_SLAY.DAL;
using Project_SLAY.Models;
using Project_SLAY.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_SLAY.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public OrdersController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Orders
        public IActionResult Index()
        {
            //Set up a list of registrations to display
            List<Order> orders;
            if (User.IsInRole("Admin"))
            {
                orders = _context.Orders
                                .Include(r => r.OrderDetails)
                                .ToList();
            }
            else //user is a customer, so only display their records
            {
                orders = _context.Orders
                                .Include(r => r.OrderDetails)
                                .Where(r => r.User.UserName == User.Identity.Name)
                                .ToList();
            }

            //
            return View(orders);
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //the user did not specify an order to view
            if (id == null)
            {
                return View("Error", new String[] { "Please specify an order to view!" });
            }

            //find the order in the database
            Order order = await _context.Orders
                                              .Include(r => r.OrderDetails)
                                              .ThenInclude(r => r.Product)
                                              .Include(r => r.User)
                                              .FirstOrDefaultAsync(m => m.OrderID== id);

            //order was not found in the database
            if (order == null)
            {
                return View("Error", new String[] { "This order was not found!" });
            }

            //make sure this order belongs to this user
            if (User.IsInRole("Customer") && order.User.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your order!  Don't be such a snoop!" });
            }

            //Send the user to the details page
            return View(order);
        }

        [Authorize(Roles = "Customer")]
        public IActionResult AddToCart(int? productID)
        {
            //make sure that the user selected a product
            if (productID == null)
            {
                return View("Error", new string[] { "Please specify a product to add to the order" });
            }

            //find the product in the database
            Product dbProduct = _context.Products.Find(productID);

            //make sure the product exists in the database
            if (dbProduct == null)
            {
                return View("Error", new string[] { "This product was not in the database!" });
            }

            //find the cart for this customer
            Order ord = _context.Orders.FirstOrDefault(r => r.User.UserName == User.Identity.Name && r.Status == OrderStatus.Pending);

            //if this order is null, there isn't one yet, so create it
            if (ord == null)
            {
                //create a new object
                ord = new Order();

                //update the generated properties of the order
                ord.Status = OrderStatus.Pending;
                ord.OrderDate = DateTime.Now;
                ord.OrderNumber = GenerateNextOrderNumber.GetNextOrderNumber(_context);
                ord.User = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

                //add the registration to the database
                _context.Orders.Add(ord);
                _context.SaveChanges();
            }

            //now create the registration detail
            OrderDetail rd = new OrderDetail();

            //add the course to the registration detail
            rd.Product = dbProduct;

            //add the registration to the registration detail
            rd.Order = ord;

            //you can assume the quantity is zero - they can edit it later
            rd.Quantity = 1;

            //calculate the properties on the orddetails
            rd.ProductPrice = dbProduct.Price;
            rd.ExtendedPrice = dbProduct.Price * rd.Quantity;

            //add the order detail to the database
            _context.OrderDetails.Add(rd);
            _context.SaveChanges(true);

            //go to the details view
            return RedirectToAction("Details", new { id = ord.OrderID });
        }

        // GET: Orders/Edit/5
        public IActionResult Edit(int? id)
        {
            //user did not specify a order to edit
            if (id == null)
            {
                return View("Error", new String[] { "Please specify an order to edit" });
            }

            //find the order in the database, and be sure to include details
            Order order = _context.Orders
                                       .Include(r => r.OrderDetails)
                                       .ThenInclude(r => r.Product)
                                       .Include(r => r.User)
                                       .FirstOrDefault(r => r.OrderID == id);

            //order was not found in the database
            if (order == null)
            {
                return View("Error", new String[] { "This order was not found in the database!" });
            }

            //order does not belong to this user
            if (User.IsInRole("Customer") && order.User.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "You are not authorized to edit this order!" });
            }

            //order is complete - cannot be edited
            if (order.Status == OrderStatus.Completed)
            {
                return View("Error", new string[] { "This order is complete and cannot be changed!" });
            }

            //send the user to the order edit view
            return View(order);
        }

        // POST: Orders/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Order order)
        {
            //this is a security measure to make sure the user is editing the correct order
            if (id != order.OrderID)
            {
                return View("Error", new String[] { "There was a problem editing this order. Try again!" });
            }

            //if there is something wrong with this order, try again
            if (ModelState.IsValid == false)
            {
                return View(order);
            }

            //if code gets this far, update the record
            try
            {
                //find the record in the database
                Order dbOrder = _context.Orders.Find(order.OrderID);

                //update the notes
                dbOrder.OrderNotes = order.OrderNotes;

                _context.Update(dbOrder);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this order!", ex.Message });
            }

            //send the user to the Orders Index page.
            return RedirectToAction(nameof(Index));
        }

        //GET: Registrations/Create
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Create()
        {
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


        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("User, OrderNotes")] Order order)
        {
            //Find the next registration number from the utilities class
            order.OrderNumber = Utilities.GenerateNextOrderNumber.GetNextOrderNumber(_context);

            //Set the date of this order
            order.OrderDate = DateTime.Now;

            //Associate the registration with the logged-in customer
            order.User = await _userManager.FindByNameAsync(User.Identity.Name);


            //if code gets this far, add the registration to the database
            _context.Add(order);
            await _context.SaveChangesAsync();

            //send the user on to the action that will allow them to 
            //create a registration detail.  Be sure to pass along the RegistrationID
            //that you created when you added the registration to the database above
            return RedirectToAction("Create", "OrderDetails", new { orderID = order.OrderID });
        }


        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> SelectCustomerForOrder(String SelectedCustomer)
        {
            if (String.IsNullOrEmpty(SelectedCustomer))
            {
                ViewBag.UserNames = await GetAllCustomerUserNamesSelectList();
                return View("SelectCustomerForOrder");
            }

            Order ord = new Order();
            ord.User = await _userManager.FindByNameAsync(SelectedCustomer);
            return View("Create", ord);
        }


        [Authorize]
        public async Task<IActionResult> CheckoutOrder(int? id)
        {
            //the user did not specify a registration to view
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a order to view!" });
            }

            //find the registration in the database
            Order order = await _context.Orders
                                              .Include(r => r.OrderDetails)
                                              .ThenInclude(r => r.Product)
                                              .Include(r => r.User)
                                              .FirstOrDefaultAsync(m => m.OrderID == id);

            //registration was not found in the database
            if (order == null)
            {
                return View("Error", new String[] { "This order was not found!" });
            }

            //make sure this registration belongs to this user
            if (User.IsInRole("Customer") && order.User.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your order!  Don't be such a snoop!" });
            }

            //Send the user to the details page
            return View("Confirm", order);
        }

        public async Task<IActionResult> Confirm(int? id)
        {
            Order dbReg = await _context.Orders.FindAsync(id);
            dbReg.Status = OrderStatus.Completed;
            _context.Update(dbReg);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        public async Task<SelectList> GetAllCustomerUserNamesSelectList()
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

            //create a new select list with the customer emails
            SelectList sl = new SelectList(allCustomers.OrderBy(c => c.Email), nameof(AppUser.UserName), nameof(AppUser.Email));

            //return the select list
            return sl;

        }
    }
}
