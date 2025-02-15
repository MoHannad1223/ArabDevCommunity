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
    public class SavedPostConfiguration : IEntityTypeConfiguration<SavedPost>
    {
        public void Configure(EntityTypeBuilder<SavedPost> builder)
        {
            builder.HasOne(U => U.User)
                .WithMany()
                .HasForeignKey(P => P.UserId); 
            builder.HasOne(P=>P.Post)
                .WithMany()
                .HasForeignKey(Post => Post.PostId);

        }
    }
}
