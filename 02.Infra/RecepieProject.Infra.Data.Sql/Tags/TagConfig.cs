using AshpazbashiBackoffice.Core.Domain.Tags;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RecepieProject.Infra.Data.Sql.Recepies
{
    public class TagConfig : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.Property(c => c.Title).HasMaxLength(50).IsUnicode(true);
        }
    }
}
