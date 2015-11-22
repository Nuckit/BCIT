using System.Collections.Generic;
using DiplomaDataModel;

namespace OptionsWebSite.Models
{
    public class YearTermViewModel
    {
        public int YearTermId { get; set; }
        public int Year { get; set; }
        public string Term { get; set; }
        public bool IsDefault { get; set; }
        

        public YearTermViewModel(YearTerm yearTerm)
        {
            YearTermId = yearTerm.YearTermId;
            Year = yearTerm.Year;
            Term = string.Format("{0} {1}", Year, GetTerm(yearTerm.Term));
            IsDefault = yearTerm.IsDefault;            
        }

        public YearTermViewModel()
        {
            
        }

        private string GetTerm(int termId)
        {
            switch (termId)
            {
                case 10:
                    return "Winter";
                case 20:
                    return "Spring/Summer";
                case 30:
                    return "Fall";
                default:
                    return string.Empty;
            }
        }
    }
}