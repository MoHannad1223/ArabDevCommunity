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
    public class PostConfigurations : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn(1, 1);
            builder.Property(p => p.Title)
                  .HasMaxLength(255);
            builder.Property(p => p.Describtion)
                   .HasMaxLength(2000);


            builder.HasOne(p => p.User)
                   .WithMany()
                   .HasForeignKey(p => p.UserId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(p => p.SavedPosts)
               .WithOne(sp => sp.Post)
               .HasForeignKey(sp => sp.PostId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
