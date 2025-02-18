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
    public class SkillsConfiguration : IEntityTypeConfiguration<Skills>
    {
        public void Configure(EntityTypeBuilder<Skills> builder)
        {
            builder.Property(x => x.Id).UseIdentityColumn(1, 1);
            builder.Property(s => s.SkillName).HasMaxLength(250);
         
            builder.HasOne(U => U.Users)
                .WithMany()
                .HasForeignKey(U => U.UserId);
        }
    }
}
