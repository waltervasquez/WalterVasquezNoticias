using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContext.MappingModel
{
    class NewsMapping : EntityTypeConfiguration<News>
	{
		public NewsMapping()
        {
            base.HasKey<int>((News m) => m.IdNew);
            base.Property<int>((News m) => m.IdNew).IsRequired();
            base.Property((News m) => m.Title).IsRequired().HasMaxLength(new int?(100));
            base.Property((News m) => m.Content).IsRequired().HasMaxLength(new int?(300));
            base.Property((News m) => m.Image).IsRequired().HasMaxLength(new int?(100));
            base.Property((News m) => m.DatePublication).IsRequired();

            base.ToTable("News");

            base.Property<int>((News m) => m.IdNew).HasColumnName("IdNew");
            base.Property((News m) => m.Title).HasColumnName("Title");
            base.Property((News m) => m.Content).HasColumnName("Content");
            base.Property((News m) => m.Image).HasColumnName("Image");
            base.Property((News m) => m.DatePublication).HasColumnName("DatePublication");

        }
    }
}
