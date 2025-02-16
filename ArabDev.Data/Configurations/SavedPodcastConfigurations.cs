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
    public class SavedPodcastConfigurations : IEntityTypeConfiguration<SavedPodcast>
    {
        public void Configure(EntityTypeBuilder<SavedPodcast> builder)
        {

            builder.HasKey(sp => new { sp.UserId, sp.PodCastId });

            builder.HasOne(U => U.User)
                .WithMany()
                .HasForeignKey(sp => sp.UserId);

            builder.HasOne(sp => sp.PodCast)
                .WithMany()
                .HasForeignKey(Post => Post.PodCastId);

        }
    }
}