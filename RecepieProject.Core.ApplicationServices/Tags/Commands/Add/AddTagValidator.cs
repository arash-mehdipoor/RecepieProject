using FluentValidation;

namespace RecepieProject.Core.ApplicationServices.Tags.Commands.Add
{
    public class AddTagValidator:AbstractValidator<AddTagCommand>
    {
        public AddTagValidator()
        {
            RuleFor(c => c.Title).NotEmpty().WithMessage("نمی تواند خالی باشد")
                .MaximumLength(50).WithMessage("نمی تواند بیش از 50 کاراکتر باشد");
        }
        
    }
}
