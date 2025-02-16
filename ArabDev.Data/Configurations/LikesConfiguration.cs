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
            builder.HasOne(P => P.Post)
                   .WithMany()
                   .HasForeignKey(P => P.PostId);

            builder.HasOne(U=>U.Users)
                   .WithMany()
                   .HasForeignKey(U => U.UserId);
            
            builder.HasOne(L => L.PodCast)
                .WithMany()
                .HasForeignKey(L=>L.PodCastId);
        }
    }
}
