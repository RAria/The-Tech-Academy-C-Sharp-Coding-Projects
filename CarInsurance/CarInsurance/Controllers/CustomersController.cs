using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Customers
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Admin()
        {
            return View(db.Customers.ToList());
        }

        // GET: Customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,DateOfBirth,CarYear,CarMake,CarModel,EverGotDUI,NumberOfSpeedingTickets,FullCoverage,MonthlyFee")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                int quote = 50;
                int customerAge = DateTime.Now.Year - customer.DateOfBirth.Year;
                if (customerAge < 18)
                {
                    quote += 100;
                }
                else if (customerAge < 25)
                {
                    quote += 25;
                }
                else if (customerAge > 100)
                {
                    quote += 25;
                }
                if (customer.CarYear < 2000)
                {
                    quote += 25;
                }
                else if (customer.CarYear > 2015)
                {
                    quote += 25;
                }
                if (customer.CarMake.ToLower() == "porsche" && customer.CarModel.ToLower() == "911 carrera")
                {
                    quote += 25;
                }
                if (customer.CarMake.ToLower() == "porsche")
                {
                    quote += 25;
                }
                if (customer.NumberOfSpeedingTickets > 0)
                {
                    quote += customer.NumberOfSpeedingTickets * 10;
                }
                if (customer.EverGotDUI == true)
                {
                    quote += quote * 25 / 100;
                }
                if (customer.FullCoverage == true)
                {
                    quote += quote * 50 / 100;
                }
                customer.MonthlyFee = quote;
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Details", new { id = customer.Id });
                
            }

            return View(customer);
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,DateOfBirth,CarYear,CarMake,CarModel,EverGotDUI,NumberOfSpeedingTickets,FullCoverage,MonthlyFee")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
