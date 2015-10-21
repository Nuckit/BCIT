using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiplomaDataModel
{
    public class YearTerm
    {
        public int YearTermId { get; set; }        
        public int Year { get; set; }        
        public int Term { get; set; }
        public bool IsDefault { get; set; }

        public List<Choice> Choices { get; set; }
    }
}