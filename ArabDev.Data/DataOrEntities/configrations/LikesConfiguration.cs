using ArabDev.Data.DataOrEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ArabDev.Data.Configurations
{
    public class LikesConfiguration : IEntityTypeConfiguration<Likes>
    {
        public void Configure(EntityTypeBuilder<Likes> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn(1, 1);

           builder.HasOne(l => l.PodCast)      // علاقة مع جدول PodCasts
        .WithMany(p => p.Likes)      // يمكن للبودكاست أن يحتوي على عدة Likes
        .HasForeignKey(l => l.PodCastId) // المفتاح الأجنبي
        .OnDelete(DeleteBehavior.Cascade);

            builder .HasOne(l => l.Users)       // علاقة مع جدول Users
        .WithMany(u => u.Likes)    // يمكن للمستخدم أن يكون لديه عدة Likes
        .HasForeignKey(l => l.UserId)  // المفتاح الأجنبي
        .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(l => l.Post)      
        .WithMany(p => p.Likes)      
        .HasForeignKey(l => l.PostId) // المفتاح الأجنبي
        .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
