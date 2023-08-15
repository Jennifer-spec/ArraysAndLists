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
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();
        //modified by jennifer
        // GET: Insuree
        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
            //return View();
        }
        //end of by jennifer

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
           
            if (ModelState.IsValid)
            {
                //modified here by Jennifer
                float BaseQuote = 50;
                float AddforAge;
                float AddforCaryear;
                float AddforMaker;
                float AddforTicket = 0;
                
                DateTime now = DateTime.Now;
                int age = now.Year - insuree.DateOfBirth.Year;
                if (age <= 18)
                {
                    AddforAge = 100;
                }
                else if (age >= 19 && age <= 25)
                {
                    AddforAge = 50;
                }
                else
                {
                    AddforAge = 25;
                }
                if (insuree.CarYear < 2015)
                {
                    AddforCaryear = 50;
                }
                else if (insuree.CarYear >= 2015 && insuree.CarYear <= 2000)
                {
                    AddforCaryear = 25;
                }
                else
                {
                    AddforCaryear = 0;
                }
                if (insuree.CarMake == "Porsche")
                {
                    if (insuree.CarModel == "911 Carrere")
                    {
                        AddforMaker = 50;
                    }
                    else { AddforMaker = 25; }
                }
                else
                {
                    AddforMaker = 0;
                }
                if (insuree.SpeedingTickets >= 0)
                {
                    AddforTicket = AddforTicket * insuree.SpeedingTickets ;
                }
                float TotalQuote = BaseQuote + AddforAge + AddforCaryear + AddforMaker + AddforTicket;
                if (insuree.DUI)
                {
                    TotalQuote = Convert.ToSingle(1.25 * TotalQuote);
                }
                if (insuree.CoverageType)
                {
                    TotalQuote = Convert.ToSingle(1.5 * TotalQuote);
                }
                insuree.Quote = (decimal)TotalQuote;
                //end modification by jennifer
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
