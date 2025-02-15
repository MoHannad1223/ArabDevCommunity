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
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasOne(S => S.User)
                 .WithMany()
                 .HasForeignKey(S => S.SenderId)
                 .OnDelete(DeleteBehavior.Restrict); ;
            builder.HasOne(S => S.User)
                .WithMany()
                .HasForeignKey(S => S.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict); ;


        }
    }
}
