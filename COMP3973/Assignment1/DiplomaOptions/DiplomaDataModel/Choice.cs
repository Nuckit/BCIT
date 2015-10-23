using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiplomaDataModel
{
    public class Choice
    {
        public int ChoiceId { get; set; }
        public int YearTermId { get; set; }

        [MaxLength(9), RegularExpression(@"A00\d{1,6}")]
        public string StudentId { get; set; }

        [Required, MaxLength(40)]
        public string StudentFirstName { get; set; }
        [Required, MaxLength(40)]
        public string StudentLastName { get; set; }
        
        public int FirstChoiceOptionId { get; set; }        
        public int SecondChoiceOptionId { get; set; }        
        public int ThirdChoiceOptionId { get; set; }       
        public int FourthChoiceOptionId { get; set; }
        public DateTime SelectionDate { get; set; }

        public YearTerm YearTerm { get; set; }

        [ForeignKey("FirstChoiceOptionId"), InverseProperty("FirstChoices")]
        public Option FirstOption { get; set; }
        [ForeignKey("SecondChoiceOptionId"), InverseProperty("SecondChoices")]
        public Option SecondOption { get; set; }
        [ForeignKey("ThirdChoiceOptionId"), InverseProperty("ThirdChoices")]
        public Option ThirdOption { get; set; }
        [ForeignKey("FourthChoiceOptionId"), InverseProperty("FourthChoices")]
        public Option FourthOption { get; set; }
    }
}