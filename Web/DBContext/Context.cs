namespace DBContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Models;
    using MappingModel;

    public partial class Context : DbContext
    {
        public Context() : base("name=Context")
        { }

        public DbSet<News> News{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add<News>(new NewsMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
