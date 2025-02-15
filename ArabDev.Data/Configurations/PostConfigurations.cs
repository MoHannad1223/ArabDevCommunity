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
            builder.HasOne(p => p.Users)
                   .WithMany()
                   .HasForeignKey(p => p.UserId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
