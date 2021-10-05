using AshpazbashiBackoffice.Core.Domain.Tags;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepieProject.Core.ApplicationServices.Tags.Queries.GetTagList
{
    public class GetTagListQuery : IRequest<List<Tag>>
    {

    }
}
