using AshpazbashiBackoffice.Core.Domain.Tags;
using MediatR;
using RecepieProject.Core.Domain.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepieProject.Core.ApplicationServices.Tags.Queries.GetTagList
{
    public class GetTagListQueryHandler : RequestHandler<GetTagListQuery, List<Tag>>
    {
        private readonly ITagRepository tagRepository;

        public GetTagListQueryHandler(ITagRepository tagRepository)
        {
            this.tagRepository = tagRepository;
        }

        protected override List<Tag> Handle(GetTagListQuery request)
        {
            return tagRepository.GetAll().ToList();
        }
    }
}
