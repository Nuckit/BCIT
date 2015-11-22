using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DiplomaDataModel;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using OptionsWebSite.Models;
using WebGrease.Css.Extensions;
using System.Data.Entity;

namespace OptionsWebSite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ReportsController : Controller
    {
        private DiplomaOptionsContext db = new DiplomaOptionsContext();

        // GET: Reports
        public ActionResult Index(int? id)
        {
            List<YearTermViewModel> yearTerms = new List<YearTermViewModel>();
            db.YearTerms.ForEach(y => yearTerms.Add(new YearTermViewModel(y)));

            int defaultYearTermId = yearTerms.First(y => y.IsDefault).YearTermId;

            ViewBag.YearTermId = new SelectList(yearTerms, "YearTermId", "Term", yearTerms.First(y => y.IsDefault).YearTermId);

            var choices = db.Choices.Include(c => c.FirstOption).Include(c => c.FourthOption).Include(c => c.SecondOption).Include(c => c.ThirdOption).Include(c => c.YearTerm);
            List<ChoiceViewModel> model = new List<ChoiceViewModel>();
            choices.ForEach(c => model.Add(new ChoiceViewModel(c)));

            List<OptionStatsViewModel> optionStats = new List<OptionStatsViewModel>();
            ViewData["OptionStats"] = optionStats;

            IEnumerable<ChoiceViewModel> filteredModel;
            if (id != null && Request.IsAjaxRequest())
            {
                filteredModel = model.Where(m => m.YearTermId == id.Value);

                foreach (Option option in db.Options)
                {                    
                    int optionId = option.OptionId;
                    OptionStatsViewModel optionView = new OptionStatsViewModel
                    {
                        OptionName = option.Title
                    };

                    foreach (var choiceView in filteredModel)
                    {
                        if (choiceView.FirstChoiceOptionId == optionId)
                        {
                            optionView.FirstOptionCount++;
                        }
                        else if (choiceView.SecondChoiceOptionId == optionId)
                        {
                            optionView.SecondOptionCount++;
                        }
                        else if (choiceView.ThirdChoiceOptionId == optionId)
                        {
                            optionView.ThirdOptionCount++;
                        }
                        else if (choiceView.FourthChoiceOptionId == optionId)
                        {
                            optionView.FourthOptionCount++;
                        }
                    }
                    optionStats.Add(optionView);
                }

                return PartialView("_Index", filteredModel);
            }

            filteredModel = model.Where(m => m.YearTermId == defaultYearTermId);

            foreach (Option option in db.Options)
            {
                int optionId = option.OptionId;
                OptionStatsViewModel optionView = new OptionStatsViewModel
                {
                    OptionName = option.Title
                };

                foreach (var choiceView in filteredModel)
                {
                    if (choiceView.FirstChoiceOptionId == optionId)
                    {
                        optionView.FirstOptionCount++;
                    }
                    else if (choiceView.SecondChoiceOptionId == optionId)
                    {
                        optionView.SecondOptionCount++;
                    }
                    else if (choiceView.ThirdChoiceOptionId == optionId)
                    {
                        optionView.ThirdOptionCount++;
                    }
                    else if (choiceView.FourthChoiceOptionId == optionId)
                    {
                        optionView.FourthOptionCount++;
                    }
                }
                optionStats.Add(optionView);
            }

            return View(filteredModel);
        }

        public ActionResult GetYearTerms([DataSourceRequest] DataSourceRequest request)
        {
            List<YearTermViewModel> model = new List<YearTermViewModel>();
            db.YearTerms.ForEach(y => model.Add(new YearTermViewModel(y)));
            return Json(model.ToDataSourceResult(request));
        }

        
        
        
    }
}