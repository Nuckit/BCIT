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

        [ForeignKey("OptionId")]
        public int FirstChoiceOptionId { get; set; }
        [ForeignKey("OptionId")]
        public int SecondChoiceOptionId { get; set; }
        [ForeignKey("OptionId")]
        public int ThirdChoiceOptionId { get; set; }
        [ForeignKey("OptionId")]
        public int FourthChoiceOptionId { get; set; }
        public DateTime SelectionDate { get; set; }

        public YearTerm YearTerm { get; set; }
        public Option FirstOption { get; set; }
        public Option SecondOption { get; set; }
        public Option ThirdOption { get; set; }
        public Option FourthOption { get; set; }
    }
}