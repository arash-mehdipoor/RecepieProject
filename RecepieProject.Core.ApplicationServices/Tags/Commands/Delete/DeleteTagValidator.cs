using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepieProject.Core.ApplicationServices.Tags.Commands.Delete
{
    public class DeleteTagValidator : AbstractValidator<DeleteTagCommand>
    {
        public DeleteTagValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage("برای شناسه تگ مقدار لازم است");
        }
    }
}
