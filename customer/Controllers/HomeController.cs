using customer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace customer.Controllers
{
    public class HomeController : Controller
    {
        /*public ActionResult Index()
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
        }*/

        customerEntities db = new customerEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(UserInfo log)
        {

            var user = db.UserInfoes.Where(x => x.UserId == log.UserId && x.passwords == log.passwords).Count();
            if (user > 0)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                //return View();
                return RedirectToAction("Index");
            }
        }
        public ActionResult Dashboard()
        {
            custinfo c = new custinfo();
            return View(c);
        }
        [HttpPost]
        public ActionResult Dashboard(custinfo cust)
        {
           

            custinfo c = new custinfo();

            c.logid = Int32.Parse(Request["logid"]);
            c.customer_email = Request["customer_email"];
            c.customer_name = Request["customer_name"];
            c.log_status = Request["log_status"];
            //c.UserId = Int32.Parse(Request["UserId"]);
            c.descriptions = Request["descriptions"];
            //user.Insert(c);

            db.custinfoes.Add(c);
            db.SaveChanges();
            Response.Write("<script> alert('complaint registered successfully')</script>");

            return RedirectToAction("Index");

        }
    }
}