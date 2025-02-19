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
    public class LikesConfiguration : IEntityTypeConfiguration<Likes>
    {
        public void Configure(EntityTypeBuilder<Likes> builder)
        {
            builder.Property(x => x.Id).UseIdentityColumn(1, 1);
<<<<<<< HEAD:confi/Configurations/LikesConfiguration.cs
            builder.HasOne(L => L.PodCast)
                .WithMany(s=>s.Likes)
                .HasForeignKey(L=>L.PodCastId)
                 .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(P => P.Post)
                   .WithMany(s=>s.Likes)
                   .HasForeignKey(P => P.PostId);

            builder.HasOne(U=>U.Users)
                   .WithMany()
                   .HasForeignKey(U => U.UserId);
            
           
=======

            builder.HasOne(l => l.Users)
                   .WithMany(u => u.Likes) // تأكد أن لديك ICollection<Likes> داخل User
                   .HasForeignKey(l => l.UserId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(l => l.Post)
                   .WithMany(p => p.Likes) // تأكد أن لديك ICollection<Likes> داخل Post
                   .HasForeignKey(l => l.PostId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(l => l.PodCast)
                   .WithMany(p => p.Likes) // تأكد أن لديك ICollection<Likes> داخل PodCast
                   .HasForeignKey(l => l.PodCastId)
                   .OnDelete(DeleteBehavior.Cascade);
>>>>>>> b3f2ef277c6404ff85cb21a8c7215bafdb032eca:ArabDev.Data/Configurations/LikesConfiguration.cs
        }
    }
}
