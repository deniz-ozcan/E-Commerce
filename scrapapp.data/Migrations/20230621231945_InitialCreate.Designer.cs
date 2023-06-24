﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using scrapapp.data.Concrete.EfCore;

#nullable disable

namespace scrapapp.data.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20230621231945_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("scrapapp.entity.Detail", b =>
                {
                    b.Property<int>("DetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ram")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Screen")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Storage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("System")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DetailId");

                    b.ToTable("details");
                });

            modelBuilder.Entity("scrapapp.entity.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DetailId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.Property<float>("Rate")
                        .HasColumnType("REAL");

                    b.Property<bool>("is_updated")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductId");

                    b.HasIndex("DetailId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("scrapapp.entity.SitesInformation", b =>
                {
                    b.Property<int>("SitesInformationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Rate")
                        .HasColumnType("REAL");

                    b.Property<string>("SiteName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SitesInformationId");

                    b.HasIndex("ProductId");

                    b.ToTable("sitesInformation");
                });

            modelBuilder.Entity("scrapapp.entity.Product", b =>
                {
                    b.HasOne("scrapapp.entity.Detail", "Detail")
                        .WithMany()
                        .HasForeignKey("DetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Detail");
                });

            modelBuilder.Entity("scrapapp.entity.SitesInformation", b =>
                {
                    b.HasOne("scrapapp.entity.Product", "Product")
                        .WithMany("SitesInformation")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("scrapapp.entity.Product", b =>
                {
                    b.Navigation("SitesInformation");
                });
#pragma warning restore 612, 618
        }
    }
}
