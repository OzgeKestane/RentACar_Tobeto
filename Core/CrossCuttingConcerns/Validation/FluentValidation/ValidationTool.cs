using FluentValidation;
using FluentValidation.Results;

namespace Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public class ValidationTool
    {
        public static void Validate(IValidator validator, object objectToValidate)
        {
            ValidationContext<object> context = new(objectToValidate); //ilgili nesneyi validate etmek için tanımlıyoruz.
            ValidationResult result = validator.Validate(context); //ilgili validator ile nesneyi validate ediyoruz.
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
