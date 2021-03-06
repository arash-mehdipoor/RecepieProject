// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecepieProject.Infra.Data.Sql.Common;

namespace RecepieProject.Infra.Data.Sql.Migrations
{
    [DbContext(typeof(RecepieDbContext))]
    partial class RecepieDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AshpazbashiBackoffice.Core.Domain.Tags.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("RecepieProject.Core.Domain.Recepies.Recipe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ReceipImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ReceipImageId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("RecepieProject.Core.Domain.Recepies.RecipeImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhysicalPath")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("RecipeImages");
                });

            modelBuilder.Entity("RecipeTag", b =>
                {
                    b.Property<Guid>("RecipesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RecipesId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("RecipeTag");
                });

            modelBuilder.Entity("RecepieProject.Core.Domain.Recepies.Recipe", b =>
                {
                    b.HasOne("RecepieProject.Core.Domain.Recepies.RecipeImage", "ReceipImage")
                        .WithMany()
                        .HasForeignKey("ReceipImageId");

                    b.OwnsMany("AshpazbashiBackoffice.Core.Domain.Recipes.Ingredient", "Ingredients", b1 =>
                        {
                            b1.Property<Guid>("RecipeId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<Guid>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Title")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Value")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("RecipeId", "Id");

                            b1.ToTable("Ingredient");

                            b1.WithOwner()
                                .HasForeignKey("RecipeId");
                        });

                    b.Navigation("Ingredients");

                    b.Navigation("ReceipImage");
                });

            modelBuilder.Entity("RecipeTag", b =>
                {
                    b.HasOne("RecepieProject.Core.Domain.Recepies.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AshpazbashiBackoffice.Core.Domain.Tags.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
