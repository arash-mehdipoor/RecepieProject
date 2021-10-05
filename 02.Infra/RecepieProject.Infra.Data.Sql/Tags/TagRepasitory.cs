using AshpazbashiBackoffice.Core.Domain.Tags;
using RecepieProject.Core.Domain.Tags;
using RecepieProject.Infra.Data.Sql.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RecepieProject.Infra.Data.Sql.Tags
{
    public class TagRepasitory : EfRepository<Tag>, ITagRepository
    {
        public TagRepasitory(RecepieDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
