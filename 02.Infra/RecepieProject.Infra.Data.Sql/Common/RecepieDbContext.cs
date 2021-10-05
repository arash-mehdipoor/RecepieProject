using AshpazbashiBackoffice.Core.Domain.Tags;
using Microsoft.EntityFrameworkCore;
using RecepieProject.Core.Domain.Recepies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepieProject.Infra.Data.Sql.Common
{
    public class RecepieDbContext : DbContext
    {
        public RecepieDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<RecipeImage> RecipeImages { get; set; }
        //public DbSet<RecipeTag> RecipeTags { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RecepieDbContext).Assembly);
        }
    }
}
