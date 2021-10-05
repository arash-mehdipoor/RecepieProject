using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepieProject.Core.ApplicationServices.Tags.Commands.Edit
{
    public class EditTagcommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
    }
}
