using System;
using System.ComponentModel.DataAnnotations;
using DiplomaDataModel;

namespace OptionsWebSite.Models
{
    public class ChoiceViewModel
    {
        public int ChoiceId { get; set; }
        public int YearTermId { get; set; }

        [MaxLength(9), RegularExpression(@"A00\d{1,6}")]
        [Display(Name = "Student ID")]
        public string StudentId { get; set; }

        [Required, MaxLength(40)]
        [Display(Name = "First Name")]
        public string StudentFirstName { get; set; }

        [Required, MaxLength(40)]
        [Display(Name = "Last Name")]
        public string StudentLastName { get; set; }

        public int FirstChoiceOptionId { get; set; }
        public int SecondChoiceOptionId { get; set; }
        public int ThirdChoiceOptionId { get; set; }
        public int FourthChoiceOptionId { get; set; }

        [Display(Name = "Selection Date")]
        public DateTime SelectionDate { get; set; }

        public YearTerm YearTerm { get; set; }


        public Option FirstOption { get; set; }
        
        public Option SecondOption { get; set; }
        
        public Option ThirdOption { get; set; }
        
        public Option FourthOption { get; set; }

        public string YearTermValue { get; set; }

        public ChoiceViewModel(Choice choice)
        {
            ChoiceId = choice.ChoiceId;
            YearTermId = choice.YearTermId;
            StudentId = choice.StudentId;
            StudentFirstName = choice.StudentFirstName;
            StudentLastName = choice.StudentLastName;
            FirstChoiceOptionId = choice.FirstChoiceOptionId;
            SecondChoiceOptionId = choice.SecondChoiceOptionId;
            ThirdChoiceOptionId = choice.ThirdChoiceOptionId;
            FourthChoiceOptionId = choice.FourthChoiceOptionId;
            SelectionDate = choice.SelectionDate;
            YearTerm = choice.YearTerm;
            FirstOption = choice.FirstOption;
            SecondOption = choice.SecondOption;
            ThirdOption = choice.ThirdOption;
            FourthOption = choice.FourthOption;
            YearTermValue = string.Format("{0} {1}", YearTerm.Year, GetTerm(YearTerm.Term));
        }

        public ChoiceViewModel()
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