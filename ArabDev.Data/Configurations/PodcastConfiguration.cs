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
    public class PodcastConfiguration : IEntityTypeConfiguration<PodCast>
    {
        public void Configure(EntityTypeBuilder<PodCast> builder)
        {
          

        }
    }
}
