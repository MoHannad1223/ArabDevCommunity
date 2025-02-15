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
    public class FolllowerConfigurations : IEntityTypeConfiguration<Follower>
    {
        public void Configure(EntityTypeBuilder<Follower> builder)
        {
            builder.HasIndex(I=>I.Id).IsUnique();
            builder.HasOne(U => U.User)
                .WithMany()
                .HasForeignKey(U => U.FollowerId);
            builder.HasOne(U => U.User)
                .WithMany()
                .HasForeignKey(F => F.FollowingId);
        }
    }
}
