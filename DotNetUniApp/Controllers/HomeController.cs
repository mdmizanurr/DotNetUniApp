using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetUniApp.Controllers
{
    public class BranchModel
    {
        public string BranchCode { get; set; }
        public string BranchName { get; set; }

    }


 

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Branches = PopulateBranches();
            return View();
        }


        public JsonResult SelectSBU(string id)
        {
            List<BranchModel> branches = PopulateBranches();

            return Json(branches.Where( x => x.BranchCode == id),JsonRequestBehavior.AllowGet);
            
        }


        public static List<BranchModel> PopulateBranches()
        {
            List<BranchModel> branches = new List<BranchModel>();
            branches.Add(new BranchModel() { BranchCode = "1", BranchName = "One" });
            branches.Add(new BranchModel() { BranchCode = "2", BranchName = "Two" });

            return branches;
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
    }
}