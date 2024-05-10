//using System.ComponentModel.DataAnnotations;

//namespace Demo1.Models
//{
//    public class UniqueIdValidatoin : ValidationAttribute
//    {

//        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
//        {
//            if (value != null)
//            {
//                int id = (int)value;
//                // check if the id is unique from the database

//                if (id < 0 || id > 1000)
//                {
//                    return new ValidationResult("u have to add a valid id between 0 : 1000");
//                }
//            }
           
//            return base.IsValid(value, validationContext);
//        }
//    }
//}