using RecepieProject.Core.Domain.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepieProject.Core.Domain.Recepies
{
    public class RecipeImage : Entity
    {
        public string Name { get; set; }
        public string PhysicalPath { get; set; }
        public string FileType { get; set; }
    }
}
