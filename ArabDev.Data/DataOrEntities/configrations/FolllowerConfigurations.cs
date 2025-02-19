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
           // builder.HasKey(x => x.Id);
            builder.HasOne(f => f.UserFollower)
             .WithMany(u => u.Following)
             .HasForeignKey(f => f.FollowerUserId)
             .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(f => f.UserFollowed)
           .WithMany(u => u.Followers)
           .HasForeignKey(f => f.FollowedUserId)
           .OnDelete(DeleteBehavior.Restrict);



        }
    }
}
