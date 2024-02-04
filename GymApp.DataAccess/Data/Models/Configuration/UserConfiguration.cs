
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymApp.DataAccess.Data.Models.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasOne(s => s.Subscription)
                .WithMany(s => s.Clients)
                .HasForeignKey(f => f.SubscriptionId);
        }
    }
}
