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
    public class SharesConfigurations : IEntityTypeConfiguration<Shares>
    {
        public void Configure(EntityTypeBuilder<Shares> builder)
        {
            builder.HasOne(S => S.User)
                .WithMany()
                .HasForeignKey(i => i.UserId);
            builder.HasOne(P => P.Post)
                .WithMany()
                .HasForeignKey(i => i.PostId);
        }
    }
}
