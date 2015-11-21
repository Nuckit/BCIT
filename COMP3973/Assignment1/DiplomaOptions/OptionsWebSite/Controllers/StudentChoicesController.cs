using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DiplomaDataModel;
using OptionsWebSite.Models;

namespace OptionsWebSite.Controllers
{
    [Authorize]
    public class StudentChoicesController : Controller
    {
        private DiplomaOptionsContext db = new DiplomaOptionsContext();

        // GET: StudentChoices
        public ActionResult Index()
        {
            var choices = db.Choices.Include(c => c.FirstOption).Include(c => c.FourthOption).Include(c => c.SecondOption).Include(c => c.ThirdOption).Include(c => c.YearTerm).Where(c => c.StudentId == User.Identity.Name);
            return View(choices.ToList());
        }

        // GET: StudentChoices/Create
        public ActionResult Create()
        {
            ViewBag.FirstChoiceOptionId = new SelectList(db.Options.Where(o => o.IsActive), "OptionId", "Title");
            ViewBag.FourthChoiceOptionId = new SelectList(db.Options.Where(o => o.IsActive), "OptionId", "Title");
            ViewBag.SecondChoiceOptionId = new SelectList(db.Options.Where(o => o.IsActive), "OptionId", "Title");
            ViewBag.ThirdChoiceOptionId = new SelectList(db.Options.Where(o => o.IsActive), "OptionId", "Title");

            var choice = new Choice
            {
                StudentId = User.Identity.Name
            };
            ViewData.Model = choice;
            return View();
        }

        // POST: StudentChoices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ChoiceId,StudentId,StudentFirstName,StudentLastName,FirstChoiceOptionId,SecondChoiceOptionId,ThirdChoiceOptionId,FourthChoiceOptionId")] Choice choice)
        {
            if (ModelState.IsValid && IsChoiceValid(choice))
            {
                choice.StudentId = User.Identity.Name;
                choice.YearTerm = db.YearTerms.FirstOrDefault(y => y.IsDefault);
                choice.SelectionDate = DateTime.Now;
                db.Choices.Add(choice);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FirstChoiceOptionId = new SelectList(db.Options.Where(o => o.IsActive), "OptionId", "Title", choice.FirstChoiceOptionId);
            ViewBag.FourthChoiceOptionId = new SelectList(db.Options.Where(o => o.IsActive), "OptionId", "Title", choice.FourthChoiceOptionId);
            ViewBag.SecondChoiceOptionId = new SelectList(db.Options.Where(o => o.IsActive), "OptionId", "Title", choice.SecondChoiceOptionId);
            ViewBag.ThirdChoiceOptionId = new SelectList(db.Options.Where(o => o.IsActive), "OptionId", "Title", choice.ThirdChoiceOptionId);
            return View(choice);
        }

        private bool IsChoiceValid(Choice choice)
        {
            YearTerm yearTerm = db.YearTerms.FirstOrDefault(y => y.IsDefault);
            if (db.Choices.Any(c => (c.StudentId == choice.StudentId && c.YearTermId == yearTerm.YearTermId)))
            {
                ViewBag.ErrorMessage = "Cannot create more than one choice with the same student ID and year/term combination";
                return false;
            }
            if (!db.Choices.Any(c => (c.StudentId == choice.StudentId && c.YearTerm.Year != yearTerm.Year)))
            {
                var options = new[]
                    {
                        choice.FirstChoiceOptionId, 
                        choice.SecondChoiceOptionId, 
                        choice.ThirdChoiceOptionId,
                        choice.FourthChoiceOptionId
                    };
                if (options.Distinct().Count() != options.Count() &&
                    !db.Choices.Any(c => (c.StudentId == choice.StudentId && c.YearTerm.Year != yearTerm.Year)))
                {
                    ViewBag.ErrorMessage = "First year students cannot choose the same choice more than once";
                    return false;
                }
            }
            return true;
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
