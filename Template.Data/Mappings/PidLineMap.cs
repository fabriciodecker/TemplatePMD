using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Template.Domain.Entities;

namespace Template.Data.Mappings
{
    public class PidLineMap : IEntityTypeConfiguration<PidLine>
    {
        public void Configure(EntityTypeBuilder<PidLine> builder)
        {
            builder.HasKey(key => key.Id);
        }
    }
}
