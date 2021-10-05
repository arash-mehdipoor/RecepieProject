using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepieProject.Core.ApplicationServices.Tags.Commands.Edit
{
    public class EditTagValidator : AbstractValidator<EditTagcommand>
    {
        public EditTagValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage("برای شناسه تگ مقدار لازم است");
            RuleFor(c => c.Title).NotEmpty().WithMessage("نمی تواند خالی باشد")
               .MaximumLength(50).WithMessage("نمی تواند بیش از 50 کاراکتر باشد");
        }
    }
}
