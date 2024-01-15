using BusinessProject.Core.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject.DAL.Configurations
{
    public class AppUserConfiguration:IEntityTypeConfiguration<AppUser>
    {
      public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(a => a.Name).IsRequired().HasMaxLength(60);
            builder.Property(a => a.Surname).IsRequired().HasMaxLength(60);
        }
    }
}
