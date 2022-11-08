using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project_SLAY.DAL;
using Project_SLAY.Models;

namespace Project_SLAY.Controllers
{
    public class OrderDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public OrderDetailsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: OrderDetails
        public IActionResult Index(int? orderID)
        {
            if (orderID == null)
            {
                return View("Error", new String[] { "Please specify an order to view!" });
            }

            //limit the list to only the order details that belong to this order
            List<OrderDetail> rds = _context.OrderDetails
                                          .Include(rd => rd.Product)
                                          .Where(rd => rd.Order.OrderID == orderID)
                                          .ToList();

            return View(rds);
        }

        // GET: OrderDetails/Create
        public IActionResult Create(int orderID)
        {
            //create a new instance of the RegistrationDetail class
            OrderDetail rd = new OrderDetail();

            //find the registration that should be associated with this registration
            Order dbOrder = _context.Orders.Find(orderID);

            //set the new registration detail's registration equal to the registration you just found
            rd.Order = dbOrder;

            //populate the ViewBag with a list of existing courses
            ViewBag.AllProducts = GetProductSelectList();

            //pass the newly created registration detail to the view
            return View(rd);
        }

        // POST: OrderDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(OrderDetail orderDetail, int SelectedProduct)
        {
            //if user has not entered all fields, send them back to try again
            if (ModelState.IsValid == false)
            {
                ViewBag.AllProducts = GetProductSelectList();
                return View(orderDetail);
            }

            //find the product to be associated with this order
            Product dbProduct = _context.Products.Find(SelectedProduct);

            //set the order detail's product to be equal to the one we just found
            orderDetail.Product = dbProduct;

            //find the order on the database that has the correct order id
            //unfortunately, the HTTP request will not contain the entire order object, 
            //just the order id, so we have to find the actual object in the database
            Order dbOrder= _context.Orders.Find(orderDetail.Order.OrderID);

            //set the order on the order detail equal to the order that we just found
            orderDetail.Order = dbOrder;

            //set the order detail's price equal to the product price
            //this will allow us to to store the price that the user paid
            orderDetail.ProductPrice = dbProduct.Price;

            //calculate the extended price for the order detail
            orderDetail.ExtendedPrice = orderDetail.Quantity * orderDetail.ProductPrice;

            //add the order detail to the database
            _context.Add(orderDetail);
            await _context.SaveChangesAsync();

            //send the user to the details page for this order
            return RedirectToAction("Details", "Orders", new { id = orderDetail.Order.OrderID });
        }

        // GET: OrderDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.OrderDetails == null)
            {
                return NotFound();
            }

            var orderDetail = await _context.OrderDetails.FindAsync(id);
            if (orderDetail == null)
            {
                return NotFound();
            }
            return View(orderDetail);
        }

        // POST: OrderDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, OrderDetail orderDetail)
        {
            //this is a security check to make sure they are editing the correct record
            if (id != orderDetail.OrderDetailID)
            {
                return View("Error", new String[] { "There was a problem editing this record. Try again!" });
            }

            //create a new order detail
            OrderDetail dbRD;
            //if code gets this far, update the record
            try
            {
                //find the existing order detail in the database
                //include both order and product
                dbRD = _context.OrderDetails
                      .Include(rd => rd.Product)
                      .Include(rd => rd.Order)
                      .FirstOrDefault(rd => rd.OrderDetailID == orderDetail.OrderDetailID);

                //information is not valid, try again
                if (ModelState.IsValid == false)
                {
                    return View(orderDetail);
                }

                //update the scalar properties
                dbRD.Quantity = orderDetail.Quantity;
                dbRD.ProductPrice = dbRD.Product.Price;
                dbRD.ExtendedPrice = dbRD.Quantity * dbRD.ProductPrice;

                //save changes
                _context.Update(dbRD);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this record", ex.Message });
            }

            //if code gets this far, go back to the order details index page
            return RedirectToAction("Details", "Orders", new { id = dbRD.Order.OrderID });
        }

        // GET: OrderDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.OrderDetails == null)
            {
                return NotFound();
            }

            var orderDetail = await _context.OrderDetails
                .FirstOrDefaultAsync(m => m.OrderDetailID == id);
            if (orderDetail == null)
            {
                return NotFound();
            }

            return View(orderDetail);
        }

        // POST: OrderDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.OrderDetails == null)
            {
                return Problem("Entity set 'AppDbContext.OrderDetails'  is null.");
            }
            var orderDetail = await _context.OrderDetails.FindAsync(id);
            if (orderDetail != null)
            {
                _context.OrderDetails.Remove(orderDetail);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Orders", new { id = orderDetail.Order.OrderID });
        }

        private bool OrderDetailExists(int id)
        {
          return (_context.OrderDetails?.Any(e => e.OrderDetailID == id)).GetValueOrDefault();
        }

        private SelectList GetProductSelectList()
        {
            //create a list for all the products
            List<Product> allProducts = _context.Products.ToList();

            //the user MUST select a product, so you don't need a dummy option for no product

            //use the constructor on select list to create a new select list with the options
            SelectList slAllProducts = new SelectList(allProducts, nameof(Product.ProductID), nameof(Product.ProductName));

            return slAllProducts;
        }
    }
}
