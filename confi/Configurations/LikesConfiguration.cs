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
            
           
        }
    }
}
