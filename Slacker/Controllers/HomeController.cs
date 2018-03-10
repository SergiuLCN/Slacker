using Slacker.Models;
using Slacker.Models.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Slacker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult FinancialTracker()
        {

            using (ApplicationContext db = new ApplicationContext())
            {

                var listOfFinancialTracker = from x in db.FinancialTracker
                                             select new FinancialTrackerEditViewModel
                                             {

                                                 TransactionId = x.TransactionId,
                                                 CurrentDate = x.CurrentDate,
                                                 SpentGainedStatus = x.SpentGainedStatus,
                                                 SpentGainedSource = x.SpentGainedSource,
                                                 InputValue = x.InputValue

                                             };

            }
                
                    var model = new FinancialTracker();
                model.FinTrList = listOfFinancialTracker.ToList();
                return View(model);
            
        }
        [HttpPost]
        public ActionResult FinancialTracker(FinancialTracker finTr)
        {
            if (ModelState.IsValid)
            {
                ApplicationContext db = new ApplicationContext();
                finTr.CurrentDate = DateTime.Now;
                db.FinancialTracker.Add(finTr);
                db.SaveChanges();
            }
            return RedirectToAction("FinancialTracker");
        }

        public ActionResult FinancialTrackerDelete(int id)
        {
            ApplicationContext db = new ApplicationContext();
            FinancialTracker x = db.FinancialTracker.Find(id);
            db.FinancialTracker.Remove(x);
            db.SaveChanges();
            return RedirectToAction("FinancialTracker");
        }
        [HttpGet]
        public ActionResult FinancialTrackerEdit(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var listOfFinancialTracker = from x in db.FinancialTracker
                                             select new FinancialTrackerViewModel()
                                             {
                                                 TransactionId = x.TransactionId,
                                                 CurrentDate = x.CurrentDate,
                                                 SpentGainedStatus = x.SpentGainedStatus,
                                                 SpentGainedSource = x.SpentGainedSource,
                                                 InputValue = x.InputValue
                                                 
                                             };
                
                var model = new FinancialTracker();
                model.FinTrList= listOfFinancialTracker.ToList();
                FinancialTracker y = db.FinancialTracker.Find(id);
                return View(y);// am nevoie de return View(y + model)
            }
            //ApplicationContext db = new ApplicationContext();
            //FinancialTracker x = db.FinancialTracker.Find(id);
            //return View(x);
        }
        [HttpPost]
        public ActionResult FinancialTrackerEdit(FinancialTracker x)
        {
            if (ModelState.IsValid)
            {
                ApplicationContext db = new ApplicationContext();
                db.Entry(x).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                RedirectToAction ("FinancialTracker");
            }
            return View(x);
        }
               
        [HttpPost]
        public JsonResult AutoComplete(String prefix)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var dbList = from x in db.FinancialTracker
                             select new FinancialTrackerViewModel
                             {
                                 TransactionId = x.TransactionId,
                                 CurrentDate = x.CurrentDate,
                                 SpentGainedStatus = x.SpentGainedStatus,
                                 SpentGainedSource = x.SpentGainedSource,
                                 InputValue = x.InputValue

                             };

                var SourceList = (from x in dbList
                                  where x.SpentGainedSource.StartsWith(prefix)
                                  select new { x.SpentGainedSource }
                                 ).ToList();
                return Json(SourceList, JsonRequestBehavior.AllowGet);
            }
        }

    }
}