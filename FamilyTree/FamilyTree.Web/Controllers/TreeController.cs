using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FamilyTree.Web.Controllers
{
    public class TreeController : Controller
    {
        
        // GET: Tree
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DrawTree(string id)
        {

            return null;
        }
    }
}