using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization.Configuration;

namespace Week3.Controllers
{
    public class FilesController : Controller
    {
        private string RootPath
        {
            get
            {
                return Server.MapPath("~/TextFiles");                
            }
        }

        // GET: Files
        public ActionResult Index()
        {            
            //string folder = Path.Combine(Environment.CurrentDirectory, "TextFiles");
            //DirectoryInfo info = new DirectoryInfo(folder);

            return View(Directory.GetFiles(RootPath));

            
        }

        public ActionResult Content(string id)
        {
            string[] contents = System.IO.File.ReadAllLines(Path.Combine(RootPath, id + ".txt"));
            return View(contents);
        }
    }
}