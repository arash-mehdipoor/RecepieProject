using RecepieProject.Core.Domain.Common;
using RecepieProject.Core.Domain.Recepies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshpazbashiBackoffice.Core.Domain.Tags
{
    public class Tag : Entity
    {
        public string Title { get; set; }
        public List<Recipe> Recipes { get; set; }
    }
}
