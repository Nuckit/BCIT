using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week3.Controllers
{
    public class ProcessController : Controller
    {
        // GET: Process
        public ActionResult Index()
        {
            Process[] processes = Process.GetProcesses();
            return View(processes.ToList());
        }

        [Authorize]
        public ActionResult Details(int id)
        {
            return View(Process.GetProcessById(id));
        }
    }
}