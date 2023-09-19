using LessonEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonEF.Configurations
{
    public class AppUserDetailConfiguration : IEntityTypeConfiguration<AppUserDetail>
    {
        public void Configure(EntityTypeBuilder<AppUserDetail> builder)
        {
            // AppUserDetail
            builder.Property(x => x.FirstName)
                .HasColumnName("Ad");

            builder.Property(x => x.FirstName).IsRequired();

            builder.Property(x => x.FirstName).HasColumnType("varchar(30)");
        }
    }
}
