

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymApp.DataAccess.Data.Models.Configuration
{
    public class FinancialOperationConfiguration : IEntityTypeConfiguration<FinancialOperation>
    {
        public void Configure(EntityTypeBuilder<FinancialOperation> builder)
        {
            builder.HasOne(s => s.Client)
                .WithMany(f => f.FinOperations)
                .HasForeignKey(s => s.ClientId);
        }
    }
}
