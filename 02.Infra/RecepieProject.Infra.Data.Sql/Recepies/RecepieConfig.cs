using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecepieProject.Core.Domain.Recepies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepieProject.Infra.Data.Sql.Recepies
{
    public class RecipeConfig : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.Property(c => c.Title).HasMaxLength(100).IsRequired();
            builder.Property(c => c.ShortDescription).HasMaxLength(500).IsRequired();
            builder.Property(c => c.Detail).IsRequired();
            builder.OwnsMany(c => c.Ingredients);
        }
    }
}
