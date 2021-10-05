using AshpazbashiBackoffice.Core.Domain.Tags;
using MediatR;
using RecepieProject.Core.Domain.Tags;

namespace RecepieProject.Core.ApplicationServices.Tags.Queries.Find
{
    public class FindTagQueryHandler : RequestHandler<FindTagQuery, Tag>
    {
        private readonly ITagRepository tagRepository;

        public FindTagQueryHandler(ITagRepository tagRepository)
        {
            this.tagRepository = tagRepository;
        }

        protected override Tag Handle(FindTagQuery request)
        {
            return tagRepository.Get(request.Id);
        }
    }
}
