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
            builder.HasKey(f => new { f.FollowerUserId, f.FollowedUserId });

            //// العلاقة بين المتابع والمتبع
            //builder.HasOne(f => f.FollowerUser)
            //       .WithMany()  // المستخدم يتابع العديد من المستخدمين
            //       .HasForeignKey(f => f.FollowerUserId)
            //       .OnDelete(DeleteBehavior.NoAction);  // حذف المتابعات عند حذف المستخدم

            //builder.HasOne(f => f.FollowedUser)
            //       .WithMany()  // المستخدم لديه متابعين
            //       .HasForeignKey(f => f.FollowedUserId)
            //       .OnDelete(DeleteBehavior.NoAction);  // حذف المتابعين عند حذف المستخ
            builder.HasOne(S => S.User)
                   .WithMany()
                   .HasForeignKey(x => x.FollowerUserId);
            builder.HasOne(S => S.User)
                  .WithMany()
                  .HasForeignKey(x => x.FollowedUserId);

        }
    }
}
