using ArabDev.Data.DataOrEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabDev.Data.Configurations
{
    public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.Property(x => x.Id).UseIdentityColumn(1, 1);
            builder.HasOne(U => U.Users)
                  .WithMany()
                  .HasForeignKey(U => U.UserId);
            builder.HasOne(P=>P.Post)
                  .WithMany()
                  .HasForeignKey(P => P.PostId);
        }
    }
}
