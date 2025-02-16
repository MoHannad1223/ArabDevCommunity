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
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(c => c.Text).IsUnicode().HasMaxLength(500);
            builder.HasOne(U => U.User)
                   .WithMany()
                   .HasForeignKey(U => U.UserId);

            builder.HasOne(P => P.Post)
                   .WithMany()
                   .HasForeignKey(P=>P.PostId);

            builder.HasOne(C => C.PodCast)
                .WithMany()
                .HasForeignKey(C=>C.PodCastId);
        }
    }
}
