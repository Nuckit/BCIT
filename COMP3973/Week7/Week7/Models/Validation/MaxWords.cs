using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Week7.Models.Validation
{
    public class MaxWords : ValidationAttribute
    {
        private uint WordCount { get; set; }

        public MaxWords(uint wordCount) : base ("{0} exceeds the max number of allowed words")
        {
            WordCount = wordCount;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string valueAsString = value.ToString();
                string[] strings = Regex.Split(valueAsString, @"\s+");

                if (strings.Length > WordCount)
                {
                    string errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
            }
            return ValidationResult.Success;
        }
    }
}