using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiplomaDataModel
{
    public class Option
    {
        public int OptionId { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        public bool IsActive { get; set; }

        public List<Choice> Choices { get; set; }
    }
}