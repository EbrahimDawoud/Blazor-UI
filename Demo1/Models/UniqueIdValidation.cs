using System.ComponentModel.DataAnnotations;

namespace Demo1.Models
{
    public class UniqueIdValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                int id = (int)value;
                if (id < 0 || id > 10000)
                {
                    return new ValidationResult("Id must be between 0 and 10000");
                }
            }
            return ValidationResult.Success;
        }
    }
}
