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
            builder.HasOne(U => U.Users)
                  .WithMany()
                  .HasForeignKey(U => U.UserId); 
        }
    }
}
