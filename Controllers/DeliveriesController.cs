using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MediaPark.Data;
using MediaPark.Models;

namespace MediaPark.Controllers
{
    public class DeliveriesController : Controller
    {
        /*ASP.NET Core dependency injection takes care of passing an instance of ParkContext into the controller. configured that in 
         * the Startup class.*/
        private readonly ParkContext _context;

        public DeliveriesController(ParkContext context)
        {
            _context = context;
        }

        // GET: Deliveries
        public async Task<IActionResult> Index(
        string sortOrder,
        string currentFilter,
        string searchString,
        int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;

            /*The two ViewData elements (NameSortParm and DateSortParm) are used by the view to configure the column heading hyperlinks
             * with the appropriate query string values.*/
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["CurrentFilter"] = searchString;

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }


            var deliveries = from s in _context.Deliveries
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                deliveries = deliveries.Where(s => s.Company.Contains(searchString)
                                       || s.Mark.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    deliveries = deliveries.OrderByDescending(s => s.Company);
                    break;
                case "Date":
                    deliveries = deliveries.OrderBy(s => s.DeliveryDate);
                    break;
                case "date_desc":
                    deliveries = deliveries.OrderByDescending(s => s.DeliveryDate);
                    break;
                default:
                    deliveries = deliveries.OrderBy(s => s.Mark);
                    break;
            }
            int pageSize = 10;
            return View(await PaginatedList<Delivery>.CreateAsync(deliveries.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: Deliveries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            /*The Include and ThenInclude methods cause the context to load the delivery.products navigation property, and within
             * each enrollment the product.branch navigation property.*/
            var delivery = await _context.Deliveries
                .Include(s => s.Products)
                .ThenInclude(e => e.Branch)
                .AsNoTracking() 
                .FirstOrDefaultAsync(m => m.ID == id);



            if (delivery == null)
            {
                return NotFound();
            }

            return View(delivery);
        }

        // GET: Deliveries/Create

        public IActionResult Create()
        {
            return View();
        }

        // POST: Deliveries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
        [Bind("DeliveryDate,Company,Mark")] Delivery delivery)
        {
            try
            {
                /* modification the HttpPost Create method by adding a try-catch block and removing ID from the Bind attribute.*/
                if (ModelState.IsValid)
                {
                    _context.Add(delivery);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }
            return View(delivery);
        }
        // GET: Deliveries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var delivery = await _context.Deliveries.FindAsync(id);
            if (delivery == null)
            {
                return NotFound();
            }
            return View(delivery);
        }

        // POST: Deliveries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Mark,Company,DeliveryDate")] Delivery delivery)
        {
            if (id != delivery.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(delivery);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeliveryExists(delivery.ID))
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
            return View(delivery);
        }

        // GET: Deliveries/Delete/5
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            /* try-catch block to the HttpPost Delete method to handle any errors that might occur 
             * when the database is updated. If an error occurs, the HttpPost 
             * Delete method calls the HttpGet Delete method, passing it a parameter that indicates that an error has occurred*/
            if (id == null)
            {
                return NotFound();
            }

            var delivery = await _context.Deliveries
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);
            if (delivery == null)
            {
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Delete failed. Try again, and if the problem persists " +
                    "see your system administrator.";
            }

            return View(delivery);
        }

        // POST: Deliveries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var delivery = await _context.Deliveries.FindAsync(id);
            
            if (delivery == null)
            {
                return RedirectToAction(nameof(Index));
            }
            try
            {

                _context.Deliveries.Remove(delivery);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            /*This code retrieves the selected entity, then calls the Remove method to set the entity's status to Deleted.
             * When SaveChanges is called, a SQL DELETE command is generated.*/
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.)
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }
        }

        private bool DeliveryExists(int id)
        {
            return _context.Deliveries.Any(e => e.ID == id);
        }
    }
}
