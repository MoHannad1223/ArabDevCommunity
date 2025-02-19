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
    public class User_CurrentlyLearning : IEntityTypeConfiguration<User_Learning>
    {
        public void Configure(EntityTypeBuilder<User_Learning> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn(1, 1);
            builder.HasOne(U => U.User)
                  .WithMany()
                  .HasForeignKey(U => U.UserId); 
        }
    }
}
