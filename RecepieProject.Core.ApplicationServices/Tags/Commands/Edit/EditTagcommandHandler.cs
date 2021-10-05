using AshpazbashiBackoffice.Core.Domain.Tags;
using MediatR;
using RecepieProject.Core.Domain.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepieProject.Core.ApplicationServices.Tags.Commands.Edit
{
    public class EditTagcommandHandler : RequestHandler<EditTagcommand, Guid>
    {
        private readonly ITagRepository tagRepository;

        public EditTagcommandHandler(ITagRepository tagRepository)
        {
            this.tagRepository = tagRepository;
        }

        protected override Guid Handle(EditTagcommand request)
        {
            var tag = new Tag()
            {
                Id = request.Id,
                Title = request.Title
            };
            tagRepository.Update(tag);
            return tag.Id;

        }
    }
}
