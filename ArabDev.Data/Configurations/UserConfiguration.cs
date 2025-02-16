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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Id).UseIdentityColumn(1, 1);
            builder.Property(x => x.UserName).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Password).IsRequired();
            builder.HasIndex(x => x.Email).IsUnique();


            //.OnDelete(DeleteBehavior.SetNull); ;

        }
    }
}
