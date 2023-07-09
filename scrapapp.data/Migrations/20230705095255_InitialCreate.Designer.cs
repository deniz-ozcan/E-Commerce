﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using scrapapp.data.Concrete.EfCore;

#nullable disable

namespace scrapapp.data.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20230705095255_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.7");

            modelBuilder.Entity("scrapapp.entity.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("scrapapp.entity.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CartId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("scrapapp.entity.Detail", b =>
                {
                    b.Property<int>("DetailId")
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

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

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

                    b.ToTable("Details");

                    b.HasData(
                        new
                        {
                            DetailId = 1,
                            Image = "https://cdn.dsmcdn.com/ty184/product/media/images/20211001/17/138444894/252192378/0/0_org_zoom.jpg",
                            Model = "NITRO 5 AN517-41 NH.QAREY.001",
                            Name = "ACER",
                            Processor = "R7 5800H",
                            ProductId = 1,
                            Ram = "16GB",
                            Screen = "17.3",
                            Slug = "acer-nitro-5-an517-41-nhqarey001-r7-5800h-16gb-512gb-freedos-173inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 2,
                            Image = "https://cdn.dsmcdn.com/ty541/product/media/images/20220928/18/180895981/581885669/1/1_org_zoom.jpg",
                            Model = "MACBOOK AIR MLY33TU/A",
                            Name = "APPLE",
                            Processor = "M2",
                            ProductId = 2,
                            Ram = "8GB",
                            Screen = "13.6",
                            Slug = "apple-macbook-air-mly33tua-m2-0-8gb-256gb-macos-136inc",
                            Storage = "256GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 3,
                            Image = "https://cdn.dsmcdn.com/ty454/product/media/images/20220614/15/125590297/117920493/1/1_org_zoom.jpg",
                            Model = "MACBOOK AIR MGN63TU/A",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 3,
                            Ram = "8GB",
                            Screen = "13.3",
                            Slug = "apple-macbook-air-mgn63tua-m1-0-8gb-256gb-macos-133inc",
                            Storage = "256GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 4,
                            Image = "https://cdn.dsmcdn.com/ty455/product/media/images/20220614/9/125455730/292483852/1/1_org_zoom.jpg",
                            Model = "MACBOOK PRO MKGR3TU/A",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 4,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "apple-macbook-pro-mkgr3tua-m1-0-16gb-512gb-macos-14inc",
                            Storage = "512GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 5,
                            Image = "https://cdn.dsmcdn.com/ty360/product/media/images/20220315/17/70305207/292549823/1/1_org_zoom.jpg",
                            Model = "MACBOOK PRO MK1E3TU/A",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 5,
                            Ram = "16GB",
                            Screen = "16",
                            Slug = "apple-macbook-pro-mk1e3tua-m1-0-16gb-512gb-macos-16inc",
                            Storage = "512GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 6,
                            Image = "https://cdn.dsmcdn.com/ty225/product/media/images/20211106/18/168186710/292523675/1/1_org_zoom.jpg",
                            Model = "MACBOOK PRO MK183TU/A",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 6,
                            Ram = "16GB",
                            Screen = "16",
                            Slug = "apple-macbook-pro-mk183tua-m1-0-16gb-512gb-macos-16inc",
                            Storage = "512GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 7,
                            Image = "https://cdn.dsmcdn.com/ty526/product/media/images/20220909/10/171173304/534491537/1/1_org_zoom.jpg",
                            Model = "MACBOOK AIR MLXW3TU/A",
                            Name = "APPLE",
                            Processor = "M2",
                            ProductId = 7,
                            Ram = "8GB",
                            Screen = "13.6",
                            Slug = "apple-macbook-air-mlxw3tua-m2-0-8gb-256gb-macos-136inc",
                            Storage = "256GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 8,
                            Image = "https://cdn.dsmcdn.com/ty174/product/media/images/20210915/17/130206497/242423403/1/1_org_zoom.jpg",
                            Model = "SPECTRE X360 14-EA0007NT 4H1T0EA",
                            Name = "HP",
                            Processor = "I7 1165G7",
                            ProductId = 8,
                            Ram = "16GB",
                            Screen = "13.5",
                            Slug = "hp-spectre-x360-14-ea0007nt-4h1t0ea-i7-1165g7-16gb-1tb-w10-135inc",
                            Storage = "1TB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 9,
                            Image = "https://cdn.dsmcdn.com/ty548/product/media/images/20221001/15/183136719/585077931/1/1_org_zoom.jpg",
                            Model = "MATEBOOK D16",
                            Name = "HUAWEI",
                            Processor = "I5 12450H",
                            ProductId = 9,
                            Ram = "8GB",
                            Screen = "16",
                            Slug = "huawei-matebook-d16-i5-12450h-8gb-512gb-w11-16inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 10,
                            Image = "https://cdn.dsmcdn.com/ty520/product/media/images/20220831/16/167388548/555831617/1/1_org_zoom.jpg",
                            Model = "MATEBOOK D15 53012TTB",
                            Name = "HUAWEI",
                            Processor = "I5 1135G7",
                            ProductId = 10,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "huawei-matebook-d15-53012ttb-i5-1135g7-8gb-512gb-w11-156inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 11,
                            Image = "https://productimages.hepsiburada.net/s/286/1500/110000274844135.jpg",
                            Model = "EXTENSA EX215-54G NX.EGHEY.003",
                            Name = "ACER",
                            Processor = "I5 1135G7",
                            ProductId = 11,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "acer-extensa-ex215-54g-nxeghey003-i5-1135g7-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 12,
                            Image = "https://cdn.dsmcdn.com/ty536/product/media/images/20220920/12/177391340/548065962/1/1_org_zoom.jpg",
                            Model = "EXTENSA EX215-54 NX.EGJEY.005",
                            Name = "ACER",
                            Processor = "I5 1135G7",
                            ProductId = 12,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "acer-extensa-ex215-54-nxegjey005-i5-1135g7-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 13,
                            Image = "https://cdn.dsmcdn.com/ty563/product/media/images/20221014/11/193282551/535765996/1/1_org_zoom.jpg",
                            Model = "NITRO 5 AN517-41 NH.QAQEY.001",
                            Name = "ACER",
                            Processor = "R7 5800H",
                            ProductId = 13,
                            Ram = "16GB",
                            Screen = "17.3",
                            Slug = "acer-nitro-5-an517-41-nhqaqey001-r7-5800h-16gb-512gb-freedos-173inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 14,
                            Image = "https://cdn.dsmcdn.com/ty499/product/media/images/20220804/17/154660914/535766301/1/1_org_zoom.jpg",
                            Model = "NITRO 5 AN517-41 NH.QBGEY.002",
                            Name = "ACER",
                            Processor = "R7 5800H",
                            ProductId = 14,
                            Ram = "16GB",
                            Screen = "17.3",
                            Slug = "acer-nitro-5-an517-41-nhqbgey002-r7-5800h-16gb-512gb-freedos-173inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 15,
                            Image = "https://cdn.dsmcdn.com/ty453/product/media/images/20220613/14/125257935/481230554/1/1_org_zoom.jpg",
                            Model = "NITRO 5 AN515-45 NH.QBAEY.005",
                            Name = "ACER",
                            Processor = "R5 5600H",
                            ProductId = 15,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "acer-nitro-5-an515-45-nhqbaey005-r5-5600h-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 16,
                            Image = "https://cdn.dsmcdn.com/ty499/product/media/images/20220804/17/154660848/535766203/1/1_org_zoom.jpg",
                            Model = "NITRO 5 AN515-45 NH.QBAEY.007",
                            Name = "ACER",
                            Processor = "R7 5800H",
                            ProductId = 16,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "acer-nitro-5-an515-45-nhqbaey007-r7-5800h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 17,
                            Image = "https://cdn.dsmcdn.com/ty184/product/media/images/20211001/16/138389210/252147683/0/0_org_zoom.jpg",
                            Model = "NITRO 5 AN515-45 NH.QBAEY.004",
                            Name = "ACER",
                            Processor = "R7 5800H",
                            ProductId = 17,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "acer-nitro-5-an515-45-nhqbaey004-r7-5800h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 18,
                            Image = "https://cdn.dsmcdn.com/ty492/product/media/images/20220728/16/151466046/530833647/1/1_org_zoom.jpg",
                            Model = "NITRO 5 AN515-45 NH.QBAEY.002",
                            Name = "ACER",
                            Processor = "R5 5600H",
                            ProductId = 18,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "acer-nitro-5-an515-45-nhqbaey002-r5-5600h-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 19,
                            Image = "https://cdn.dsmcdn.com/ty434/product/media/images/20220517/14/112669628/478837285/1/1_org_zoom.jpg",
                            Model = "SWIFT 3 SF314-43 NX.AB1EY.002",
                            Name = "ACER",
                            Processor = "R5 5500U",
                            ProductId = 19,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "acer-swift-3-sf314-43-nxab1ey002-r5-5500u-8gb-512gb-freedos-14inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 20,
                            Image = "https://cdn.dsmcdn.com/ty521/product/media/images/20220901/12/168009115/556787068/1/1_org_zoom.jpg",
                            Model = "ASPIRE 3 A315-56 NX.HS7EY.002",
                            Name = "ACER",
                            Processor = "I3 1005G1",
                            ProductId = 20,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "acer-aspire-3-a315-56-nxhs7ey002-i3-1005g1-8gb-256gb-w10-156inc",
                            Storage = "256GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 21,
                            Image = "https://cdn.dsmcdn.com/ty362/product/media/images/20220315/17/70305226/302326685/1/1_org_zoom.jpg",
                            Model = "MACBOOK PRO MK1F3TU/A",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 21,
                            Ram = "16GB",
                            Screen = "16",
                            Slug = "apple-macbook-pro-mk1f3tua-m1-0-16gb-1tb-macos-16inc",
                            Storage = "1TB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 22,
                            Image = "https://cdn.dsmcdn.com/ty539/product/media/images/20220920/18/177522575/574073391/1/1_org_zoom.jpg",
                            Model = "MACBOOK PRO MNEH3TU/A",
                            Name = "APPLE",
                            Processor = "M2",
                            ProductId = 22,
                            Ram = "8GB",
                            Screen = "13.3",
                            Slug = "apple-macbook-pro-mneh3tua-m2-0-8gb-256gb-macos-133inc",
                            Storage = "256GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 23,
                            Image = "https://cdn.dsmcdn.com/ty512/product/media/images/20220817/14/161464640/545994829/1/1_org_zoom.jpg",
                            Model = "MACBOOK AIR MLY43TU/A",
                            Name = "APPLE",
                            Processor = "M2",
                            ProductId = 23,
                            Ram = "8GB",
                            Screen = "13.6",
                            Slug = "apple-macbook-air-mly43tua-m2-0-8gb-512gb-macos-136inc",
                            Storage = "512GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 24,
                            Image = "https://cdn.dsmcdn.com/ty453/product/media/images/20220613/9/124993692/292444480/1/1_org_zoom.jpg",
                            Model = "MACBOOK PRO MKGP3TU/A",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 24,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "apple-macbook-pro-mkgp3tua-m1-0-16gb-512gb-macos-14inc",
                            Storage = "512GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 25,
                            Image = "https://cdn.dsmcdn.com/ty541/product/media/images/20220928/9/180703209/581535501/1/1_org_zoom.jpg",
                            Model = "MACBOOK AIR MLY33TUA1 Z16000102",
                            Name = "APPLE",
                            Processor = "M2",
                            ProductId = 25,
                            Ram = "16GB",
                            Screen = "13.6",
                            Slug = "apple-macbook-air-mly33tua1-z16000102-m2-0-16gb-256gb-macos-136inc",
                            Storage = "256GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 26,
                            Image = "https://cdn.dsmcdn.com/ty264/product/media/images/20211206/13/5505228/331036763/1/1_org_zoom.jpg",
                            Model = "MACBOOK PRO MKGQ3TU/A",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 26,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "apple-macbook-pro-mkgq3tua-m1-0-16gb-1tb-macos-14inc",
                            Storage = "1TB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 27,
                            Image = "https://cdn.dsmcdn.com/ty437/product/media/images/20220519/11/113491740/129690931/2/2_org_zoom.jpg",
                            Model = "MACBOOK PRO MYD82TU/A",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 27,
                            Ram = "8GB",
                            Screen = "13",
                            Slug = "apple-macbook-pro-myd82tua-m1-0-8gb-256gb-macos-13inc",
                            Storage = "256GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 28,
                            Image = "https://cdn.dsmcdn.com/ty541/product/media/images/20220927/12/180274273/580525600/1/1_org_zoom.jpg",
                            Model = "MACBOOK AIR MLY13TU/A",
                            Name = "APPLE",
                            Processor = "M2",
                            ProductId = 28,
                            Ram = "8GB",
                            Screen = "13.6",
                            Slug = "apple-macbook-air-mly13tua-m2-0-8gb-256gb-macos-136inc",
                            Storage = "256GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 29,
                            Image = "https://cdn.dsmcdn.com/ty407/product/media/images/20220423/22/96755235/456442387/1/1_org_zoom.jpg",
                            Model = "X515JA-EJ2120A2",
                            Name = "ASUS",
                            Processor = "I7 1065G7",
                            ProductId = 29,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-x515ja-ej2120a2-i7-1065g7-16gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 30,
                            Image = "https://cdn.dsmcdn.com/ty444/product/media/images/20220602/16/120044340/492623463/1/1_org_zoom.jpg",
                            Model = "X415EA-EK977",
                            Name = "ASUS",
                            Processor = "I5 1135G7",
                            ProductId = 30,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "asus-x415ea-ek977-i5-1135g7-8gb-256gb-freedos-14inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 31,
                            Image = "https://cdn.dsmcdn.com/ty497/product/media/images/20220802/19/153702007/534012728/1/1_org_zoom.jpg",
                            Model = "X515EA-BQ1186W",
                            Name = "ASUS",
                            Processor = "I5 1135G7",
                            ProductId = 31,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-x515ea-bq1186w-i5-1135g7-8gb-256gb-w11-156inc",
                            Storage = "256GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 32,
                            Image = "https://cdn.dsmcdn.com/ty491/product/media/images/20220725/19/149701017/528561343/1/1_org_zoom.jpg",
                            Model = "TUF F15 FX506LH-HN004W",
                            Name = "ASUS",
                            Processor = "I5 10300H",
                            ProductId = 32,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-tuf-f15-fx506lh-hn004w-i5-10300h-8gb-512gb-w11-156inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 33,
                            Image = "https://cdn.dsmcdn.com/ty363/product/media/images/20220317/12/71390013/418206394/1/1_org_zoom.jpg",
                            Model = "ROG STRIX G15 G513IC-HN037",
                            Name = "ASUS",
                            Processor = "R7 4800H",
                            ProductId = 33,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-rog-strix-g15-g513ic-hn037-r7-4800h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 34,
                            Image = "https://cdn.dsmcdn.com/ty434/product/media/images/20220517/20/112803087/481529736/1/1_org_zoom.jpg",
                            Model = "VIVOBOOK 15 X571LI-BQ377",
                            Name = "ASUS",
                            Processor = "I7 10870H",
                            ProductId = 34,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-vivobook-15-x571li-bq377-i7-10870h-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 35,
                            Image = "https://cdn.dsmcdn.com/ty484/product/media/images/20220720/15/146754703/524560649/1/1_org_zoom.jpg",
                            Model = "ROG ZEPHYRUS G14 GA401QC-BM206 BM20609",
                            Name = "ASUS",
                            Processor = "R7 5800HS",
                            ProductId = 35,
                            Ram = "40GB",
                            Screen = "14",
                            Slug = "asus-rog-zephyrus-g14-ga401qc-bm206-bm20609-r7-5800hs-40gb-2tb-freedos-14inc",
                            Storage = "2TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 36,
                            Image = "https://cdn.dsmcdn.com/ty286/product/media/images/20220104/13/21515281/351491658/1/1_org_zoom.jpg",
                            Model = "X515JF-EJ354",
                            Name = "ASUS",
                            Processor = "I5 1035G1",
                            ProductId = 36,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-x515jf-ej354-i5-1035g1-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 37,
                            Image = "https://cdn.dsmcdn.com/ty212/product/media/images/20211026/16/156776868/275530452/1/1_org_zoom.jpg",
                            Model = "D515DA-BR998",
                            Name = "ASUS",
                            Processor = "R3 3250U",
                            ProductId = 37,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "asus-d515da-br998-r3-3250u-4gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 38,
                            Image = "https://cdn.dsmcdn.com/ty469/product/media/images/20220706/13/136076084/515413748/8/8_org_zoom.jpg",
                            Model = "TUF A15 FA507RM-HN095",
                            Name = "ASUS",
                            Processor = "R7 6800H",
                            ProductId = 38,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-tuf-a15-fa507rm-hn095-r7-6800h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 39,
                            Image = "https://cdn.dsmcdn.com/ty533/product/media/images/20220914/16/175212740/569243579/1/1_org_zoom.jpg",
                            Model = "TUF A15 FA507RM-HN082",
                            Name = "ASUS",
                            Processor = "R7 6800H",
                            ProductId = 39,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-tuf-a15-fa507rm-hn082-r7-6800h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 40,
                            Image = "https://cdn.dsmcdn.com/ty540/product/media/images/20220926/15/180024681/579067581/1/1_org_zoom.jpg",
                            Model = "D515DA-BQ1253",
                            Name = "ASUS",
                            Processor = "R3 3250U",
                            ProductId = 40,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-d515da-bq1253-r3-3250u-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 41,
                            Image = "https://cdn.dsmcdn.com/ty156/product/media/images/20210814/13/118506347/226965507/1/1_org_zoom.jpg",
                            Model = "VIVOBOOK 15 X540UA-DM911",
                            Name = "ASUS",
                            Processor = "I3 7020U",
                            ProductId = 41,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "asus-vivobook-15-x540ua-dm911-i3-7020u-4gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 42,
                            Image = "https://cdn.dsmcdn.com/ty467/product/media/images/20220701/13/133381495/511044991/1/1_org_zoom.jpg",
                            Model = "D515DA-BR3169",
                            Name = "ASUS",
                            Processor = "R3 3250U",
                            ProductId = 42,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "asus-d515da-br3169-r3-3250u-4gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 43,
                            Image = "https://cdn.dsmcdn.com/ty513/product/media/images/20220821/10/163404844/548661780/1/1_org_zoom.jpg",
                            Model = "D515DA-BR1424",
                            Name = "ASUS",
                            Processor = "R3 3250U",
                            ProductId = 43,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-d515da-br1424-r3-3250u-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 44,
                            Image = "https://cdn.dsmcdn.com/ty489/product/media/images/20220725/19/149700927/528561214/1/1_org_zoom.jpg",
                            Model = "TUF F15 FX506LH-HN004W03",
                            Name = "ASUS",
                            Processor = "I5 10300H",
                            ProductId = 44,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-tuf-f15-fx506lh-hn004w03-i5-10300h-16gb-512gb-w11-156inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 45,
                            Image = "https://cdn.dsmcdn.com/ty206/product/media/images/20211020/0/152469119/268899985/0/0_org_zoom.jpg",
                            Model = "X571GTA4-HN1012A4",
                            Name = "ASUS",
                            Processor = "I5 9300H",
                            ProductId = 45,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-x571gta4-hn1012a4-i5-9300h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 46,
                            Image = "https://cdn.dsmcdn.com/ty407/product/media/images/20220423/22/96760727/456449064/1/1_org_zoom.jpg",
                            Model = "X515JA-EJ2120A108",
                            Name = "ASUS",
                            Processor = "I7 1065G7",
                            ProductId = 46,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-x515ja-ej2120a108-i7-1065g7-16gb-512gb-w11p-156inc",
                            Storage = "512GB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 47,
                            Image = "https://cdn.dsmcdn.com/ty540/product/media/images/20220926/22/180132924/579642085/1/1_org_zoom.jpg",
                            Model = "ROG STRIX G513IE-HN065A16",
                            Name = "ASUS",
                            Processor = "R7 4800H",
                            ProductId = 47,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-rog-strix-g513ie-hn065a16-r7-4800h-16gb-512gb-w10-156inc",
                            Storage = "512GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 48,
                            Image = "https://cdn.dsmcdn.com/ty405/product/media/images/20220423/21/96750249/456436426/1/1_org_zoom.jpg",
                            Model = "X515JA-EJ2120A4",
                            Name = "ASUS",
                            Processor = "I7 1065G7",
                            ProductId = 48,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-x515ja-ej2120a4-i7-1065g7-16gb-1tb-freedos-156inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 49,
                            Image = "https://cdn.dsmcdn.com/ty265/product/media/images/20211207/11/6237110/331759125/1/1_org_zoom.jpg",
                            Model = "VIVOBOOK K3400PH-KM018",
                            Name = "ASUS",
                            Processor = "I5 11300H",
                            ProductId = 49,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "asus-vivobook-k3400ph-km018-i5-11300h-16gb-512gb-freedos-14inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 50,
                            Image = "https://cdn.dsmcdn.com/ty424/product/media/images/20220509/13/107358934/474477130/1/1_org_zoom.jpg",
                            Model = "X515JA-EJ2120A3",
                            Name = "ASUS",
                            Processor = "I7 1065G7",
                            ProductId = 50,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-x515ja-ej2120a3-i7-1065g7-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 51,
                            Image = "https://cdn.dsmcdn.com/ty373/product/media/images/20220326/16/76361813/426601079/1/1_org_zoom.jpg",
                            Model = "D513UA-L1346",
                            Name = "ASUS",
                            Processor = "R5 5500U",
                            ProductId = 51,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-d513ua-l1346-r5-5500u-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 52,
                            Image = "https://cdn.dsmcdn.com/ty440/product/media/images/20220523/8/114971600/484876597/2/2_org_zoom.jpg",
                            Model = "INSPIRON 15 3511 I35111015U",
                            Name = "DELL",
                            Processor = "I5 1135G7",
                            ProductId = 52,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "dell-inspiron-15-3511-i35111015u-i5-1135g7-8gb-512gb-ubuntu-156inc",
                            Storage = "512GB",
                            System = "UBUNTU"
                        },
                        new
                        {
                            DetailId = 53,
                            Image = "https://cdn.dsmcdn.com/ty519/product/media/images/20220902/22/168739590/542841093/1/1_org_zoom.jpg",
                            Model = "G15 5511 G55112306U",
                            Name = "DELL",
                            Processor = "I5 11260H",
                            ProductId = 53,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "dell-g15-5511-g55112306u-i5-11260h-16gb-512gb-ubuntu-156inc",
                            Storage = "512GB",
                            System = "UBUNTU"
                        },
                        new
                        {
                            DetailId = 54,
                            Image = "https://cdn.dsmcdn.com/ty396/product/media/images/20220414/19/91946702/449495790/1/1_org_zoom.jpg",
                            Model = "G15 5511 G55112801U04",
                            Name = "DELL",
                            Processor = "I7 11800H",
                            ProductId = 54,
                            Ram = "64GB",
                            Screen = "15.6",
                            Slug = "dell-g15-5511-g55112801u04-i7-11800h-64gb-1tb-freedos-156inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 55,
                            Image = "https://cdn.dsmcdn.com/ty341/product/media/images/20220223/16/57408929/396254952/1/1_org_zoom.jpg",
                            Model = "INSPIRON 3511 F35OBF821NA46",
                            Name = "DELL",
                            Processor = "I5 1135G7",
                            ProductId = 55,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "dell-inspiron-3511-f35obf821na46-i5-1135g7-16gb-512gb-w10p-156inc",
                            Storage = "512GB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 56,
                            Image = "https://cdn.dsmcdn.com/ty386/product/media/images/20220406/12/84413709/343124626/1/1_org_zoom.jpg",
                            Model = "EXCALIBUR G770.1140-BVL0X-B",
                            Name = "CASPER",
                            Processor = "I5 11400H",
                            ProductId = 56,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "casper-excalibur-g7701140-bvl0x-b-i5-11400h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 57,
                            Image = "https://cdn.dsmcdn.com/ty553/product/media/images/20221005/12/186410812/589622759/1/1_org_zoom.jpg",
                            Model = "15-DW4010NT 6Y7Z9EA",
                            Name = "HP",
                            Processor = "I5 1235U",
                            ProductId = 57,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "hp-15-dw4010nt-6y7z9ea-i5-1235u-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 58,
                            Image = "https://cdn.dsmcdn.com/ty439/product/media/images/20220525/16/116221036/487333877/1/1_org_zoom.jpg",
                            Model = "PAVILION 15 DK2080NT 68N55EA",
                            Name = "HP",
                            Processor = "I7 11370H",
                            ProductId = 58,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "hp-pavilion-15-dk2080nt-68n55ea-i7-11370h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 59,
                            Image = "https://cdn.dsmcdn.com/ty108/product/media/images/20210430/14/84113570/168995760/1/1_org_zoom.jpg",
                            Model = "PAVILION 15-EG0013NT 2Y7X6EA",
                            Name = "HP",
                            Processor = "I5 1135G7",
                            ProductId = 59,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "hp-pavilion-15-eg0013nt-2y7x6ea-i5-1135g7-8gb-256gb-w10-156inc",
                            Storage = "256GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 60,
                            Image = "https://cdn.dsmcdn.com/ty161/product/media/images/20210819/17/120217524/229810485/1/1_org_zoom.jpg",
                            Model = "PAVILION 14-DV0029NT 4H0U5EA",
                            Name = "HP",
                            Processor = "I7 1165G7",
                            ProductId = 60,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "hp-pavilion-14-dv0029nt-4h0u5ea-i7-1165g7-8gb-512gb-w10-14inc",
                            Storage = "512GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 61,
                            Image = "https://cdn.dsmcdn.com/ty331/product/media/images/20220214/19/50297959/387574138/1/1_org_zoom.jpg",
                            Model = "ZBOOK STUDIO G8 314G1EA",
                            Name = "HP",
                            Processor = "I7 11850H",
                            ProductId = 61,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "hp-zbook-studio-g8-314g1ea-i7-11850h-32gb-1tb-w10p-156inc",
                            Storage = "1TB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 62,
                            Image = "https://cdn.dsmcdn.com/ty550/product/media/images/20221003/15/184882729/587391474/1/1_org_zoom.jpg",
                            Model = "PAVILION 15-EC2052NT 68N66EA",
                            Name = "HP",
                            Processor = "R7 5800H",
                            ProductId = 62,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "hp-pavilion-15-ec2052nt-68n66ea-r7-5800h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 63,
                            Image = "https://cdn.dsmcdn.com/ty410/product/media/images/20220425/16/97405357/447144351/1/1_org_zoom.jpg",
                            Model = "PAVILION 15-EC2051NT 68N67EA",
                            Name = "HP",
                            Processor = "R7 5800H",
                            ProductId = 63,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "hp-pavilion-15-ec2051nt-68n67ea-r7-5800h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 64,
                            Image = "https://cdn.dsmcdn.com/ty458/product/media/images/20220617/19/126898871/502129416/1/1_org_zoom.jpg",
                            Model = "ELITEBOOK 840 G8 336D6EA",
                            Name = "HP",
                            Processor = "I7 1165G7",
                            ProductId = 64,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "hp-elitebook-840-g8-336d6ea-i7-1165g7-16gb-512gb-w10p-14inc",
                            Storage = "512GB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 65,
                            Image = "https://cdn.dsmcdn.com/ty25/product/media/images/20201125/18/32521040/112935099/1/1_org_zoom.jpg",
                            Model = "14S-FQ0014NT 227D6EA",
                            Name = "HP",
                            Processor = "R3 3250U",
                            ProductId = 65,
                            Ram = "4GB",
                            Screen = "14",
                            Slug = "hp-14s-fq0014nt-227d6ea-r3-3250u-4gb-128gb-w10-14inc",
                            Storage = "128GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 66,
                            Image = "https://cdn.dsmcdn.com/ty24/product/media/images/20201116/10/26710285/106450738/1/1_org_zoom.jpg",
                            Model = "14S-FQ0014NT 227D9EA",
                            Name = "HP",
                            Processor = "R3 3250U",
                            ProductId = 66,
                            Ram = "4GB",
                            Screen = "14",
                            Slug = "hp-14s-fq0014nt-227d9ea-r3-3250u-4gb-128gb-w10-14inc",
                            Storage = "128GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 67,
                            Image = "https://cdn.dsmcdn.com/ty458/product/media/images/20220620/12/128009366/503438152/1/1_org_zoom.jpg",
                            Model = "PROBOOK 450 G8 2X7X4EA",
                            Name = "HP",
                            Processor = "I5 1135G7",
                            ProductId = 67,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "hp-probook-450-g8-2x7x4ea-i5-1135g7-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 68,
                            Image = "https://cdn.dsmcdn.com/ty544/product/media/images/20220930/16/181849292/463272710/1/1_org_zoom.jpg",
                            Model = "PAVILION 15-EC2059NT 68N74EA",
                            Name = "HP",
                            Processor = "R5 5600H",
                            ProductId = 68,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "hp-pavilion-15-ec2059nt-68n74ea-r5-5600h-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 69,
                            Image = "https://cdn.dsmcdn.com/ty408/product/media/images/20220425/16/97403890/447158294/1/1_org_zoom.jpg",
                            Model = "PAVILION 15-EC2056NT 68N71EA",
                            Name = "HP",
                            Processor = "R5 5600H",
                            ProductId = 69,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "hp-pavilion-15-ec2056nt-68n71ea-r5-5600h-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 70,
                            Image = "https://cdn.dsmcdn.com/ty317/product/media/images/20220131/23/39951477/377032608/1/1_org_zoom.jpg",
                            Model = "255 G8 4P3M3ES08",
                            Name = "HP",
                            Processor = "R7 5700U",
                            ProductId = 70,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "hp-255-g8-4p3m3es08-r7-5700u-32gb-1tb-w10-156inc",
                            Storage = "1TB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 71,
                            Image = "https://cdn.dsmcdn.com/ty263/product/media/images/20211203/12/3528167/328435116/1/1_org_zoom.jpg",
                            Model = "255 G8 4P3M3ES",
                            Name = "HP",
                            Processor = "R7 5700U",
                            ProductId = 71,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "hp-255-g8-4p3m3es-r7-5700u-8gb-256gb-w10-156inc",
                            Storage = "256GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 72,
                            Image = "https://cdn.dsmcdn.com/ty547/product/media/images/20221003/12/184454397/586874853/1/1_org_zoom.jpg",
                            Model = "ELITEBOOK 630 G9 6S6Y3EA",
                            Name = "HP",
                            Processor = "I5 1235U",
                            ProductId = 72,
                            Ram = "16GB",
                            Screen = "13.3",
                            Slug = "hp-elitebook-630-g9-6s6y3ea-i5-1235u-16gb-512gb-freedos-133inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 73,
                            Image = "https://cdn.dsmcdn.com/ty170/product/media/images/20210902/9/124923242/235966940/1/1_org_zoom.jpg",
                            Model = "ENVY 13-BA1009NT 4H0T7EA",
                            Name = "HP",
                            Processor = "I7 1165G7",
                            ProductId = 73,
                            Ram = "16GB",
                            Screen = "13.3",
                            Slug = "hp-envy-13-ba1009nt-4h0t7ea-i7-1165g7-16gb-512gb-w10-133inc",
                            Storage = "512GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 74,
                            Image = "https://cdn.dsmcdn.com/ty135/product/media/images/20210625/13/104333427/121343094/1/1_org_zoom.jpg",
                            Model = "15-DA2033NT 9HN16EA",
                            Name = "HP",
                            Processor = "I5 10210U",
                            ProductId = 74,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "hp-15-da2033nt-9hn16ea-i5-10210u-4gb-256gb-w10-156inc",
                            Storage = "256GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 75,
                            Image = "https://cdn.dsmcdn.com/ty523/product/media/images/20220903/14/168876317/558576889/1/1_org_zoom.jpg",
                            Model = "15S-EQ3004NT 68N36EA",
                            Name = "HP",
                            Processor = "R7 5825U",
                            ProductId = 75,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "hp-15s-eq3004nt-68n36ea-r7-5825u-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 76,
                            Image = "https://cdn.dsmcdn.com/ty270/product/media/images/20211216/18/12291663/339397937/1/1_org_zoom.jpg",
                            Model = "PAVILION 13-BB0007NT 4J670EA",
                            Name = "HP",
                            Processor = "I7 1165G7",
                            ProductId = 76,
                            Ram = "8GB",
                            Screen = "13.3",
                            Slug = "hp-pavilion-13-bb0007nt-4j670ea-i7-1165g7-8gb-512gb-w10-133inc",
                            Storage = "512GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 77,
                            Image = "https://cdn.dsmcdn.com/ty489/product/media/images/20220727/10/150658553/475837892/1/1_org_zoom.jpg",
                            Model = "OMEN 15-EN1018NT 4H0R8EA",
                            Name = "HP",
                            Processor = "R7 5800H",
                            ProductId = 77,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "hp-omen-15-en1018nt-4h0r8ea-r7-5800h-16gb-1tb-freedos-156inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 78,
                            Image = "https://cdn.dsmcdn.com/ty257/product/media/images/20211127/19/156169/323919825/1/1_org_zoom.jpg",
                            Model = "ZBOOK STUDIO G8 314F7EA",
                            Name = "HP",
                            Processor = "I7 11800H",
                            ProductId = 78,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "hp-zbook-studio-g8-314f7ea-i7-11800h-16gb-512gb-w10p-156inc",
                            Storage = "512GB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 79,
                            Image = "https://cdn.dsmcdn.com/ty292/product/media/images/20220110/10/23935886/354814259/1/1_org_zoom.jpg",
                            Model = "255 G8 4P3K9ES",
                            Name = "HP",
                            Processor = "R5 5500U",
                            ProductId = 79,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "hp-255-g8-4p3k9es-r5-5500u-8gb-256gb-w10-156inc",
                            Storage = "256GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 80,
                            Image = "https://cdn.dsmcdn.com/ty516/product/media/images/20220825/16/165572843/552353656/1/1_org_zoom.jpg",
                            Model = "255 G8 4P3M4ES",
                            Name = "HP",
                            Processor = "R7 5700U",
                            ProductId = 80,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "hp-255-g8-4p3m4es-r7-5700u-8gb-512gb-w10-156inc",
                            Storage = "512GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 81,
                            Image = "https://cdn.dsmcdn.com/ty394/product/media/images/20220412/12/89104303/445405341/1/1_org_zoom.jpg",
                            Model = "MATEBOOK D15 BOD-WFE9",
                            Name = "HUAWEI",
                            Processor = "I7 1165G7",
                            ProductId = 81,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "huawei-matebook-d15-bod-wfe9-i7-1165g7-16gb-512gb-w11-156inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 82,
                            Image = "https://cdn.dsmcdn.com/ty527/product/media/images/20220909/10/171163919/561701052/1/1_org_zoom.jpg",
                            Model = "MATEBOOK D15 IRIS XE",
                            Name = "HUAWEI",
                            Processor = "I5 1135G7",
                            ProductId = 82,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "huawei-matebook-d15-iris-xe-i5-1135g7-8gb-256gb-w11-156inc",
                            Storage = "256GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 83,
                            Image = "https://cdn.dsmcdn.com/ty532/product/media/images/20220913/18/174936826/568816826/1/1_org_zoom.jpg",
                            Model = "MATEBOOK 16S CREF-X9611T",
                            Name = "HUAWEI",
                            Processor = "I9 12900H",
                            ProductId = 83,
                            Ram = "16GB",
                            Screen = "16",
                            Slug = "huawei-matebook-16s-cref-x9611t-i9-12900h-16gb-1tb-w11-16inc",
                            Storage = "1TB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 84,
                            Image = "https://cdn.dsmcdn.com/ty521/product/media/images/20220901/9/167922084/556589085/1/1_org_zoom.jpg",
                            Model = "MATEBOOK 16",
                            Name = "HUAWEI",
                            Processor = "R7 5800H",
                            ProductId = 84,
                            Ram = "16GB",
                            Screen = "16",
                            Slug = "huawei-matebook-16-r7-5800h-16gb-512gb-w11-16inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 85,
                            Image = "https://cdn.dsmcdn.com/ty433/product/media/images/20220517/20/112817837/481543708/1/1_org_zoom.jpg",
                            Model = "MATEBOOK D15 BOD-WDI9",
                            Name = "HUAWEI",
                            Processor = "I3 1115G4",
                            ProductId = 85,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "huawei-matebook-d15-bod-wdi9-i3-1115g4-8gb-256gb-w11-156inc",
                            Storage = "256GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 86,
                            Image = "https://cdn.dsmcdn.com/ty318/product/media/images/20220202/14/41808255/378512354/1/1_org_zoom.jpg",
                            Model = "MATEBOOK D15 MBOOKD15R5",
                            Name = "HUAWEI",
                            Processor = "R5 5500U",
                            ProductId = 86,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "huawei-matebook-d15-mbookd15r5-r5-5500u-8gb-512gb-w11-156inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 87,
                            Image = "https://cdn.dsmcdn.com/ty514/product/media/images/20220824/11/164893561/551293277/1/1_org_zoom.jpg",
                            Model = "THINKPAD E14 G2 20TA0055TX",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 87,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-e14-g2-20ta0055tx-i7-1165g7-16gb-512gb-freedos-14inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 88,
                            Image = "https://cdn.dsmcdn.com/ty387/product/media/images/20220407/10/85295995/439742382/1/1_org_zoom.jpg",
                            Model = "THINKPAD E15 G2 20TDS02VTX053",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 88,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-e15-g2-20tds02vtx053-i7-1165g7-32gb-1tb-w11p-156inc",
                            Storage = "1TB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 89,
                            Image = "https://cdn.dsmcdn.com/ty326/product/media/images/20220207/15/46281283/350855754/2/2_org_zoom.jpg",
                            Model = "IDEAPAD L3 82HL009KTX",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 89,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-ideapad-l3-82hl009ktx-i5-1135g7-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 90,
                            Image = "https://cdn.dsmcdn.com/ty501/product/media/images/20220810/14/157494946/138347822/1/1_org_zoom.jpg",
                            Model = "THINKPAD E15 G2 20TD0045TX",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 90,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-e15-g2-20td0045tx-i5-1135g7-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 91,
                            Image = "https://cdn.dsmcdn.com/ty335/product/media/images/20220217/11/51620926/389546940/1/1_org_zoom.jpg",
                            Model = "THINKBOOK 15 G3 ACL 21A40037TX",
                            Name = "LENOVO",
                            Processor = "R7 5700U",
                            ProductId = 91,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkbook-15-g3-acl-21a40037tx-r7-5700u-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 92,
                            Image = "https://cdn.dsmcdn.com/ty482/product/media/images/20220718/13/143818986/523433148/1/1_org_zoom.jpg",
                            Model = "V14 82KC0005TX",
                            Name = "LENOVO",
                            Processor = "R3 5300U",
                            ProductId = 92,
                            Ram = "4GB",
                            Screen = "14",
                            Slug = "lenovo-v14-82kc0005tx-r3-5300u-4gb-256gb-freedos-14inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 93,
                            Image = "https://cdn.dsmcdn.com/ty343/product/media/images/20220224/13/57962650/397080315/1/1_org_zoom.jpg",
                            Model = "THINKPAD L15 G2 20X4S25A00",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 93,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-l15-g2-20x4s25a00-i7-1165g7-16gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 94,
                            Image = "https://cdn.dsmcdn.com/ty488/product/media/images/20220722/11/147418005/525730760/1/1_org_zoom.jpg",
                            Model = "V15 G2 ALC 82KD0042TX",
                            Name = "LENOVO",
                            Processor = "R5 5500U",
                            ProductId = 94,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-v15-g2-alc-82kd0042tx-r5-5500u-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 95,
                            Image = "https://cdn.dsmcdn.com/ty534/product/media/images/20220915/17/175584282/560731524/2/2_org_zoom.jpg",
                            Model = "V14 G2 82KA0027TX",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 95,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "lenovo-v14-g2-82ka0027tx-i5-1135g7-8gb-512gb-w10-14inc",
                            Storage = "512GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 96,
                            Image = "https://cdn.dsmcdn.com/ty469/product/media/images/20220704/13/134977606/513429787/1/1_org_zoom.jpg",
                            Model = "IDEAPAD 5 15ALC05 82LN00CCTX",
                            Name = "LENOVO",
                            Processor = "R5 5500U",
                            ProductId = 96,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-ideapad-5-15alc05-82ln00cctx-r5-5500u-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 97,
                            Image = "https://cdn.dsmcdn.com/ty467/product/media/images/20220701/12/133364713/511042405/1/1_org_zoom.jpg",
                            Model = "V15 82NB003GTX",
                            Name = "LENOVO",
                            Processor = "I5 10210U",
                            ProductId = 97,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-v15-82nb003gtx-i5-10210u-8gb-512gb-w10-156inc",
                            Storage = "512GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 98,
                            Image = "https://cdn.dsmcdn.com/ty462/product/media/images/20220628/18/131331269/508452553/1/1_org_zoom.jpg",
                            Model = "IDEAPAD 3 15ALC6 82KU00VNTXA7",
                            Name = "LENOVO",
                            Processor = "R7 5700U",
                            ProductId = 98,
                            Ram = "20GB",
                            Screen = "15.6",
                            Slug = "lenovo-ideapad-3-15alc6-82ku00vntxa7-r7-5700u-20gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 99,
                            Image = "https://cdn.dsmcdn.com/ty307/product/media/images/20220125/18/35885105/370823902/1/1_org_zoom.jpg",
                            Model = "V14 G2 ALC 82KC0005TX02",
                            Name = "LENOVO",
                            Processor = "R3 5300U",
                            ProductId = 99,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "lenovo-v14-g2-alc-82kc0005tx02-r3-5300u-8gb-256gb-freedos-14inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 100,
                            Image = "https://cdn.dsmcdn.com/ty525/product/media/images/20220910/10/171490919/562056574/1/1_org_zoom.jpg",
                            Model = "IDEAPAD G3 82K100KDTX",
                            Name = "LENOVO",
                            Processor = "I7 11390H",
                            ProductId = 100,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-ideapad-g3-82k100kdtx-i7-11390h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 101,
                            Image = "https://cdn.dsmcdn.com/ty115/product/media/images/20210517/12/88985574/175007395/1/1_org_zoom.jpg",
                            Model = "THINKPAD X1 NANO G1 20UN002TTX",
                            Name = "LENOVO",
                            Processor = "I7 1160G7",
                            ProductId = 101,
                            Ram = "16GB",
                            Screen = "13",
                            Slug = "lenovo-thinkpad-x1-nano-g1-20un002ttx-i7-1160g7-16gb-512gb-w10p-13inc",
                            Storage = "512GB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 102,
                            Image = "https://cdn.dsmcdn.com/ty485/product/media/images/20220719/14/145670720/524061565/1/1_org_zoom.jpg",
                            Model = "LEGION 5 82JM0013TX",
                            Name = "LENOVO",
                            Processor = "I7 11800H",
                            ProductId = 102,
                            Ram = "16GB",
                            Screen = "17.3",
                            Slug = "lenovo-legion-5-82jm0013tx-i7-11800h-16gb-512gb-freedos-173inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 103,
                            Image = "https://cdn.dsmcdn.com/ty38/product/media/images/20210322/0/74174810/119819284/1/1_org_zoom.jpg",
                            Model = "V15 IIL 82C500R2TX",
                            Name = "LENOVO",
                            Processor = "I5 1035G1",
                            ProductId = 103,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "lenovo-v15-iil-82c500r2tx-i5-1035g1-4gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 104,
                            Image = "https://cdn.dsmcdn.com/ty465/product/media/images/20220704/9/134772151/513126804/1/1_org_zoom.jpg",
                            Model = "IDEAPAD 3 15ALC6 82KU00VNTXA147",
                            Name = "LENOVO",
                            Processor = "R7 5700U",
                            ProductId = 104,
                            Ram = "20GB",
                            Screen = "15.6",
                            Slug = "lenovo-ideapad-3-15alc6-82ku00vntxa147-r7-5700u-20gb-512gb-w11p-156inc",
                            Storage = "512GB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 105,
                            Image = "https://cdn.dsmcdn.com/ty267/product/media/images/20211213/17/10146388/336759209/1/1_org_zoom.jpg",
                            Model = "V15 G2 ALC 82KD004ATX",
                            Name = "LENOVO",
                            Processor = "R3 5300U",
                            ProductId = 105,
                            Ram = "12GB",
                            Screen = "15.6",
                            Slug = "lenovo-v15-g2-alc-82kd004atx-r3-5300u-12gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 106,
                            Image = "https://cdn.dsmcdn.com/ty379/product/media/images/20220401/13/80356263/432963732/1/1_org_zoom.jpg",
                            Model = "V14 G2 ITL 82KA0026TX",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 106,
                            Ram = "4GB",
                            Screen = "14",
                            Slug = "lenovo-v14-g2-itl-82ka0026tx-i5-1135g7-4gb-256gb-freedos-14inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 107,
                            Image = "https://cdn.dsmcdn.com/ty511/product/media/images/20220818/14/162339283/138345564/1/1_org_zoom.jpg",
                            Model = "THINKPAD E15 G2 20TD004KTX",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 107,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-e15-g2-20td004ktx-i7-1165g7-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 108,
                            Image = "https://cdn.dsmcdn.com/ty465/product/media/images/20220701/11/133355139/511028440/1/1_org_zoom.jpg",
                            Model = "IDEAPAD 3 15ITL6 82H802F7TX",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 108,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-ideapad-3-15itl6-82h802f7tx-i7-1165g7-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 109,
                            Image = "https://cdn.dsmcdn.com/ty569/product/media/images/20221017/14/195646030/356353975/1/1_org_zoom.jpg",
                            Model = "SUMMIT E13 FLIP EVO A11MT-232TR",
                            Name = "MSI",
                            Processor = "I7 1195G7",
                            ProductId = 109,
                            Ram = "16GB",
                            Screen = "13.4",
                            Slug = "msi-summit-e13-flip-evo-a11mt-232tr-i7-1195g7-16gb-512gb-w10p-134inc",
                            Storage = "512GB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 110,
                            Image = "https://cdn.dsmcdn.com/ty455/product/media/images/20220614/13/125537962/498608765/1/1_org_zoom.jpg",
                            Model = "TITAN GT77 12UHS-036TR",
                            Name = "MSI",
                            Processor = "I9 12900HX",
                            ProductId = 110,
                            Ram = "64GB",
                            Screen = "17.3",
                            Slug = "msi-titan-gt77-12uhs-036tr-i9-12900hx-64gb-2tb-w11-173inc",
                            Storage = "2TB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 111,
                            Image = "https://cdn.dsmcdn.com/ty384/product/media/images/20220405/15/83633348/437436441/1/1_org_zoom.jpg",
                            Model = "PULSE GL76 12UEK-247XTR",
                            Name = "MSI",
                            Processor = "I7 12700H",
                            ProductId = 111,
                            Ram = "16GB",
                            Screen = "17.3",
                            Slug = "msi-pulse-gl76-12uek-247xtr-i7-12700h-16gb-1tb-freedos-173inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 112,
                            Image = "https://cdn.dsmcdn.com/ty544/product/media/images/20220929/19/181424220/583199997/1/1_org_zoom.jpg",
                            Model = "TUF A15 FA507RM-HN052",
                            Name = "ASUS",
                            Processor = "R7 6800H",
                            ProductId = 112,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-tuf-a15-fa507rm-hn052-r7-6800h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 113,
                            Image = "https://productimages.hepsiburada.net/s/230/1500/110000211864305.jpg",
                            Model = "ROG STRIX G15 G513RM-HF265",
                            Name = "ASUS",
                            Processor = "R7 6800H",
                            ProductId = 113,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-rog-strix-g15-g513rm-hf265-r7-6800h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 114,
                            Image = "https://productimages.hepsiburada.net/s/238/1500/110000221636161.jpg",
                            Model = "ROG STRIX G15 G513RM-HF266",
                            Name = "ASUS",
                            Processor = "R7 6800H",
                            ProductId = 114,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-rog-strix-g15-g513rm-hf266-r7-6800h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 115,
                            Image = "https://cdn.dsmcdn.com/ty461/product/media/images/20220623/16/129271889/505509256/1/1_org_zoom.jpg",
                            Model = "ROG STRIX G15 G513RW-HF208",
                            Name = "ASUS",
                            Processor = "R7 6800H",
                            ProductId = 115,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-rog-strix-g15-g513rw-hf208-r7-6800h-16gb-1tb-freedos-156inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 116,
                            Image = "https://cdn.dsmcdn.com/ty454/product/media/images/20220615/19/125993174/500518976/1/1_org_zoom.jpg",
                            Model = "ROG STRIX G15 G513RW-HF206",
                            Name = "ASUS",
                            Processor = "R7 6800H",
                            ProductId = 116,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-rog-strix-g15-g513rw-hf206-r7-6800h-16gb-1tb-freedos-156inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 117,
                            Image = "https://cdn.dsmcdn.com/ty458/product/media/images/20220617/16/126783528/501919587/1/1_org_zoom.jpg",
                            Model = "TUF A15 FA507RM-HN096",
                            Name = "ASUS",
                            Processor = "R7 6800H",
                            ProductId = 117,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-tuf-a15-fa507rm-hn096-r7-6800h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 118,
                            Image = "https://cdn.dsmcdn.com/ty542/product/media/images/20220927/16/180345127/580972342/1/1_org_zoom.jpg",
                            Model = "D515DA-BQ9801",
                            Name = "ASUS",
                            Processor = "R3 3250U",
                            ProductId = 118,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-d515da-bq9801-r3-3250u-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 119,
                            Image = "https://cdn.dsmcdn.com/ty279/product/media/images/20211229/18/18786513/347784804/1/1_org_zoom.jpg",
                            Model = "D515DA-BR114201",
                            Name = "ASUS",
                            Processor = "R3 3250U",
                            ProductId = 119,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-d515da-br114201-r3-3250u-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 120,
                            Image = "https://cdn.dsmcdn.com/ty403/product/media/images/20220419/11/94230005/452590427/1/1_org_zoom.jpg",
                            Model = "D515DA-EJ1426",
                            Name = "ASUS",
                            Processor = "R3 3250U",
                            ProductId = 120,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-d515da-ej1426-r3-3250u-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 121,
                            Image = "https://productimages.hepsiburada.net/s/59/1500/110000000086985.jpg",
                            Model = "D515DA-BR125",
                            Name = "ASUS",
                            Processor = "R3 3250U",
                            ProductId = 121,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "asus-d515da-br125-r3-3250u-4gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 122,
                            Image = "https://cdn.dsmcdn.com/ty457/product/media/images/20220621/12/128354954/484684898/1/1_org_zoom.jpg",
                            Model = "D515DA-EJ819",
                            Name = "ASUS",
                            Processor = "R3 3250U",
                            ProductId = 122,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "asus-d515da-ej819-r3-3250u-4gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 123,
                            Image = "https://cdn.dsmcdn.com/ty205/product/media/images/20211020/15/152898015/269470580/1/1_org_zoom.jpg",
                            Model = "D515DA-BR408",
                            Name = "ASUS",
                            Processor = "R3 3250U",
                            ProductId = 123,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "asus-d515da-br408-r3-3250u-4gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 124,
                            Image = "https://cdn.dsmcdn.com/ty538/product/media/images/20220922/11/178394138/575211420/1/1_org_zoom.jpg",
                            Model = "ROG STRIX G15 G513IE-HN085",
                            Name = "ASUS",
                            Processor = "R7 4800H",
                            ProductId = 124,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-rog-strix-g15-g513ie-hn085-r7-4800h-16gb-1tb-freedos-156inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 125,
                            Image = "https://cdn.dsmcdn.com/ty517/product/media/images/20220826/15/166029863/496851979/1/1_org_zoom.jpg",
                            Model = "ROG STRIX G15 G513IC-HN096",
                            Name = "ASUS",
                            Processor = "R7 4800H",
                            ProductId = 125,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-rog-strix-g15-g513ic-hn096-r7-4800h-16gb-1tb-freedos-156inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 126,
                            Image = "https://cdn.dsmcdn.com/ty453/product/media/images/20220615/19/125990421/500514835/1/1_org_zoom.jpg",
                            Model = "ROG STRIX G15 G513IC-HN049",
                            Name = "ASUS",
                            Processor = "R7 4800H",
                            ProductId = 126,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-rog-strix-g15-g513ic-hn049-r7-4800h-16gb-1tb-freedos-156inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 127,
                            Image = "https://productimages.hepsiburada.net/s/153/500/110000109351190.jpg",
                            Model = "X509UA-EJ073",
                            Name = "ASUS",
                            Processor = "I3 7020U",
                            ProductId = 127,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "asus-x509ua-ej073-i3-7020u-4gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 128,
                            Image = "https://cdn.dsmcdn.com/ty532/product/media/images/20220915/11/175446404/548427705/1/1_org_zoom.jpg",
                            Model = "TUF FX506LHB-HN348",
                            Name = "ASUS",
                            Processor = "I5 10300H",
                            ProductId = 128,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-tuf-fx506lhb-hn348-i5-10300h-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 129,
                            Image = "https://cdn.dsmcdn.com/ty550/product/media/images/20221003/13/184697766/587105427/1/1_org_zoom.jpg",
                            Model = "TUF FX506LHB-HN345",
                            Name = "ASUS",
                            Processor = "I5 10300H",
                            ProductId = 129,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-tuf-fx506lhb-hn345-i5-10300h-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 130,
                            Image = "https://cdn.dsmcdn.com/ty455/product/media/images/20220615/20/126013729/500548198/4/4_org_zoom.jpg",
                            Model = "TUF FX506LHB-HN323",
                            Name = "ASUS",
                            Processor = "I5 10300H",
                            ProductId = 130,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-tuf-fx506lhb-hn323-i5-10300h-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 131,
                            Image = "https://productimages.hepsiburada.net/s/274/1500/110000259769021.jpg",
                            Model = "TUF F15 FX506LHB-HN348",
                            Name = "ASUS",
                            Processor = "I5 10300H",
                            ProductId = 131,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-tuf-f15-fx506lhb-hn348-i5-10300h-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 132,
                            Image = "https://cdn.dsmcdn.com/ty526/product/media/images/20220909/10/171173790/561701573/1/1_org_zoom.jpg",
                            Model = "X515EA-BR2026A",
                            Name = "ASUS",
                            Processor = "I5 1135G7",
                            ProductId = 132,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-x515ea-br2026a-i5-1135g7-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 133,
                            Image = "https://cdn.dsmcdn.com/ty454/product/media/images/20220615/13/125839491/500309917/1/1_org_zoom.jpg",
                            Model = "X415EA-EB976",
                            Name = "ASUS",
                            Processor = "I5 1135G7",
                            ProductId = 133,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "asus-x415ea-eb976-i5-1135g7-8gb-256gb-freedos-14inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 134,
                            Image = "https://cdn.dsmcdn.com/ty516/product/media/images/20220824/16/165098279/551543513/1/1_org_zoom.jpg",
                            Model = "VIVOBOOK 15 K513EP L157602",
                            Name = "ASUS",
                            Processor = "I5 1135G7",
                            ProductId = 134,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-vivobook-15-k513ep-l157602-i5-1135g7-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 135,
                            Image = "https://cdn.dsmcdn.com/ty527/product/media/images/20220908/13/170706007/561205442/1/1_org_zoom.jpg",
                            Model = "VIVOBOOK K513EPA4-L1576A4",
                            Name = "ASUS",
                            Processor = "I5 1135G7",
                            ProductId = 135,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-vivobook-k513epa4-l1576a4-i5-1135g7-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 136,
                            Image = "https://cdn.dsmcdn.com/ty346/product/media/images/20220302/16/61340509/401502762/1/1_org_zoom.jpg",
                            Model = "X515EA-EJ122927",
                            Name = "ASUS",
                            Processor = "I5 1135G7",
                            ProductId = 136,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-x515ea-ej122927-i5-1135g7-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 137,
                            Image = "https://cdn.dsmcdn.com/ty453/product/media/images/20220613/12/125240114/499387703/1/1_org_zoom.jpg",
                            Model = "X515JA-EJ2112W",
                            Name = "ASUS",
                            Processor = "I3 1005G1",
                            ProductId = 137,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "asus-x515ja-ej2112w-i3-1005g1-4gb-256gb-w11-156inc",
                            Storage = "256GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 138,
                            Image = "https://cdn.dsmcdn.com/ty507/product/media/images/20220816/9/160655623/545011304/1/1_org_zoom.jpg",
                            Model = "X515JA-EJ2137W",
                            Name = "ASUS",
                            Processor = "I3 1005G1",
                            ProductId = 138,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "asus-x515ja-ej2137w-i3-1005g1-4gb-256gb-w11-156inc",
                            Storage = "256GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 139,
                            Image = "https://cdn.dsmcdn.com/ty353/product/media/images/20220308/11/64842834/407952317/1/1_org_zoom.jpg",
                            Model = "X509FA",
                            Name = "ASUS",
                            Processor = "I5 10210U",
                            ProductId = 139,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-x509fa-i5-10210u-8gb-256gb-w10-156inc",
                            Storage = "256GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 140,
                            Image = "https://cdn.dsmcdn.com/ty292/product/media/images/20220111/14/24965825/356386402/1/1_org_zoom.jpg",
                            Model = "X515FA-EJ053T",
                            Name = "ASUS",
                            Processor = "I5 10210U",
                            ProductId = 140,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-x515fa-ej053t-i5-10210u-8gb-256gb-w10-156inc",
                            Storage = "256GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 141,
                            Image = "https://cdn.dsmcdn.com/ty211/product/media/images/20211026/14/156626727/275319830/1/1_org_zoom.jpg",
                            Model = "X509FA-EJ1072T",
                            Name = "ASUS",
                            Processor = "I5 10210U",
                            ProductId = 141,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-x509fa-ej1072t-i5-10210u-8gb-256gb-w10-156inc",
                            Storage = "256GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 142,
                            Image = "https://cdn.dsmcdn.com/ty537/product/media/images/20220920/18/177522942/574097902/1/1_org_zoom.jpg",
                            Model = "X515EA-BQ511W",
                            Name = "ASUS",
                            Processor = "I5 1135G7",
                            ProductId = 142,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-x515ea-bq511w-i5-1135g7-8gb-512gb-w11-156inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 143,
                            Image = "https://cdn.dsmcdn.com/ty527/product/media/images/20220908/17/170860052/561348139/1/1_org_zoom.jpg",
                            Model = "X515EA-BQ1185W",
                            Name = "ASUS",
                            Processor = "I5 1135G7",
                            ProductId = 143,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-x515ea-bq1185w-i5-1135g7-8gb-512gb-w11-156inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 144,
                            Image = "https://cdn.dsmcdn.com/ty520/product/media/images/20220901/17/168245306/557115517/1/1_org_zoom.jpg",
                            Model = "VIVOBOOK 15",
                            Name = "ASUS",
                            Processor = "I5 1135G7",
                            ProductId = 144,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-vivobook-15-i5-1135g7-8gb-512gb-w11-156inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 145,
                            Image = "https://cdn.dsmcdn.com/ty508/product/media/images/20220815/12/160086270/544325640/1/1_org_zoom.jpg",
                            Model = "ROG STRIX G15 G513IE-HN065",
                            Name = "ASUS",
                            Processor = "R7 4800H",
                            ProductId = 145,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-rog-strix-g15-g513ie-hn065-r7-4800h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 146,
                            Image = "https://cdn.dsmcdn.com/ty540/product/media/images/20220926/22/180132613/579638427/1/1_org_zoom.jpg",
                            Model = "ROG STRIX G513IE-HN065A8",
                            Name = "ASUS",
                            Processor = "R7 4800H",
                            ProductId = 146,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "asus-rog-strix-g513ie-hn065a8-r7-4800h-32gb-1tb-freedos-156inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 147,
                            Image = "https://cdn.dsmcdn.com/ty485/product/media/images/20220720/14/146750934/524554589/1/1_org_zoom.jpg",
                            Model = "ROG STRIX G513IE-HN065 HN06503",
                            Name = "ASUS",
                            Processor = "R7 4800H",
                            ProductId = 147,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "asus-rog-strix-g513ie-hn065-hn06503-r7-4800h-32gb-1tb-freedos-156inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 148,
                            Image = "https://cdn.dsmcdn.com/ty534/product/media/images/20220919/11/176881867/561850268/1/1_org_zoom.jpg",
                            Model = "TUF FA507RM-HN052A5",
                            Name = "ASUS",
                            Processor = "R7 6800H",
                            ProductId = 148,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "asus-tuf-fa507rm-hn052a5-r7-6800h-32gb-1tb-freedos-156inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 149,
                            Image = "https://cdn.dsmcdn.com/ty289/product/media/images/20220108/23/23531642/354082309/1/1_org_zoom.jpg",
                            Model = "X409FA-BV653",
                            Name = "ASUS",
                            Processor = "I7 8565U",
                            ProductId = 149,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "asus-x409fa-bv653-i7-8565u-8gb-512gb-freedos-14inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 150,
                            Image = "https://cdn.dsmcdn.com/ty542/product/media/images/20220927/15/180325458/580916225/1/1_org_zoom.jpg",
                            Model = "D515DA-BQ9802",
                            Name = "ASUS",
                            Processor = "R3 3250U",
                            ProductId = 150,
                            Ram = "12GB",
                            Screen = "15.6",
                            Slug = "asus-d515da-bq9802-r3-3250u-12gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 151,
                            Image = "https://cdn.dsmcdn.com/ty279/product/media/images/20211229/18/18784902/347783605/1/1_org_zoom.jpg",
                            Model = "D515DA-BR114203",
                            Name = "ASUS",
                            Processor = "R3 3250U",
                            ProductId = 151,
                            Ram = "12GB",
                            Screen = "15.6",
                            Slug = "asus-d515da-br114203-r3-3250u-12gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 152,
                            Image = "https://cdn.dsmcdn.com/ty440/product/media/images/20220527/13/116799964/488409227/1/1_org_zoom.jpg",
                            Model = "VIVOBOOK K3400PH-KM370",
                            Name = "ASUS",
                            Processor = "I5 11300H",
                            ProductId = 152,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "asus-vivobook-k3400ph-km370-i5-11300h-16gb-512gb-freedos-14inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 153,
                            Image = "https://cdn.dsmcdn.com/ty535/product/media/images/20220919/11/176881961/561850012/1/1_org_zoom.jpg",
                            Model = "TUF FA507RM-HN052A6",
                            Name = "ASUS",
                            Processor = "R7 6800H",
                            ProductId = 153,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "asus-tuf-fa507rm-hn052a6-r7-6800h-32gb-2tb-freedos-156inc",
                            Storage = "2TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 154,
                            Image = "https://cdn.dsmcdn.com/ty171/product/media/images/20210908/12/127634644/239046974/1/1_org_zoom.jpg",
                            Model = "D515DA BR028T",
                            Name = "ASUS",
                            Processor = "R3 3250U",
                            ProductId = 154,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "asus-d515da-br028t-r3-3250u-4gb-256gb-w10-156inc",
                            Storage = "256GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 155,
                            Image = "https://cdn.dsmcdn.com/ty557/product/media/images/20221008/11/189190258/389640110/1/1_org_zoom.jpg",
                            Model = "ROG ZEPHYRUS G14 GA401QC-BM207",
                            Name = "ASUS",
                            Processor = "R7 5800HS",
                            ProductId = 155,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "asus-rog-zephyrus-g14-ga401qc-bm207-r7-5800hs-8gb-1tb-freedos-14inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 156,
                            Image = "https://cdn.dsmcdn.com/ty536/product/media/images/20220915/18/175610230/569886180/1/1_org_zoom.jpg",
                            Model = "VIVOBOOK 15 M1502",
                            Name = "ASUS",
                            Processor = "R5 4600H",
                            ProductId = 156,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-vivobook-15-m1502-r5-4600h-8gb-256gb-w11-156inc",
                            Storage = "256GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 157,
                            Image = "https://cdn.dsmcdn.com/ty537/product/media/images/20220920/19/177543852/574138700/1/1_org_zoom.jpg",
                            Model = "X515JF",
                            Name = "ASUS",
                            Processor = "I5 1035G1",
                            ProductId = 157,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-x515jf-i5-1035g1-8gb-512gb-w10-156inc",
                            Storage = "512GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 158,
                            Image = "https://cdn.dsmcdn.com/ty252/product/media/images/20211125/14/111733741/321976667/1/1_org_zoom.jpg",
                            Model = "X409FA-BV659",
                            Name = "ASUS",
                            Processor = "I7 8565U",
                            ProductId = 158,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "asus-x409fa-bv659-i7-8565u-8gb-512gb-freedos-14inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 159,
                            Image = "https://cdn.dsmcdn.com/ty537/product/media/images/20220922/11/178387520/575200618/1/1_org_zoom.jpg",
                            Model = "TUF A15 FA506ICB-HN178",
                            Name = "ASUS",
                            Processor = "R5 4600H",
                            ProductId = 159,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-tuf-a15-fa506icb-hn178-r5-4600h-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 160,
                            Image = "https://cdn.dsmcdn.com/ty531/product/media/images/20220913/9/174751960/568541892/1/1_org_zoom.jpg",
                            Model = "ROG STRIX SCAR 17 G733ZS-KH011",
                            Name = "ASUS",
                            Processor = "I9 12900H",
                            ProductId = 160,
                            Ram = "16GB",
                            Screen = "17.3",
                            Slug = "asus-rog-strix-scar-17-g733zs-kh011-i9-12900h-16gb-1tb-freedos-173inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 161,
                            Image = "https://cdn.dsmcdn.com/ty318/product/media/images/20220202/19/42230449/378832789/1/1_org_zoom.jpg",
                            Model = "ROG STRIX G17 G713RS-KH004",
                            Name = "ASUS",
                            Processor = "R9 6900HX",
                            ProductId = 161,
                            Ram = "16GB",
                            Screen = "17.3",
                            Slug = "asus-rog-strix-g17-g713rs-kh004-r9-6900hx-16gb-1tb-freedos-173inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 162,
                            Image = "https://cdn.dsmcdn.com/ty461/product/media/images/20220625/12/129755255/506354860/1/1_org_zoom.jpg",
                            Model = "ROG STRIX G17 G713RS-KH010",
                            Name = "ASUS",
                            Processor = "R9 6900HX",
                            ProductId = 162,
                            Ram = "16GB",
                            Screen = "17.3",
                            Slug = "asus-rog-strix-g17-g713rs-kh010-r9-6900hx-16gb-1tb-freedos-173inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 163,
                            Image = "https://productimages.hepsiburada.net/s/211/500/110000188360666.jpg",
                            Model = "X515JF-EJ354Z13",
                            Name = "ASUS",
                            Processor = "I5 1035G1",
                            ProductId = 163,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-x515jf-ej354z13-i5-1035g1-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 164,
                            Image = "https://cdn.dsmcdn.com/ty526/product/media/images/20220909/16/171281390/561849567/1/1_org_zoom.jpg",
                            Model = "VIVOBOOK X571LI-BQ377A3",
                            Name = "ASUS",
                            Processor = "I7 10870H",
                            ProductId = 164,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-vivobook-x571li-bq377a3-i7-10870h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 165,
                            Image = "https://cdn.dsmcdn.com/ty535/product/media/images/20220915/18/175615437/569887370/1/1_org_zoom.jpg",
                            Model = "ZENBOOK 14 UM3402",
                            Name = "ASUS",
                            Processor = "R5 5625U",
                            ProductId = 165,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "asus-zenbook-14-um3402-r5-5625u-16gb-512gb-w11-14inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 166,
                            Image = "https://cdn.dsmcdn.com/ty549/product/media/images/20221003/18/185041181/587590886/1/1_org_zoom.jpg",
                            Model = "TUF FA507RM-HN052A32",
                            Name = "ASUS",
                            Processor = "R7 6800H",
                            ProductId = 166,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "asus-tuf-fa507rm-hn052a32-r7-6800h-32gb-1tb-w11p-156inc",
                            Storage = "1TB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 167,
                            Image = "https://cdn.dsmcdn.com/ty517/product/media/images/20220824/15/165064752/551500711/1/1_org_zoom.jpg",
                            Model = "VIVOBOOK 15 K513EP L157624",
                            Name = "ASUS",
                            Processor = "I5 1135G7",
                            ProductId = 167,
                            Ram = "40GB",
                            Screen = "15.6",
                            Slug = "asus-vivobook-15-k513ep-l157624-i5-1135g7-40gb-2tb-w11p-156inc",
                            Storage = "2TB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 168,
                            Image = "https://cdn.dsmcdn.com/ty536/product/media/images/20220916/11/175949405/570319891/1/1_org_zoom.jpg",
                            Model = "X515FA-BR039",
                            Name = "ASUS",
                            Processor = "I3 10110U",
                            ProductId = 168,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "asus-x515fa-br039-i3-10110u-4gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 169,
                            Image = "https://cdn.dsmcdn.com/ty306/product/media/images/20220125/17/35859985/276835732/2/2_org_zoom.jpg",
                            Model = "X509FA-BR951T",
                            Name = "ASUS",
                            Processor = "I3 10110U",
                            ProductId = 169,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "asus-x509fa-br951t-i3-10110u-4gb-256gb-w10-156inc",
                            Storage = "256GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 170,
                            Image = "https://cdn.dsmcdn.com/ty517/product/media/images/20220827/15/166341607/554065576/1/1_org_zoom.jpg",
                            Model = "X515JA-EJ2119",
                            Name = "ASUS",
                            Processor = "I7 1065G7",
                            ProductId = 170,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-x515ja-ej2119-i7-1065g7-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 171,
                            Image = "https://cdn.dsmcdn.com/ty405/product/media/images/20220423/22/96755214/456442373/1/1_org_zoom.jpg",
                            Model = "X515JA-EJ2120A1",
                            Name = "ASUS",
                            Processor = "I7 1065G7",
                            ProductId = 171,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-x515ja-ej2120a1-i7-1065g7-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 172,
                            Image = "https://cdn.dsmcdn.com/ty553/product/media/images/20221006/17/187720592/590723609/1/1_org_zoom.jpg",
                            Model = "X515JA-BQ2070W",
                            Name = "ASUS",
                            Processor = "I5 1035G1",
                            ProductId = 172,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-x515ja-bq2070w-i5-1035g1-8gb-512gb-w11-156inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 173,
                            Image = "https://cdn.dsmcdn.com/ty446/product/media/images/20220601/13/119306745/491727287/1/1_org_zoom.jpg",
                            Model = "K513EP-L1576",
                            Name = "ASUS",
                            Processor = "I5 1135G7",
                            ProductId = 173,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-k513ep-l1576-i5-1135g7-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 174,
                            Image = "https://cdn.dsmcdn.com/ty499/product/media/images/20220808/10/156057946/537926105/1/1_org_zoom.jpg",
                            Model = "VIVOBOOK 15 X571LI-BQ377A3",
                            Name = "ASUS",
                            Processor = "I7 10870H",
                            ProductId = 174,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-vivobook-15-x571li-bq377a3-i7-10870h-16gb-1tb-freedos-156inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 175,
                            Image = "https://cdn.dsmcdn.com/ty357/product/media/images/20220311/16/68046810/412811269/1/1_org_zoom.jpg",
                            Model = "ZENBOOK OLED UX325EA-KG654W",
                            Name = "ASUS",
                            Processor = "I7 1165G7",
                            ProductId = 175,
                            Ram = "16GB",
                            Screen = "13.3",
                            Slug = "asus-zenbook-oled-ux325ea-kg654w-i7-1165g7-16gb-1tb-w11-133inc",
                            Storage = "1TB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 176,
                            Image = "https://cdn.dsmcdn.com/ty531/product/media/images/20220913/8/174738984/568529637/1/1_org_zoom.jpg",
                            Model = "ZENBOOK 14X UX5401",
                            Name = "ASUS",
                            Processor = "I7 1165G7",
                            ProductId = 176,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "asus-zenbook-14x-ux5401-i7-1165g7-16gb-1tb-w11-14inc",
                            Storage = "1TB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 177,
                            Image = "https://cdn.dsmcdn.com/ty454/product/media/images/20220613/13/125247376/499394701/1/1_org_zoom.jpg",
                            Model = "ROG ZEPHYRUS G15 GA503RM-HQ124",
                            Name = "ASUS",
                            Processor = "R7 6800HS",
                            ProductId = 177,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-rog-zephyrus-g15-ga503rm-hq124-r7-6800hs-16gb-1tb-freedos-156inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 178,
                            Image = "https://cdn.dsmcdn.com/ty538/product/media/images/20220920/18/177525692/574088986/1/1_org_zoom.jpg",
                            Model = "ZENBOOK 14X UM5401",
                            Name = "ASUS",
                            Processor = "R9 5900HX",
                            ProductId = 178,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "asus-zenbook-14x-um5401-r9-5900hx-16gb-1tb-w11-14inc",
                            Storage = "1TB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 179,
                            Image = "https://cdn.dsmcdn.com/ty543/product/media/images/20220930/18/181893954/583869549/1/1_org_zoom.jpg",
                            Model = "X415EA-EB1360W02",
                            Name = "ASUS",
                            Processor = "I7 1165G7",
                            ProductId = 179,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "asus-x415ea-eb1360w02-i7-1165g7-16gb-512gb-w11-14inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 180,
                            Image = "https://cdn.dsmcdn.com/ty544/product/media/images/20220930/16/181849882/582534773/1/1_org_zoom.jpg",
                            Model = "TUF A15 FA506IEB-HN066",
                            Name = "ASUS",
                            Processor = "R5 4600H",
                            ProductId = 180,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "asus-tuf-a15-fa506ieb-hn066-r5-4600h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 181,
                            Image = "https://cdn.dsmcdn.com/ty537/product/media/images/20220920/18/177517612/574058156/1/1_org_zoom.jpg",
                            Model = "ZENBOOK 14 UM425",
                            Name = "ASUS",
                            Processor = "R5 5600H",
                            ProductId = 181,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "asus-zenbook-14-um425-r5-5600h-16gb-512gb-w11-14inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 182,
                            Image = "https://cdn.dsmcdn.com/ty499/product/media/images/20220804/14/154593869/535666725/1/1_org_zoom.jpg",
                            Model = "X515EA-BQ1843T11",
                            Name = "ASUS",
                            Processor = "I5 1135G7",
                            ProductId = 182,
                            Ram = "24GB",
                            Screen = "15.6",
                            Slug = "asus-x515ea-bq1843t11-i5-1135g7-24gb-1tb-freedos-156inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 183,
                            Image = "https://cdn.dsmcdn.com/ty524/product/media/images/20220907/17/170291368/560657694/1/1_org_zoom.jpg",
                            Model = "X515EA-BQ1186W08",
                            Name = "ASUS",
                            Processor = "I5 1135G7",
                            ProductId = 183,
                            Ram = "24GB",
                            Screen = "15.6",
                            Slug = "asus-x515ea-bq1186w08-i5-1135g7-24gb-1tb-w11-156inc",
                            Storage = "1TB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 184,
                            Image = "https://cdn.dsmcdn.com/ty547/product/media/images/20221001/23/183499494/585873332/1/1_org_zoom.jpg",
                            Model = "TUF A15 FA507RM-HN096 HN09614",
                            Name = "ASUS",
                            Processor = "R7 6800H",
                            ProductId = 184,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "asus-tuf-a15-fa507rm-hn096-hn09614-r7-6800h-32gb-1tb-w11-156inc",
                            Storage = "1TB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 185,
                            Image = "https://cdn.dsmcdn.com/ty521/product/media/images/20220901/11/167965052/556667263/1/1_org_zoom.jpg",
                            Model = "X515JA-EJ2138",
                            Name = "ASUS",
                            Processor = "I3 1005G1",
                            ProductId = 185,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "asus-x515ja-ej2138-i3-1005g1-4gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 186,
                            Image = "https://cdn.dsmcdn.com/ty522/product/media/images/20220906/0/169582508/559592474/1/1_org_zoom.jpg",
                            Model = "X515FA-EJ116W",
                            Name = "ASUS",
                            Processor = "I3 10110U",
                            ProductId = 186,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "asus-x515fa-ej116w-i3-10110u-4gb-256gb-w11-156inc",
                            Storage = "256GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 187,
                            Image = "https://cdn.dsmcdn.com/ty431/product/media/images/20220512/15/109861805/477714244/1/1_org_zoom.jpg",
                            Model = "X515JF-BR229T",
                            Name = "ASUS",
                            Processor = "I5 1035G1U",
                            ProductId = 187,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "asus-x515jf-br229t-i5-1035g1u-4gb-256gb-w10-156inc",
                            Storage = "256GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 188,
                            Image = "https://cdn.dsmcdn.com/ty457/product/media/images/20220618/18/127622707/502965535/1/1_org_zoom.jpg",
                            Model = "D515DA-EJ1423W",
                            Name = "ASUS",
                            Processor = "R3 3250U",
                            ProductId = 188,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "asus-d515da-ej1423w-r3-3250u-4gb-256gb-w11-156inc",
                            Storage = "256GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 189,
                            Image = "https://productimages.hepsiburada.net/s/186/1500/110000151195803.jpg",
                            Model = "X515FA-EJ045",
                            Name = "ASUS",
                            Processor = "I5 10210U",
                            ProductId = 189,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-x515fa-ej045-i5-10210u-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 190,
                            Image = "https://cdn.dsmcdn.com/ty313/product/media/images/20220128/20/38516735/374726119/1/1_org_zoom.jpg",
                            Model = "X415EA-EK977W",
                            Name = "ASUS",
                            Processor = "I5 11135G7",
                            ProductId = 190,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "asus-x415ea-ek977w-i5-11135g7-8gb-256gb-w11-14inc",
                            Storage = "256GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 191,
                            Image = "https://cdn.dsmcdn.com/ty157/product/media/images/20210814/11/118483282/226920434/0/0_org_zoom.jpg",
                            Model = "X409FA-BV660",
                            Name = "ASUS",
                            Processor = "I7 8565U",
                            ProductId = 191,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "asus-x409fa-bv660-i7-8565u-8gb-256gb-freedos-14inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 192,
                            Image = "https://cdn.dsmcdn.com/ty380/product/media/images/20220401/14/80382143/433007644/1/1_org_zoom.jpg",
                            Model = "D415DA-EK713",
                            Name = "ASUS",
                            Processor = "R3 3250U",
                            ProductId = 192,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "asus-d415da-ek713-r3-3250u-8gb-256gb-freedos-14inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 193,
                            Image = "https://cdn.dsmcdn.com/ty400/product/media/images/20220415/10/92357182/449963178/1/1_org_zoom.jpg",
                            Model = "X515JA-BQ1827W",
                            Name = "ASUS",
                            Processor = "I5 1035G1U",
                            ProductId = 193,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-x515ja-bq1827w-i5-1035g1u-8gb-512gb-w11-156inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 194,
                            Image = "https://cdn.dsmcdn.com/ty204/product/media/images/20211020/10/152688272/269189430/1/1_org_zoom.jpg",
                            Model = "X571GTA44-HN1012A44",
                            Name = "ASUS",
                            Processor = "I5 9300H",
                            ProductId = 194,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-x571gta44-hn1012a44-i5-9300h-8gb-512gb-w10-156inc",
                            Storage = "512GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 195,
                            Image = "https://productimages.hepsiburada.net/s/207/500/110000183608369.jpg",
                            Model = "X515JA-EJ2120A36",
                            Name = "ASUS",
                            Processor = "I7 1065G7",
                            ProductId = 195,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "asus-x515ja-ej2120a36-i7-1065g7-8gb-512gb-w10-156inc",
                            Storage = "512GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 196,
                            Image = "https://cdn.dsmcdn.com/ty311/product/media/images/20220126/19/36784901/372070541/1/1_org_zoom.jpg",
                            Model = "X409FA-EK036",
                            Name = "ASUS",
                            Processor = "I7 8565U",
                            ProductId = 196,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "asus-x409fa-ek036-i7-8565u-8gb-512gb-w10p-14inc",
                            Storage = "512GB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 197,
                            Image = "https://productimages.hepsiburada.net/s/264/1500/110000248531338.jpg",
                            Model = "NITRO 5 AN515-45 NH.QB9EY.003",
                            Name = "ACER",
                            Processor = "R5 5600H",
                            ProductId = 197,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "acer-nitro-5-an515-45-nhqb9ey003-r5-5600h-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 198,
                            Image = "https://cdn.dsmcdn.com/ty159/product/media/images/20210819/11/120001282/229195386/1/1_org_zoom.jpg",
                            Model = "ASPIRE 7 A715-42 NH.QBFEY.001",
                            Name = "ACER",
                            Processor = "R5 5500U",
                            ProductId = 198,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "acer-aspire-7-a715-42-nhqbfey001-r5-5500u-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 199,
                            Image = "https://cdn.dsmcdn.com/ty444/product/media/images/20220602/16/120038441/492617450/1/1_org_zoom.jpg",
                            Model = "ASPIRE 7 A715-42G NH.QBFEY.007",
                            Name = "ACER",
                            Processor = "R5 5500U",
                            ProductId = 199,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "acer-aspire-7-a715-42g-nhqbfey007-r5-5500u-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 200,
                            Image = "https://cdn.dsmcdn.com/ty446/product/media/images/20220602/14/119897737/492463000/1/1_org_zoom.jpg",
                            Model = "ASPIRE 7 A715-42G NH.QE5EY.006",
                            Name = "ACER",
                            Processor = "R5 5500U",
                            ProductId = 200,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "acer-aspire-7-a715-42g-nhqe5ey006-r5-5500u-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 201,
                            Image = "https://cdn.dsmcdn.com/ty499/product/media/images/20220804/17/154660718/535765997/1/1_org_zoom.jpg",
                            Model = "NITRO 5 AN515-45 NH.QBBEY.001",
                            Name = "ACER",
                            Processor = "R7 5800H",
                            ProductId = 201,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "acer-nitro-5-an515-45-nhqbbey001-r7-5800h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 202,
                            Image = "https://cdn.dsmcdn.com/ty183/product/media/images/20211001/17/138415184/252179791/0/0_org_zoom.jpg",
                            Model = "NITRO 5 AN515-45 NH.QBAEY.003",
                            Name = "ACER",
                            Processor = "R5 5600H",
                            ProductId = 202,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "acer-nitro-5-an515-45-nhqbaey003-r5-5600h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 203,
                            Image = "https://cdn.dsmcdn.com/ty500/product/media/images/20220804/17/154660940/535766326/1/1_org_zoom.jpg",
                            Model = "NITRO 5 AN515-45 NH.QBBEY.003",
                            Name = "ACER",
                            Processor = "R5 5600H",
                            ProductId = 203,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "acer-nitro-5-an515-45-nhqbbey003-r5-5600h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 204,
                            Image = "https://cdn.dsmcdn.com/ty161/product/media/images/20210819/5/119734144/229230608/0/0_org_zoom.jpg",
                            Model = "NITRO 5 AN515-45 NH.QBCEY.005",
                            Name = "ACER",
                            Processor = "R5 5600H",
                            ProductId = 204,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "acer-nitro-5-an515-45-nhqbcey005-r5-5600h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 205,
                            Image = "https://cdn.dsmcdn.com/ty436/product/media/images/20220521/14/114510492/485297355/1/1_org_zoom.jpg",
                            Model = "EXTENSA EX215-54G NX.EGHEY.001",
                            Name = "ACER",
                            Processor = "I5 1135G7",
                            ProductId = 205,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "acer-extensa-ex215-54g-nxeghey001-i5-1135g7-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 206,
                            Image = "https://cdn.dsmcdn.com/ty518/product/media/images/20220825/10/165283273/551885152/1/1_org_zoom.jpg",
                            Model = "ASPIRE 3 A315-56-327T NX.HS5EY.006",
                            Name = "ACER",
                            Processor = "I3 1005G1",
                            ProductId = 206,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "acer-aspire-3-a315-56-327t-nxhs5ey006-i3-1005g1-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 207,
                            Image = "https://cdn.dsmcdn.com/ty211/product/media/images/20211026/15/156687094/275355513/0/0_org_zoom.jpg",
                            Model = "ASPIRE 3 A315-56 NX.HS6EY.001",
                            Name = "ACER",
                            Processor = "I3 1005G1",
                            ProductId = 207,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "acer-aspire-3-a315-56-nxhs6ey001-i3-1005g1-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 208,
                            Image = "https://cdn.dsmcdn.com/ty470/product/media/images/20220707/9/136469279/515856881/1/1_org_zoom.jpg",
                            Model = "ASPIRE 7 A715-75G-53BQ",
                            Name = "ACER",
                            Processor = "I5 10300H",
                            ProductId = 208,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "acer-aspire-7-a715-75g-53bq-i5-10300h-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 209,
                            Image = "https://cdn.dsmcdn.com/ty167/product/media/images/20210826/9/122626409/232941474/1/1_org_zoom.jpg",
                            Model = "NITRO AN515-55 NH.Q7JEY.006",
                            Name = "ACER",
                            Processor = "I5 10300H",
                            ProductId = 209,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "acer-nitro-an515-55-nhq7jey006-i5-10300h-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 210,
                            Image = "https://cdn.dsmcdn.com/ty538/product/media/images/20220921/17/178143566/500537713/1/1_org_zoom.jpg",
                            Model = "NITRO 5 AN515-58 NH.QFLEY.003",
                            Name = "ACER",
                            Processor = "I7 12700H",
                            ProductId = 210,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "acer-nitro-5-an515-58-nhqfley003-i7-12700h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 211,
                            Image = "https://cdn.dsmcdn.com/ty535/product/media/images/20220920/11/177388951/547888636/1/1_org_zoom.jpg",
                            Model = "NITRO 5 AN515-58 NH.QFMEY.003",
                            Name = "ACER",
                            Processor = "I7 12700H",
                            ProductId = 211,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "acer-nitro-5-an515-58-nhqfmey003-i7-12700h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 212,
                            Image = "https://cdn.dsmcdn.com/ty520/product/media/images/20220831/16/167375017/555830038/1/1_org_zoom.jpg",
                            Model = "EXTENSA 15 EX215-54-57LW",
                            Name = "ACER",
                            Processor = "I5 1135G7",
                            ProductId = 212,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "acer-extensa-15-ex215-54-57lw-i5-1135g7-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 213,
                            Image = "https://cdn.dsmcdn.com/ty499/product/media/images/20220804/9/154495491/511280436/1/1_org_zoom.jpg",
                            Model = "ASPIRE 3 A315-58 NX.ADDEY.004",
                            Name = "ACER",
                            Processor = "I5 1135G7",
                            ProductId = 213,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "acer-aspire-3-a315-58-nxaddey004-i5-1135g7-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 214,
                            Image = "https://cdn.dsmcdn.com/ty446/product/media/images/20220602/16/120044425/492623558/1/1_org_zoom.jpg",
                            Model = "ASPIRE 7 A715-42G NH.QE5EY.004",
                            Name = "ACER",
                            Processor = "R5 5500U",
                            ProductId = 214,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "acer-aspire-7-a715-42g-nhqe5ey004-r5-5500u-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 215,
                            Image = "https://cdn.dsmcdn.com/ty362/product/media/images/20220316/15/70799089/417385417/1/1_org_zoom.jpg",
                            Model = "PREDATOR PT315-52-57PN",
                            Name = "ACER",
                            Processor = "I5 10300H",
                            ProductId = 215,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "acer-predator-pt315-52-57pn-i5-10300h-16gb-512gb-w10-156inc",
                            Storage = "512GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 216,
                            Image = "https://cdn.dsmcdn.com/ty388/product/media/images/20220407/11/85324024/439792692/1/1_org_zoom.jpg",
                            Model = "SWIFT 3 SF314-511 NX.ABNEY.002",
                            Name = "ACER",
                            Processor = "I7 1165G7",
                            ProductId = 216,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "acer-swift-3-sf314-511-nxabney002-i7-1165g7-16gb-512gb-w10-14inc",
                            Storage = "512GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 217,
                            Image = "https://cdn.dsmcdn.com/ty435/product/media/images/20220520/12/114105414/484647373/1/1_org_zoom.jpg",
                            Model = "EXTENSA 15 NX.EG9EY.004",
                            Name = "ACER",
                            Processor = "R3 3250U",
                            ProductId = 217,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "acer-extensa-15-nxeg9ey004-r3-3250u-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 218,
                            Image = "https://cdn.dsmcdn.com/ty484/product/media/images/20220719/13/145591574/485878214/2/2_org_zoom.jpg",
                            Model = "SWIFT 3 SF314-511 NX.ABNEY.003",
                            Name = "ACER",
                            Processor = "I5 1135G7",
                            ProductId = 218,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "acer-swift-3-sf314-511-nxabney003-i5-1135g7-8gb-512gb-w11-14inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 219,
                            Image = "https://cdn.dsmcdn.com/ty564/product/media/images/20221014/22/193666439/596614620/1/1_org_zoom.jpg",
                            Model = "ASPIRE 3",
                            Name = "ACER",
                            Processor = "I5 1135G7",
                            ProductId = 219,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "acer-aspire-3-i5-1135g7-8gb-512gb-w11-156inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 220,
                            Image = "https://cdn.dsmcdn.com/ty535/product/media/images/20220920/12/177389574/547803671/1/1_org_zoom.jpg",
                            Model = "NITRO 5 AN515-57 NH.QFGEY.002",
                            Name = "ACER",
                            Processor = "I7 11800H",
                            ProductId = 220,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "acer-nitro-5-an515-57-nhqfgey002-i7-11800h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 221,
                            Image = "https://cdn.dsmcdn.com/ty478/product/media/images/20220715/13/141963287/521613015/1/1_org_zoom.jpg",
                            Model = "MACBOOK PRO MNEJ3TU/A",
                            Name = "APPLE",
                            Processor = "M2",
                            ProductId = 221,
                            Ram = "8GB",
                            Screen = "13.3",
                            Slug = "apple-macbook-pro-mnej3tua-m2-0-8gb-512gb-macos-133inc",
                            Storage = "512GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 222,
                            Image = "https://cdn.dsmcdn.com/ty563/product/media/images/20221014/11/193279032/535511399/1/1_org_zoom.jpg",
                            Model = "MACBOOK PRO MNEQ3TU/A",
                            Name = "APPLE",
                            Processor = "M2",
                            ProductId = 222,
                            Ram = "8GB",
                            Screen = "13.3",
                            Slug = "apple-macbook-pro-mneq3tua-m2-0-8gb-512gb-macos-133inc",
                            Storage = "512GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 223,
                            Image = "https://cdn.dsmcdn.com/ty84/product/media/images/20210313/11/71047419/151781302/1/1_org_zoom.jpg",
                            Model = "MACBOOK AIR Z125000BV",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 223,
                            Ram = "16GB",
                            Screen = "13",
                            Slug = "apple-macbook-air-z125000bv-m1-0-16gb-512gb-macos-13inc",
                            Storage = "512GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 224,
                            Image = "https://cdn.dsmcdn.com/ty84/product/media/images/20210313/12/71054058/151791243/1/1_org_zoom.jpg",
                            Model = "MACBOOK PRO Z11C0007Y",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 224,
                            Ram = "16GB",
                            Screen = "13",
                            Slug = "apple-macbook-pro-z11c0007y-m1-0-16gb-512gb-macos-13inc",
                            Storage = "512GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 225,
                            Image = "https://cdn.dsmcdn.com/ty500/product/media/images/20220804/9/154482677/535524369/1/1_org_zoom.jpg",
                            Model = "MACBOOK PRO MNEP3TU/A",
                            Name = "APPLE",
                            Processor = "M2",
                            ProductId = 225,
                            Ram = "8GB",
                            Screen = "13.3",
                            Slug = "apple-macbook-pro-mnep3tua-m2-0-8gb-256gb-macos-133inc",
                            Storage = "256GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 226,
                            Image = "https://cdn.dsmcdn.com/ty531/product/media/images/20220915/11/175443049/306919731/1/1_org_zoom.jpg",
                            Model = "MACBOOK PRO",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 226,
                            Ram = "16GB",
                            Screen = "16",
                            Slug = "apple-macbook-pro-m1-0-16gb-1tb-macos-16inc",
                            Storage = "1TB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 227,
                            Image = "https://productimages.hepsiburada.net/s/131/1500/110000081537742.jpg",
                            Model = "MACBOOK PRO MK193TU/A",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 227,
                            Ram = "16GB",
                            Screen = "16",
                            Slug = "apple-macbook-pro-mk193tua-m1-0-16gb-1tb-macos-16inc",
                            Storage = "1TB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 228,
                            Image = "https://productimages.hepsiburada.net/s/64/1500/110000005442676.jpg",
                            Model = "MACBOOK AIR Z1240009K",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 228,
                            Ram = "16GB",
                            Screen = "13.3",
                            Slug = "apple-macbook-air-z1240009k-m1-0-16gb-256gb-macos-133inc",
                            Storage = "256GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 229,
                            Image = "https://cdn.dsmcdn.com/ty453/product/media/images/20220614/15/125590325/378519693/1/1_org_zoom.jpg",
                            Model = "MACBOOK AIR Z127M116256-TQ6",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 229,
                            Ram = "16GB",
                            Screen = "13.3",
                            Slug = "apple-macbook-air-z127m116256-tq6-m1-0-16gb-256gb-macos-133inc",
                            Storage = "256GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 230,
                            Image = "https://productimages.hepsiburada.net/s/265/500/110000250478677.jpg",
                            Model = "MACBOOK PRO Z11B00098",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 230,
                            Ram = "16GB",
                            Screen = "13.3",
                            Slug = "apple-macbook-pro-z11b00098-m1-0-16gb-256gb-macos-133inc",
                            Storage = "256GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 231,
                            Image = "https://cdn.dsmcdn.com/ty328/product/media/images/20220211/12/48508136/376324141/1/1_org_zoom.jpg",
                            Model = "MACBOOK AIR Z127M116512-TQ6",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 231,
                            Ram = "16GB",
                            Screen = "13.3",
                            Slug = "apple-macbook-air-z127m116512-tq6-m1-0-16gb-512gb-macos-133inc",
                            Storage = "512GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 232,
                            Image = "https://cdn.dsmcdn.com/ty456/product/media/images/20220617/11/126657077/378719684/1/1_org_zoom.jpg",
                            Model = "MACBOOK AIR Z124M116512-TQ6",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 232,
                            Ram = "16GB",
                            Screen = "13.3",
                            Slug = "apple-macbook-air-z124m116512-tq6-m1-0-16gb-512gb-macos-133inc",
                            Storage = "512GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 233,
                            Image = "https://cdn.dsmcdn.com/ty208/product/media/images/20211025/14/155924235/124608760/1/1_org_zoom.jpg",
                            Model = "MACBOOK PRO MYD92TU/A",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 233,
                            Ram = "8GB",
                            Screen = "13.3",
                            Slug = "apple-macbook-pro-myd92tua-m1-0-8gb-512gb-macos-133inc",
                            Storage = "512GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 234,
                            Image = "https://productimages.hepsiburada.net/s/49/500/10983950843954.jpg",
                            Model = "MACBOOK AIR MGNA3TU/A",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 234,
                            Ram = "8GB",
                            Screen = "13.3",
                            Slug = "apple-macbook-air-mgna3tua-m1-0-8gb-512gb-macos-133inc",
                            Storage = "512GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 235,
                            Image = "https://cdn.dsmcdn.com/ty208/product/media/images/20211025/14/155912736/117305379/1/1_org_zoom.jpg",
                            Model = "MACBOOK AIR MGN73TU/A",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 235,
                            Ram = "8GB",
                            Screen = "13",
                            Slug = "apple-macbook-air-mgn73tua-m1-0-8gb-512gb-macos-13inc",
                            Storage = "512GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 236,
                            Image = "https://cdn.dsmcdn.com/ty162/product/media/images/20210820/22/120702443/231050462/0/0_org_zoom.jpg",
                            Model = "MACBOOK PRO Z11D116256-TQ6",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 236,
                            Ram = "16GB",
                            Screen = "13",
                            Slug = "apple-macbook-pro-z11d116256-tq6-m1-0-16gb-256gb-macos-13inc",
                            Storage = "256GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 237,
                            Image = "https://cdn.dsmcdn.com/ty537/product/media/images/20220920/19/177543929/574138741/1/1_org_zoom.jpg",
                            Model = "MACBOOK AIR Z15SM2JT16512",
                            Name = "APPLE",
                            Processor = "M2",
                            ProductId = 237,
                            Ram = "16GB",
                            Screen = "13.6",
                            Slug = "apple-macbook-air-z15sm2jt16512-m2-0-16gb-512gb-macos-136inc",
                            Storage = "512GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 238,
                            Image = "https://cdn.dsmcdn.com/ty246/product/media/images/20211116/17/181494130/302345198/1/1_org_zoom.jpg",
                            Model = "MACBOOK PRO MAX MK1H3TU/A",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 238,
                            Ram = "32GB",
                            Screen = "16",
                            Slug = "apple-macbook-pro-max-mk1h3tua-m1-0-32gb-1tb-macos-16inc",
                            Storage = "1TB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 239,
                            Image = "https://cdn.dsmcdn.com/ty539/product/media/images/20220920/19/177539667/574135302/1/1_org_zoom.jpg",
                            Model = "MACBOOK AIR MLXX3TU/A",
                            Name = "APPLE",
                            Processor = "M2",
                            ProductId = 239,
                            Ram = "8GB",
                            Screen = "13.6",
                            Slug = "apple-macbook-air-mlxx3tua-m2-0-8gb-512gb-macos-136inc",
                            Storage = "512GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 240,
                            Image = "https://cdn.dsmcdn.com/ty540/product/media/images/20220928/16/180837020/581824585/1/1_org_zoom.jpg",
                            Model = "MACBOOK AIR MLY03TU/A",
                            Name = "APPLE",
                            Processor = "M2",
                            ProductId = 240,
                            Ram = "8GB",
                            Screen = "13.6",
                            Slug = "apple-macbook-air-mly03tua-m2-0-8gb-512gb-macos-136inc",
                            Storage = "512GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 241,
                            Image = "https://cdn.dsmcdn.com/ty539/product/media/images/20220920/18/177517324/574057574/1/1_org_zoom.jpg",
                            Model = "MACBOOK AIR MLY23TU/A",
                            Name = "APPLE",
                            Processor = "M2",
                            ProductId = 241,
                            Ram = "8GB",
                            Screen = "13.6",
                            Slug = "apple-macbook-air-mly23tua-m2-0-8gb-512gb-macos-136inc",
                            Storage = "512GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 242,
                            Image = "https://cdn.dsmcdn.com/ty501/product/media/images/20220809/18/156743900/539017844/1/1_org_zoom.jpg",
                            Model = "MACBOOK PRO MAX Z14VM1MNY642-TQ6",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 242,
                            Ram = "64GB",
                            Screen = "16",
                            Slug = "apple-macbook-pro-max-z14vm1mny642-tq6-m1-0-64gb-2tb-macos-16inc",
                            Storage = "2TB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 243,
                            Image = "https://cdn.dsmcdn.com/ty375/product/media/images/20220329/14/78182302/429338710/1/1_org_zoom.jpg",
                            Model = "MACBOOK PRO MKGT3TU/A",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 243,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "apple-macbook-pro-mkgt3tua-m1-0-16gb-1tb-macos-14inc",
                            Storage = "1TB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 244,
                            Image = "https://cdn.dsmcdn.com/ty437/product/media/images/20220519/10/113459570/117794442/1/1_org_zoom.jpg",
                            Model = "MACBOOK AIR MGN93TU/A",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 244,
                            Ram = "8GB",
                            Screen = "13",
                            Slug = "apple-macbook-air-mgn93tua-m1-0-8gb-256gb-macos-13inc",
                            Storage = "256GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 245,
                            Image = "https://cdn.dsmcdn.com/ty513/product/media/images/20220822/16/163937942/117736341/1/1_org_zoom.jpg",
                            Model = "MACBOOK AIR MGND3TU/A",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 245,
                            Ram = "8GB",
                            Screen = "13",
                            Slug = "apple-macbook-air-mgnd3tua-m1-0-8gb-256gb-macos-13inc",
                            Storage = "256GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 246,
                            Image = "https://cdn.dsmcdn.com/ty437/product/media/images/20220519/10/113461526/124489941/1/1_org_zoom.jpg",
                            Model = "MACBOOK PRO MYDA2TU/A",
                            Name = "APPLE",
                            Processor = "M1",
                            ProductId = 246,
                            Ram = "8GB",
                            Screen = "13",
                            Slug = "apple-macbook-pro-myda2tua-m1-0-8gb-256gb-macos-13inc",
                            Storage = "256GB",
                            System = "MACOS"
                        },
                        new
                        {
                            DetailId = 247,
                            Image = "https://cdn.dsmcdn.com/ty278/product/media/images/20211224/12/15878662/344305655/1/1_org_zoom.jpg",
                            Model = "INSPIRON 3511 F1135F85N",
                            Name = "DELL",
                            Processor = "I5 1135G7",
                            ProductId = 247,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "dell-inspiron-3511-f1135f85n-i5-1135g7-8gb-512gb-ubuntu-156inc",
                            Storage = "512GB",
                            System = "UBUNTU"
                        },
                        new
                        {
                            DetailId = 248,
                            Image = "https://cdn.dsmcdn.com/ty410/product/media/images/20220426/12/98396234/459521621/1/1_org_zoom.jpg",
                            Model = "LATITUDE 3520 N014L352017EMEA_U",
                            Name = "DELL",
                            Processor = "I7 1165G7",
                            ProductId = 248,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "dell-latitude-3520-n014l352017emea_u-i7-1165g7-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 249,
                            Image = "https://cdn.dsmcdn.com/ty524/product/media/images/20220905/14/169388354/559297617/1/1_org_zoom.jpg",
                            Model = "LATITUDE 5430 N213L543014EMEA_W",
                            Name = "DELL",
                            Processor = "I7 1255U",
                            ProductId = 249,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "dell-latitude-5430-n213l543014emea_w-i7-1255u-16gb-512gb-w10p-14inc",
                            Storage = "512GB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 250,
                            Image = "https://cdn.dsmcdn.com/ty468/product/media/images/20220705/12/135595671/514294849/1/1_org_zoom.jpg",
                            Model = "G515 G55201800U",
                            Name = "DELL",
                            Processor = "I7 12700H",
                            ProductId = 250,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "dell-g515-g55201800u-i7-12700h-16gb-512gb-ubuntu-156inc",
                            Storage = "512GB",
                            System = "UBUNTU"
                        },
                        new
                        {
                            DetailId = 251,
                            Image = "https://cdn.dsmcdn.com/ty515/product/media/images/20220822/12/163815531/549290609/1/1_org_zoom.jpg",
                            Model = "INSPIRON 3511 FB11F82N",
                            Name = "DELL",
                            Processor = "I3 1115G4",
                            ProductId = 251,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "dell-inspiron-3511-fb11f82n-i3-1115g4-8gb-256gb-ubuntu-156inc",
                            Storage = "256GB",
                            System = "UBUNTU"
                        },
                        new
                        {
                            DetailId = 252,
                            Image = "https://cdn.dsmcdn.com/ty490/product/media/images/20220726/11/149966481/528845394/3/3_org_zoom.jpg",
                            Model = "G15 5510 4B500W85C",
                            Name = "DELL",
                            Processor = "I5 10500H",
                            ProductId = 252,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "dell-g15-5510-4b500w85c-i5-10500h-8gb-512gb-w10-156inc",
                            Storage = "512GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 253,
                            Image = "https://cdn.dsmcdn.com/ty341/product/media/images/20220223/13/57304433/396151255/1/1_org_zoom.jpg",
                            Model = "INSPIRON 3511 F35OBF821NA3",
                            Name = "DELL",
                            Processor = "I5 1135G7",
                            ProductId = 253,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "dell-inspiron-3511-f35obf821na3-i5-1135g7-16gb-256gb-linux-156inc",
                            Storage = "256GB",
                            System = "LINUX"
                        },
                        new
                        {
                            DetailId = 254,
                            Image = "https://cdn.dsmcdn.com/ty339/product/media/images/20220223/17/57506236/396362982/1/1_org_zoom.jpg",
                            Model = "INSPIRON 3511 F35OBF821NA24",
                            Name = "DELL",
                            Processor = "I5 1135G7",
                            ProductId = 254,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "dell-inspiron-3511-f35obf821na24-i5-1135g7-16gb-256gb-w10-156inc",
                            Storage = "256GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 255,
                            Image = "https://cdn.dsmcdn.com/ty340/product/media/images/20220223/13/57304462/396151276/1/1_org_zoom.jpg",
                            Model = "INSPIRON 3511 F35OBF821NA4",
                            Name = "DELL",
                            Processor = "I5 1135G7",
                            ProductId = 255,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "dell-inspiron-3511-f35obf821na4-i5-1135g7-16gb-512gb-linux-156inc",
                            Storage = "512GB",
                            System = "LINUX"
                        },
                        new
                        {
                            DetailId = 256,
                            Image = "https://cdn.dsmcdn.com/ty339/product/media/images/20220223/14/57332572/396178918/1/1_org_zoom.jpg",
                            Model = "INSPIRON 3511 F35OBF821NA25",
                            Name = "DELL",
                            Processor = "I5 1135G7",
                            ProductId = 256,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "dell-inspiron-3511-f35obf821na25-i5-1135g7-16gb-512gb-w10-156inc",
                            Storage = "512GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 257,
                            Image = "https://cdn.dsmcdn.com/ty332/product/media/images/20220214/16/50203476/387444828/1/1_org_zoom.jpg",
                            Model = "G15 5515 6GR7W165N",
                            Name = "DELL",
                            Processor = "R7 5800H",
                            ProductId = 257,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "dell-g15-5515-6gr7w165n-r7-5800h-16gb-512gb-w11-156inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 258,
                            Image = "https://cdn.dsmcdn.com/ty222/product/media/images/20211105/8/166049033/172096731/1/1_org_zoom.jpg",
                            Model = "INSPIRON 14 7400 7400-S35WP82N",
                            Name = "DELL",
                            Processor = "I5 1135G7",
                            ProductId = 258,
                            Ram = "8GB",
                            Screen = "14.5",
                            Slug = "dell-inspiron-14-7400-7400-s35wp82n-i5-1135g7-8gb-256gb-w10p-145inc",
                            Storage = "256GB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 259,
                            Image = "https://cdn.dsmcdn.com/ty384/product/media/images/20220406/12/84415362/193051103/1/1_org_zoom.jpg",
                            Model = "EXCALIBUR G770.1140-8EL0T-B",
                            Name = "CASPER",
                            Processor = "I5 11400H",
                            ProductId = 259,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "casper-excalibur-g7701140-8el0t-b-i5-11400h-8gb-512gb-w11-156inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 260,
                            Image = "https://productimages.hepsiburada.net/s/159/1500/110000117273165.jpg",
                            Model = "NIRVANA S500.1135-8E00T-G-F",
                            Name = "CASPER",
                            Processor = "I5 1135G7",
                            ProductId = 260,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "casper-nirvana-s5001135-8e00t-g-f-i5-1135g7-8gb-512gb-w11-156inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 261,
                            Image = "https://cdn.dsmcdn.com/ty540/product/media/images/20220928/9/180700515/581528089/1/1_org_zoom.jpg",
                            Model = "NIRVANA F500.1135-8E00T-G-F",
                            Name = "CASPER",
                            Processor = "I5 1135G7",
                            ProductId = 261,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "casper-nirvana-f5001135-8e00t-g-f-i5-1135g7-8gb-512gb-w11-156inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 262,
                            Image = "https://cdn.dsmcdn.com/ty169/product/media/images/20210901/22/124774283/235807406/0/0_org_zoom.jpg",
                            Model = "NIRVANA X500.1021-8D00X-G-F",
                            Name = "CASPER",
                            Processor = "I5 10210U",
                            ProductId = 262,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "casper-nirvana-x5001021-8d00x-g-f-i5-10210u-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 263,
                            Image = "https://cdn.dsmcdn.com/ty451/product/media/images/20220610/11/123674443/497650370/1/1_org_zoom.jpg",
                            Model = "EXCALIBUR G770.1245-8VJ0X-B",
                            Name = "CASPER",
                            Processor = "I5 12450H",
                            ProductId = 263,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "casper-excalibur-g7701245-8vj0x-b-i5-12450h-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 264,
                            Image = "https://cdn.dsmcdn.com/ty384/product/media/images/20220406/12/84413743/343125678/1/1_org_zoom.jpg",
                            Model = "EXCALIBUR G770.1160-BVH0X-B",
                            Name = "CASPER",
                            Processor = "I7 11600H",
                            ProductId = 264,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "casper-excalibur-g7701160-bvh0x-b-i7-11600h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 265,
                            Image = "https://cdn.dsmcdn.com/ty531/product/media/images/20220914/17/175217384/569223671/1/1_org_zoom.jpg",
                            Model = "250 G9 6Q8M6ES",
                            Name = "HP",
                            Processor = "I5 1235U",
                            ProductId = 265,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "hp-250-g9-6q8m6es-i5-1235u-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 266,
                            Image = "https://cdn.dsmcdn.com/ty506/product/media/images/20220811/21/158059417/541828854/1/1_org_zoom.jpg",
                            Model = "250 G8 5N2Y4ES",
                            Name = "HP",
                            Processor = "I5 1135G7",
                            ProductId = 266,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "hp-250-g8-5n2y4es-i5-1135g7-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 267,
                            Image = "https://cdn.dsmcdn.com/ty410/product/media/images/20220425/16/97403926/447159873/1/1_org_zoom.jpg",
                            Model = "PAVILION 15-EC2057NT 68N72EA",
                            Name = "HP",
                            Processor = "R5 5600H",
                            ProductId = 267,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "hp-pavilion-15-ec2057nt-68n72ea-r5-5600h-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 268,
                            Image = "https://cdn.dsmcdn.com/ty483/product/media/images/20220720/15/146762235/524575897/1/1_org_zoom.jpg",
                            Model = "ELITEBOOK 840 G8 336D6EA01",
                            Name = "HP",
                            Processor = "I7 1165G7",
                            ProductId = 268,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "hp-elitebook-840-g8-336d6ea01-i7-1165g7-16gb-1tb-w10p-14inc",
                            Storage = "1TB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 269,
                            Image = "https://productimages.hepsiburada.net/s/131/1500/110000081497102.jpg",
                            Model = "PROBOOK 450 G8 32M62EA",
                            Name = "HP",
                            Processor = "I3 1115G4",
                            ProductId = 269,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "hp-probook-450-g8-32m62ea-i3-1115g4-4gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 270,
                            Image = "https://cdn.dsmcdn.com/ty147/product/media/images/20210717/1/111393397/204864568/1/1_org_zoom.jpg",
                            Model = "15S-FQ2046NT 2N2Q9EA",
                            Name = "HP",
                            Processor = "I3 1115G4",
                            ProductId = 270,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "hp-15s-fq2046nt-2n2q9ea-i3-1115g4-4gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 271,
                            Image = "https://cdn.dsmcdn.com/ty227/product/media/images/20211105/12/166147934/288969439/1/1_org_zoom.jpg",
                            Model = "250 G8 34N99ESA4",
                            Name = "HP",
                            Processor = "I7 1165G7",
                            ProductId = 271,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "hp-250-g8-34n99esa4-i7-1165g7-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 272,
                            Image = "https://cdn.dsmcdn.com/ty499/product/media/images/20220804/13/154556014/535620919/1/1_org_zoom.jpg",
                            Model = "ELITEBOOK 850 G8 401F0EA",
                            Name = "HP",
                            Processor = "I7 1165G7",
                            ProductId = 272,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "hp-elitebook-850-g8-401f0ea-i7-1165g7-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 273,
                            Image = "https://cdn.dsmcdn.com/ty322/product/media/images/20220205/10/44798848/380979742/1/1_org_zoom.jpg",
                            Model = "255 G8 4P3M3ES04",
                            Name = "HP",
                            Processor = "R7 5700U",
                            ProductId = 273,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "hp-255-g8-4p3m3es04-r7-5700u-16gb-512gb-w10-156inc",
                            Storage = "512GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 274,
                            Image = "https://cdn.dsmcdn.com/ty546/product/media/images/20221001/17/183282861/585229128/1/1_org_zoom.jpg",
                            Model = "PROOBOK 440 G9 6S6W2EA28",
                            Name = "HP",
                            Processor = "I7 1255U",
                            ProductId = 274,
                            Ram = "64GB",
                            Screen = "14",
                            Slug = "hp-proobok-440-g9-6s6w2ea28-i7-1255u-64gb-1tb-w11p-14inc",
                            Storage = "1TB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 275,
                            Image = "https://cdn.dsmcdn.com/ty547/product/media/images/20221003/12/184542027/586955324/1/1_org_zoom.jpg",
                            Model = "PROOBOK 450 G9 6S6X1EA29",
                            Name = "HP",
                            Processor = "I7 1255U",
                            ProductId = 275,
                            Ram = "64GB",
                            Screen = "15.6",
                            Slug = "hp-proobok-450-g9-6s6x1ea29-i7-1255u-64gb-2tb-w11p-156inc",
                            Storage = "2TB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 276,
                            Image = "https://cdn.dsmcdn.com/ty446/product/media/images/20220601/19/119590555/492041713/1/1_org_zoom.jpg",
                            Model = "PAVILION 15-DK207NT 54T32EA",
                            Name = "HP",
                            Processor = "I5 11300H",
                            ProductId = 276,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "hp-pavilion-15-dk207nt-54t32ea-i5-11300h-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 277,
                            Image = "https://cdn.dsmcdn.com/ty541/product/media/images/20220926/22/180132324/579634798/1/1_org_zoom.jpg",
                            Model = "15-DW4010NTA4 6Y7Z9EAA4",
                            Name = "HP",
                            Processor = "I5 1235U",
                            ProductId = 277,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "hp-15-dw4010nta4-6y7z9eaa4-i5-1235u-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 278,
                            Image = "https://cdn.dsmcdn.com/ty541/product/media/images/20220925/20/179740181/578595499/1/1_org_zoom.jpg",
                            Model = "15-DW4010NT 6Y7Z9EAC14",
                            Name = "HP",
                            Processor = "I5 1235U",
                            ProductId = 278,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "hp-15-dw4010nt-6y7z9eac14-i5-1235u-16gb-512gb-w10p-156inc",
                            Storage = "512GB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 279,
                            Image = "https://cdn.dsmcdn.com/ty342/product/media/images/20220228/21/60191962/399830501/1/1_org_zoom.jpg",
                            Model = "OMEN 15-EK1012NT 4H0J0EA",
                            Name = "HP",
                            Processor = "I7 10870H",
                            ProductId = 279,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "hp-omen-15-ek1012nt-4h0j0ea-i7-10870h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 280,
                            Image = "https://cdn.dsmcdn.com/ty542/product/media/images/20220928/11/180740952/581623726/1/1_org_zoom.jpg",
                            Model = "PROBOOK 450 G9 6A180EA",
                            Name = "HP",
                            Processor = "I7 1255U",
                            ProductId = 280,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "hp-probook-450-g9-6a180ea-i7-1255u-16gb-512gb-w11p-156inc",
                            Storage = "512GB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 281,
                            Image = "https://productimages.hepsiburada.net/s/131/500/110000081587321.jpg",
                            Model = "250 G8 34N99ESA25",
                            Name = "HP",
                            Processor = "I7 1165G7",
                            ProductId = 281,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "hp-250-g8-34n99esa25-i7-1165g7-32gb-1tb-w10p-156inc",
                            Storage = "1TB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 282,
                            Image = "https://productimages.hepsiburada.net/s/151/1500/110000106860209.jpg",
                            Model = "14S-FQ1014NT 4H0V4EA",
                            Name = "HP",
                            Processor = "R5 5500U",
                            ProductId = 282,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "hp-14s-fq1014nt-4h0v4ea-r5-5500u-8gb-256gb-w10-14inc",
                            Storage = "256GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 283,
                            Image = "https://cdn.dsmcdn.com/ty252/product/media/images/20211123/18/1057496/320623123/1/1_org_zoom.jpg",
                            Model = "14S-FQ1012NT 4H0V3EA",
                            Name = "HP",
                            Processor = "R5 5500U",
                            ProductId = 283,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "hp-14s-fq1012nt-4h0v3ea-r5-5500u-8gb-256gb-w10-14inc",
                            Storage = "256GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 284,
                            Image = "https://cdn.dsmcdn.com/ty544/product/media/images/20220930/18/181894022/583865782/1/1_org_zoom.jpg",
                            Model = "15S-EQ3014NT 68N46EA",
                            Name = "HP",
                            Processor = "R5 5625U",
                            ProductId = 284,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "hp-15s-eq3014nt-68n46ea-r5-5625u-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 285,
                            Image = "https://cdn.dsmcdn.com/ty532/product/media/images/20220912/18/174534496/568285518/1/1_org_zoom.jpg",
                            Model = "255 G9 6Q8N1ES",
                            Name = "HP",
                            Processor = "R5 5625U",
                            ProductId = 285,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "hp-255-g9-6q8n1es-r5-5625u-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 286,
                            Image = "https://cdn.dsmcdn.com/ty515/product/media/images/20220822/10/163731578/549123648/1/1_org_zoom.jpg",
                            Model = "250 G8 5N2Y4ES02",
                            Name = "HP",
                            Processor = "I5 1135G7",
                            ProductId = 286,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "hp-250-g8-5n2y4es02-i5-1135g7-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 287,
                            Image = "https://cdn.dsmcdn.com/ty455/product/media/images/20220613/13/125251747/499404165/1/1_org_zoom.jpg",
                            Model = "250 G8 5N2Y5ES04",
                            Name = "HP",
                            Processor = "I5 1135G7",
                            ProductId = 287,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "hp-250-g8-5n2y5es04-i5-1135g7-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 288,
                            Image = "https://cdn.dsmcdn.com/ty460/product/media/images/20220624/10/129443302/505787827/1/1_org_zoom.jpg",
                            Model = "OMEN 16-C0053NT 68P69EA",
                            Name = "HP",
                            Processor = "R7 5800H",
                            ProductId = 288,
                            Ram = "16GB",
                            Screen = "16.1",
                            Slug = "hp-omen-16-c0053nt-68p69ea-r7-5800h-16gb-512gb-w11-161inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 289,
                            Image = "https://cdn.dsmcdn.com/ty531/product/media/images/20220915/11/175444067/569524192/1/1_org_zoom.jpg",
                            Model = "VICTUS 16-E1004NT 68S20EA",
                            Name = "HP",
                            Processor = "R7 6800H",
                            ProductId = 289,
                            Ram = "16GB",
                            Screen = "16.1",
                            Slug = "hp-victus-16-e1004nt-68s20ea-r7-6800h-16gb-512gb-freedos-161inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 290,
                            Image = "https://cdn.dsmcdn.com/ty546/product/media/images/20221001/17/183283139/585229323/1/1_org_zoom.jpg",
                            Model = "PROOBOK 450 G9 6S748EA24",
                            Name = "HP",
                            Processor = "I7 1255U",
                            ProductId = 290,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "hp-proobok-450-g9-6s748ea24-i7-1255u-32gb-1tb-w11p-156inc",
                            Storage = "1TB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 291,
                            Image = "https://cdn.dsmcdn.com/ty535/product/media/images/20220919/14/176952715/573320372/1/1_org_zoom.jpg",
                            Model = "240 G9 6Q8L8ES",
                            Name = "HP",
                            Processor = "I5 1235U",
                            ProductId = 291,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "hp-240-g9-6q8l8es-i5-1235u-8gb-256gb-freedos-14inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 292,
                            Image = "https://cdn.dsmcdn.com/ty532/product/media/images/20220912/16/174469897/568223368/1/1_org_zoom.jpg",
                            Model = "250 G9 6Q8N9ES",
                            Name = "HP",
                            Processor = "I5 1235U",
                            ProductId = 292,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "hp-250-g9-6q8n9es-i5-1235u-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 293,
                            Image = "https://productimages.hepsiburada.net/s/77/500/110000019201366.jpg",
                            Model = "255 G8 27K40EA",
                            Name = "HP",
                            Processor = "R5 3500U",
                            ProductId = 293,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "hp-255-g8-27k40ea-r5-3500u-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 294,
                            Image = "https://cdn.dsmcdn.com/ty309/product/media/images/20220127/20/37757309/373667096/1/1_org_zoom.jpg",
                            Model = "ENVY 13-BA1002NT 4H0T9EA",
                            Name = "HP",
                            Processor = "I5 1135G7",
                            ProductId = 294,
                            Ram = "8GB",
                            Screen = "13.3",
                            Slug = "hp-envy-13-ba1002nt-4h0t9ea-i5-1135g7-8gb-512gb-w10-133inc",
                            Storage = "512GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 295,
                            Image = "https://productimages.hepsiburada.net/s/67/1500/110000009145755.jpg",
                            Model = "840 G8 2M5U1ES",
                            Name = "HP",
                            Processor = "I7 1165G7",
                            ProductId = 295,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "hp-840-g8-2m5u1es-i7-1165g7-8gb-512gb-freedos-14inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 296,
                            Image = "https://cdn.dsmcdn.com/ty401/product/media/images/20220414/13/91590462/448913881/1/1_org_zoom.jpg",
                            Model = "255 G8",
                            Name = "HP",
                            Processor = "R5 5500U",
                            ProductId = 296,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "hp-255-g8-r5-5500u-8gb-512gb-w10-156inc",
                            Storage = "512GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 297,
                            Image = "https://cdn.dsmcdn.com/ty171/product/media/images/20210909/10/127891830/239365035/1/1_org_zoom.jpg",
                            Model = "OMEN 15-EK1000NT 39C40EA",
                            Name = "HP",
                            Processor = "I7 10870H",
                            ProductId = 297,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "hp-omen-15-ek1000nt-39c40ea-i7-10870h-16gb-512gb-w10-156inc",
                            Storage = "512GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 298,
                            Image = "https://cdn.dsmcdn.com/ty562/product/media/images/20221014/9/193199645/596035500/1/1_org_zoom.jpg",
                            Model = "ELITEBOOK 860 G9 6F5W9EA",
                            Name = "HP",
                            Processor = "I7 1255U",
                            ProductId = 298,
                            Ram = "16GB",
                            Screen = "16",
                            Slug = "hp-elitebook-860-g9-6f5w9ea-i7-1255u-16gb-512gb-w11p-16inc",
                            Storage = "512GB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 299,
                            Image = "https://cdn.dsmcdn.com/ty283/product/media/images/20211231/12/19559352/348972106/1/1_org_zoom.jpg",
                            Model = "ZBOOK FURY 17 G8 4A6B2EA",
                            Name = "HP",
                            Processor = "I9 11950H",
                            ProductId = 299,
                            Ram = "32GB",
                            Screen = "17.3",
                            Slug = "hp-zbook-fury-17-g8-4a6b2ea-i9-11950h-32gb-1tb-w10p-173inc",
                            Storage = "1TB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 300,
                            Image = "https://cdn.dsmcdn.com/ty514/product/media/images/20220822/10/163731624/549124459/1/1_org_zoom.jpg",
                            Model = "250 G8 5N2Y4ES04",
                            Name = "HP",
                            Processor = "I5 1135G7",
                            ProductId = 300,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "hp-250-g8-5n2y4es04-i5-1135g7-32gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 301,
                            Image = "https://cdn.dsmcdn.com/ty259/product/media/images/20211130/10/1855843/326083248/1/1_org_zoom.jpg",
                            Model = "250 34N69ES",
                            Name = "HP",
                            Processor = "I3 1115G4",
                            ProductId = 301,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "hp-250-34n69es-i3-1115g4-4gb-256gb-w10-156inc",
                            Storage = "256GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 302,
                            Image = "https://cdn.dsmcdn.com/ty485/product/media/images/20220720/14/146753528/524558928/1/1_org_zoom.jpg",
                            Model = "PROBOOK 430 G8 4P3R0ES11",
                            Name = "HP",
                            Processor = "I7 1165G7",
                            ProductId = 302,
                            Ram = "64GB",
                            Screen = "13.3",
                            Slug = "hp-probook-430-g8-4p3r0es11-i7-1165g7-64gb-1tb-w10p-133inc",
                            Storage = "1TB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 303,
                            Image = "https://cdn.dsmcdn.com/ty176/product/media/images/20210916/11/130998966/243126981/1/1_org_zoom.jpg",
                            Model = "14S-DQ2006NT G7 4G6A5EA",
                            Name = "HP",
                            Processor = "I5 1135G7",
                            ProductId = 303,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "hp-14s-dq2006nt-g7-4g6a5ea-i5-1135g7-8gb-256gb-freedos-14inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 304,
                            Image = "https://cdn.dsmcdn.com/ty558/product/media/images/20221010/19/190580171/593148903/1/1_org_zoom.jpg",
                            Model = "PROBOOK 440 G9 5Y3Z1EA",
                            Name = "HP",
                            Processor = "I5 1235U",
                            ProductId = 304,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "hp-probook-440-g9-5y3z1ea-i5-1235u-8gb-256gb-w11p-14inc",
                            Storage = "256GB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 305,
                            Image = "https://productimages.hepsiburada.net/s/76/500/110000017623626.jpg",
                            Model = "255 G7 255F6ES-S8",
                            Name = "HP",
                            Processor = "R3 3200U",
                            ProductId = 305,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "hp-255-g7-255f6es-s8-r3-3200u-8gb-256gb-w10-156inc",
                            Storage = "256GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 306,
                            Image = "https://cdn.dsmcdn.com/ty534/product/media/images/20220916/14/176087131/570433742/1/1_org_zoom.jpg",
                            Model = "255 G9 6Q8N2ES",
                            Name = "HP",
                            Processor = "R5 5625U",
                            ProductId = 306,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "hp-255-g9-6q8n2es-r5-5625u-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 307,
                            Image = "https://cdn.dsmcdn.com/ty139/product/media/images/20210702/18/106674185/196534144/0/0_org_zoom.jpg",
                            Model = "ENVY X360 CONVERT 13-AY0007NT 4H0N8EA",
                            Name = "HP",
                            Processor = "R7 4700U",
                            ProductId = 307,
                            Ram = "8GB",
                            Screen = "13.3",
                            Slug = "hp-envy-x360-convert-13-ay0007nt-4h0n8ea-r7-4700u-8gb-512gb-w10-133inc",
                            Storage = "512GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 308,
                            Image = "https://cdn.dsmcdn.com/ty537/product/media/images/20220923/15/178831020/575764922/1/1_org_zoom.jpg",
                            Model = "THINKPAD T15 G2 20W4S0B3TX004",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 308,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-t15-g2-20w4s0b3tx004-i7-1165g7-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 309,
                            Image = "https://cdn.dsmcdn.com/ty106/product/media/images/20210427/9/83228962/167835614/1/1_org_zoom.jpg",
                            Model = "THINKPAD E15 G2 20TDS02VTX004",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 309,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-e15-g2-20tds02vtx004-i7-1165g7-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 310,
                            Image = "https://cdn.dsmcdn.com/ty518/product/media/images/20220826/11/165939661/552947469/1/1_org_zoom.jpg",
                            Model = "THINKPAD E15 G2 20TDS08K00",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 310,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-e15-g2-20tds08k00-i7-1165g7-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 311,
                            Image = "https://cdn.dsmcdn.com/ty446/product/media/images/20220601/16/119455168/491883765/1/1_org_zoom.jpg",
                            Model = "V15 82KB00CDTX",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 311,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-v15-82kb00cdtx-i7-1165g7-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 312,
                            Image = "https://cdn.dsmcdn.com/ty483/product/media/images/20220720/14/146749844/524552797/1/1_org_zoom.jpg",
                            Model = "V15 G2 82KB00CBTX06",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 312,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-v15-g2-82kb00cbtx06-i7-1165g7-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 313,
                            Image = "https://cdn.dsmcdn.com/ty107/product/media/images/20210427/9/83229971/167835558/1/1_org_zoom.jpg",
                            Model = "THINKPAD E15 G2 20TDS02VTX008",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 313,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-e15-g2-20tds02vtx008-i7-1165g7-32gb-1tb-freedos-156inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 314,
                            Image = "https://cdn.dsmcdn.com/ty443/product/media/images/20220531/3/118519033/490798306/1/1_org_zoom.jpg",
                            Model = "THINKPAD E15 G2 20TD004HTX047",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 314,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-e15-g2-20td004htx047-i7-1165g7-16gb-512gb-w11p-156inc",
                            Storage = "512GB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 315,
                            Image = "https://cdn.dsmcdn.com/ty539/product/media/images/20220923/15/178826760/575757360/1/1_org_zoom.jpg",
                            Model = "THINKPAD T15 G2 20W4S0B3TX051",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 315,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-t15-g2-20w4s0b3tx051-i7-1165g7-16gb-512gb-w11p-156inc",
                            Storage = "512GB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 316,
                            Image = "https://cdn.dsmcdn.com/ty537/product/media/images/20220923/16/178835691/575774806/1/1_org_zoom.jpg",
                            Model = "THINKPAD T15 G2 20W4S0B3TX018",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 316,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-t15-g2-20w4s0b3tx018-i7-1165g7-16gb-512gb-w10p-156inc",
                            Storage = "512GB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 317,
                            Image = "https://cdn.dsmcdn.com/ty537/product/media/images/20220923/15/178834369/575772151/1/1_org_zoom.jpg",
                            Model = "THINKPAD T15 G2 20W4S0B3TX009",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 317,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-t15-g2-20w4s0b3tx009-i7-1165g7-16gb-1tb-freedos-156inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 318,
                            Image = "https://cdn.dsmcdn.com/ty107/product/media/images/20210427/12/83273584/167894739/1/1_org_zoom.jpg",
                            Model = "THINKPAD E15 G2 20TDS02VTX026",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 318,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-e15-g2-20tds02vtx026-i7-1165g7-32gb-1tb-w10p-156inc",
                            Storage = "1TB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 319,
                            Image = "https://cdn.dsmcdn.com/ty537/product/media/images/20220923/15/178828293/575759914/1/1_org_zoom.jpg",
                            Model = "THINKPAD T15 G2 20W4S0B3TX026",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 319,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-t15-g2-20w4s0b3tx026-i7-1165g7-32gb-1tb-w10p-156inc",
                            Storage = "1TB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 320,
                            Image = "https://cdn.dsmcdn.com/ty537/product/media/images/20220923/15/178830954/575764709/1/1_org_zoom.jpg",
                            Model = "THINKPAD T15 G2 20W4S0B3TX023",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 320,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-t15-g2-20w4s0b3tx023-i7-1165g7-32gb-512gb-w10p-156inc",
                            Storage = "512GB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 321,
                            Image = "https://cdn.dsmcdn.com/ty458/product/media/images/20220617/13/126671699/415709735/1/1_org_zoom.jpg",
                            Model = "V14 G2 82KA00ECTX",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 321,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "lenovo-v14-g2-82ka00ectx-i5-1135g7-8gb-256gb-freedos-14inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 322,
                            Image = "https://cdn.dsmcdn.com/ty502/product/media/images/20220810/17/157574901/540784080/1/1_org_zoom.jpg",
                            Model = "V15 G2 82KB00CATX012",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 322,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-v15-g2-82kb00catx012-i5-1135g7-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 323,
                            Image = "https://cdn.dsmcdn.com/ty549/product/media/images/20221003/15/184869232/587374953/1/1_org_zoom.jpg",
                            Model = "V15 G2 ALC 82KD0045TX",
                            Name = "LENOVO",
                            Processor = "R7 5700U",
                            ProductId = 323,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-v15-g2-alc-82kd0045tx-r7-5700u-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 324,
                            Image = "https://cdn.dsmcdn.com/ty485/product/media/images/20220719/17/145839897/524197709/1/1_org_zoom.jpg",
                            Model = "THINKBOOK 15 G3 ACL 21A40037TX01",
                            Name = "LENOVO",
                            Processor = "R7 5700U",
                            ProductId = 324,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkbook-15-g3-acl-21a40037tx01-r7-5700u-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 325,
                            Image = "https://cdn.dsmcdn.com/ty282/product/media/images/20211231/15/19675273/349133863/1/1_org_zoom.jpg",
                            Model = "THINKBOOK 15 G3 21A40036TX",
                            Name = "LENOVO",
                            Processor = "R7 5700U",
                            ProductId = 325,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkbook-15-g3-21a40036tx-r7-5700u-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 326,
                            Image = "https://cdn.dsmcdn.com/ty515/product/media/images/20220822/9/163703819/549051367/1/1_org_zoom.jpg",
                            Model = "IDEAPAD 3 82KU00VNTX",
                            Name = "LENOVO",
                            Processor = "R7 5700U",
                            ProductId = 326,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-ideapad-3-82ku00vntx-r7-5700u-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 327,
                            Image = "https://cdn.dsmcdn.com/ty140/product/media/images/20210701/17/106181169/195952189/1/1_org_zoom.jpg",
                            Model = "THINKPAD E14 G2 20TA0054TX",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 327,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-e14-g2-20ta0054tx-i5-1135g7-8gb-256gb-freedos-14inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 328,
                            Image = "https://cdn.dsmcdn.com/ty532/product/media/images/20220913/12/174803538/234809812/1/1_org_zoom.jpg",
                            Model = "V14 G2 82KA0025TX",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 328,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "lenovo-v14-g2-82ka0025tx-i5-1135g7-8gb-256gb-freedos-14inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 329,
                            Image = "https://cdn.dsmcdn.com/ty66/product/media/images/20210208/20/61136766/139109660/1/1_org_zoom.jpg",
                            Model = "THINKPAD E15 G2 20TD004KTX012",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 329,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-e15-g2-20td004ktx012-i7-1165g7-32gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 330,
                            Image = "https://cdn.dsmcdn.com/ty538/product/media/images/20220923/16/178837981/575779657/1/1_org_zoom.jpg",
                            Model = "THINKPAD T15 G2 20W4S0B3TX006",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 330,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-t15-g2-20w4s0b3tx006-i7-1165g7-32gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 331,
                            Image = "https://cdn.dsmcdn.com/ty537/product/media/images/20220923/15/178826969/575757613/1/1_org_zoom.jpg",
                            Model = "THINKPAD T15 G2 20W4S0B3TX038",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 331,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-t15-g2-20w4s0b3tx038-i7-1165g7-32gb-512gb-w11-156inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 332,
                            Image = "https://productimages.hepsiburada.net/s/289/500/110000278092927.jpg",
                            Model = "THINKPAD E14 G2 20TAS0CX00",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 332,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-e14-g2-20tas0cx00-i7-1165g7-16gb-512gb-freedos-14inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 333,
                            Image = "https://cdn.dsmcdn.com/ty539/product/media/images/20220923/15/178827959/575759110/1/1_org_zoom.jpg",
                            Model = "THINKPAD T15 G2 20W4S0B3TX056",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 333,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-t15-g2-20w4s0b3tx056-i7-1165g7-32gb-1tb-w11p-156inc",
                            Storage = "1TB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 334,
                            Image = "https://cdn.dsmcdn.com/ty542/product/media/images/20220927/16/180354249/581024900/1/1_org_zoom.jpg",
                            Model = "THINKPAD E14 G2 20TA00JXTX",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 334,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-e14-g2-20ta00jxtx-i7-1165g7-16gb-512gb-w11p-14inc",
                            Storage = "512GB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 335,
                            Image = "https://cdn.dsmcdn.com/ty540/product/media/images/20220926/13/179975893/578962488/1/1_org_zoom.jpg",
                            Model = "THINKPAD T15 G2 20W4S0B3TX054",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 335,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-t15-g2-20w4s0b3tx054-i7-1165g7-16gb-1tb-w11p-156inc",
                            Storage = "1TB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 336,
                            Image = "https://cdn.dsmcdn.com/ty459/product/media/images/20220622/18/129030153/505146995/1/1_org_zoom.jpg",
                            Model = "V15 G2 82KB00HWTX",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 336,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-v15-g2-82kb00hwtx-i5-1135g7-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 337,
                            Image = "https://cdn.dsmcdn.com/ty481/product/media/images/20220718/18/143995745/523637885/1/1_org_zoom.jpg",
                            Model = "V15 G2 82KB00CATX",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 337,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-v15-g2-82kb00catx-i5-1135g7-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 338,
                            Image = "https://productimages.hepsiburada.net/s/205/500/110000180661193.jpg",
                            Model = "THINKPAD L15 G2 20X300GHTX",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 338,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-l15-g2-20x300ghtx-i5-1135g7-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 339,
                            Image = "https://cdn.dsmcdn.com/ty180/product/media/images/20210922/10/135167232/248229021/1/1_org_zoom.jpg",
                            Model = "THINKPAD E15 G2 20TD004GTX",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 339,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-e15-g2-20td004gtx-i5-1135g7-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 340,
                            Image = "https://cdn.dsmcdn.com/ty148/product/media/images/20210717/13/111461963/205718205/1/1_org_zoom.jpg",
                            Model = "THINKPAD E14 G2 20TA0056TX041",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 340,
                            Ram = "32GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-e14-g2-20ta0056tx041-i7-1165g7-32gb-1tb-w10p-14inc",
                            Storage = "1TB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 341,
                            Image = "https://cdn.dsmcdn.com/ty538/product/media/images/20220920/17/177504378/574043758/1/1_org_zoom.jpg",
                            Model = "THINKPAD E14 G2 20TAS0CXTA32",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 341,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-e14-g2-20tas0cxta32-i7-1165g7-16gb-1tb-w10p-14inc",
                            Storage = "1TB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 342,
                            Image = "https://cdn.dsmcdn.com/ty323/product/media/images/20220204/20/44297206/356576086/1/1_org_zoom.jpg",
                            Model = "THINKPAD E14 G2 20TBS44CTX018",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 342,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-e14-g2-20tbs44ctx018-i7-1165g7-16gb-1tb-w10p-14inc",
                            Storage = "1TB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 343,
                            Image = "https://cdn.dsmcdn.com/ty538/product/media/images/20220924/15/179220652/576434018/1/1_org_zoom.jpg",
                            Model = "THINKPAD T14 G2 20WM0AEHTX054",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 343,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-t14-g2-20wm0aehtx054-i7-1165g7-16gb-1tb-w11p-14inc",
                            Storage = "1TB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 344,
                            Image = "https://productimages.hepsiburada.net/s/286/1500/110000275338848.jpg",
                            Model = "YOGA 7 82BJ00DMTX",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 344,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-yoga-7-82bj00dmtx-i7-1165g7-16gb-512gb-w11-156inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 345,
                            Image = "https://cdn.dsmcdn.com/ty540/product/media/images/20220926/14/180007809/579010092/1/1_org_zoom.jpg",
                            Model = "THINKPAD T15 G2 20W4S0B3TX045",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 345,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-t15-g2-20w4s0b3tx045-i7-1165g7-16gb-256gb-w11p-156inc",
                            Storage = "256GB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 346,
                            Image = "https://cdn.dsmcdn.com/ty160/product/media/images/20210819/13/120021790/229553202/1/1_org_zoom.jpg",
                            Model = "THINKPAD E14 G2 20TA0053TX25",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 346,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-e14-g2-20ta0053tx25-i7-1165g7-16gb-256gb-w10p-14inc",
                            Storage = "256GB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 347,
                            Image = "https://cdn.dsmcdn.com/ty450/product/media/images/20220609/11/123364220/494099081/1/1_org_zoom.jpg",
                            Model = "V14 G2 82KA00ECTX005",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 347,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "lenovo-v14-g2-82ka00ectx005-i5-1135g7-16gb-256gb-freedos-14inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 348,
                            Image = "https://productimages.hepsiburada.net/s/207/500/110000183779701.jpg",
                            Model = "THINKPAD E14 G2 20TA004YTX",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 348,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-e14-g2-20ta004ytx-i5-1135g7-16gb-256gb-freedos-14inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 349,
                            Image = "https://productimages.hepsiburada.net/s/196/500/110000164452442.jpg",
                            Model = "IDEAPAD L3 82HL009HTX",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 349,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-ideapad-l3-82hl009htx-i7-1165g7-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 350,
                            Image = "https://cdn.dsmcdn.com/ty505/product/media/images/20220811/16/157933178/541485885/1/1_org_zoom.jpg",
                            Model = "THINKPAD E14 G2 20TDR2ABX45",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 350,
                            Ram = "32GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-e14-g2-20tdr2abx45-i7-1165g7-32gb-1tb-w11p-14inc",
                            Storage = "1TB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 351,
                            Image = "https://cdn.dsmcdn.com/ty539/product/media/images/20220923/15/178830936/575764678/1/1_org_zoom.jpg",
                            Model = "THINKPAD T15 G2 20W4S0B3TX015",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 351,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-t15-g2-20w4s0b3tx015-i7-1165g7-16gb-256gb-w10p-156inc",
                            Storage = "256GB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 352,
                            Image = "https://cdn.dsmcdn.com/ty162/product/media/images/20210823/11/121502200/231903970/0/0_org_zoom.jpg",
                            Model = "THINKPAD E14 G2 20TA0050TX019",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 352,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-e14-g2-20ta0050tx019-i7-1165g7-16gb-1tb-w10-14inc",
                            Storage = "1TB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 353,
                            Image = "https://cdn.dsmcdn.com/ty539/product/media/images/20220921/13/177967007/574641972/1/1_org_zoom.jpg",
                            Model = "THINKPAD E14 G2 20TAS0CXTA11",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 353,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-e14-g2-20tas0cxta11-i7-1165g7-16gb-2tb-freedos-14inc",
                            Storage = "2TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 354,
                            Image = "https://cdn.dsmcdn.com/ty539/product/media/images/20220923/15/178827844/575758822/1/1_org_zoom.jpg",
                            Model = "THINKPAD T15 G2 20W4S0B3TX012",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 354,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-t15-g2-20w4s0b3tx012-i7-1165g7-16gb-2tb-freedos-156inc",
                            Storage = "2TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 355,
                            Image = "https://cdn.dsmcdn.com/ty138/product/media/images/20210702/10/106348960/196116691/1/1_org_zoom.jpg",
                            Model = "THINKPAD E14 G2 20TA0054TX004",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 355,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-e14-g2-20ta0054tx004-i5-1135g7-16gb-512gb-freedos-14inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 356,
                            Image = "https://cdn.dsmcdn.com/ty450/product/media/images/20220609/11/123364200/494092218/1/1_org_zoom.jpg",
                            Model = "V14 G2 82KA00ECTX041",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 356,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "lenovo-v14-g2-82ka00ectx041-i5-1135g7-16gb-512gb-w11-14inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 357,
                            Image = "https://cdn.dsmcdn.com/ty489/product/media/images/20220724/21/149294286/528034072/1/1_org_zoom.jpg",
                            Model = "IDEAPAD FLEX5 82HS00MVTX",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 357,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "lenovo-ideapad-flex5-82hs00mvtx-i5-1135g7-16gb-512gb-w11-14inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 358,
                            Image = "https://cdn.dsmcdn.com/ty541/product/media/images/20220927/17/180359366/581069780/1/1_org_zoom.jpg",
                            Model = "THINKPAD E14 G2 20TAS0CXTA36",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 358,
                            Ram = "32GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-e14-g2-20tas0cxta36-i7-1165g7-32gb-2tb-w10p-14inc",
                            Storage = "2TB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 359,
                            Image = "https://cdn.dsmcdn.com/ty540/product/media/images/20220927/17/180366708/581091106/1/1_org_zoom.jpg",
                            Model = "FLEX 5 82HS00JXTX",
                            Name = "LENOVO",
                            Processor = "I3 1115G4",
                            ProductId = 359,
                            Ram = "4GB",
                            Screen = "14",
                            Slug = "lenovo-flex-5-82hs00jxtx-i3-1115g4-4gb-256gb-w11-14inc",
                            Storage = "256GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 360,
                            Image = "https://cdn.dsmcdn.com/ty527/product/media/images/20220910/14/171552725/562159220/1/1_org_zoom.jpg",
                            Model = "THINKPAD P15 20YQ001NTX07",
                            Name = "LENOVO",
                            Processor = "I7 11800H",
                            ProductId = 360,
                            Ram = "64GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-p15-20yq001ntx07-i7-11800h-64gb-1tb-w10p-156inc",
                            Storage = "1TB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 361,
                            Image = "https://cdn.dsmcdn.com/ty371/product/media/images/20220323/16/75083527/424181553/1/1_org_zoom.jpg",
                            Model = "THINKPAD P17 G2 20YU0022TX02",
                            Name = "LENOVO",
                            Processor = "I7 11800H",
                            ProductId = 361,
                            Ram = "64GB",
                            Screen = "17.3",
                            Slug = "lenovo-thinkpad-p17-g2-20yu0022tx02-i7-11800h-64gb-1tb-w10p-173inc",
                            Storage = "1TB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 362,
                            Image = "https://cdn.dsmcdn.com/ty370/product/media/images/20220323/16/75083956/424182710/1/1_org_zoom.jpg",
                            Model = "THINKPAD P17 G2 20YU0022TX05",
                            Name = "LENOVO",
                            Processor = "I7 11800H",
                            ProductId = 362,
                            Ram = "64GB",
                            Screen = "17.3",
                            Slug = "lenovo-thinkpad-p17-g2-20yu0022tx05-i7-11800h-64gb-1tb-w10p-173inc",
                            Storage = "1TB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 363,
                            Image = "https://cdn.dsmcdn.com/ty435/product/media/images/20220519/10/113459053/482490701/1/1_org_zoom.jpg",
                            Model = "82HS00NSTX IDEAPAD FLEX 5",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 363,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "lenovo-82hs00nstx-ideapad-flex-5-i5-1135g7-8gb-256gb-w10-14inc",
                            Storage = "256GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 364,
                            Image = "https://cdn.dsmcdn.com/ty538/product/media/images/20220923/15/178830510/575763751/1/1_org_zoom.jpg",
                            Model = "THINKPAD T15 G2 20W4S0B3TX001",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 364,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-t15-g2-20w4s0b3tx001-i7-1165g7-16gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 365,
                            Image = "https://cdn.dsmcdn.com/ty226/product/media/images/20211105/12/166134005/288949589/1/1_org_zoom.jpg",
                            Model = "THINKPAD X1 CARBON G9 20XWS09XCG2",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 365,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-x1-carbon-g9-20xws09xcg2-i7-1165g7-16gb-2tb-w10p-14inc",
                            Storage = "2TB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 366,
                            Image = "https://cdn.dsmcdn.com/ty537/product/media/images/20220920/17/177504956/574045105/1/1_org_zoom.jpg",
                            Model = "THINKPAD E14 G2 20TAS0CXTA35",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 366,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-e14-g2-20tas0cxta35-i7-1165g7-16gb-2tb-w10p-14inc",
                            Storage = "2TB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 367,
                            Image = "https://cdn.dsmcdn.com/ty504/product/media/images/20220812/16/158577545/542458064/1/1_org_zoom.jpg",
                            Model = "THINKPAD E15 G2 20TD004HTX48",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 367,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-e15-g2-20td004htx48-i7-1165g7-32gb-2tb-w11p-156inc",
                            Storage = "2TB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 368,
                            Image = "https://cdn.dsmcdn.com/ty461/product/media/images/20220623/17/129278211/505518665/1/1_org_zoom.jpg",
                            Model = "YOGA 7 82BH00AGTX01",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 368,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "lenovo-yoga-7-82bh00agtx01-i7-1165g7-8gb-1tb-w10-14inc",
                            Storage = "1TB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 369,
                            Image = "https://cdn.dsmcdn.com/ty561/product/media/images/20221014/17/193533662/596440010/1/1_org_zoom.jpg",
                            Model = "IDEAPAD 3",
                            Name = "LENOVO",
                            Processor = "I3 1115G4",
                            ProductId = 369,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-ideapad-3-i3-1115g4-8gb-256gb-w11-156inc",
                            Storage = "256GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 370,
                            Image = "https://cdn.dsmcdn.com/ty509/product/media/images/20220816/9/160667993/545018194/1/1_org_zoom.jpg",
                            Model = "IDEAPAD 3 82H80144TX",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 370,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-ideapad-3-82h80144tx-i5-1135g7-8gb-256gb-w10-156inc",
                            Storage = "256GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 371,
                            Image = "https://cdn.dsmcdn.com/ty353/product/media/images/20220307/16/64134681/334520358/2/2_org_zoom.jpg",
                            Model = "V15 G2 82KB000RTX",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 371,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-v15-g2-82kb000rtx-i5-1135g7-8gb-256gb-w10-156inc",
                            Storage = "256GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 372,
                            Image = "https://cdn.dsmcdn.com/ty544/product/media/images/20220930/18/181891489/583866498/1/1_org_zoom.jpg",
                            Model = "IDEAPAD 3 15ITL6 82H802C5TX",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 372,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-ideapad-3-15itl6-82h802c5tx-i5-1135g7-8gb-512gb-w11-156inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 373,
                            Image = "https://cdn.dsmcdn.com/ty497/product/media/images/20220802/14/153584121/533371736/1/1_org_zoom.jpg",
                            Model = "IDEAPAD 82H801GJTX",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 373,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-ideapad-82h801gjtx-i5-1135g7-8gb-512gb-w11-156inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 374,
                            Image = "https://cdn.dsmcdn.com/ty460/product/media/images/20220623/16/129272084/505510064/1/1_org_zoom.jpg",
                            Model = "YOGA 7 82BH00AGTX",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 374,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "lenovo-yoga-7-82bh00agtx-i7-1165g7-8gb-512gb-w10-14inc",
                            Storage = "512GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 375,
                            Image = "https://cdn.dsmcdn.com/ty513/product/media/images/20220823/17/164498618/550827145/1/1_org_zoom.jpg",
                            Model = "V15 ALC G2 82KD0042TX04",
                            Name = "LENOVO",
                            Processor = "R5 5500U",
                            ProductId = 375,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-v15-alc-g2-82kd0042tx04-r5-5500u-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 376,
                            Image = "https://productimages.hepsiburada.net/s/127/500/110000077043631.jpg",
                            Model = "THINKPAD E14 G3 20Y7004ETX",
                            Name = "LENOVO",
                            Processor = "R7 5700U",
                            ProductId = 376,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-e14-g3-20y7004etx-r7-5700u-16gb-512gb-freedos-14inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 377,
                            Image = "https://cdn.dsmcdn.com/ty538/product/media/images/20220920/17/177505367/574045613/1/1_org_zoom.jpg",
                            Model = "THINKPAD E14 G2 20TAS0CXTA12",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 377,
                            Ram = "32GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-e14-g2-20tas0cxta12-i7-1165g7-32gb-2tb-freedos-14inc",
                            Storage = "2TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 378,
                            Image = "https://cdn.dsmcdn.com/ty482/product/media/images/20220718/15/143856303/523489096/1/1_org_zoom.jpg",
                            Model = "THINKPAD E14 20Y7S04100",
                            Name = "LENOVO",
                            Processor = "R5 5500U",
                            ProductId = 378,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-e14-20y7s04100-r5-5500u-8gb-256gb-freedos-14inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 379,
                            Image = "https://cdn.dsmcdn.com/ty142/product/media/images/20210709/17/108726658/200072517/1/1_org_zoom.jpg",
                            Model = "THINKPAD E14 G2 20TA0054TX003",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 379,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-e14-g2-20ta0054tx003-i5-1135g7-16gb-256gb-freedos-14inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 380,
                            Image = "https://cdn.dsmcdn.com/ty537/product/media/images/20220923/17/178884453/251360828/1/1_org_zoom.jpg",
                            Model = "THINKPAD E14 G3 20Y7004FTX",
                            Name = "LENOVO",
                            Processor = "R5 5500U",
                            ProductId = 380,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-e14-g3-20y7004ftx-r5-5500u-8gb-256gb-freedos-14inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 381,
                            Image = "https://productimages.hepsiburada.net/s/218/500/110000196762561.jpg",
                            Model = "THINKPAD E15 G3 20YG0046TX",
                            Name = "LENOVO",
                            Processor = "R5 5500U",
                            ProductId = 381,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-e15-g3-20yg0046tx-r5-5500u-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 382,
                            Image = "https://cdn.dsmcdn.com/ty165/product/media/images/20210826/12/122679917/233368499/1/1_org_zoom.jpg",
                            Model = "THINKPAD E15 V14 G2 82KA006XTX",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 382,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-e15-v14-g2-82ka006xtx-i5-1135g7-8gb-512gb-freedos-14inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 383,
                            Image = "https://cdn.dsmcdn.com/ty417/product/media/images/20220506/14/103080033/467675605/1/1_org_zoom.jpg",
                            Model = "IDEAPAD G3 82K100CWTX03",
                            Name = "LENOVO",
                            Processor = "I5 11300H",
                            ProductId = 383,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-ideapad-g3-82k100cwtx03-i5-11300h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 384,
                            Image = "https://cdn.dsmcdn.com/ty542/product/media/images/20220927/13/180285557/380819768/2/2_org_zoom.jpg",
                            Model = "IDEAPAD G3 82K100CSTX",
                            Name = "LENOVO",
                            Processor = "I5 11300H",
                            ProductId = 384,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-ideapad-g3-82k100cstx-i5-11300h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 385,
                            Image = "https://cdn.dsmcdn.com/ty554/product/media/images/20221006/15/187670838/590627662/1/1_org_zoom.jpg",
                            Model = "THINKPAD E15 G2 20TD004CTX",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 385,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-e15-g2-20td004ctx-i5-1135g7-16gb-512gb-w10p-156inc",
                            Storage = "512GB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 386,
                            Image = "https://cdn.dsmcdn.com/ty496/product/media/images/20220802/10/153467173/533590200/1/1_org_zoom.jpg",
                            Model = "IDEAPAD 3 82H80253TX",
                            Name = "LENOVO",
                            Processor = "I3 1115G4",
                            ProductId = 386,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "lenovo-ideapad-3-82h80253tx-i3-1115g4-4gb-256gb-w11-156inc",
                            Storage = "256GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 387,
                            Image = "https://cdn.dsmcdn.com/ty533/product/media/images/20220915/12/175464075/569546622/1/1_org_zoom.jpg",
                            Model = "V15 G2 ALC 82KD0041TX",
                            Name = "LENOVO",
                            Processor = "R3 5300U",
                            ProductId = 387,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-v15-g2-alc-82kd0041tx-r3-5300u-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 388,
                            Image = "https://cdn.dsmcdn.com/ty280/product/media/images/20211227/16/17119189/345747231/1/1_org_zoom.jpg",
                            Model = "THINKBOOK 15 G3 21A4009UTX",
                            Name = "LENOVO",
                            Processor = "R5 5500U",
                            ProductId = 388,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkbook-15-g3-21a4009utx-r5-5500u-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 389,
                            Image = "https://cdn.dsmcdn.com/ty456/product/media/images/20220617/17/126852686/502064662/1/1_org_zoom.jpg",
                            Model = "IDEAPAD G3 82K200JXTX",
                            Name = "LENOVO",
                            Processor = "R7 5800H",
                            ProductId = 389,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-ideapad-g3-82k200jxtx-r7-5800h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 390,
                            Image = "https://cdn.dsmcdn.com/ty552/product/media/images/20221006/16/187692164/380444698/1/1_org_zoom.jpg",
                            Model = "IDEAPAD G3 82K200JWTX",
                            Name = "LENOVO",
                            Processor = "R7 5800H",
                            ProductId = 390,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-ideapad-g3-82k200jwtx-r7-5800h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 391,
                            Image = "https://cdn.dsmcdn.com/ty537/product/media/images/20220923/16/178857792/575814113/1/1_org_zoom.jpg",
                            Model = "THINKPAD T15 G2 20W4S0B3TX005",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 391,
                            Ram = "24GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-t15-g2-20w4s0b3tx005-i7-1165g7-24gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 392,
                            Image = "https://cdn.dsmcdn.com/ty537/product/media/images/20220923/15/178834370/575772155/1/1_org_zoom.jpg",
                            Model = "THINKPAD T15 G2 20W4S0B3TX007",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 392,
                            Ram = "24GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-t15-g2-20w4s0b3tx007-i7-1165g7-24gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 393,
                            Image = "https://productimages.hepsiburada.net/s/241/500/110000225450604.jpg",
                            Model = "V14 G2 ITL 82KA00ECTX019",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 393,
                            Ram = "12GB",
                            Screen = "14",
                            Slug = "lenovo-v14-g2-itl-82ka00ectx019-i5-1135g7-12gb-256gb-w10p-14inc",
                            Storage = "256GB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 394,
                            Image = "https://cdn.dsmcdn.com/ty468/product/media/images/20220707/13/136514259/515989100/1/1_org_zoom.jpg",
                            Model = "V14 82KC000QTX06",
                            Name = "LENOVO",
                            Processor = "R3 5300U",
                            ProductId = 394,
                            Ram = "12GB",
                            Screen = "14",
                            Slug = "lenovo-v14-82kc000qtx06-r3-5300u-12gb-256gb-freedos-14inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 395,
                            Image = "https://cdn.dsmcdn.com/ty398/product/media/images/20220413/16/90315754/447320363/1/1_org_zoom.jpg",
                            Model = "IDEAPAD 5 82FE00AYTX",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 395,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "lenovo-ideapad-5-82fe00aytx-i7-1165g7-16gb-1tb-freedos-14inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 396,
                            Image = "https://cdn.dsmcdn.com/ty307/product/media/images/20220125/18/35884251/370822834/1/1_org_zoom.jpg",
                            Model = "V14 82KC0005TX05",
                            Name = "LENOVO",
                            Processor = "R3 5300U",
                            ProductId = 396,
                            Ram = "12GB",
                            Screen = "14",
                            Slug = "lenovo-v14-82kc0005tx05-r3-5300u-12gb-256gb-freedos-14inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 397,
                            Image = "https://productimages.hepsiburada.net/s/218/500/110000197381607.jpg",
                            Model = "IDEAPAD G3 82K200T4TX",
                            Name = "LENOVO",
                            Processor = "R5 5600H",
                            ProductId = 397,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-ideapad-g3-82k200t4tx-r5-5600h-16gb-1tb-freedos-156inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 398,
                            Image = "https://productimages.hepsiburada.net/s/282/500/110000269967286.jpg",
                            Model = "THINKPAD E15 G3 20YGS04400Z36",
                            Name = "LENOVO",
                            Processor = "R7 5700U",
                            ProductId = 398,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-e15-g3-20ygs04400z36-r7-5700u-16gb-512gb-w10p-156inc",
                            Storage = "512GB",
                            System = "W10P"
                        },
                        new
                        {
                            DetailId = 399,
                            Image = "https://cdn.dsmcdn.com/ty483/product/media/images/20220719/18/145865610/524182717/1/1_org_zoom.jpg",
                            Model = "THINKBOOK 15 G3 ACL 21A40037TX12",
                            Name = "LENOVO",
                            Processor = "R7 5700U",
                            ProductId = 399,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkbook-15-g3-acl-21a40037tx12-r7-5700u-16gb-512gb-w11p-156inc",
                            Storage = "512GB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 400,
                            Image = "https://cdn.dsmcdn.com/ty540/product/media/images/20220926/12/179956340/578910404/1/1_org_zoom.jpg",
                            Model = "THINKPAD E15 G3 20YGS04400Z62",
                            Name = "LENOVO",
                            Processor = "R7 5700U",
                            ProductId = 400,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-e15-g3-20ygs04400z62-r7-5700u-16gb-512gb-w11p-156inc",
                            Storage = "512GB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 401,
                            Image = "https://cdn.dsmcdn.com/ty538/product/media/images/20220923/15/178827871/575758852/1/1_org_zoom.jpg",
                            Model = "THINKPAD T15 G2 20W4S0B3TX049",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 401,
                            Ram = "24GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-t15-g2-20w4s0b3tx049-i7-1165g7-24gb-512gb-w11p-156inc",
                            Storage = "512GB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 402,
                            Image = "https://cdn.dsmcdn.com/ty538/product/media/images/20220923/15/178830575/575763894/1/1_org_zoom.jpg",
                            Model = "THINKPAD T15 G2 20W4S0B3TX052",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 402,
                            Ram = "24GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-t15-g2-20w4s0b3tx052-i7-1165g7-24gb-512gb-w11p-156inc",
                            Storage = "512GB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 403,
                            Image = "https://productimages.hepsiburada.net/s/241/500/110000225450604.jpg",
                            Model = "V14 G2 ITL 82KA00ECTX042",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 403,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "lenovo-v14-g2-itl-82ka00ectx042-i5-1135g7-8gb-1tb-w11-14inc",
                            Storage = "1TB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 404,
                            Image = "https://cdn.dsmcdn.com/ty496/product/media/images/20220801/15/153089795/533168174/1/1_org_zoom.jpg",
                            Model = "YOGA 7 14ITL5 82BH00DHTX01",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 404,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "lenovo-yoga-7-14itl5-82bh00dhtx01-i5-1135g7-8gb-1tb-w11-14inc",
                            Storage = "1TB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 405,
                            Image = "https://cdn.dsmcdn.com/ty465/product/media/images/20220701/11/133358489/511034207/1/1_org_zoom.jpg",
                            Model = "V15 82KB0005TXX",
                            Name = "LENOVO",
                            Processor = "I3 1115G4",
                            ProductId = 405,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-v15-82kb0005txx-i3-1115g4-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 406,
                            Image = "https://cdn.dsmcdn.com/ty522/product/media/images/20220907/12/170048095/560486631/1/1_org_zoom.jpg",
                            Model = "IDEAPAD 3 81WB01EJTX",
                            Name = "LENOVO",
                            Processor = "I5 10210U",
                            ProductId = 406,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-ideapad-3-81wb01ejtx-i5-10210u-8gb-256gb-w11-156inc",
                            Storage = "256GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 407,
                            Image = "https://cdn.dsmcdn.com/ty538/product/media/images/20220920/17/177504702/574045097/1/1_org_zoom.jpg",
                            Model = "THINKPAD E14 G2 20TAS0CXTA10",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 407,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-e14-g2-20tas0cxta10-i7-1165g7-8gb-2tb-freedos-14inc",
                            Storage = "2TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 408,
                            Image = "https://cdn.dsmcdn.com/ty498/product/media/images/20220805/17/155073910/536369060/1/1_org_zoom.jpg",
                            Model = "L3 15IML05 81Y300MDTX",
                            Name = "LENOVO",
                            Processor = "I5 10210U",
                            ProductId = 408,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-l3-15iml05-81y300mdtx-i5-10210u-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 409,
                            Image = "https://cdn.dsmcdn.com/ty534/product/media/images/20220915/19/175638472/569927650/1/1_org_zoom.jpg",
                            Model = "IDEAPAD 3 81WB01EHTX",
                            Name = "LENOVO",
                            Processor = "I5 10210U",
                            ProductId = 409,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-ideapad-3-81wb01ehtx-i5-10210u-8gb-512gb-w11-156inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 410,
                            Image = "https://cdn.dsmcdn.com/ty277/product/media/images/20211224/13/15895327/344324177/1/1_org_zoom.jpg",
                            Model = "V15 82C500R2TX01",
                            Name = "LENOVO",
                            Processor = "I5 1035G1",
                            ProductId = 410,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-v15-82c500r2tx01-i5-1035g1-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 411,
                            Image = "https://cdn.dsmcdn.com/ty67/product/media/images/20210208/12/61014497/138985904/1/1_org_zoom.jpg",
                            Model = "IDEAPAD 3 81W1005RTX",
                            Name = "LENOVO",
                            Processor = "R7 3700U",
                            ProductId = 411,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-ideapad-3-81w1005rtx-r7-3700u-8gb-512gb-w10-156inc",
                            Storage = "512GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 412,
                            Image = "https://cdn.dsmcdn.com/ty67/product/media/images/20210316/11/72011414/152979637/1/1_org_zoom.jpg",
                            Model = "V17-IIL 82GX007VTX",
                            Name = "LENOVO",
                            Processor = "I7 1065G7",
                            ProductId = 412,
                            Ram = "12GB",
                            Screen = "17.3",
                            Slug = "lenovo-v17-iil-82gx007vtx-i7-1065g7-12gb-512gb-freedos-173inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 413,
                            Image = "https://cdn.dsmcdn.com/ty306/product/media/images/20220125/19/35905053/370845838/1/1_org_zoom.jpg",
                            Model = "V14 G2 ALC 82KC0005TX06",
                            Name = "LENOVO",
                            Processor = "R3 5300U",
                            ProductId = 413,
                            Ram = "12GB",
                            Screen = "14",
                            Slug = "lenovo-v14-g2-alc-82kc0005tx06-r3-5300u-12gb-512gb-freedos-14inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 414,
                            Image = "https://cdn.dsmcdn.com/ty552/product/media/images/20221007/9/187909123/590999845/1/1_org_zoom.jpg",
                            Model = "THINKPAD T14 G3 21AH00CSTX050",
                            Name = "LENOVO",
                            Processor = "I7 1255U",
                            ProductId = 414,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-t14-g3-21ah00cstx050-i7-1255u-16gb-1tb-w11p-14inc",
                            Storage = "1TB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 415,
                            Image = "https://cdn.dsmcdn.com/ty440/product/media/images/20220524/9/115551081/486512581/1/1_org_zoom.jpg",
                            Model = "IDEAPAD G3 15IHU6 82K100CMTX",
                            Name = "LENOVO",
                            Processor = "I7 11370H",
                            ProductId = 415,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-ideapad-g3-15ihu6-82k100cmtx-i7-11370h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 416,
                            Image = "https://cdn.dsmcdn.com/ty347/product/media/images/20220302/11/61210848/401409207/1/1_org_zoom.jpg",
                            Model = "LEGION 5 82JH002JTX03",
                            Name = "LENOVO",
                            Processor = "I7 11600H",
                            ProductId = 416,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "lenovo-legion-5-82jh002jtx03-i7-11600h-16gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 417,
                            Image = "https://cdn.dsmcdn.com/ty541/product/media/images/20220928/12/180758822/581662517/1/1_org_zoom.jpg",
                            Model = "THINKPAD T14 G3 21AH00CSTX025",
                            Name = "LENOVO",
                            Processor = "I7 1255U",
                            ProductId = 417,
                            Ram = "16GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-t14-g3-21ah00cstx025-i7-1255u-16gb-512gb-w11-14inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 418,
                            Image = "https://cdn.dsmcdn.com/ty539/product/media/images/20220923/15/178827045/575757696/1/1_org_zoom.jpg",
                            Model = "THINKPAD T15 G2 20W4S0B3TX037",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 418,
                            Ram = "24GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-t15-g2-20w4s0b3tx037-i7-1165g7-24gb-512gb-w11-156inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 419,
                            Image = "https://cdn.dsmcdn.com/ty540/product/media/images/20220928/11/180733015/581582513/1/1_org_zoom.jpg",
                            Model = "THINKPAD T14 G3 21AH00CSTX013",
                            Name = "LENOVO",
                            Processor = "I7 1255U",
                            ProductId = 419,
                            Ram = "32GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-t14-g3-21ah00cstx013-i7-1255u-32gb-1tb-freedos-14inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 420,
                            Image = "https://cdn.dsmcdn.com/ty552/product/media/images/20221007/10/187911809/591003249/1/1_org_zoom.jpg",
                            Model = "THINKPAD T14 G3 21AH00CSTX028",
                            Name = "LENOVO",
                            Processor = "I7 1255U",
                            ProductId = 420,
                            Ram = "32GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-t14-g3-21ah00cstx028-i7-1255u-32gb-512gb-w11-14inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 421,
                            Image = "https://cdn.dsmcdn.com/ty557/product/media/images/20221010/13/190346104/592841716/1/1_org_zoom.jpg",
                            Model = "THINKPAD T14 G3 21AH00CSTX048",
                            Name = "LENOVO",
                            Processor = "I7 1255U",
                            ProductId = 421,
                            Ram = "32GB",
                            Screen = "14",
                            Slug = "lenovo-thinkpad-t14-g3-21ah00cstx048-i7-1255u-32gb-512gb-w11p-14inc",
                            Storage = "512GB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 422,
                            Image = "https://cdn.dsmcdn.com/ty485/product/media/images/20220720/15/146758766/524569606/1/1_org_zoom.jpg",
                            Model = "THINKBOOK 14 G2 20VD0045TX31",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 422,
                            Ram = "40GB",
                            Screen = "14",
                            Slug = "lenovo-thinkbook-14-g2-20vd0045tx31-i7-1165g7-40gb-1tb-w11p-14inc",
                            Storage = "1TB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 423,
                            Image = "https://cdn.dsmcdn.com/ty363/product/media/images/20220317/18/71554903/418464401/1/1_org_zoom.jpg",
                            Model = "V17 G2 ITL 82NX00ECTX081",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 423,
                            Ram = "40GB",
                            Screen = "17.3",
                            Slug = "lenovo-v17-g2-itl-82nx00ectx081-i7-1165g7-40gb-512gb-w11p-173inc",
                            Storage = "512GB",
                            System = "W11P"
                        },
                        new
                        {
                            DetailId = 424,
                            Image = "https://cdn.dsmcdn.com/ty26/product/media/images/20201121/19/30087611/109752630/1/1_org_zoom.jpg",
                            Model = "IDEAPAD 3 81W1005VTX",
                            Name = "LENOVO",
                            Processor = "R3 3250U",
                            ProductId = 424,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "lenovo-ideapad-3-81w1005vtx-r3-3250u-4gb-128gb-w10-156inc",
                            Storage = "128GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 425,
                            Image = "https://cdn.dsmcdn.com/ty467/product/media/images/20220630/17/133147236/510686987/1/1_org_zoom.jpg",
                            Model = "V15 82KB0005TX",
                            Name = "LENOVO",
                            Processor = "I3 1115G4",
                            ProductId = 425,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "lenovo-v15-82kb0005tx-i3-1115g4-4gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 426,
                            Image = "https://cdn.dsmcdn.com/ty293/product/media/images/20220110/15/24462092/355700258/1/1_org_zoom.jpg",
                            Model = "IDEAPAD FLEX 5 82HS00FFTX",
                            Name = "LENOVO",
                            Processor = "I3 1115G4",
                            ProductId = 426,
                            Ram = "4GB",
                            Screen = "14",
                            Slug = "lenovo-ideapad-flex-5-82hs00fftx-i3-1115g4-4gb-256gb-w10-14inc",
                            Storage = "256GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 427,
                            Image = "https://cdn.dsmcdn.com/ty355/product/media/images/20220310/0/66764439/198839615/1/1_org_zoom.jpg",
                            Model = "V15-ITL 82KB000STX",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 427,
                            Ram = "4GB",
                            Screen = "15.6",
                            Slug = "lenovo-v15-itl-82kb000stx-i5-1135g7-4gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 428,
                            Image = "https://cdn.dsmcdn.com/ty346/product/media/images/20220302/11/61209554/401408820/1/1_org_zoom.jpg",
                            Model = "LEGION 5 82JH002JTX08",
                            Name = "LENOVO",
                            Processor = "I7 11600H",
                            ProductId = 428,
                            Ram = "64GB",
                            Screen = "15.6",
                            Slug = "lenovo-legion-5-82jh002jtx08-i7-11600h-64gb-2tb-freedos-156inc",
                            Storage = "2TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 429,
                            Image = "https://cdn.dsmcdn.com/ty1/product/media/images/20200330/13/698150/66998407/1/1_org_zoom.jpg",
                            Model = "THINKPAD E15 20RD0061TX",
                            Name = "LENOVO",
                            Processor = "I5 10210U",
                            ProductId = 429,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-thinkpad-e15-20rd0061tx-i5-10210u-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 430,
                            Image = "https://cdn.dsmcdn.com/ty250/product/media/images/20211118/12/44153/157910465/1/1_org_zoom.jpg",
                            Model = "THINKBOOK 13S G2 ITL 20V9005VTX",
                            Name = "LENOVO",
                            Processor = "I5 1135G7",
                            ProductId = 430,
                            Ram = "8GB",
                            Screen = "13.3",
                            Slug = "lenovo-thinkbook-13s-g2-itl-20v9005vtx-i5-1135g7-8gb-256gb-freedos-133inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 431,
                            Image = "https://cdn.dsmcdn.com/ty6/product/media/images/20200708/9/3887655/76036993/3/3_org_zoom.jpg",
                            Model = "V15-IIL 82C500GDTX",
                            Name = "LENOVO",
                            Processor = "I7 1065G7",
                            ProductId = 431,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-v15-iil-82c500gdtx-i7-1065g7-8gb-256gb-freedos-156inc",
                            Storage = "256GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 432,
                            Image = "https://cdn.dsmcdn.com/ty128/product/media/images/20210608/9/96957328/184258949/1/1_org_zoom.jpg",
                            Model = "V14 82KC0009TX",
                            Name = "LENOVO",
                            Processor = "R5 5500U",
                            ProductId = 432,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "lenovo-v14-82kc0009tx-r5-5500u-8gb-256gb-w10-14inc",
                            Storage = "256GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 433,
                            Image = "https://cdn.dsmcdn.com/ty538/product/media/images/20220920/18/177517455/574057806/1/1_org_zoom.jpg",
                            Model = "YOGA 7 EVO 82BH00FUTX",
                            Name = "LENOVO",
                            Processor = "I7 1165G7",
                            ProductId = 433,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "lenovo-yoga-7-evo-82bh00futx-i7-1165g7-8gb-512gb-w11-14inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 434,
                            Image = "https://cdn.dsmcdn.com/ty139/product/media/images/20210629/21/105625249/195292393/0/0_org_zoom.jpg",
                            Model = "V15 ADA 82C7005WTX",
                            Name = "LENOVO",
                            Processor = "R3 3250U",
                            ProductId = 434,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "lenovo-v15-ada-82c7005wtx-r3-3250u-8gb-512gb-w10-156inc",
                            Storage = "512GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 435,
                            Image = "https://cdn.dsmcdn.com/ty469/product/media/images/20220707/12/136509906/515980269/1/1_org_zoom.jpg",
                            Model = "V14 82KC000QTX03",
                            Name = "LENOVO",
                            Processor = "R3 5300U",
                            ProductId = 435,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "lenovo-v14-82kc000qtx03-r3-5300u-8gb-512gb-freedos-14inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 436,
                            Image = "https://cdn.dsmcdn.com/ty250/product/media/images/20211119/9/526742/317924722/1/1_org_zoom.jpg",
                            Model = "V14 G2 ALC 82KC0002TX",
                            Name = "LENOVO",
                            Processor = "R5 5500U",
                            ProductId = 436,
                            Ram = "8GB",
                            Screen = "14",
                            Slug = "lenovo-v14-g2-alc-82kc0002tx-r5-5500u-8gb-512gb-w10-14inc",
                            Storage = "512GB",
                            System = "W10"
                        },
                        new
                        {
                            DetailId = 437,
                            Image = "https://cdn.dsmcdn.com/ty402/product/media/images/20220418/22/93813674/452133850/1/1_org_zoom.jpg",
                            Model = "CROSSHAIR 17 B12UGZ-298XTR",
                            Name = "MSI",
                            Processor = "I7 12700H",
                            ProductId = 437,
                            Ram = "16GB",
                            Screen = "17.3",
                            Slug = "msi-crosshair-17-b12ugz-298xtr-i7-12700h-16gb-1tb-freedos-173inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 438,
                            Image = "https://cdn.dsmcdn.com/ty505/product/media/images/20220811/12/157835226/500934651/1/1_org_zoom.jpg",
                            Model = "KATANA GF76 12UD-217XTR",
                            Name = "MSI",
                            Processor = "I7 12700H",
                            ProductId = 438,
                            Ram = "16GB",
                            Screen = "17.3",
                            Slug = "msi-katana-gf76-12ud-217xtr-i7-12700h-16gb-1tb-freedos-173inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 439,
                            Image = "https://cdn.dsmcdn.com/ty384/product/media/images/20220405/16/83638530/437450702/1/1_org_zoom.jpg",
                            Model = "CROSSHAIR 15 R6E B12UGZ-414TR",
                            Name = "MSI",
                            Processor = "I7 12700H",
                            ProductId = 439,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "msi-crosshair-15-r6e-b12ugz-414tr-i7-12700h-32gb-1tb-w11-156inc",
                            Storage = "1TB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 440,
                            Image = "https://cdn.dsmcdn.com/ty524/product/media/images/20220907/22/170475719/560899274/1/1_org_zoom.jpg",
                            Model = "CROSSHAIR 15",
                            Name = "MSI",
                            Processor = "I7 12700H",
                            ProductId = 440,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "msi-crosshair-15-i7-12700h-32gb-1tb-w11-156inc",
                            Storage = "1TB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 441,
                            Image = "https://cdn.dsmcdn.com/ty328/product/media/images/20220211/15/48591420/382350270/1/1_org_zoom.jpg",
                            Model = "RAIDER GE66 12UGS-033TR",
                            Name = "MSI",
                            Processor = "I7 12700H",
                            ProductId = 441,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "msi-raider-ge66-12ugs-033tr-i7-12700h-32gb-1tb-w11-156inc",
                            Storage = "1TB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 442,
                            Image = "https://cdn.dsmcdn.com/ty311/product/media/images/20220126/11/36399027/370729093/1/1_org_zoom.jpg",
                            Model = "STEALTH GS66 12UGS-016TR",
                            Name = "MSI",
                            Processor = "I7 12700H",
                            ProductId = 442,
                            Ram = "32GB",
                            Screen = "15.6",
                            Slug = "msi-stealth-gs66-12ugs-016tr-i7-12700h-32gb-1tb-w11-156inc",
                            Storage = "1TB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 443,
                            Image = "https://cdn.dsmcdn.com/ty186/product/media/images/20211004/10/139714952/173506307/1/1_org_zoom.jpg",
                            Model = "KATANA GF76 11UD-059XTR",
                            Name = "MSI",
                            Processor = "I7 11800H",
                            ProductId = 443,
                            Ram = "16GB",
                            Screen = "17.3",
                            Slug = "msi-katana-gf76-11ud-059xtr-i7-11800h-16gb-512gb-freedos-173inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 444,
                            Image = "https://cdn.dsmcdn.com/ty332/product/media/images/20220214/13/50130808/360235039/1/1_org_zoom.jpg",
                            Model = "KATANA GF76 11UG-254XTR",
                            Name = "MSI",
                            Processor = "I7 11800H",
                            ProductId = 444,
                            Ram = "16GB",
                            Screen = "17.3",
                            Slug = "msi-katana-gf76-11ug-254xtr-i7-11800h-16gb-512gb-freedos-173inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 445,
                            Image = "https://cdn.dsmcdn.com/ty516/product/media/images/20220827/11/166296827/267514827/1/1_org_zoom.jpg",
                            Model = "GF63 THIN 11SC-035XTR",
                            Name = "MSI",
                            Processor = "I5 11400H",
                            ProductId = 445,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "msi-gf63-thin-11sc-035xtr-i5-11400h-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 446,
                            Image = "https://cdn.dsmcdn.com/ty520/product/media/images/20220831/16/167375839/453064429/1/1_org_zoom.jpg",
                            Model = "GF63 THIN 11UC-617XTR",
                            Name = "MSI",
                            Processor = "I5 11400H",
                            ProductId = 446,
                            Ram = "8GB",
                            Screen = "15.6",
                            Slug = "msi-gf63-thin-11uc-617xtr-i5-11400h-8gb-512gb-freedos-156inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 447,
                            Image = "https://cdn.dsmcdn.com/ty370/product/media/images/20220322/20/74653893/423209761/1/1_org_zoom.jpg",
                            Model = "STEALTH GS77 12UHS-081TR",
                            Name = "MSI",
                            Processor = "I7 12700H",
                            ProductId = 447,
                            Ram = "32GB",
                            Screen = "17.3",
                            Slug = "msi-stealth-gs77-12uhs-081tr-i7-12700h-32gb-2tb-w11-173inc",
                            Storage = "2TB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 448,
                            Image = "https://cdn.dsmcdn.com/ty348/product/media/images/20220307/10/63963722/381384412/2/2_org_zoom.jpg",
                            Model = "RAIDER GE76 12UHS-022TR",
                            Name = "MSI",
                            Processor = "I7 12700H",
                            ProductId = 448,
                            Ram = "32GB",
                            Screen = "17.3",
                            Slug = "msi-raider-ge76-12uhs-022tr-i7-12700h-32gb-2tb-w11-173inc",
                            Storage = "2TB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 449,
                            Image = "https://cdn.dsmcdn.com/ty463/product/media/images/20220628/18/131327193/508439933/1/1_org_zoom.jpg",
                            Model = "RAIDER GE76 12UHS-037TR",
                            Name = "MSI",
                            Processor = "I9 12900HK",
                            ProductId = 449,
                            Ram = "64GB",
                            Screen = "17.3",
                            Slug = "msi-raider-ge76-12uhs-037tr-i9-12900hk-64gb-2tb-w11-173inc",
                            Storage = "2TB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 450,
                            Image = "https://cdn.dsmcdn.com/ty309/product/media/images/20220127/17/37655797/346254521/1/1_org_zoom.jpg",
                            Model = "KATANA GF76 11UE-414TR",
                            Name = "MSI",
                            Processor = "I7 11800H",
                            ProductId = 450,
                            Ram = "16GB",
                            Screen = "17.3",
                            Slug = "msi-katana-gf76-11ue-414tr-i7-11800h-16gb-1tb-w11-173inc",
                            Storage = "1TB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 451,
                            Image = "https://cdn.dsmcdn.com/ty386/product/media/images/20220405/15/83622563/437416031/1/1_org_zoom.jpg",
                            Model = "CROSSHAIR 15 B12UGZ-476XTR",
                            Name = "MSI",
                            Processor = "I7 12700H",
                            ProductId = 451,
                            Ram = "16GB",
                            Screen = "15.6",
                            Slug = "msi-crosshair-15-b12ugz-476xtr-i7-12700h-16gb-1tb-freedos-156inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 452,
                            Image = "https://cdn.dsmcdn.com/ty325/product/media/images/20220208/14/46932494/192914914/1/1_org_zoom.jpg",
                            Model = "KATANA GF76 11UC-058XTR",
                            Name = "MSI",
                            Processor = "I7 11800H",
                            ProductId = 452,
                            Ram = "16GB",
                            Screen = "17.3",
                            Slug = "msi-katana-gf76-11uc-058xtr-i7-11800h-16gb-1tb-freedos-173inc",
                            Storage = "1TB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 453,
                            Image = "https://cdn.dsmcdn.com/ty460/product/media/images/20220625/10/129735628/501713354/1/1_org_zoom.jpg",
                            Model = "KATANA GF76 12UD-218TR",
                            Name = "MSI",
                            Processor = "I7 12700H",
                            ProductId = 453,
                            Ram = "16GB",
                            Screen = "17.3",
                            Slug = "msi-katana-gf76-12ud-218tr-i7-12700h-16gb-512gb-w11-173inc",
                            Storage = "512GB",
                            System = "W11"
                        },
                        new
                        {
                            DetailId = 454,
                            Image = "https://cdn.dsmcdn.com/ty362/product/media/images/20220315/17/70298932/319002839/1/1_org_zoom.jpg",
                            Model = "ALPHA 17 B5EEK-018XTR",
                            Name = "MSI",
                            Processor = "R7 5800H",
                            ProductId = 454,
                            Ram = "16GB",
                            Screen = "17.3",
                            Slug = "msi-alpha-17-b5eek-018xtr-r7-5800h-16gb-512gb-freedos-173inc",
                            Storage = "512GB",
                            System = "FREEDOS"
                        },
                        new
                        {
                            DetailId = 455,
                            Image = "https://cdn.dsmcdn.com/ty453/product/media/images/20220614/12/125509070/498566580/1/1_org_zoom.jpg",
                            Model = "RAIDER GE77HX 12UHS-042TR",
                            Name = "MSI",
                            Processor = "I7 12800HX",
                            ProductId = 455,
                            Ram = "32GB",
                            Screen = "17.3",
                            Slug = "msi-raider-ge77hx-12uhs-042tr-i7-12800hx-32gb-2tb-w11-173inc",
                            Storage = "2TB",
                            System = "W11"
                        });
                });

            modelBuilder.Entity("scrapapp.entity.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConversationId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("OrderState")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PaymentId")
                        .HasColumnType("TEXT");

                    b.Property<int>("PaymentType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("scrapapp.entity.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("scrapapp.entity.Product", b =>
                {
                    b.Property<int>("Id")
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

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DetailId = 1,
                            Price = 24969f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 2,
                            DetailId = 2,
                            Price = 24875f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 3,
                            DetailId = 3,
                            Price = 19399f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 4,
                            DetailId = 4,
                            Price = 39499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 5,
                            DetailId = 5,
                            Price = 47299f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 6,
                            DetailId = 6,
                            Price = 47474f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 7,
                            DetailId = 7,
                            Price = 24754f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 8,
                            DetailId = 8,
                            Price = 32990f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 9,
                            DetailId = 9,
                            Price = 17449f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 10,
                            DetailId = 10,
                            Price = 13991f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 11,
                            DetailId = 11,
                            Price = 10699f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 12,
                            DetailId = 12,
                            Price = 9499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 13,
                            DetailId = 13,
                            Price = 20499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 14,
                            DetailId = 14,
                            Price = 27699f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 15,
                            DetailId = 15,
                            Price = 16299f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 16,
                            DetailId = 16,
                            Price = 18799f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 17,
                            DetailId = 17,
                            Price = 19989f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 18,
                            DetailId = 18,
                            Price = 16299f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 19,
                            DetailId = 19,
                            Price = 9429f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 20,
                            DetailId = 20,
                            Price = 8999f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 21,
                            DetailId = 21,
                            Price = 53599f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 22,
                            DetailId = 22,
                            Price = 29699f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 23,
                            DetailId = 23,
                            Price = 31784f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 24,
                            DetailId = 24,
                            Price = 39999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 25,
                            DetailId = 25,
                            Price = 32299f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 26,
                            DetailId = 26,
                            Price = 55390f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 27,
                            DetailId = 27,
                            Price = 24561f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 28,
                            DetailId = 28,
                            Price = 24799f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 29,
                            DetailId = 29,
                            Price = 14012f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 30,
                            DetailId = 30,
                            Price = 10299f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 31,
                            DetailId = 31,
                            Price = 10999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 32,
                            DetailId = 32,
                            Price = 17499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 33,
                            DetailId = 33,
                            Price = 20799f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 34,
                            DetailId = 34,
                            Price = 16499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 35,
                            DetailId = 35,
                            Price = 26851f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 36,
                            DetailId = 36,
                            Price = 11449f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 37,
                            DetailId = 37,
                            Price = 6429f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 38,
                            DetailId = 38,
                            Price = 27199f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 39,
                            DetailId = 39,
                            Price = 27189f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 40,
                            DetailId = 40,
                            Price = 7193f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 41,
                            DetailId = 41,
                            Price = 7176f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 42,
                            DetailId = 42,
                            Price = 6499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 43,
                            DetailId = 43,
                            Price = 7499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 44,
                            DetailId = 44,
                            Price = 20319f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 45,
                            DetailId = 45,
                            Price = 15738f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 46,
                            DetailId = 46,
                            Price = 15833f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 47,
                            DetailId = 47,
                            Price = 24585f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 48,
                            DetailId = 48,
                            Price = 15843f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 49,
                            DetailId = 49,
                            Price = 17999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 50,
                            DetailId = 50,
                            Price = 14535f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 51,
                            DetailId = 51,
                            Price = 10999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 52,
                            DetailId = 52,
                            Price = 12999f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 53,
                            DetailId = 53,
                            Price = 19490f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 54,
                            DetailId = 54,
                            Price = 40188f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 55,
                            DetailId = 55,
                            Price = 13923f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 56,
                            DetailId = 56,
                            Price = 17999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 57,
                            DetailId = 57,
                            Price = 12142f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 58,
                            DetailId = 58,
                            Price = 20499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 59,
                            DetailId = 59,
                            Price = 13499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 60,
                            DetailId = 60,
                            Price = 17999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 61,
                            DetailId = 61,
                            Price = 65159f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 62,
                            DetailId = 62,
                            Price = 18699f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 63,
                            DetailId = 63,
                            Price = 18999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 64,
                            DetailId = 64,
                            Price = 24000f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 65,
                            DetailId = 65,
                            Price = 5414f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 66,
                            DetailId = 66,
                            Price = 5849f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 67,
                            DetailId = 67,
                            Price = 15520f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 68,
                            DetailId = 68,
                            Price = 15499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 69,
                            DetailId = 69,
                            Price = 17499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 70,
                            DetailId = 70,
                            Price = 15829f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 71,
                            DetailId = 71,
                            Price = 11172f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 72,
                            DetailId = 72,
                            Price = 17193f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 73,
                            DetailId = 73,
                            Price = 20743f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 74,
                            DetailId = 74,
                            Price = 9574f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 75,
                            DetailId = 75,
                            Price = 11999f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 76,
                            DetailId = 76,
                            Price = 16999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 77,
                            DetailId = 77,
                            Price = 29876f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 78,
                            DetailId = 78,
                            Price = 47499f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 79,
                            DetailId = 79,
                            Price = 9888f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 80,
                            DetailId = 80,
                            Price = 10669f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 81,
                            DetailId = 81,
                            Price = 19299f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 82,
                            DetailId = 82,
                            Price = 11869f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 83,
                            DetailId = 83,
                            Price = 39000f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 84,
                            DetailId = 84,
                            Price = 21699f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 85,
                            DetailId = 85,
                            Price = 10998f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 86,
                            DetailId = 86,
                            Price = 12499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 87,
                            DetailId = 87,
                            Price = 21649f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 88,
                            DetailId = 88,
                            Price = 27094f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 89,
                            DetailId = 89,
                            Price = 12329f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 90,
                            DetailId = 90,
                            Price = 17989f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 91,
                            DetailId = 91,
                            Price = 11999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 92,
                            DetailId = 92,
                            Price = 6949f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 93,
                            DetailId = 93,
                            Price = 18499f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 94,
                            DetailId = 94,
                            Price = 10749f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 95,
                            DetailId = 95,
                            Price = 10999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 96,
                            DetailId = 96,
                            Price = 11999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 97,
                            DetailId = 97,
                            Price = 13868f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 98,
                            DetailId = 98,
                            Price = 13198f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 99,
                            DetailId = 99,
                            Price = 7499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 100,
                            DetailId = 100,
                            Price = 22699f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 101,
                            DetailId = 101,
                            Price = 43857f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 102,
                            DetailId = 102,
                            Price = 30999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 103,
                            DetailId = 103,
                            Price = 11798f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 104,
                            DetailId = 104,
                            Price = 14723f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 105,
                            DetailId = 105,
                            Price = 9199f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 106,
                            DetailId = 106,
                            Price = 9999f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 107,
                            DetailId = 107,
                            Price = 21999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 108,
                            DetailId = 108,
                            Price = 13899f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 109,
                            DetailId = 109,
                            Price = 29999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 110,
                            DetailId = 110,
                            Price = 121959f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 111,
                            DetailId = 111,
                            Price = 44849f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 112,
                            DetailId = 112,
                            Price = 32399f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 113,
                            DetailId = 113,
                            Price = 32499f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 114,
                            DetailId = 114,
                            Price = 32499f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 115,
                            DetailId = 115,
                            Price = 41899f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 116,
                            DetailId = 116,
                            Price = 41999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 117,
                            DetailId = 117,
                            Price = 27499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 118,
                            DetailId = 118,
                            Price = 7923f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 119,
                            DetailId = 119,
                            Price = 7199f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 120,
                            DetailId = 120,
                            Price = 9156f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 121,
                            DetailId = 121,
                            Price = 6899f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 122,
                            DetailId = 122,
                            Price = 6859f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 123,
                            DetailId = 123,
                            Price = 6999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 124,
                            DetailId = 124,
                            Price = 23899f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 125,
                            DetailId = 125,
                            Price = 21999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 126,
                            DetailId = 126,
                            Price = 28999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 127,
                            DetailId = 127,
                            Price = 7715f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 128,
                            DetailId = 128,
                            Price = 15899f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 129,
                            DetailId = 129,
                            Price = 15999f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 130,
                            DetailId = 130,
                            Price = 17472f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 131,
                            DetailId = 131,
                            Price = 18999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 132,
                            DetailId = 132,
                            Price = 10499f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 133,
                            DetailId = 133,
                            Price = 10938f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 134,
                            DetailId = 134,
                            Price = 15970f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 135,
                            DetailId = 135,
                            Price = 15924f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 136,
                            DetailId = 136,
                            Price = 13058f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 137,
                            DetailId = 137,
                            Price = 7949f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 138,
                            DetailId = 138,
                            Price = 7999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 139,
                            DetailId = 139,
                            Price = 14763f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 140,
                            DetailId = 140,
                            Price = 11399f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 141,
                            DetailId = 141,
                            Price = 11599f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 142,
                            DetailId = 142,
                            Price = 11999f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 143,
                            DetailId = 143,
                            Price = 12254f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 144,
                            DetailId = 144,
                            Price = 17800f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 145,
                            DetailId = 145,
                            Price = 21999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 146,
                            DetailId = 146,
                            Price = 25722f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 147,
                            DetailId = 147,
                            Price = 30085f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 148,
                            DetailId = 148,
                            Price = 33860f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 149,
                            DetailId = 149,
                            Price = 10944f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 150,
                            DetailId = 150,
                            Price = 8273f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 151,
                            DetailId = 151,
                            Price = 7299f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 152,
                            DetailId = 152,
                            Price = 16799f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 153,
                            DetailId = 153,
                            Price = 35082f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 154,
                            DetailId = 154,
                            Price = 6929f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 155,
                            DetailId = 155,
                            Price = 19199f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 156,
                            DetailId = 156,
                            Price = 10799f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 157,
                            DetailId = 157,
                            Price = 17107f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 158,
                            DetailId = 158,
                            Price = 12699f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 159,
                            DetailId = 159,
                            Price = 17199f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 160,
                            DetailId = 160,
                            Price = 59999f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 161,
                            DetailId = 161,
                            Price = 52989f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 162,
                            DetailId = 162,
                            Price = 52999f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 163,
                            DetailId = 163,
                            Price = 13129f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 164,
                            DetailId = 164,
                            Price = 21999f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 165,
                            DetailId = 165,
                            Price = 27689f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 166,
                            DetailId = 166,
                            Price = 35082f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 167,
                            DetailId = 167,
                            Price = 23323f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 168,
                            DetailId = 168,
                            Price = 9252f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 169,
                            DetailId = 169,
                            Price = 8499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 170,
                            DetailId = 170,
                            Price = 13363f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 171,
                            DetailId = 171,
                            Price = 13886f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 172,
                            DetailId = 172,
                            Price = 15701f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 173,
                            DetailId = 173,
                            Price = 13499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 174,
                            DetailId = 174,
                            Price = 21539f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 175,
                            DetailId = 175,
                            Price = 36499f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 176,
                            DetailId = 176,
                            Price = 39556f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 177,
                            DetailId = 177,
                            Price = 34499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 178,
                            DetailId = 178,
                            Price = 35600f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 179,
                            DetailId = 179,
                            Price = 17859f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 180,
                            DetailId = 180,
                            Price = 20499f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 181,
                            DetailId = 181,
                            Price = 21755f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 182,
                            DetailId = 182,
                            Price = 14259f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 183,
                            DetailId = 183,
                            Price = 15555f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 184,
                            DetailId = 184,
                            Price = 36553f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 185,
                            DetailId = 185,
                            Price = 7416f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 186,
                            DetailId = 186,
                            Price = 7999f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 187,
                            DetailId = 187,
                            Price = 12759f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 188,
                            DetailId = 188,
                            Price = 6999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 189,
                            DetailId = 189,
                            Price = 12999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 190,
                            DetailId = 190,
                            Price = 11899f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 191,
                            DetailId = 191,
                            Price = 10799f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 192,
                            DetailId = 192,
                            Price = 6899f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 193,
                            DetailId = 193,
                            Price = 12561f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 194,
                            DetailId = 194,
                            Price = 15864f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 195,
                            DetailId = 195,
                            Price = 14656f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 196,
                            DetailId = 196,
                            Price = 12971f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 197,
                            DetailId = 197,
                            Price = 14899f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 198,
                            DetailId = 198,
                            Price = 14999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 199,
                            DetailId = 199,
                            Price = 14299f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 200,
                            DetailId = 200,
                            Price = 15999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 201,
                            DetailId = 201,
                            Price = 18999f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 202,
                            DetailId = 202,
                            Price = 20999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 203,
                            DetailId = 203,
                            Price = 17999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 204,
                            DetailId = 204,
                            Price = 24449f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 205,
                            DetailId = 205,
                            Price = 11449f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 206,
                            DetailId = 206,
                            Price = 8300f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 207,
                            DetailId = 207,
                            Price = 7370f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 208,
                            DetailId = 208,
                            Price = 14750f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 209,
                            DetailId = 209,
                            Price = 19199f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 210,
                            DetailId = 210,
                            Price = 22499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 211,
                            DetailId = 211,
                            Price = 27699f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 212,
                            DetailId = 212,
                            Price = 9999f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 213,
                            DetailId = 213,
                            Price = 10849f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 214,
                            DetailId = 214,
                            Price = 13998f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 215,
                            DetailId = 215,
                            Price = 29153f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 216,
                            DetailId = 216,
                            Price = 17750f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 217,
                            DetailId = 217,
                            Price = 7499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 218,
                            DetailId = 218,
                            Price = 11599f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 219,
                            DetailId = 219,
                            Price = 13599f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 220,
                            DetailId = 220,
                            Price = 29959f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 221,
                            DetailId = 221,
                            Price = 31500f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 222,
                            DetailId = 222,
                            Price = 31999f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 223,
                            DetailId = 223,
                            Price = 27981f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 224,
                            DetailId = 224,
                            Price = 34498f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 225,
                            DetailId = 225,
                            Price = 27999f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 226,
                            DetailId = 226,
                            Price = 52660f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 227,
                            DetailId = 227,
                            Price = 54399f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 228,
                            DetailId = 228,
                            Price = 27899f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 229,
                            DetailId = 229,
                            Price = 24999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 230,
                            DetailId = 230,
                            Price = 28199f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 231,
                            DetailId = 231,
                            Price = 27885f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 232,
                            DetailId = 232,
                            Price = 28189f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 233,
                            DetailId = 233,
                            Price = 26999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 234,
                            DetailId = 234,
                            Price = 22859f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 235,
                            DetailId = 235,
                            Price = 23699f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 236,
                            DetailId = 236,
                            Price = 29373f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 237,
                            DetailId = 237,
                            Price = 33999f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 238,
                            DetailId = 238,
                            Price = 65499f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 239,
                            DetailId = 239,
                            Price = 30599f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 240,
                            DetailId = 240,
                            Price = 30599f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 241,
                            DetailId = 241,
                            Price = 30599f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 242,
                            DetailId = 242,
                            Price = 87999f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 243,
                            DetailId = 243,
                            Price = 49000f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 244,
                            DetailId = 244,
                            Price = 19399f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 245,
                            DetailId = 245,
                            Price = 19399f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 246,
                            DetailId = 246,
                            Price = 24440f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 247,
                            DetailId = 247,
                            Price = 13299f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 248,
                            DetailId = 248,
                            Price = 20174f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 249,
                            DetailId = 249,
                            Price = 29002f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 250,
                            DetailId = 250,
                            Price = 32299f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 251,
                            DetailId = 251,
                            Price = 10399f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 252,
                            DetailId = 252,
                            Price = 17354f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 253,
                            DetailId = 253,
                            Price = 12104f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 254,
                            DetailId = 254,
                            Price = 12811f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 255,
                            DetailId = 255,
                            Price = 12912f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 256,
                            DetailId = 256,
                            Price = 13620f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 257,
                            DetailId = 257,
                            Price = 26998f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 258,
                            DetailId = 258,
                            Price = 13798f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 259,
                            DetailId = 259,
                            Price = 19998f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 260,
                            DetailId = 260,
                            Price = 12500f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 261,
                            DetailId = 261,
                            Price = 12999f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 262,
                            DetailId = 262,
                            Price = 11999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 263,
                            DetailId = 263,
                            Price = 20998f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 264,
                            DetailId = 264,
                            Price = 18998f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 265,
                            DetailId = 265,
                            Price = 13549f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 266,
                            DetailId = 266,
                            Price = 12851f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 267,
                            DetailId = 267,
                            Price = 16099f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 268,
                            DetailId = 268,
                            Price = 25900f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 269,
                            DetailId = 269,
                            Price = 8929f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 270,
                            DetailId = 270,
                            Price = 9899f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 271,
                            DetailId = 271,
                            Price = 16102f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 272,
                            DetailId = 272,
                            Price = 22648f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 273,
                            DetailId = 273,
                            Price = 13939f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 274,
                            DetailId = 274,
                            Price = 36485f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 275,
                            DetailId = 275,
                            Price = 31457f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 276,
                            DetailId = 276,
                            Price = 18499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 277,
                            DetailId = 277,
                            Price = 12650f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 278,
                            DetailId = 278,
                            Price = 14399f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 279,
                            DetailId = 279,
                            Price = 28999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 280,
                            DetailId = 280,
                            Price = 22150f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 281,
                            DetailId = 281,
                            Price = 19792f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 282,
                            DetailId = 282,
                            Price = 8900f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 283,
                            DetailId = 283,
                            Price = 9989f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 284,
                            DetailId = 284,
                            Price = 9298f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 285,
                            DetailId = 285,
                            Price = 8999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 286,
                            DetailId = 286,
                            Price = 16226f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 287,
                            DetailId = 287,
                            Price = 13799f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 288,
                            DetailId = 288,
                            Price = 25799f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 289,
                            DetailId = 289,
                            Price = 27819f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 290,
                            DetailId = 290,
                            Price = 31771f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 291,
                            DetailId = 291,
                            Price = 11429f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 292,
                            DetailId = 292,
                            Price = 11529f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 293,
                            DetailId = 293,
                            Price = 9199f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 294,
                            DetailId = 294,
                            Price = 12799f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 295,
                            DetailId = 295,
                            Price = 20899f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 296,
                            DetailId = 296,
                            Price = 11631f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 297,
                            DetailId = 297,
                            Price = 36900f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 298,
                            DetailId = 298,
                            Price = 29239f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 299,
                            DetailId = 299,
                            Price = 89099f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 300,
                            DetailId = 300,
                            Price = 16359f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 301,
                            DetailId = 301,
                            Price = 8499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 302,
                            DetailId = 302,
                            Price = 26529f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 303,
                            DetailId = 303,
                            Price = 10870f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 304,
                            DetailId = 304,
                            Price = 25999f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 305,
                            DetailId = 305,
                            Price = 8499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 306,
                            DetailId = 306,
                            Price = 9889f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 307,
                            DetailId = 307,
                            Price = 16989f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 308,
                            DetailId = 308,
                            Price = 34270f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 309,
                            DetailId = 309,
                            Price = 23247f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 310,
                            DetailId = 310,
                            Price = 30059f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 311,
                            DetailId = 311,
                            Price = 16999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 312,
                            DetailId = 312,
                            Price = 19697f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 313,
                            DetailId = 313,
                            Price = 24999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 314,
                            DetailId = 314,
                            Price = 25875f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 315,
                            DetailId = 315,
                            Price = 38207f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 316,
                            DetailId = 316,
                            Price = 37840f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 317,
                            DetailId = 317,
                            Price = 35366f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 318,
                            DetailId = 318,
                            Price = 27507f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 319,
                            DetailId = 319,
                            Price = 40695f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 320,
                            DetailId = 320,
                            Price = 39553f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 321,
                            DetailId = 321,
                            Price = 10399f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 322,
                            DetailId = 322,
                            Price = 13949f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 323,
                            DetailId = 323,
                            Price = 12999f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 324,
                            DetailId = 324,
                            Price = 14799f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 325,
                            DetailId = 325,
                            Price = 14449f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 326,
                            DetailId = 326,
                            Price = 10998f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 327,
                            DetailId = 327,
                            Price = 15599f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 328,
                            DetailId = 328,
                            Price = 9999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 329,
                            DetailId = 329,
                            Price = 26644f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 330,
                            DetailId = 330,
                            Price = 35915f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 331,
                            DetailId = 331,
                            Price = 38839f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 332,
                            DetailId = 332,
                            Price = 24578f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 333,
                            DetailId = 333,
                            Price = 40695f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 334,
                            DetailId = 334,
                            Price = 29302f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 335,
                            DetailId = 335,
                            Price = 38982f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 336,
                            DetailId = 336,
                            Price = 12429f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 337,
                            DetailId = 337,
                            Price = 11999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 338,
                            DetailId = 338,
                            Price = 15892f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 339,
                            DetailId = 339,
                            Price = 15839f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 340,
                            DetailId = 340,
                            Price = 28548f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 341,
                            DetailId = 341,
                            Price = 26223f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 342,
                            DetailId = 342,
                            Price = 26379f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 343,
                            DetailId = 343,
                            Price = 38982f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 344,
                            DetailId = 344,
                            Price = 24999f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 345,
                            DetailId = 345,
                            Price = 37126f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 346,
                            DetailId = 346,
                            Price = 25790f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 347,
                            DetailId = 347,
                            Price = 12899f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 348,
                            DetailId = 348,
                            Price = 16999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 349,
                            DetailId = 349,
                            Price = 15999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 350,
                            DetailId = 350,
                            Price = 27546f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 351,
                            DetailId = 351,
                            Price = 37126f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 352,
                            DetailId = 352,
                            Price = 26511f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 353,
                            DetailId = 353,
                            Price = 25728f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 354,
                            DetailId = 354,
                            Price = 37971f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 355,
                            DetailId = 355,
                            Price = 18898f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 356,
                            DetailId = 356,
                            Price = 17634f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 357,
                            DetailId = 357,
                            Price = 19269f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 358,
                            DetailId = 358,
                            Price = 28887f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 359,
                            DetailId = 359,
                            Price = 9999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 360,
                            DetailId = 360,
                            Price = 66549f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 361,
                            DetailId = 361,
                            Price = 73909f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 362,
                            DetailId = 362,
                            Price = 80599f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 363,
                            DetailId = 363,
                            Price = 17499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 364,
                            DetailId = 364,
                            Price = 33584f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 365,
                            DetailId = 365,
                            Price = 45836f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 366,
                            DetailId = 366,
                            Price = 27293f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 367,
                            DetailId = 367,
                            Price = 29697f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 368,
                            DetailId = 368,
                            Price = 22017f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 369,
                            DetailId = 369,
                            Price = 8499f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 370,
                            DetailId = 370,
                            Price = 13725f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 371,
                            DetailId = 371,
                            Price = 13724f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 372,
                            DetailId = 372,
                            Price = 12399f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 373,
                            DetailId = 373,
                            Price = 12999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 374,
                            DetailId = 374,
                            Price = 21288f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 375,
                            DetailId = 375,
                            Price = 12899f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 376,
                            DetailId = 376,
                            Price = 19399f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 377,
                            DetailId = 377,
                            Price = 27339f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 378,
                            DetailId = 378,
                            Price = 14249f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 379,
                            DetailId = 379,
                            Price = 18470f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 380,
                            DetailId = 380,
                            Price = 13999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 381,
                            DetailId = 381,
                            Price = 12990f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 382,
                            DetailId = 382,
                            Price = 10749f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 383,
                            DetailId = 383,
                            Price = 20529f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 384,
                            DetailId = 384,
                            Price = 19999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 385,
                            DetailId = 385,
                            Price = 26547f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 386,
                            DetailId = 386,
                            Price = 8499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 387,
                            DetailId = 387,
                            Price = 9311f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 388,
                            DetailId = 388,
                            Price = 10999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 389,
                            DetailId = 389,
                            Price = 18999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 390,
                            DetailId = 390,
                            Price = 22998f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 391,
                            DetailId = 391,
                            Price = 35092f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 392,
                            DetailId = 392,
                            Price = 35092f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 393,
                            DetailId = 393,
                            Price = 17210f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 394,
                            DetailId = 394,
                            Price = 7999f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 395,
                            DetailId = 395,
                            Price = 19599f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 396,
                            DetailId = 396,
                            Price = 7899f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 397,
                            DetailId = 397,
                            Price = 29899f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 398,
                            DetailId = 398,
                            Price = 17290f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 399,
                            DetailId = 399,
                            Price = 15699f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 400,
                            DetailId = 400,
                            Price = 17826f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 401,
                            DetailId = 401,
                            Price = 38696f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 402,
                            DetailId = 402,
                            Price = 38696f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 403,
                            DetailId = 403,
                            Price = 17916f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 404,
                            DetailId = 404,
                            Price = 18199f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 405,
                            DetailId = 405,
                            Price = 9021f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 406,
                            DetailId = 406,
                            Price = 10999f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 407,
                            DetailId = 407,
                            Price = 25130f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 408,
                            DetailId = 408,
                            Price = 12499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 409,
                            DetailId = 409,
                            Price = 13499f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 410,
                            DetailId = 410,
                            Price = 11799f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 411,
                            DetailId = 411,
                            Price = 11039f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 412,
                            DetailId = 412,
                            Price = 15999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 413,
                            DetailId = 413,
                            Price = 8548f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 414,
                            DetailId = 414,
                            Price = 35840f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 415,
                            DetailId = 415,
                            Price = 22959f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 416,
                            DetailId = 416,
                            Price = 34398f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 417,
                            DetailId = 417,
                            Price = 33984f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 418,
                            DetailId = 418,
                            Price = 37982f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 419,
                            DetailId = 419,
                            Price = 32499f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 420,
                            DetailId = 420,
                            Price = 35840f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 421,
                            DetailId = 421,
                            Price = 36554f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 422,
                            DetailId = 422,
                            Price = 31045f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 423,
                            DetailId = 423,
                            Price = 25574f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 424,
                            DetailId = 424,
                            Price = 7299f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 425,
                            DetailId = 425,
                            Price = 8899f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 426,
                            DetailId = 426,
                            Price = 9699f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 427,
                            DetailId = 427,
                            Price = 9999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 428,
                            DetailId = 428,
                            Price = 41398f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 429,
                            DetailId = 429,
                            Price = 14349f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 430,
                            DetailId = 430,
                            Price = 14299f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 431,
                            DetailId = 431,
                            Price = 15517f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 432,
                            DetailId = 432,
                            Price = 9998f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 433,
                            DetailId = 433,
                            Price = 24199f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 434,
                            DetailId = 434,
                            Price = 9499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 435,
                            DetailId = 435,
                            Price = 7760f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 436,
                            DetailId = 436,
                            Price = 10631f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 437,
                            DetailId = 437,
                            Price = 49889f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 438,
                            DetailId = 438,
                            Price = 34990f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 439,
                            DetailId = 439,
                            Price = 57979f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 440,
                            DetailId = 440,
                            Price = 60458f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 441,
                            DetailId = 441,
                            Price = 73899f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 442,
                            DetailId = 442,
                            Price = 64599f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 443,
                            DetailId = 443,
                            Price = 29299f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 444,
                            DetailId = 444,
                            Price = 43697f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 445,
                            DetailId = 445,
                            Price = 17339f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 446,
                            DetailId = 446,
                            Price = 19499f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 447,
                            DetailId = 447,
                            Price = 85939f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 448,
                            DetailId = 448,
                            Price = 86399f,
                            Rate = 0f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 449,
                            DetailId = 449,
                            Price = 116672f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 450,
                            DetailId = 450,
                            Price = 43697f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 451,
                            DetailId = 451,
                            Price = 44299f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 452,
                            DetailId = 452,
                            Price = 26199f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 453,
                            DetailId = 453,
                            Price = 36999f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 454,
                            DetailId = 454,
                            Price = 34089f,
                            Rate = 5f,
                            is_updated = false
                        },
                        new
                        {
                            Id = 455,
                            DetailId = 455,
                            Price = 90899f,
                            Rate = 0f,
                            is_updated = false
                        });
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

                    b.ToTable("SitesInformations");

                    b.HasData(
                        new
                        {
                            SitesInformationId = 1,
                            Link = "https://www.hepsiburada.com/acer-nitro-5-an517-41-amd-ryzen-7-5800h-16gb-512gb-ssd-rtx3060-freedos-17-3-fhd-tasinabilir-bilgisayar-nh-qarey-001-p-HBCV00000RF4Z7",
                            Price = 24969f,
                            ProductId = 1,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 2,
                            Link = "https://www.trendyol.com/acer/nitro-5-an517-41-amd-ryzen-7-5800h-16-gb-512-gb-ssd-rtx3060-144hz-17-3-fhd-freedos-nh-qarey-001-p-151463997?boutiqueId=61&merchantId=106740",
                            Price = 25999f,
                            ProductId = 1,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 3,
                            Link = "https://www.n11.com/urun/acer-nitro-5-an517-41-nhqarey001-r7-5800h-16-gb-512-gb-ssd-rtx3060-144hz-173-dos-dizustu-bilgisayar-2152264?magaza=teknoryabilisim",
                            Price = 24999f,
                            ProductId = 1,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 4,
                            Link = "https://www.vatanbilgisayar.com/acer-nitro-5-5-nesil-ryzen-7-5800h-16gb-512gb-ssd-17-3inc-rtx3060-6gb-freedos.html",
                            Price = 26999f,
                            ProductId = 1,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 5,
                            Link = "https://www.hepsiburada.com/apple-macbook-air-m2-cip-8gb-256gb-ssd-macos-13-tasinabilir-bilgisayar-gece-yarisi-mly33tu-a-p-HBCV00002GNKO5",
                            Price = 24875f,
                            ProductId = 2,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 6,
                            Link = "https://www.trendyol.com/apple/mly33tu-a-m2-islemci-8gb-ram-256gb-ssd-13-macbook-air-midnight-p-358594646?boutiqueId=61&merchantId=275331",
                            Price = 25900f,
                            ProductId = 2,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 7,
                            Link = "https://www.n11.com/urun/apple-macbook-air-mly33tua-m2-8c-8gpu-8-gb-256-gb-ssd-136-dizustu-bilgisayar-20783352?magaza=gpnteknoloji",
                            Price = 24299f,
                            ProductId = 2,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 8,
                            Link = "https://www.vatanbilgisayar.com/macbook-air-mly33tu-a-m2-8gb-256gb-ssd-liquid-retina-13-6inc-gece-yarisi.html",
                            Price = 25899f,
                            ProductId = 2,
                            Rate = 5f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 9,
                            Link = "https://www.hepsiburada.com/apple-macbook-air-m1-cip-8gb-256gb-ssd-macos-13-qhd-tasinabilir-bilgisayar-uzay-grisi-mgn63tu-a-p-HBV0000130VND",
                            Price = 19399f,
                            ProductId = 3,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 10,
                            Link = "https://www.trendyol.com/apple/macbook-air-13-m1-8gb-256gb-ssd-uzay-grisi-dizustu-bilgisayar-p-68042136?boutiqueId=614309&merchantId=110963",
                            Price = 19785f,
                            ProductId = 3,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 11,
                            Link = "https://www.n11.com/urun/apple-macbook-air-mgn63tua-apple-m1-8-gb-ram-256-gb-ssd-133-macos-dizustu-bilgisayar-gri-1715113?magaza=teknoraks",
                            Price = 20854f,
                            ProductId = 3,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 12,
                            Link = "https://www.vatanbilgisayar.com/macbook-air-m1-notebook.html",
                            Price = 20999f,
                            ProductId = 3,
                            Rate = 4f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 13,
                            Link = "https://www.hepsiburada.com/apple-macbook-m1-pro-cip-16gb-512gb-ssd-macos-14-qhd-tasinabilir-bilgisayar-gumus-mkgr3tu-a-p-HBCV00000U6XEP",
                            Price = 39499f,
                            ProductId = 4,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 14,
                            Link = "https://www.trendyol.com/apple/macbook-pro-14-m1-pro-8c-cpu-14c-gpu-16-gb-512gb-ssd-gumus-p-179224615?boutiqueId=614308&merchantId=107870",
                            Price = 38219f,
                            ProductId = 4,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 15,
                            Link = "https://www.n11.com/urun/apple-macbook-pro-mkgr3tua-apple-m1-pro-16-gb-512-gb-ssd-14-macos-dizustu-bilgisayar-2299671?magaza=integrakurumsal",
                            Price = 42499f,
                            ProductId = 4,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 16,
                            Link = "https://www.vatanbilgisayar.com/macbook-pro-mkgr3tu-a-m1-pro-16gb-512gbssd-liquid-retina-14-silver.html",
                            Price = 38999f,
                            ProductId = 4,
                            Rate = 5f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 17,
                            Link = "https://www.hepsiburada.com/apple-macbook-m1-pro-cip-16gb-512gb-ssd-macos-16-qhd-tasinabilir-bilgisayar-gumus-mk1e3tu-a-p-HBCV00000U6XEF",
                            Price = 47299f,
                            ProductId = 5,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 18,
                            Link = "https://www.trendyol.com/apple/macbook-m1-pro-10c-cpu-16c-gpu-16gb-512gb-ssd-macos-16-qhd-gumus-laptop-apple-turkiye-garantili-p-179259323?boutiqueId=613344&merchantId=141868",
                            Price = 47190f,
                            ProductId = 5,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 19,
                            Link = "https://www.n11.com/urun/apple-macbook-pro-mk1e3tua-apple-m1-pro-16-gb-512-gb-ssd-16-macos-dizustu-bilgisayar-2299711?magaza=pozitiftasarim",
                            Price = 51969f,
                            ProductId = 5,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 20,
                            Link = "https://www.vatanbilgisayar.com/macbook-pro-mkgr3tu-a-m1-pro-16gb-512gbssd-liquid-retina-16-silver.html",
                            Price = 47399f,
                            ProductId = 5,
                            Rate = 5f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 21,
                            Link = "https://www.hepsiburada.com/apple-macbook-m1-pro-cip-16gb-512gb-ssd-macos-16-qhd-tasinabilir-bilgisayar-uzay-grisi-mk183tu-a-p-HBCV00000U6WE5",
                            Price = 47474f,
                            ProductId = 6,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 22,
                            Link = "https://www.trendyol.com/apple/macbook-pro-16-m1-pro-16-gb-512gb-ssd-uzay-grisi-p-179245274?boutiqueId=613344&merchantId=141868",
                            Price = 47399f,
                            ProductId = 6,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 23,
                            Link = "https://www.n11.com/urun/apple-macbook-pro-mk183tua-apple-m1-pro-16-gb-512-gb-ssd-16-macos-dizustu-bilgisayar-2299691?magaza=integrakurumsal",
                            Price = 49999f,
                            ProductId = 6,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 24,
                            Link = "https://www.vatanbilgisayar.com/macbook-pro-mk183tu-a-m1-pro-16gb-512gbssd-liquid-retina-16-space-grey.html",
                            Price = 47399f,
                            ProductId = 6,
                            Rate = 5f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 25,
                            Link = "https://www.hepsiburada.com/apple-macbook-air-m2-cip-8gb-256gb-ssd-macos-13-tasinabilir-bilgisayar-uzay-grisi-mlxw3tu-a-p-HBCV00002GNKNT",
                            Price = 24754f,
                            ProductId = 7,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 26,
                            Link = "https://www.trendyol.com/apple/macbook-air-13-6-m2-8gb-256gb-ssd-uzay-grisi-p-335392170?boutiqueId=61&merchantId=118442",
                            Price = 24155f,
                            ProductId = 7,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 27,
                            Link = "https://www.n11.com/urun/apple-macbook-air-mlxw3tua-m2-8c-8gpu-8-gb-ram-256-gb-ssd-136-dizustu-bilgisayar-20783408?magaza=gpnteknoloji",
                            Price = 24399f,
                            ProductId = 7,
                            Rate = 4f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 28,
                            Link = "https://www.vatanbilgisayar.com/macbook-air-mlxw3tu-a-m2-8gb-256gb-ssd-liquid-retina-13-6inc-uzay-grisi.html",
                            Price = 25899f,
                            ProductId = 7,
                            Rate = 5f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 29,
                            Link = "https://www.hepsiburada.com/hp-spectre-x360-14-ea0008nt-intel-core-i7-1165g7-16gb-1tb-ssd-windows-10-home-13-5-tasinabilir-bilgisayar-4h1t0ea-p-HBCV00000N9TCW",
                            Price = 32990f,
                            ProductId = 8,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 30,
                            Link = "https://www.trendyol.com/hp/spectre-x360-14-ea0008nt-4h1t0ea-i7-1165g7-16gb-ram-1tb-ssd-13-5-wuxga-dokunmatik-windows-10-p-143631717?boutiqueId=613344&merchantId=118442",
                            Price = 32999f,
                            ProductId = 8,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 31,
                            Link = "https://www.n11.com/urun/hp-spectre-x360-4h1t0ea-i7-1165g7-16-gb-1-tb-ssd-135-w10h-touch-dizustu-bilgisayar-2126136?magaza=gpnteknoloji",
                            Price = 34356f,
                            ProductId = 8,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 32,
                            Link = "https://www.vatanbilgisayar.com/hp-spectre-x360-14-ea0007nt-core-i7-1165g7-2-8ghz-16gb-1tb-ssd-13-5-int-w10.html",
                            Price = 32499f,
                            ProductId = 8,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 33,
                            Link = "https://www.hepsiburada.com/huawei-matebook-d16-intel-core-i5-12450h-8gb-512gb-ssd-windows-11-home-16-tasinabilir-bilgisayar-p-HBCV00002NKF5S",
                            Price = 17449f,
                            ProductId = 9,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 34,
                            Link = "https://www.trendyol.com/huawei/matebook-d16-i5-12450h-8gb-ram-512gb-ssd-16-win-11-laptop-uzay-grisi-p-360596495?boutiqueId=61&merchantId=275331",
                            Price = 17000f,
                            ProductId = 9,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 35,
                            Link = "https://www.n11.com/urun/huawei-matebook-d-16-rollef-w5851-i5-12450h-8-gb-512-gb-16-w11h-dizustu-bilgisayar-18565098?magaza=laptopfirsati",
                            Price = 19199f,
                            ProductId = 9,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 36,
                            Link = "https://www.vatanbilgisayar.com/huawei-matebook-d16-12-nesil-core-i5-12450h-8gb-512gb-ssd-16inc-w11.html",
                            Price = 16999f,
                            ProductId = 9,
                            Rate = 5f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 37,
                            Link = "https://www.hepsiburada.com/huawei-matebook-d15-intel-core-i5-1135g7-8gb-512gb-ssd-windows-11-home-15-6-fhd-tasinabilir-bilgisayar-p-HBCV000022AS0J",
                            Price = 13991f,
                            ProductId = 10,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 38,
                            Link = "https://www.trendyol.com/huawei/matebook-d15-11-nesil-core-i5-1135g7-8gb-512gb-ssd-15-6inc-w11-p-347142184?boutiqueId=61&merchantId=143314",
                            Price = 13661f,
                            ProductId = 10,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 39,
                            Link = "https://www.n11.com/urun/huawei-matebook-d15-i5-1135g7-8-gb-512-gb-156-w11h-fhd-dizustu-bilgisayar-4790661?magaza=ant-bilisim-a-s",
                            Price = 13838f,
                            ProductId = 10,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 40,
                            Link = "https://www.vatanbilgisayar.com/huawei-matebook-d15-11-nesil-core-i5-1135g7-8gb-512gb-ssd-15-6inc-w11.html",
                            Price = 13799f,
                            ProductId = 10,
                            Rate = 4f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 41,
                            Link = "https://www.hepsiburada.com/acer-extensa-ex215-54g-intel-core-i5-1135g7-8-gb-512-gb-ssd-mx350-2-gb-freedos-15-6-fhd-tasinabilir-bilgisayar-nx-eghey-003-p-HBCV00002SM00H",
                            Price = 10699f,
                            ProductId = 11,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 42,
                            Link = "https://www.n11.com/urun/acer-extensa-ex215-54g-nxeghey003-i5-1135g7-8-gb-512-gb-ssd-2-gb-mx350-156-dos-dizustu-bilgisayar-21752710?magaza=bozdanteknoloji",
                            Price = 11499f,
                            ProductId = 11,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 43,
                            Link = "https://www.vatanbilgisayar.com/acer-extensa-15-11-nesil-core-i5-1135g7-8gb-512gb-ssd-15-6inch-mx350-2gb-freedos.html",
                            Price = 11699f,
                            ProductId = 11,
                            Rate = 5f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 44,
                            Link = "https://www.hepsiburada.com/acer-extensa-ex215-54-intel-core-i5-1135g7-8-gb-512-gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-nx-egjey-005-p-HBCV00002SQNIQ",
                            Price = 9499f,
                            ProductId = 12,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 45,
                            Link = "https://www.trendyol.com/acer/extensa-ex215-54g-corei5-1135g7-8gb-512gb-ssd-freedos-15-6-fhd-notebook-nx-egjey-005-p-343207843?boutiqueId=61&merchantId=107007",
                            Price = 9999f,
                            ProductId = 12,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 46,
                            Link = "https://www.n11.com/urun/acer-extensa-15-ex215-54-nxegjey005-i5-1135g7-8-gb-512-gb-ssd-156-free-dos-fhd-dizustu-bilgisayar-21752652?magaza=bozdanteknoloji",
                            Price = 9498f,
                            ProductId = 12,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 47,
                            Link = "https://www.hepsiburada.com/acer-nitro-5-an517-41-amd-ryzen-7-5800h-16-gb-512-gb-ssd-rtx-3050ti-freedos-17-3-fhd-144-hz-tasinabilir-bilgisayar-nh-qaqey-001-p-HBCV00002QBQ8M",
                            Price = 20499f,
                            ProductId = 13,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 48,
                            Link = "https://www.trendyol.com/acer/nitro-5-an517-41-r7-5800h-16gb-512gb-ssd-rtx3050ti-dos-17-3-fhd-144hz-notebook-nh-qaqey-001-p-335996975?boutiqueId=613344&merchantId=106740",
                            Price = 22499f,
                            ProductId = 13,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 49,
                            Link = "https://www.n11.com/urun/acer-nitro-5-an517-41-nhqaqey001-r7-5800h-16-gb-512-gb-ssd-rtx3050ti-173-dos-dizustu-bilgisayar-18597206?magaza=teknoryabilisim",
                            Price = 20499f,
                            ProductId = 13,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 50,
                            Link = "https://www.hepsiburada.com/acer-nitro-5-an517-41-amd-ryzen-7-5800h-16-gb-512-gb-ssd-rtx-3070-freedos-17-3-fhd-144-hz-tasinabilir-bilgisayar-nh-qbgey-002-p-HBCV00002QBQ8Q",
                            Price = 27699f,
                            ProductId = 14,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 51,
                            Link = "https://www.trendyol.com/acer/nitro-5-an517-41-r7-5800h-16gb-512gb-ssd-rtx3070-dos-17-3-fhd-144hz-notebook-nh-qbgey-002-p-335997167?boutiqueId=61&merchantId=106740",
                            Price = 29999f,
                            ProductId = 14,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 52,
                            Link = "https://www.n11.com/urun/acer-nitro-5-an517-41-nhqbgey002-r7-5800h-16-gb-512-gb-ssd-rtx3070-173-dos-dizustu-bilgisayar-18597604?magaza=teknoryabilisim",
                            Price = 27999f,
                            ProductId = 14,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 53,
                            Link = "https://www.hepsiburada.com/acer-nitro-5-an515-45-amd-ryzen-5-5600h-8-gb-512-gb-ssd-rtx-3050-freedos-15-6-fhd-144-hz-tasinabilir-bilgisayar-nh-qbaey-005-p-HBCV000028L2HB",
                            Price = 16299f,
                            ProductId = 15,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 54,
                            Link = "https://www.trendyol.com/acer/nitro-5-an515-45-r5-5600h-8gb-512gb-ssd-rtx3050-dos-15-6-fhd-diuzstu-bilgisayar-nh-qbaey-005-p-302185457?boutiqueId=613344&merchantId=106740",
                            Price = 16799f,
                            ProductId = 15,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 55,
                            Link = "https://www.n11.com/urun/acer-nitro-5-an515-45-nhqbaey005-r5-5600h-8-gb-512-gb-ssd-rtx3050-156-dos-dizustu-bilgisayar-5092260?magaza=teknoryabilisim",
                            Price = 16099f,
                            ProductId = 15,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 56,
                            Link = "https://www.hepsiburada.com/acer-nitro-5-an515-45-amd-ryzen-7-5800h-16-gb-512-gb-ssd-rtx-3050-freedos-15-6-fhd-144-hz-tasinabilir-bilgisayar-nh-qbaey-007-p-HBCV00002QBQ8K",
                            Price = 18799f,
                            ProductId = 16,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 57,
                            Link = "https://www.trendyol.com/acer/nitro-5-an515-45-r7-5800h-16gb-512gb-ssd-rtx3050-dos-15-6-fhd-144hz-notebook-nh-qbaey-007-p-335997103?boutiqueId=61&merchantId=106740",
                            Price = 20499f,
                            ProductId = 16,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 58,
                            Link = "https://www.n11.com/urun/acer-nitro-5-an515-45-nhqbaey007-r7-5800h-16-gb-512-gb-ssd-rtx3050-156-dos-dizustu-bilgisayar-18597679?magaza=teknoryabilisim",
                            Price = 18799f,
                            ProductId = 16,
                            Rate = 4f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 59,
                            Link = "https://www.hepsiburada.com/acer-nitro-5-an515-45-amd-ryzen-7-5800h-16gb-512gb-ssd-rtx3050-freedos-15-6-fhd-tasinabilir-bilgisayar-nh-qbaey-004-p-HBCV00000RF4Z5",
                            Price = 19989f,
                            ProductId = 17,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 60,
                            Link = "https://www.trendyol.com/acer/nitro-5-an515-45-amd-ryzen-7-5800h-16-gb-512-gb-ssd-rtx3050-144hz-15-6-fhd-freedos-nh-qbaey-004-p-151427013?boutiqueId=613344&merchantId=106740",
                            Price = 22999f,
                            ProductId = 17,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 61,
                            Link = "https://www.n11.com/urun/acer-nitro-5-an515-45-nhqbaey004-r7-5800h-16-gb-512-gb-ssd-rtx3050-144hz-156-dos-dizustu-bilgisayar-2152263?magaza=teknoryabilisim",
                            Price = 19999f,
                            ProductId = 17,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 62,
                            Link = "https://www.hepsiburada.com/acer-nitro-5-an515-45-ryzen-5-5600h-8gb-512gb-ssd-rtx3050-freedos-15-6-fhd-tasinabilir-bilgisayar-nh-qbaey-002-canta-ve-mouse-p-HBCV00002P6Y1H",
                            Price = 16299f,
                            ProductId = 18,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 63,
                            Link = "https://www.trendyol.com/acer/nitro-5-an515-45-r5-5600h-8-gb-512gb-ssd-rtx3050-144hz-15-6-fhd-dos-nh-qbaey-002-canta-ve-mouse-p-333103267?boutiqueId=613344&merchantId=106740",
                            Price = 19599f,
                            ProductId = 18,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 64,
                            Link = "https://www.n11.com/urun/acer-nitro-5-an515-45-nhqbaey002-r5-5600h-8-gb-512-gb-ssd-rtx3050-144-hz-156-dos-dizustu-bilgisayar-2152318?magaza=teknoryabilisim",
                            Price = 16199f,
                            ProductId = 18,
                            Rate = 3f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 65,
                            Link = "https://www.hepsiburada.com/acer-swift-3-sf314-43-amd-ryzen-5-5500u-8gb-512gb-ssd-freedos-14-tasinabilir-bilgisayar-nx-ab1ey-002-p-HBCV0000156DKK",
                            Price = 9429f,
                            ProductId = 19,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 66,
                            Link = "https://www.trendyol.com/acer/swift-3-sf314-43-ryzen5-5500u-8gb-512gb-ssd-dos-14-fhd-tasinabilir-bilgisayar-nx-ab1ey-002-p-300442845?boutiqueId=613344&merchantId=106740",
                            Price = 9599f,
                            ProductId = 19,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 67,
                            Link = "https://www.n11.com/urun/acer-swift-3-sf314-43-nxab1ey002-r5-5500u-8-gb-512-gb-ssd-14-free-dos-dizustu-bilgisayar-4937028?magaza=teknoryabilisim",
                            Price = 9599f,
                            ProductId = 19,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 68,
                            Link = "https://www.hepsiburada.com/acer-aspire-3-a315-56-intel-core-i3-1005g1-8gb-256gb-ssd-windows-10-home-15-6-fhd-tasinabilir-bilgisayar-nx-hs7ey-002-p-HBCV00002UDCZW",
                            Price = 8999f,
                            ProductId = 20,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 69,
                            Link = "https://www.trendyol.com/acer/aspire-3-a315-56-corei3-1005g1-8gb-256gb-ssd-w10h-15-6-fhd-tasinabilir-bilgisayar-nx-hs7ey-002x-p-347679200?boutiqueId=613344&merchantId=106740",
                            Price = 8999f,
                            ProductId = 20,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 70,
                            Link = "https://www.n11.com/urun/acer-aspire-3-a315-56-nxhs7ey00201-i3-1005g1-8-gb-256-gb-156-w10h-dizustu-bilgisayar-21003966?magaza=teknoryabilisim",
                            Price = 9318f,
                            ProductId = 20,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 71,
                            Link = "https://www.hepsiburada.com/apple-macbook-m1-pro-cip-16gb-1tb-ssd-macos-16-qhd-tasinabilir-bilgisayar-gumus-mk1f3tu-a-p-HBCV00000U6XEH",
                            Price = 53599f,
                            ProductId = 21,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 72,
                            Link = "https://www.trendyol.com/apple/macbook-pro-mk1f3tu-a-m1-16gb-1tb-ssd-16-silver-p-184532581?boutiqueId=613344&merchantId=141868",
                            Price = 52590f,
                            ProductId = 21,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 73,
                            Link = "https://www.vatanbilgisayar.com/macbook-pro-mk1f3tu-a-m1-pro-16gb-1tb-ssd-liquid-retina-16-silver.html",
                            Price = 55599f,
                            ProductId = 21,
                            Rate = 5f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 74,
                            Link = "https://www.hepsiburada.com/apple-macbook-pro-m2-cip-8gb-256gb-ssd-macos-13-tasinabilir-bilgisayar-uzay-grisi-mneh3tu-a-p-HBCV00002GN5LH",
                            Price = 29699f,
                            ProductId = 22,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 75,
                            Link = "https://www.trendyol.com/apple/macbook-pro-mneh3tu-a-m2-8gb-256gb-ssd-retina-13-3inc-uzay-grisi-p-355659542?boutiqueId=61&merchantId=624588",
                            Price = 26699f,
                            ProductId = 22,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 76,
                            Link = "https://www.vatanbilgisayar.com/macbook-pro-mneh3tu-a-m2-8gb-256gb-ssd-retina-13-3inc-uzay-grisi.html",
                            Price = 26699f,
                            ProductId = 22,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 77,
                            Link = "https://www.hepsiburada.com/apple-macbook-air-m2-cip-8gb-512gb-ssd-macos-13-tasinabilir-bilgisayar-gece-yarisi-mly43tu-a-p-HBCV00002GNKO7",
                            Price = 31784f,
                            ProductId = 23,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 78,
                            Link = "https://www.trendyol.com/apple/macbook-air-13-6-m2-8gb-512gb-ssd-gece-yarisi-p-341826642?boutiqueId=61&merchantId=624588",
                            Price = 30599f,
                            ProductId = 23,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 79,
                            Link = "https://www.vatanbilgisayar.com/macbook-air-mly43tu-a-m2-8gb-512gb-ssd-liquid-retina-13-6inc-gece-yarisi.html",
                            Price = 30599f,
                            ProductId = 23,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 80,
                            Link = "https://www.hepsiburada.com/apple-macbook-m1-pro-cip-16gb-512gb-ssd-macos-14-qhd-tasinabilir-bilgisayar-uzay-grisi-mkgp3tu-a-p-HBCV00000U6XEL",
                            Price = 39999f,
                            ProductId = 24,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 81,
                            Link = "https://www.trendyol.com/apple/macbookpro-14-m1-pro-8ccpu-14c-gpu-16gb512gb-ssd-grisi-dizustu-bilgisayar-apple-turkiye-garantili-p-179203086?boutiqueId=613344&merchantId=427280",
                            Price = 38989f,
                            ProductId = 24,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 82,
                            Link = "https://www.vatanbilgisayar.com/macbook-pro-mkgp3tu-a-m1-pro-16gb-512gbssd-liquid-retina-14-space-grey.html",
                            Price = 38999f,
                            ProductId = 24,
                            Rate = 5f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 83,
                            Link = "https://www.hepsiburada.com/apple-macbook-air-13-6-mly33tua1-m2-8-cpu-8-gpu-16-gb-256-ssd-gece-yarisi-tasinabilir-bilgisayar-z16000102-p-HBCV00002XX737",
                            Price = 32299f,
                            ProductId = 25,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 84,
                            Link = "https://www.trendyol.com/apple/macbook-air-13-6-mly33tua1-m2-8cpu-8gpu-16gb-256ssd-gece-yarisi-z16000102-tasinabilir-bilgi-p-358437762?boutiqueId=61&merchantId=106664",
                            Price = 29999f,
                            ProductId = 25,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 85,
                            Link = "https://www.n11.com/urun/apple-macbook-air-mly33tua1-z16000102-m2-8-cpu-8-gpu-16-gb-256-gb-ssd-136-dizustu-bilgisayar-24040364?magaza=teknoraks",
                            Price = 31599f,
                            ProductId = 25,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 86,
                            Link = "https://www.trendyol.com/apple/macbook-pro-mkgq3tu-a-14-m1-pro-10cpu-16gpu-16gb-1tbssd-uzay-grisi-tasinabilir-bilgisayar-p-202258873?boutiqueId=613344&merchantId=141868",
                            Price = 55390f,
                            ProductId = 26,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 87,
                            Link = "https://www.n11.com/urun/apple-macbook-pro-mkgq3tua-apple-m1-pro-16-gb-1-tb-ssd-14-macos-dizustu-bilgisayar-2299690?magaza=integrakurumsal",
                            Price = 49979f,
                            ProductId = 26,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 88,
                            Link = "https://www.vatanbilgisayar.com/macbook-pro-mkgq3tu-a-m1-pro-16gb-1tb-ssd-liquid-retina-14-space-grey.html",
                            Price = 46499f,
                            ProductId = 26,
                            Rate = 5f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 89,
                            Link = "https://www.hepsiburada.com/apple-macbook-pro-m1-cip-8gb-256gb-ssd-macos-13-qhd-tasinabilir-bilgisayar-uzay-grisi-myd82tu-a-p-HBV0000130VNO",
                            Price = 24561f,
                            ProductId = 27,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 90,
                            Link = "https://www.trendyol.com/apple/macbook-pro-13-m1-8gb-256gb-ssd-uzay-grisi-dizustu-bilgisayar-apple-turkiye-garantili-p-75753347?boutiqueId=613344&merchantId=141868",
                            Price = 22888f,
                            ProductId = 27,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 91,
                            Link = "https://www.vatanbilgisayar.com/macbook-pro-myd82tu-a-m1-8gb-256gbssd-retina-13-3-int-space-grey.html",
                            Price = 23999f,
                            ProductId = 27,
                            Rate = 4f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 92,
                            Link = "https://www.hepsiburada.com/apple-macbook-air-m2-cip-8gb-256gb-ssd-macos-13-tasinabilir-bilgisayar-yildiz-isigi-mly13tu-a-p-HBCV00002GNKO1",
                            Price = 24799f,
                            ProductId = 28,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 93,
                            Link = "https://www.trendyol.com/apple/macbook-air-mly13tu-a-m2-8gb-256gb-ssd-liquid-retina-13-6inc-yildiz-isigi-p-358064123?boutiqueId=61&merchantId=624588",
                            Price = 25899f,
                            ProductId = 28,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 94,
                            Link = "https://www.vatanbilgisayar.com/macbook-air-mly13tu-a-m2-8gb-256gb-ssd-liquid-retina-13-6inc-yildiz-isigi.html",
                            Price = 25899f,
                            ProductId = 28,
                            Rate = 5f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 95,
                            Link = "https://www.hepsiburada.com/asus-x515ja-ej2120a2-intel-core-i7-1065g7-16gb-256gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV000023ARJD",
                            Price = 14012f,
                            ProductId = 29,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 96,
                            Link = "https://www.trendyol.com/asus/x515ja-ej2120a2-intel-core-i7-1065g7-16gb-256gb-ssd-freedos-15-6-fhd-p-286882601?boutiqueId=613344&merchantId=155616",
                            Price = 14678f,
                            ProductId = 29,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 97,
                            Link = "https://www.n11.com/urun/asus-x515ja-ej2120a2-i7-1065g7-16-gb-256-gb-ssd-156-free-dos-fhd-dizustu-bilgisayar-9018277?magaza=arcadia-bilisim",
                            Price = 13846f,
                            ProductId = 29,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 98,
                            Link = "https://www.trendyol.com/asus/x415ea-ek977-i5-1135g7-8-gb-256-gb-ssd-14-free-dos-fhd-dizustu-bilgisayar-p-308655535?boutiqueId=61&merchantId=194340",
                            Price = 10299f,
                            ProductId = 30,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 99,
                            Link = "https://www.n11.com/urun/asus-x415ea-ek977-i5-1135g7-8-gb-256-gb-ssd-14-free-dos-fhd-dizustu-bilgisayar-7426230?magaza=tekramarket",
                            Price = 9998f,
                            ProductId = 30,
                            Rate = 4f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 100,
                            Link = "https://www.vatanbilgisayar.com/asus-x415ea-11-nesil-core-i5-1135g7-8gb-256gb-ssd-14inc-freedos.html",
                            Price = 10599f,
                            ProductId = 30,
                            Rate = 5f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 101,
                            Link = "https://www.hepsiburada.com/asus-x515ea-bq1186w-intel-core-i5-1135g7-8-gb-256-gb-ssd-iris-xe-windows-11-home-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00002Q9S3D",
                            Price = 10999f,
                            ProductId = 31,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 102,
                            Link = "https://www.trendyol.com/asus/x515ea-bq1186w-intel-i5-1135g7-8gb-ram-256gb-ssd-iris-xe-15-6-fhd-ips-w11-p-335137108?boutiqueId=613344&merchantId=451837",
                            Price = 11099f,
                            ProductId = 31,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 103,
                            Link = "https://www.vatanbilgisayar.com/asus-x515ea-11-nesil-core-i5-1135g7-8gb-256gb-ssd-15-6inc-w11.html",
                            Price = 11999f,
                            ProductId = 31,
                            Rate = 4f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 104,
                            Link = "https://www.trendyol.com/asus/tuf-gaming-f15-fx506lh-hn004w-i5-10300h-8gb-512ssd-gtx1650-15-6-fullhd-w11h-tasinabilir-bilgis-p-331641603?boutiqueId=613344&merchantId=624588",
                            Price = 17499f,
                            ProductId = 32,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 105,
                            Link = "https://www.n11.com/urun/asus-tuf-gaming-fx506lh-hn004w-i5-10300h-8-gb-512-gb-ssd-gtx1650-156-w11h-fhd-dizustu-bilgisayar-18062831?magaza=teknoraks",
                            Price = 18729f,
                            ProductId = 32,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 106,
                            Link = "https://www.vatanbilgisayar.com/asus-tuf-gaming-15-10-nesil-core-i5-10300h-8gb-512gb-ssd-15-6inc-gtx1650-4gb-w10.html",
                            Price = 17462f,
                            ProductId = 32,
                            Rate = 4f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 107,
                            Link = "https://www.hepsiburada.com/asus-rog-strix-g513ic-hn037-amd-ryzen-7-4800h-16gb-512gb-ssd-rtx3050-freedos-15-6-tasinabilir-bilgisayar-p-HBCV00001E2066",
                            Price = 20799f,
                            ProductId = 33,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 108,
                            Link = "https://www.trendyol.com/asus/rog-strix-g15-g513ic-hn037-ryzen7-4800h-16gb-512gb-ssd-rtx3050-dos-15-6-tasinabilir-bilgisayar-p-263161666?boutiqueId=613344&merchantId=593536",
                            Price = 20899f,
                            ProductId = 33,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 109,
                            Link = "https://www.n11.com/urun/asus-rog-strix-g15-g513ic-hn037-r7-4800h-16-gb-512-gb-ssd-rtx3050-156-dos-fhd-dizustu-bilgisayar-2792498?magaza=notebookcity",
                            Price = 22079f,
                            ProductId = 33,
                            Rate = 4f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 110,
                            Link = "https://www.hepsiburada.com/asus-vivobook-x571li-bq377-intel-core-i7-10870h-8gb-512gb-ssd-gtx1650ti-freedos-15-6-fhd-ips-tasinabilir-bilgisayar-p-HBCV00001CL0HJ",
                            Price = 16499f,
                            ProductId = 34,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 111,
                            Link = "https://www.trendyol.com/asus/vivobook-15-x571li-bq377-intel-core-i7-10870h-8gb-512gb-ssd-gtx1650ti-freedos-15-6-tasinabilir-p-302302590?boutiqueId=61&merchantId=149834",
                            Price = 17836f,
                            ProductId = 34,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 112,
                            Link = "https://www.n11.com/urun/asus-vivobook-15-x571li-bq377-i7-10870h-8-gb-512-gb-ssd-gtx1650ti-156-dos-fhd-dizustu-bilgisayar-19292282?magaza=gti-bilisim",
                            Price = 16679f,
                            ProductId = 34,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 113,
                            Link = "https://www.hepsiburada.com/asus-rog-zephyrus-g14-ga401qc-bm206-amd-ryzen-7-5800hs-40gb-2tb-ssd-4gb-rtx3050-14-fhd-freedos-tasinabililir-bilgisayar-bm20609-p-HBCV00002N3H9Q",
                            Price = 26851f,
                            ProductId = 35,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 114,
                            Link = "https://www.trendyol.com/asus/rog-zephyrus-g14-ga401qc-bm206-amd-ryzen-7-5800hs-40gb-2tb-ssd-4gb-rtx3050-14-fhd-fdos-bm20609-p-329720966?boutiqueId=61&merchantId=106536",
                            Price = 29899f,
                            ProductId = 35,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 115,
                            Link = "https://www.hepsiburada.com/asus-x515jf-ej354-intel-core-i5-1035g1-8gb-256gb-ssd-2gb-mx130-vga-15-6-freedos-tasinabilir-bilgisayar-p-HBCV00001P5J2O",
                            Price = 11449f,
                            ProductId = 36,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 116,
                            Link = "https://www.trendyol.com/asus/x515jf-ej354-i5-1035g1-8gb-ram-256gb-ssd-2gb-mx130-15-6-fhd-freedos-p-217075285?boutiqueId=613344&merchantId=118442",
                            Price = 10999f,
                            ProductId = 36,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 117,
                            Link = "https://www.n11.com/urun/asus-x515jf-ej354-i5-1035g1-8-gb-256-gb-ssd-2-gb-mx130-156-free-dos-dizustu-bilgisayar-2435187?magaza=gpnteknoloji",
                            Price = 12104f,
                            ProductId = 36,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 118,
                            Link = "https://www.hepsiburada.com/asus-d515da-br998-amd-ryzen-3-3250u-4-gb-256-gb-ssd-freedos-15-6-hd-tasinabilir-bilgisayar-p-HBCV00000VMIRI",
                            Price = 6429f,
                            ProductId = 37,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 119,
                            Link = "https://www.trendyol.com/asus/d515da-br998-amd-ryzen-3-3250u-4-gb-256-gb-ssd-dos-15-6-hd-tasinabilir-bilgisayar-p-168824663?boutiqueId=613344&merchantId=106740",
                            Price = 6698f,
                            ProductId = 37,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 120,
                            Link = "https://www.n11.com/urun/asus-d515da-br998-ryzen-3-3250u-4-gb-256-gb-ssd-156-free-dos-hd-dizustu-bilgisayar-2186934?magaza=teknoryabilisim",
                            Price = 6429f,
                            ProductId = 37,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 121,
                            Link = "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa507rm-hn095-ryzen-7-6800h-16gb-512gb-ssd-rtx-3060-144-hz-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00002GIDW2",
                            Price = 27199f,
                            ProductId = 38,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 122,
                            Link = "https://www.trendyol.com/asus/tuf-gaming-a15-fa507rm-hn095-ryzen-7-6800h-16gb-ram-512gb-ssd-6gb-rtx3060-15-6-inc-fhd-144hz-p-322587921?boutiqueId=613344&merchantId=118442",
                            Price = 27499f,
                            ProductId = 38,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 123,
                            Link = "https://www.n11.com/urun/asus-tuf-gaming-a15-fa507rm-hn095-r7-6800h-16-gb-512-gb-ssd-rtx3060-144hz-156-dos-dizustu-bilgisayar-10526522?magaza=gpnteknoloji",
                            Price = 27999f,
                            ProductId = 38,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 124,
                            Link = "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa507rm-hn082-amd-ryzen-7-6800h-16-gb-512-gb-ssd-rtx-3060-144-hz-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001ET5UY",
                            Price = 27189f,
                            ProductId = 39,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 125,
                            Link = "https://www.trendyol.com/asus/tuf-gaming-a15-fa507rm-hn082-r7-6800h-16gb-512gb-ssd-rtx3060-144hz-dos-15-6-fhd-canta-mouse-p-353779788?boutiqueId=61&merchantId=106740",
                            Price = 28399f,
                            ProductId = 39,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 126,
                            Link = "https://www.n11.com/urun/asus-tuf-gaming-a15-fa507rm-hn082-r7-6800h-16-gb-512-gb-ssd-rtx3060-144hz-156-dos-dizustu-bilgisayar-2574519?magaza=teknoryabilisim",
                            Price = 28189f,
                            ProductId = 39,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 127,
                            Link = "https://www.hepsiburada.com/asus-d515da-bq1253-ryzen-3-3250u-8gb-ram-256gb-ssd-o-b-radeon-vga-15-6-fullhd-freedos-gumus-notebook-p-HBCV00002Z4CDL",
                            Price = 7193f,
                            ProductId = 40,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 128,
                            Link = "https://www.trendyol.com/asus/d515da-bq1253-ryzen3-3250u-8gb-256gb-15-6-dos-fhd-p-357865314?boutiqueId=61&merchantId=131190",
                            Price = 8500f,
                            ProductId = 40,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 129,
                            Link = "https://www.n11.com/urun/asus-d515da-bq1253-ryzen-3-3250u-8-gb-256-gb-ssd-156-free-dos-fhd-dizustu-bilgisayar-24157741?magaza=elmacik",
                            Price = 6899f,
                            ProductId = 40,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 130,
                            Link = "https://www.hepsiburada.com/asus-vivobook-15-intel-core-i3-7020u-4gb-256gb-ssd-15-6-freedos-tasinabilir-bilgisayar-x540ua-dm911-p-HBCV000011EUQD",
                            Price = 7176f,
                            ProductId = 41,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 131,
                            Link = "https://www.trendyol.com/asus/x540ua-dm911-core-i3-7020u-4gb-256-ssd-15-6-free-dos-silver-p-132301915?boutiqueId=61&merchantId=334898",
                            Price = 7399f,
                            ProductId = 41,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 132,
                            Link = "https://www.n11.com/urun/asus-x540ua-dm911-i3-7020u-4-gb-256-gb-ssd-156-free-dos-dizustu-bilgisayar-2101425?magaza=dualpazar",
                            Price = 6896f,
                            ProductId = 41,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 133,
                            Link = "https://www.hepsiburada.com/asus-d515da-br3169-amd-ryzen-3-3250u-4gb-256gb-ssd-15-6-freedos-tasinabilir-bilgisayar-p-HBCV00002KOPKB",
                            Price = 6499f,
                            ProductId = 42,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 134,
                            Link = "https://www.trendyol.com/asus/d515da-br3169-amd-ryzen-3-3250u-4gb-256gb-ssd-15-6-free-dos-p-320149654?boutiqueId=613344&merchantId=106198",
                            Price = 6699f,
                            ProductId = 42,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 135,
                            Link = "https://www.n11.com/urun/asus-d515da-br3169-ryzen-3-3250u-4-gb-256-gb-ssd-156-free-dos-hd-dizustu-bilgisayar-15757851?magaza=techburada",
                            Price = 6699f,
                            ProductId = 42,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 136,
                            Link = "https://www.hepsiburada.com/asus-d515da-br1424-amd-ryzen-3-3250u-8gb-256gb-ssd-freedos-15-6-tasinabilir-bilgisayar-p-HBCV000022XP0G",
                            Price = 7499f,
                            ProductId = 43,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 137,
                            Link = "https://www.trendyol.com/asus/d515da-br1424-amd-ryzen-3-3250u-8gb-256gb-ssd-freedos-15-6-tasinabilir-bilgisayar-p-343651384?boutiqueId=613344&merchantId=121368",
                            Price = 7349f,
                            ProductId = 43,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 138,
                            Link = "https://www.n11.com/urun/asus-d515da-br1424-ryzen-3-3250u-8-gb-256-gb-ssd-156-free-dos-dizustu-bilgisayar-20001801?magaza=seyfiteknoloji",
                            Price = 7499f,
                            ProductId = 43,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 139,
                            Link = "https://www.hepsiburada.com/asus-tuf-gaming-f15-fx506lh-hn004w03-intel-core-i5-10300h-16-gb-512-ssd-gtx1650-windows-11-home-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00002OQ25Q",
                            Price = 20319f,
                            ProductId = 44,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 140,
                            Link = "https://www.trendyol.com/asus/tuf-gaming-f15-fx506lh-hn004w03-i5-10300h-16gb-512ssd-gtx1650-15-6-w11h-tasinabilir-bilgisayar-p-331641546?boutiqueId=613344&merchantId=106664",
                            Price = 19189f,
                            ProductId = 44,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 141,
                            Link = "https://www.n11.com/urun/asus-tuf-gaming-fx506lh-hn004w03-i5-10300h-16-gb-512-gb-ssd-gtx1650-156-w11h-dizustu-bilgisayar-18062816?magaza=teknoraks",
                            Price = 19321f,
                            ProductId = 44,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 142,
                            Link = "https://www.hepsiburada.com/asus-x571gta4-hn1012a4-intel-core-i5-9300h-16gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00000R63TB",
                            Price = 15738f,
                            ProductId = 45,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 143,
                            Link = "https://www.trendyol.com/asus/x571gta4-hn1012a4-intel-core-i5-9300h-16gb-512gb-ssd-gtx1650-144hz-freedos-15-6-fhd-p-164804862?boutiqueId=613344&merchantId=155616",
                            Price = 16072f,
                            ProductId = 45,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 144,
                            Link = "https://www.n11.com/urun/asus-x571gta4-hn1012a4-i5-9300h-16-gb-512-gb-ssd-gtx1650-156-dos-dizustu-bilgisayar-4196719?magaza=arcadia-bilisim",
                            Price = 15471f,
                            ProductId = 45,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 145,
                            Link = "https://www.hepsiburada.com/asus-x515ja-ej2120a108-intel-core-i7-1065g7-16gb-512gb-ssd-windows-11-pro-15-6-fhd-tasinabilir-bilgisayar-p-HBCV000023ATH5",
                            Price = 15833f,
                            ProductId = 46,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 146,
                            Link = "https://www.trendyol.com/asus/x515ja-ej2120a108-intel-core-i7-1065g7-16gb-512gb-ssd-windows-11-pro-15-6-fhd-p-286887897?boutiqueId=613344&merchantId=155616",
                            Price = 16514f,
                            ProductId = 46,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 147,
                            Link = "https://www.n11.com/urun/asus-x515ja-ej2120a108-i7-1065g7-16-gb-512-gb-ssd-156-w11p-fhd-dizustu-bilgisayar-9018624?magaza=arcadia-bilisim",
                            Price = 15646f,
                            ProductId = 46,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 148,
                            Link = "https://www.hepsiburada.com/asus-rog-strix-g513ie-hn065a16-amd-ryzen-7-4800h-16gb-512gb-ssd-windows-10-home-rtx3050ti-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00002Y67YY",
                            Price = 24585f,
                            ProductId = 47,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 149,
                            Link = "https://www.trendyol.com/asus/rog-strix-g513ie-hn065a16-amd-ryzen-7-4800h-16gb-512gb-ssd-windows-10-home-rtx3050ti-15-6-p-357954799?boutiqueId=61&merchantId=155616",
                            Price = 25242f,
                            ProductId = 47,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 150,
                            Link = "https://www.vatanbilgisayar.com/asus-rog-strix-g15-amd-r7-4800h-2-9ghz-16gb-512gb-ssd-15-6-rtx3050ti-4gb-w10.html",
                            Price = 32576f,
                            ProductId = 47,
                            Rate = 4f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 151,
                            Link = "https://www.hepsiburada.com/asus-x515ja-ej2120a4-intel-core-i7-1065g7-16gb-1tb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV000023ARJH",
                            Price = 15843f,
                            ProductId = 48,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 152,
                            Link = "https://www.trendyol.com/asus/x515ja-ej2120a4-intel-core-i7-1065g7-16gb-1tb-ssd-freedos-15-6-fhd-p-286877973?boutiqueId=613344&merchantId=155616",
                            Price = 16524f,
                            ProductId = 48,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 153,
                            Link = "https://www.n11.com/urun/asus-x515ja-ej2120a4-i7-1065g7-16-gb-1-tb-ssd-156-free-dos-fhd-dizustu-bilgisayar-9018293?magaza=arcadia-bilisim",
                            Price = 15655f,
                            ProductId = 48,
                            Rate = 1f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 154,
                            Link = "https://www.hepsiburada.com/asus-vivobook-k3400ph-km018-intel-core-i5-11300h-16gb-ram-512gb-ssd-gtx1650-freedos-14-oled-tasinabilir-bilgisayar-p-HBCV000012VZYG",
                            Price = 17999f,
                            ProductId = 49,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 155,
                            Link = "https://www.trendyol.com/asus/intel-core-i5-11300h-16gb-ram-512gb-ssd-4gb-gtx1650-oled-freedos-14-k3400ph-km018-p-202870115?boutiqueId=613344&merchantId=104683",
                            Price = 17999f,
                            ProductId = 49,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 156,
                            Link = "https://www.n11.com/urun/asus-vivobook-pro-14-oled-k3400ph-km018-i5-11300h-16-gb-512-gb-ssd-gtx1650-14-dos-dizustu-bilgisayar-2359211?magaza=nethouse",
                            Price = 17998f,
                            ProductId = 49,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 157,
                            Link = "https://www.hepsiburada.com/asus-x515ja-ej2120a3-intel-core-i7-1065g7-16gb-512gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV000023ARJF",
                            Price = 14535f,
                            ProductId = 50,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 158,
                            Link = "https://www.trendyol.com/asus/x515ja-ej2120a3-intel-core-i7-1065g7-16gb-512gb-ssd-freedos-15-6-fhd-p-297616241?boutiqueId=613344&merchantId=482979",
                            Price = 15199f,
                            ProductId = 50,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 159,
                            Link = "https://www.n11.com/urun/asus-x515ja-ej2120a3-i7-1065g7-16-gb-512-gb-ssd-156-free-dos-fhd-dizustu-bilgisayar-9018326?magaza=arcadia-bilisim",
                            Price = 14067f,
                            ProductId = 50,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 160,
                            Link = "https://www.hepsiburada.com/asus-vivobook-d513ua-l1346-oled-amd-ryzen-5-5500u-8gb-512gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00000H2DVD",
                            Price = 10999f,
                            ProductId = 51,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 161,
                            Link = "https://www.trendyol.com/asus/vivobook-d513ua-l1346-oled-amd-ryzen-5-5500u-8gb-512gb-ssd-dos-15-6-fhd-tasinabilir-bilgisayar-p-267626325?boutiqueId=613344&merchantId=106934",
                            Price = 11299f,
                            ProductId = 51,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 162,
                            Link = "https://www.n11.com/urun/asus-vivobook-15-oled-d513ua-l1346-ryzen-5-5500u-8-gb-512-gb-ssd-156-free-dos-dizustu-bilgisayar-2417045?magaza=gti-bilisim",
                            Price = 10499f,
                            ProductId = 51,
                            Rate = 4f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 163,
                            Link = "https://www.hepsiburada.com/dell-inspiron-15-3511-i5-1135g7-8gb-ram-512gb-ssd-2gb-mx350-15-6-fhd-ubuntu-i35111015u-tasinabilirbilgisayar-p-HBCV000029ASZ5",
                            Price = 12999f,
                            ProductId = 52,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 164,
                            Link = "https://www.trendyol.com/dell/inspiron-15-3511-i5-1135g7-8gb-ram-512gb-ssd-2gb-mx350-15-6-inc-fhd-ubuntu-p-303472730?boutiqueId=614347&merchantId=118442",
                            Price = 12499f,
                            ProductId = 52,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 165,
                            Link = "https://www.n11.com/urun/dell-inspiron-15-3511-i35111015u-i5-1135g7-8-gb-512-gb-ssd-mx350-156-ubuntu-dizustu-bilgisayar-24325180?magaza=gpnteknoloji",
                            Price = 11899f,
                            ProductId = 52,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 166,
                            Link = "https://www.hepsiburada.com/dell-gaming-g15-5511-i5-11260h-16gb-512gb-ssd-rtx3050-15-6-fhd-ubuntu-tasinabilir-bilgisayar-g55112306u-p-HBCV00002R8KR6",
                            Price = 19490f,
                            ProductId = 53,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 167,
                            Link = "https://www.trendyol.com/dell/g15-5511-g55112306u-i5-11260h-16gb-512gb-rtx3050-15-6-ubuntu-p-339557801?boutiqueId=614349&merchantId=106248",
                            Price = 17999f,
                            ProductId = 53,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 168,
                            Link = "https://www.n11.com/urun/dell-g15-5511-g55112306u-i5-11260h-16-gb-512-gb-ssd-rtx-3050-156-ubuntu-fhd-dizustu-bilgisayar-18775113?magaza=garajonline",
                            Price = 18029f,
                            ProductId = 53,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 169,
                            Link = "https://www.hepsiburada.com/dell-g15-5511-g55112801u04-intel-core-i7-11800h-64gb-1tb-ssd-rtx3060-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00002398KQ",
                            Price = 40188f,
                            ProductId = 54,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 170,
                            Link = "https://www.trendyol.com/dell/g15-5511-g55112801u04-i7-11800h-64gb-1tbssd-rtx3060-15-6-fullhd-freedos-tasinabilir-bilgisayar-p-282436568?boutiqueId=613344&merchantId=106664",
                            Price = 37619f,
                            ProductId = 54,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 171,
                            Link = "https://www.n11.com/urun/dell-g15-5511-g55112801u04-i7-11800h-64-gb-1-tb-ssd-rtx3060-156-free-dos-fhd-dizustu-bilgisayar-3970240?magaza=teknoraks",
                            Price = 38212f,
                            ProductId = 54,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 172,
                            Link = "https://www.hepsiburada.com/dell-inspiron-3511-intel-core-i5-1135g7-16gb-512gb-ssd-windows-10-pro-15-6-tasinabilir-bilgisayar-f35obf821na46-p-HBCV00001DZJ3R",
                            Price = 13923f,
                            ProductId = 55,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 173,
                            Link = "https://www.trendyol.com/dell/inspiron-3511-intel-core-i5-1135g7-16gb-512gb-ssd-windows-10-pro-15-6-f35obf821na46-p-247654415?boutiqueId=613344&merchantId=155616",
                            Price = 14093f,
                            ProductId = 55,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 174,
                            Link = "https://www.n11.com/urun/dell-inspiron-3511-f35obf821na46-i5-1135g7-16-gb-512-gb-ssd-156-w10p-fhd-dizustu-bilgisayar-10140859?magaza=arcadia-bilisim",
                            Price = 13758f,
                            ProductId = 55,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 175,
                            Link = "https://www.hepsiburada.com/casper-excalibur-g770-1140-bvl0x-b-intel-core-i5-11400h-16gb-500gb-ssd-rtx3050ti-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00000B7X1D",
                            Price = 17999f,
                            ProductId = 56,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 176,
                            Link = "https://www.trendyol.com/casper/excalibur-g770-1140-bvh0x-b-intel-core-i5-11400h-16gb-500gb-nvme-ssd-4gb-gtx1650-freedos-15-6-p-211200181?boutiqueId=61&merchantId=131190",
                            Price = 17023f,
                            ProductId = 56,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 177,
                            Link = "https://www.n11.com/urun/casper-excalibur-g7701140-bvh0x-b-i5-11400h-16-gb-500-gb-nvme-ssd-gtx1650-156-dos-dizustu-bilgisayar-2413166?magaza=okyanusteknolojimlt",
                            Price = 18888f,
                            ProductId = 56,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 178,
                            Link = "https://www.hepsiburada.com/hp-15-dw4010nt-intel-core-i5-1235u-8gb-512gb-ssd-freedos-15-6-tasinabilir-bilgisayar-6y7z9ea-p-HBCV00002VUPYB",
                            Price = 12142f,
                            ProductId = 57,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 179,
                            Link = "https://www.trendyol.com/hp/15-dw4010nt-intel-core-i5-1235u-8gb-512-gb-ssd-freedos-15-6-6y7z9ea-p-363613987?boutiqueId=61&merchantId=107092",
                            Price = 12215f,
                            ProductId = 57,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 180,
                            Link = "https://www.n11.com/urun/hp-15-dw4010nt-6y7z9ea-i5-1235u-8-gb-512-gb-ssd-156-free-dos-dizustu-bilgisayar-24042338?magaza=seyfiteknoloji",
                            Price = 12250f,
                            ProductId = 57,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 181,
                            Link = "https://www.hepsiburada.com/hp-pavilion-gaming-15-dk2079nt-intel-core-i7-11370h-16gb-512gb-ssd-rtx3050ti-freedos-15-6-ips-fhd-tasinabilir-bilgisayar-68n54ea-p-HBCV00002JH4B3",
                            Price = 20499f,
                            ProductId = 58,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 182,
                            Link = "https://www.trendyol.com/hp/pavilion-gaming-15-dk2080nt-68n55ea-intel-core-i7-11370h-16gb-512ssd-rtx3050-4gb-15-6-fhd-freedos-p-305167267?boutiqueId=614349&merchantId=105238",
                            Price = 20989f,
                            ProductId = 58,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 183,
                            Link = "https://www.n11.com/urun/hp-pavilion-15-dk2080nt-68n55ea-i7-11370h-16-gb-512-gb-ssd-rtx3050-156-dos-fhd-dizustu-bilgisayar-5603155?magaza=mtbilisim",
                            Price = 22999f,
                            ProductId = 58,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 184,
                            Link = "https://www.hepsiburada.com/hp-pavilion-15-eg0013nt-intel-core-i5-1135g7-8gb-256gb-ssd-mx350-windows-10-home-15-6-fhd-tasinabilir-bilgisayar-2y7x6ea-p-HBCV000005WPM1",
                            Price = 13499f,
                            ProductId = 59,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 185,
                            Link = "https://www.trendyol.com/hp/pavilion-15-eg0013nt-i5-1135g7-8gb-256gb-mx350-ssd-win10-15-6-notebook-2y7x6ea-p-101964549?boutiqueId=613344&merchantId=154426",
                            Price = 13499f,
                            ProductId = 59,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 186,
                            Link = "https://www.n11.com/urun/hp-pavilion-15-eg0013nt-2y7x6ea-i5-1135g7-8-gb-256-gb-ssd-2-gb-mx350-156-w10h-dizustu-bilgisayar-1980368?magaza=notisteknoloji",
                            Price = 12959f,
                            ProductId = 59,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 187,
                            Link = "https://www.trendyol.com/hp/pavilion-14-dv0029nt-intel-core-i7-1165g7-8gb-512gb-ssd-mx450-windows-10-home-14-fhd-p-133866853?boutiqueId=613344&merchantId=107403",
                            Price = 17999f,
                            ProductId = 60,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 188,
                            Link = "https://www.n11.com/urun/hp-pavilion-14-dv0029nt-4h0u5ea-i7-1165g7-8-gb-512-gb-mx450-14-w10h-fhd-dizustu-bilgisayar-2101671?magaza=doludepo",
                            Price = 17933f,
                            ProductId = 60,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 189,
                            Link = "https://www.vatanbilgisayar.com/hp-pavilion-14-dv0029nt-core-i7-1165g7-2-8ghz-8gb-512gb-ssd-14-mx450-2gb-w10.html",
                            Price = 20499f,
                            ProductId = 60,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 190,
                            Link = "https://www.hepsiburada.com/hp-zbook-studio-g8-intel-core-i7-11850h-32-gb-1-tb-ssd-rtx-a3000-windows-10-pro-15-6-fhd-tasinabilir-is-istasyonu-314g1ea-p-HBCV00000ZNJY1",
                            Price = 65159f,
                            ProductId = 61,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 191,
                            Link = "https://www.trendyol.com/hp/zbook-studio-g8-314g1ea-i7-11850h-32gb-1tbssd-a3000-w10p-15-6-fullhd-tasinabilir-is-istasyonu-p-241301358?boutiqueId=613901&merchantId=106664",
                            Price = 64649f,
                            ProductId = 61,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 192,
                            Link = "https://www.n11.com/urun/hp-ws-zbook-studio-g8-314g1ea-i7-11850h-32-gb-1-tb-ssd-rtx-a3000-156-w10p-fhd-dizustu-bilgisayar-2153874?magaza=vesmark",
                            Price = 62799f,
                            ProductId = 61,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 193,
                            Link = "https://www.hepsiburada.com/hp-pavilion-gaming-laptop-15-ec2052nt-amd-ryzen-7-5800h-16-gb-512-gb-ssd-rtx-3050-144-hz-freedos-15-6-fhd-tasinabilir-bilgisayar-68n66ea-p-HBCV00002UM64S",
                            Price = 18699f,
                            ProductId = 62,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 194,
                            Link = "https://www.trendyol.com/hp/pavilion-gaming-laptop-r7-5800h-16gb-512gb-ssd-rtx3050-144hz-dos-15-6-fhd-68n66ea-canta-ve-mouse-p-362248848?boutiqueId=61&merchantId=106740",
                            Price = 19099f,
                            ProductId = 62,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 195,
                            Link = "https://www.n11.com/urun/hp-pavilion-15-ec2052nt-68n66ea-r7-5800h-16-gb-512-gb-rtx3050-144hz-156-dos-dizustu-bilgisayar-21289692?magaza=teknoryabilisim",
                            Price = 18699f,
                            ProductId = 62,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 196,
                            Link = "https://www.hepsiburada.com/hp-pavilion-68n67ea-15-ec2051nt-amd-ryzen-7-5800h-16gb-rtx3050ti-512gb-ssd-144-hz-fhd-15-6-freedos-gaming-notebook-p-HBCV000022O86J",
                            Price = 18999f,
                            ProductId = 63,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 197,
                            Link = "https://www.trendyol.com/hp/pavilion-amd-ryzen-7-5800h-16gb-rtx3050ti-512gb-ssd-144hz-15-6-freedos-gaming-notebook-68n67ea-p-280772774?boutiqueId=61&merchantId=105369",
                            Price = 20199f,
                            ProductId = 63,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 198,
                            Link = "https://www.n11.com/urun/hp-pavilion-gaming-68n67ea-r7-5800h-16gb-512-gb-ssd-rtx3050ti-144hz-156-dos-fhd-dizustu-bilgisayar-3791424?magaza=betaplusteknoloji",
                            Price = 21269f,
                            ProductId = 63,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 199,
                            Link = "https://www.hepsiburada.com/hp-elitebook-840-g8-intel-core-i7-1165g7-16-gb-512-gb-ssd-windows-10-pro-14-fhd-tasinabilir-bilgisayar-336d6ea-p-HBCV000010G54I",
                            Price = 24000f,
                            ProductId = 64,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 200,
                            Link = "https://www.trendyol.com/hp/elitebook-840-g8-i7-1165g7-16-gb-512-gb-ssd-w10pro-14-fhd-tasinabilir-bilgisayar-336d6ea-p-314607986?boutiqueId=613344&merchantId=114271",
                            Price = 25999f,
                            ProductId = 64,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 201,
                            Link = "https://www.n11.com/urun/hp-elitebook-840-g8-336d6ea-i7-1165g7-16-gb-512-gb-ssd-14-w10p-dizustu-bilgisayar-1720300?magaza=indeokurumsal",
                            Price = 26706f,
                            ProductId = 64,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 202,
                            Link = "https://www.hepsiburada.com/hp-14s-fq0014nt-amd-ryzen-3-3250u-4gb-128gb-ssd-windows-10-home-14-tasinabilir-bilgisayar-227d6ea-p-HBCV000002NZ5O",
                            Price = 5414f,
                            ProductId = 65,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 203,
                            Link = "https://www.trendyol.com/hp/14s-fq0014nt-amd-ryzen-3-3250u-4gb-128gbssd-14-w10-ho-227d6ea-p-64983665?boutiqueId=613344&merchantId=121153",
                            Price = 5559f,
                            ProductId = 65,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 204,
                            Link = "https://www.n11.com/urun/hp-14s-fq0014nt-227d6ea-amd-ryzen-3-3250u-4-gb-128-gb-ssd-14-w10h-dizustu-bilgisayar-1680984?magaza=tvshoop",
                            Price = 5439f,
                            ProductId = 65,
                            Rate = 4f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 205,
                            Link = "https://www.hepsiburada.com/hp-14s-fq0014nt-amd-ryzen-3-3250u-4gb-128gb-ssd-windows-10-home-14-tasinabilir-bilgisayar-227d9ea-p-HBV000015XCMI",
                            Price = 5849f,
                            ProductId = 66,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 206,
                            Link = "https://www.trendyol.com/hp/laptop-14s-fq0014nt-ryzen3-3250u-14-inc-4-gb-ram-128-gb-ssd-windows-10-p-60231641?boutiqueId=613344&merchantId=107676",
                            Price = 5549f,
                            ProductId = 66,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 207,
                            Link = "https://www.vatanbilgisayar.com/hp-14s-fq0014nt-amd-ryzen-3-3250u-2-6ghz-4gb-128gb-ssd-15-6-amd-w10.html",
                            Price = 7499f,
                            ProductId = 66,
                            Rate = 4f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 208,
                            Link = "https://www.hepsiburada.com/hp-2x7x4ea-probook-450-g8-intel-core-i5-1135g7-8gb-512-gb-ssd-15-6-freedos-tasinabilir-bilgisayar-p-HBCV0000088909",
                            Price = 15520f,
                            ProductId = 67,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 209,
                            Link = "https://www.trendyol.com/hp/probook-450-g8-2x7x4ea-i5-1135g7-8gb-512gb-ssd-15-6-dos-p-315631507?boutiqueId=613344&merchantId=207789",
                            Price = 15355f,
                            ProductId = 67,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 210,
                            Link = "https://www.n11.com/urun/hp-450-g8-2x7x4ea-i5-1135g7-8-gb-512-gb-ssd-156-free-dos-dizustu-bilgisayar-1995968?magaza=indeokurumsal",
                            Price = 14947f,
                            ProductId = 67,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 211,
                            Link = "https://www.hepsiburada.com/hp-pavilion-15-ec2059nt-amd-ryzen-5-5600h-8gb-512gb-ssd-gtx-1650-freedos15-6-fhd-144-hz-ips-tasinabilir-bilgisayar-68n74ea-p-HBCV000026XU55",
                            Price = 15499f,
                            ProductId = 68,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 212,
                            Link = "https://www.trendyol.com/hp/pavilion-15-ec2059nt-amd-ryzen-5-5600h-8gb-512gb-ssd-gtx-1650-15-6-fhd-144-hz-ips-freedos-68n74ea-p-290126990?boutiqueId=61&merchantId=106740",
                            Price = 15599f,
                            ProductId = 68,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 213,
                            Link = "https://www.n11.com/urun/hp-pavilion-15-ec2059nt-68n74ea-r5-5600h-8-gb-512-gb-ssd-gtx1650-144hz-156-dos-fhd-dizustu-bilgisayar-4478312?magaza=teknoryabilisim",
                            Price = 15541f,
                            ProductId = 68,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 214,
                            Link = "https://www.hepsiburada.com/hp-pavilion-gaming-laptop-15-ec2056nt-amd-ryzen-5-5600h-8-gb-512-gb-ssd-rtx-3050ti-144-hz-freedos-15-6-fhd-tasinabilir-bilgisayar-68n71ea-p-HBCV000022O86P",
                            Price = 17499f,
                            ProductId = 69,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 215,
                            Link = "https://www.trendyol.com/hp/pavilion-gaming-laptop-ryzen5-5600h-8gb-512gb-ssd-rtx3050ti-144hz-dos-15-6-fhd-notebook-68n71ea-p-280778503?boutiqueId=613344&merchantId=106740",
                            Price = 17399f,
                            ProductId = 69,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 216,
                            Link = "https://www.n11.com/urun/hp-pavilion-gaming-68n71ea-r5-5600h-8-gb-512-gb-ssd-rtx3050ti-144hz-156-dos-fhd-dizustu-bilgisayar-3791483?magaza=teknoryabilisim",
                            Price = 17499f,
                            ProductId = 69,
                            Rate = 4f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 217,
                            Link = "https://www.hepsiburada.com/hp-255-g8-amd-ryzen7-5700u-32gb-1tb-ssd-windows-10-home-15-6-fhd-tasinabilir-bilgisayar-4p3m3es08-p-HBCV00001CINJM",
                            Price = 15829f,
                            ProductId = 70,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 218,
                            Link = "https://www.trendyol.com/hp/255-g8-4p3m3es08-ryzen7-5700u-32gb-1tbssd-15-6-fullhd-w10h-tasinabilir-bilgisayar-p-234348496?boutiqueId=613344&merchantId=106664",
                            Price = 14899f,
                            ProductId = 70,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 219,
                            Link = "https://www.n11.com/urun/hp-255-g8-4p3m3es08-ryzen-7-5700u-32-gb-1-tb-ssd-156-w10h-fhd-dizustu-bilgisayar-2511890?magaza=teknoraks",
                            Price = 15053f,
                            ProductId = 70,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 220,
                            Link = "https://www.trendyol.com/hp/255-g8-4p3m3es-ryzen-7-5700u-8gb-256gb-ssd-15-6-fhd-windows-10-p-200342547?boutiqueId=613344&merchantId=124635",
                            Price = 11172f,
                            ProductId = 71,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 221,
                            Link = "https://www.n11.com/urun/hp-255-g8-4p3m3es-ryzen-7-5700u-8-gb-256-gb-ssd-156-w10h-dizustu-bilgisayar-2358177?magaza=kocpa",
                            Price = 11299f,
                            ProductId = 71,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 222,
                            Link = "https://www.vatanbilgisayar.com/hp-255-g8-5-nesil-ryzen-7-5700u-8gb-256gb-ssd-15-6-w10.html",
                            Price = 10099f,
                            ProductId = 71,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 223,
                            Link = "https://www.hepsiburada.com/hp-elitebook-630-g9-6s6y3ea-intel-core-i5-1235u-16gb-512gb-ssd-freedos-13-3-uwva-tasinabilir-bilgisayar-p-HBCV00002ZTHTP",
                            Price = 17193f,
                            ProductId = 72,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 224,
                            Link = "https://www.trendyol.com/hp/elitebook-630-g9-6s6y3ea-i5-1235u-16gb-512gb-ssd-13-3-uwva-dos-p-361837044?boutiqueId=61&merchantId=207789",
                            Price = 17010f,
                            ProductId = 72,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 225,
                            Link = "https://www.n11.com/urun/hp-elitebook-630-g9-6s6y3ea-i5-1235u-16-gb-512-gb-ssd-133-free-dos-dizustu-bilgisayar-24881408?magaza=indeokurumsal",
                            Price = 17193f,
                            ProductId = 72,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 226,
                            Link = "https://www.trendyol.com/hp/envy-13-ba1000nt-4h0t7ea-i7-1165g7-16gb-ram-512gb-ssd-2gb-mx450-13-3-fhd-windows-10-p-138198353?boutiqueId=614596&merchantId=216294",
                            Price = 20743f,
                            ProductId = 73,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 227,
                            Link = "https://www.n11.com/urun/hp-envy-13-ba1000nt-4h0t7ea-i7-1165g7-16-gb-512-gb-ssd-mx450-133-w10h-fhd-dizustu-bilgisayar-2117143?magaza=vpbilisim",
                            Price = 20399f,
                            ProductId = 73,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 228,
                            Link = "https://www.vatanbilgisayar.com/hp-envy-13-ba1009nt-core-i7-1165g7-2-8ghz-16gb-512gb-ssd-13-3-mx450-2gb-w10.html",
                            Price = 22999f,
                            ProductId = 73,
                            Rate = 5f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 229,
                            Link = "https://www.hepsiburada.com/hp-15-da2033nt-intel-core-i5-10210u-4gb-256gb-ssd-windows-10-home-15-6-tasinabilir-bilgisayar-9hn16ea-p-HBV0000138K0W",
                            Price = 9574f,
                            ProductId = 74,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 230,
                            Link = "https://www.trendyol.com/hp/15-da2033nt-9hn16ea-intel-i5-10210u-4gb-256gb-ssd-15-6-int-w10-p-70101814?boutiqueId=61&merchantId=108699",
                            Price = 10667f,
                            ProductId = 74,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 231,
                            Link = "https://www.vatanbilgisayar.com/hp-15-da2033nt-core-i5-10210u-1-6ghz-4gb-256gb-ssd-15-6-mx110-2gb-w10.html",
                            Price = 12225f,
                            ProductId = 74,
                            Rate = 5f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 232,
                            Link = "https://www.hepsiburada.com/hp-15s-eq3004nt-amd-ryzen-7-5825u-8gb-256gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-68n36ea-s8-p-HBCV00002ZRYE5",
                            Price = 11999f,
                            ProductId = 75,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 233,
                            Link = "https://www.trendyol.com/hp/laptop-15s-eq3004nt-68n36ea-amd-ryzen7-5825u-8gb-ram-256-ssd-15-6-freedos-notebook-p-348350637?boutiqueId=61&merchantId=105290",
                            Price = 10339f,
                            ProductId = 75,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 234,
                            Link = "https://www.n11.com/urun/hp-15s-eq3004nt-68n36ea-r7-5825u-8-gb-256-gb-ssd-156-free-dos-fhd-dizustu-bilgisayar-22289942?magaza=exen",
                            Price = 10290f,
                            ProductId = 75,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 235,
                            Link = "https://www.hepsiburada.com/hp-pavilion-13-bb0007nt-intel-core-i7-1165g7-8gb-512gb-ssd-13-3-ips-fhd-windows-10-home-tasinabilir-bilgisayar-4j670ea-p-HBCV00001TXB0K",
                            Price = 16999f,
                            ProductId = 76,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 236,
                            Link = "https://www.trendyol.com/hp/4j670ea-pavilion-core-i7-1165g7-8gb-ram-512gb-ssd-13-3-w10h-laptop-gumus-p-208554865?boutiqueId=613344&merchantId=125175",
                            Price = 16829f,
                            ProductId = 76,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 237,
                            Link = "https://www.vatanbilgisayar.com/hp-pavilion-13-bb0007nt-core-i7-1165g7-2-8ghz-8gb-512gb-ssd-13-3-int-w10.html",
                            Price = 12299f,
                            ProductId = 76,
                            Rate = 5f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 238,
                            Link = "https://www.hepsiburada.com/hp-omen-15-en1018nt-amd-ryzen-7-5800h-16gb-1tb-ssd-rtx3070-144hz-free-dos-15-6-fhd-tasinabilir-bilgisayar-4h0r8ea-p-HBCV000026164C",
                            Price = 29876f,
                            ProductId = 77,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 239,
                            Link = "https://www.trendyol.com/hp/4h0r8ea-omen-15-en1018nt-r7-5800h-16gb-1tb-ssd-rtx3070-15-6-free-dos-p-298425048?boutiqueId=613344&merchantId=124551",
                            Price = 28733f,
                            ProductId = 77,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 240,
                            Link = "https://www.n11.com/urun/hp-omen-15-en1018nt-4h0r8ea-r7-5800h-16-gb-1-tb-ssd-rtx3070-144hz-156-dos-fhd-dizustu-bilgisayar-4499101?magaza=garajonline",
                            Price = 28333f,
                            ProductId = 77,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 241,
                            Link = "https://www.hepsiburada.com/hp-zbook-studio-g8-intel-core-i7-11800h-16-gb-512-gb-ssd-t1200-windows-10-pro-15-6-fhd-tasinabilir-is-istasyonu-314f7ea-p-HBCV00000ZNRNH",
                            Price = 47499f,
                            ProductId = 78,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 242,
                            Link = "https://www.trendyol.com/hp/zbook-studio-g8-i7-11800h-16gb-512gb-ssd-t1200-w10p-15-6-fhd-tasinabilir-is-istasyonu-314f7ea-p-197143103?boutiqueId=613344&merchantId=114271",
                            Price = 52999f,
                            ProductId = 78,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 243,
                            Link = "https://www.n11.com/urun/hp-ws-zbook-studio-g8-314f7ea-i7-11800h-16-gb-512-gb-ssd-t1200-156-w10p-fhd-dizustu-bilgisayar-2153869?magaza=vesmark",
                            Price = 45999f,
                            ProductId = 78,
                            Rate = 4f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 244,
                            Link = "https://www.hepsiburada.com/hp-255-g8-amd-ryzen-5-5500u-8gb-256gb-ssd-windows-10-home-15-6-fhd-tasinabilir-bilgisayar-4p3k9es-p-HBCV0000188NQL",
                            Price = 9888f,
                            ProductId = 79,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 245,
                            Link = "https://www.trendyol.com/hp/255-g8-4p3k9es-ryzen-5-5500u-8-gb-256-gb-ssd-15-6-w10h-dizustu-bilgisayar-p-219061963?boutiqueId=613344&merchantId=124635",
                            Price = 9800f,
                            ProductId = 79,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 246,
                            Link = "https://www.n11.com/urun/hp-255-g8-4p3k9es-ryzen-5-5500u-8-gb-256-gb-ssd-156-w10h-dizustu-bilgisayar-2408772?magaza=kocpa",
                            Price = 9999f,
                            ProductId = 79,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 247,
                            Link = "https://www.hepsiburada.com/hp-255-g8-amd-ryzen-7-5700u-8gb-512gb-ssd-windows-10-home-15-6-fhd-tasinabilir-bilgisayar-4p3m4es-p-HBCV000013SS8O",
                            Price = 10669f,
                            ProductId = 80,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 248,
                            Link = "https://www.trendyol.com/hp/255-g8-amd-ryzen-7-5700u-8gb-512gb-ssd-windows-10-home-15-6-fhd-tasinabilir-bilgisayar-4p3m4es-p-345571463?boutiqueId=613344&merchantId=514546",
                            Price = 11999f,
                            ProductId = 80,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 249,
                            Link = "https://www.n11.com/urun/hp-255-g8-4p3m4es-ryzen-7-5700u-8-gb-512-gb-ssd-156-w10h-fhd-dizustu-bilgisayar-2461607?magaza=by-pro",
                            Price = 11499f,
                            ProductId = 80,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 250,
                            Link = "https://www.hepsiburada.com/huawei-matebook-d15-intel-core-i7-1165g7-16gb-512gb-ssd-windows-11-home-15-6-tasinabilir-bilgisayar-p-HBCV00001GBB0E",
                            Price = 19299f,
                            ProductId = 81,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 251,
                            Link = "https://www.trendyol.com/huawei/matebook-d15-intel-core-i7-1165g7-16gb-512gb-ssd-windows-11-home-15-6-tasinabilir-bilgisayar-p-279707179?boutiqueId=61&merchantId=126144",
                            Price = 19899f,
                            ProductId = 81,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 252,
                            Link = "https://www.n11.com/urun/huawei-matebook-d15-i7-1165g7-16-gb-512-gb-156-w11h-fhd-dizustu-bilgisayar-2764823?magaza=pliples",
                            Price = 18599f,
                            ProductId = 81,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 253,
                            Link = "https://www.hepsiburada.com/huawei-matebook-d15-intel-core-i5-1135g7-8gb-256gb-ssd-windows-11-home-15-6-tasinabilir-bilgisayar-p-HBCV000027P76J",
                            Price = 11869f,
                            ProductId = 82,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 254,
                            Link = "https://www.trendyol.com/huawei/matebook-d15-11-nesil-core-i5-1135g7-8gb-256gb-ssd-15-6inc-w11-p-350156041?boutiqueId=61&merchantId=106202",
                            Price = 11519f,
                            ProductId = 82,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 255,
                            Link = "https://www.vatanbilgisayar.com/huawei-matebook-d15-11-nesil-core-i5-1135g7-8gb-256gb-ssd-15-6-w11.html",
                            Price = 12999f,
                            ProductId = 82,
                            Rate = 4f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 256,
                            Link = "https://www.hepsiburada.com/huawei-matebook-16s-intel-core-i9-12900h-16gb-1tb-ssd-windows-11-home-16-tasinabilir-bilgisayar-p-HBCV00002NKF5U",
                            Price = 39000f,
                            ProductId = 83,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 257,
                            Link = "https://www.trendyol.com/huawei/matebook-16s-i9-12900h-16gb-1tb-w11h-16-tasinabilir-bilgisayar-cref-x9611t-p-353594550?boutiqueId=61&merchantId=655835",
                            Price = 40999f,
                            ProductId = 83,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 258,
                            Link = "https://www.n11.com/urun/huawei-matebook-16s-cref-x9611t-i9-12900h-16-gb-1-tb-16-w11h-dizustu-bilgisayar-18539212?magaza=gokkusagibilgisayar",
                            Price = 33249f,
                            ProductId = 83,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 259,
                            Link = "https://www.trendyol.com/huawei/matebook-16-5-nesil-ryzen-7-5800h-16gb-512gb-ssd-16inc-w11-p-347593212?boutiqueId=61&merchantId=169540",
                            Price = 21699f,
                            ProductId = 84,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 260,
                            Link = "https://www.n11.com/urun/huawei-matebook-16-ryzen-7-5800h-16-gb-512-gb-16-w11h-dizustu-bilgisayar-4790654?magaza=fixsmart",
                            Price = 22899f,
                            ProductId = 84,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 261,
                            Link = "https://www.vatanbilgisayar.com/huawei-matebook-16-5-nesil-ryzen-7-5800h-16gb-512gb-ssd-16inc-w11.html",
                            Price = 21999f,
                            ProductId = 84,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 262,
                            Link = "https://www.hepsiburada.com/huawei-matebook-d15-intel-core-i3-1115g4-8gb-256gb-ssd-windows-11-home-15-6-tasinabilir-bilgisayar-p-HBCV00002F55U1",
                            Price = 10998f,
                            ProductId = 85,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 263,
                            Link = "https://www.trendyol.com/huawei/matebook-d15-intel-core-i3-1115g4-8gb-256gb-ssd-fhd-windows-11-home-p-302313191?boutiqueId=613344&merchantId=141868",
                            Price = 11990f,
                            ProductId = 85,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 264,
                            Link = "https://www.n11.com/urun/huawei-matebook-d15-i3-1115g4-8-gb-256-gb-ssd-w11h-fhd-dizustu-bilgisayar-5204869?magaza=tantech",
                            Price = 13299f,
                            ProductId = 85,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 265,
                            Link = "https://www.hepsiburada.com/huawei-matebook-d15-amd-ryzen-5-5500u-8gb-512gb-ssd-windows-11-home-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001D68DN",
                            Price = 12499f,
                            ProductId = 86,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 266,
                            Link = "https://www.trendyol.com/huawei/matebook-d15-amd-ryzen-5-5500u-8gb-512gb-ssd-gri-dizustu-bilgisayar-huawei-turkiye-garantili-p-235294620?boutiqueId=614790&merchantId=968",
                            Price = 12498f,
                            ProductId = 86,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 267,
                            Link = "https://www.n11.com/urun/huawei-matebook-d15-ryzen-5-5500u-8-gb-512-gb-ssd-156-w11h-fhd-dizustu-bilgisayar-2526404?magaza=websiniall",
                            Price = 12479f,
                            ProductId = 86,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 268,
                            Link = "https://www.hepsiburada.com/lenovo-thinkpad-e14-gen-2-intel-core-i7-1165g7-16gb-512gb-ssd-mx450-freedos-14-fhd-tasinabilir-bilgisayar-20ta0055tx-p-HBV000018NJOJ",
                            Price = 21649f,
                            ProductId = 87,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 269,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e14-gen-2-intel-core-i7-1165g7-16gb-512gb-ssd-mx450-freedos-14-fhd-20ta0055tx-p-344961607?boutiqueId=613901&merchantId=114271",
                            Price = 26599f,
                            ProductId = 87,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 270,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-e14-g2-20ta0055tx-i7-1165g7-16-gb-512-gb-ssd-mx450-14-free-dos-dizustu-bilgisayar-1719672?magaza=victory",
                            Price = 22647f,
                            ProductId = 87,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 271,
                            Link = "https://www.hepsiburada.com/lenovo-thinkpad-e15-g2-i7-1165g7-32-gb-1-tb-ssd-2gb-mx450-windows-11-pro-15-6-fhd-20tds02vtx053-p-HBCV0000210LNU",
                            Price = 27094f,
                            ProductId = 88,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 272,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e15-g2-i7-1165g7-32-gb-1-tb-ssd-2gb-mx450-windows-11-pro-15-6-fhd-20tds02vtx053-p-275929726?boutiqueId=613344&merchantId=114271",
                            Price = 27507f,
                            ProductId = 88,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 273,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-e15-g2-20tds02vtx053-i7-1165g7-32-gb-1-tb-ssd-2-gb-mx450-156-w11p-fhd-dizustu-bilgisayar-3548549?magaza=victory",
                            Price = 26417f,
                            ProductId = 88,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 274,
                            Link = "https://www.hepsiburada.com/lenovo-ideapad-l3-intel-core-i5-1135g7-8gb-512gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-82hl009ktx-p-HBCV000015UFU7",
                            Price = 12329f,
                            ProductId = 89,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 275,
                            Link = "https://www.trendyol.com/lenovo/l3-i5-1135g7-8gb-512gb-ssd-15-6-fhd-freedos-p-216600821?boutiqueId=613344&merchantId=106664",
                            Price = 11599f,
                            ProductId = 89,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 276,
                            Link = "https://www.n11.com/urun/lenovo-ideapad-l3-15itl6-82hl009ktx-i5-1135g7-8-gb-512-gb-ssd-156-free-dos-fhd-dizustu-bilgisayar-2529226?magaza=teknoraks",
                            Price = 11784f,
                            ProductId = 89,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 277,
                            Link = "https://www.hepsiburada.com/lenovo-thinkpad-e15-gen-2-intel-core-i5-1135g7-16gb-512gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-20td0045tx-p-HBV00001BOCXG",
                            Price = 17989f,
                            ProductId = 90,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 278,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e15-20td0045tx-i5-1135g7-16gb-512ssd-15-6-freedos-tasinabilir-bilgisayar-p-81814065?boutiqueId=613901&merchantId=133639",
                            Price = 17499f,
                            ProductId = 90,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 279,
                            Link = "https://www.n11.com/urun/lenovo-e15-g2-20td0045tx-i5-1135g7-16-gb-512-gb-ssd-156-free-dos-dizustu-bilgisayar-1741771?magaza=7renk",
                            Price = 17637f,
                            ProductId = 90,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 280,
                            Link = "https://www.hepsiburada.com/lenovo-thinkbook-15-g3-acl-amd-ryzen-7-5700u-8-gb-512-gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-21a40037tx-p-HBCV00001FQHVW",
                            Price = 11999f,
                            ProductId = 91,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 281,
                            Link = "https://www.trendyol.com/lenovo/thinkbook-15-g3-acl-amd-ryzen-7-5700u-8-gb-512-gb-ssd-freedos-15-6-fhd-21a40037tx-p-242445007?boutiqueId=614596&merchantId=106934",
                            Price = 12249f,
                            ProductId = 91,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 282,
                            Link = "https://www.n11.com/urun/lenovo-thinkbook-15-g3-acl-21a40037tx-r7-5700u-8-gb-512-gb-ssd-156-free-dos-fhd-dizustu-bilgisayar-2583504?magaza=gti-bilisim",
                            Price = 12199f,
                            ProductId = 91,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 283,
                            Link = "https://www.hepsiburada.com/lenovo-v14-g2-alc-amd-ryzen-3-5300u-4gb-256gb-ssd-free-dos-14-fhd-tasinabilir-bilgisayar-82kc0005tx-p-HBCV000015KM14",
                            Price = 6949f,
                            ProductId = 92,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 284,
                            Link = "https://www.trendyol.com/lenovo/14-v14-82kc0005tx-r3-5300u-4gb-ram-256gb-ssd-fdos-dizustu-bilgisayar-p-328929255?boutiqueId=61&merchantId=353047",
                            Price = 6699f,
                            ProductId = 92,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 285,
                            Link = "https://www.n11.com/urun/lenovo-v14-g2-alc-82kc0005tx-ryzen-3-5300u-4-gb-256-gb-ssd-14-free-dos-dizustu-bilgisayar-2418561?magaza=teknoraks",
                            Price = 6744f,
                            ProductId = 92,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 286,
                            Link = "https://www.hepsiburada.com/lenovo-thinkpad-l15-gen-2-intel-core-i7-1165g7-16gb-256gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-20x4s25a00-p-HBCV00001G95RK",
                            Price = 18499f,
                            ProductId = 93,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 287,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-l15-gen-2-intel-core-i7-1165g7-16gb-256gb-ssd-freedos-15-6-fhd-20x4s25a00-p-248172046?boutiqueId=613344&merchantId=106934",
                            Price = 18499f,
                            ProductId = 93,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 288,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-l15-gen-2-20x4s25a00-i7-1165g7-16-gb-256-gb-ssd-156-dos-fhd-dizustu-bilgisayar-2633630?magaza=gti-bilisim",
                            Price = 19248f,
                            ProductId = 93,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 289,
                            Link = "https://www.hepsiburada.com/lenovo-v15-gen2-amd-ryzen-5-5500u-8gb-256gb-ssd-15-6-freedos-fhd-tasinabilir-bilgisayar-82kd0042tx-p-HBCV00002QL8FO",
                            Price = 10749f,
                            ProductId = 94,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 290,
                            Link = "https://www.trendyol.com/lenovo/v15-82kd0042tx-ryzen5-5500u-8gb-256gb-15-6-freedos-tasinabilir-bilgisayar-p-330200798?boutiqueId=613344&merchantId=106664",
                            Price = 10198f,
                            ProductId = 94,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 291,
                            Link = "https://www.n11.com/urun/lenovo-v15-g2-alc-82kd0042tx-ryzen-5-5500u-8-gb-256-gb-156-free-dos-dizustu-bilgisayar-18593865?magaza=bizdehesapli",
                            Price = 10123f,
                            ProductId = 94,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 292,
                            Link = "https://www.hepsiburada.com/lenovo-v14-itl-gen2-intel-core-i5-1135g7-8gb-512gb-ssd-windows-10-home-14-fhd-tasinabilir-bilgisayar-82ka0027tx-p-HBCV00000QK2IA",
                            Price = 10999f,
                            ProductId = 95,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 293,
                            Link = "https://www.trendyol.com/lenovo/v14-intel-core-i5-1135g7-8gb-512gb-ssd-win10h-14-fhd-82ka0027tx-microsoft-365-bireysel-1-yil-p-349491254?boutiqueId=613344&merchantId=104683",
                            Price = 12499f,
                            ProductId = 95,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 294,
                            Link = "https://www.n11.com/urun/lenovo-v14-g2-82ka0027tx-i5-1135g7-8-gb-512-gb-ssd-14-w10h-dizustu-bilgisayar-2136196?magaza=garajonline",
                            Price = 11943f,
                            ProductId = 95,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 295,
                            Link = "https://www.hepsiburada.com/lenovo-ideapad-5-15alc05-ryzen-5-5500u-8gb-512gb-ssd-15-6-fhd-freedos-tasinabilir-bilgisayar-82ln00cctx-p-HBCV00002LFSBG",
                            Price = 11999f,
                            ProductId = 96,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 296,
                            Link = "https://www.trendyol.com/lenovo/ideapad-5-15alc05-ryzen-5-5500u-8gb-512gb-ssd-15-6-fhd-freedos-82ln00cctx-p-321675354?boutiqueId=614596&merchantId=365957",
                            Price = 10790f,
                            ProductId = 96,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 297,
                            Link = "https://www.n11.com/urun/lenovo-ideapad-5-82ln00cctx-15alc05-ryzen-5-5500u-8-gb-512-gb-ssd-156-free-dos-dizustu-bilgisayar-19194143?magaza=gti-bilisim",
                            Price = 11799f,
                            ProductId = 96,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 298,
                            Link = "https://www.hepsiburada.com/lenovo-v15-intel-core-i5-10210u-8gb-512gb-ssd-mx330-15-6-fhd-windows-10-home-tasinabilir-bilgisayar-82nb003gtx-p-HBCV00002KOPVF",
                            Price = 13868f,
                            ProductId = 97,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 299,
                            Link = "https://www.trendyol.com/lenovo/v15-82nb003gtx-i5-10210u-8gb-512gb-mx330-ssd-15-6-fhd-windows-10-home-dizustu-bilgisayar-p-320147814?boutiqueId=61&merchantId=530815",
                            Price = 11879f,
                            ProductId = 97,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 300,
                            Link = "https://www.n11.com/urun/lenovo-v15-iml-82nb003gtx-i5-10210u-8-gb-512-gb-ssd-156-w10h-fhd-dizustu-bilgisayar-15584659?magaza=noontek-market",
                            Price = 13642f,
                            ProductId = 97,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 301,
                            Link = "https://www.hepsiburada.com/lenovo-ideapad-3-amd-ryzen-7-5700u-20gb-512gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-82ku00vntxa7-p-HBCV00002HU8HT",
                            Price = 13198f,
                            ProductId = 98,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 302,
                            Link = "https://www.trendyol.com/lenovo/lenovo-ideapad-3-amd-ryzen-7-5700u-20gb-512gb-ssd-freedos-15-6-82ku00vntxa7-p-318334271?boutiqueId=613344&merchantId=155616",
                            Price = 13213f,
                            ProductId = 98,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 303,
                            Link = "https://www.n11.com/urun/lenovo-ideapad-3-15alc6-82ku00vntxa7-r7-5700u-20-gb-512-gb-ssd-156-dos-dizustu-bilgisayar-17297317?magaza=arcadia-bilisim",
                            Price = 13041f,
                            ProductId = 98,
                            Rate = 4f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 304,
                            Link = "https://www.hepsiburada.com/lenovo-v14-amd-ryzen-3-5300u-8gb-256gb-ssd-freedos-14-fhd-tasinabilir-bilgisayar-82kc0005tx02-p-HBCV00001CA4Y1",
                            Price = 7499f,
                            ProductId = 99,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 305,
                            Link = "https://www.trendyol.com/lenovo/v14-82kc0005tx02-ryzen3-5300u-8gb-256ssd-14-fullhd-freedos-tasinabilir-bilgisayar-p-230412820?boutiqueId=613344&merchantId=106664",
                            Price = 7298f,
                            ProductId = 99,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 306,
                            Link = "https://www.n11.com/urun/lenovo-v14-g2-alc-82kc0005tx02-ryzen-3-5300u-8-gb-256-gb-ssd-14-free-dos-dizustu-bilgisayar-2507911?magaza=teknoraks",
                            Price = 7152f,
                            ProductId = 99,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 307,
                            Link = "https://www.hepsiburada.com/lenovo-ideapad-gaming-3-intel-core-i7-11390h-16gb-512gb-ssd-rtx-3050ti-freedos-15-6-fhd-tasinabilir-bilgisayar-82k100kdtx-p-HBCV00001VQ5V3",
                            Price = 22699f,
                            ProductId = 100,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 308,
                            Link = "https://www.trendyol.com/lenovo/ideapad-gaming-3-82k100kdtx-i7-11390h-16gb-512ssd-rtx3050ti-15-6-fullhd-freedos-tasinabilir-p-350373229?boutiqueId=613901&merchantId=106664",
                            Price = 27498f,
                            ProductId = 100,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 309,
                            Link = "https://www.n11.com/urun/lenovo-ip-gaming-3-82k100kdtx-i7-11390h-16-gb-512-gb-ssd-rtx3050ti-156-dos-fhd-dizustu-bilgisayar-2882785?magaza=gti-bilisim",
                            Price = 23499f,
                            ProductId = 100,
                            Rate = 4f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 310,
                            Link = "https://www.hepsiburada.com/lenovo-thinkpad-x1-nano-gen-1-intel-core-i7-1160g7-16gb-512gb-ssd-windows-10-pro-13-2k-uhd-tasinabilir-bilgisayar-20un002ttx-p-HBCV000006KEFA",
                            Price = 43857f,
                            ProductId = 101,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 311,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-x1-nano-gen-1-intel-i7-1160g7-16gb-512gb-ssd-windows-10-pro-13-2k-uhd-20un002ttx-p-106242986?boutiqueId=613344&merchantId=107092",
                            Price = 46642f,
                            ProductId = 101,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 312,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-x1-nano-g1-20un002ttx-i7-1160g7-16-gb-512-gb-ssd-13-2k-w10p-dizustu-bilgisayar-2162228?magaza=victory",
                            Price = 44060f,
                            ProductId = 101,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 313,
                            Link = "https://www.hepsiburada.com/lenovo-legion-5-intel-core-i7-11800h-16gb-512gb-ssd-rtx3060-freedos-17-3-fhd-tasinabilir-bilgisayar-82jm0013tx-p-HBCV00002LBY9Z",
                            Price = 30999f,
                            ProductId = 102,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 314,
                            Link = "https://www.trendyol.com/lenovo/legion5intel-corei7-11800h-16gb-512gb-ssd-rtx3060-6gb-dos-17-3-fhd-82jm0013tx-p-329375305?boutiqueId=614724&merchantId=124551",
                            Price = 30515f,
                            ProductId = 102,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 315,
                            Link = "https://www.n11.com/urun/lenovo-legion-5-82jm0013tx-i7-11800h-16-gb-512-gb-rtx3060-144hz-173-dos-fhd-dizustu-bilgisayar-14692173?magaza=garajonline",
                            Price = 30766f,
                            ProductId = 102,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 316,
                            Link = "https://www.hepsiburada.com/lenovo-v15-iil-intel-core-i5-1035g1-4gb-512gb-ssd-mx330-freedos15-6-fhd-tasinabilir-bilgisayar-82c500r2tx-p-HBV000014SZYX",
                            Price = 11798f,
                            ProductId = 103,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 317,
                            Link = "https://www.trendyol.com/lenovo/v15-iil-i5-1035g1-4gb-512gb-ssd-2gb-15-6-fd-82c500r2tx-p-69135550?boutiqueId=613344&merchantId=552118",
                            Price = 11899f,
                            ProductId = 103,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 318,
                            Link = "https://www.n11.com/urun/lenovo-v15-iil-82c500r2tx-i5-1035g1-4-gb-512-gb-ssd-2-gb-mx330-156-free-dos-dizustu-bilgisayar-1688187?magaza=aptekteknoloji",
                            Price = 11759f,
                            ProductId = 103,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 319,
                            Link = "https://www.hepsiburada.com/lenovo-ideapad-3-amd-ryzen-7-5700u-20gb-512gb-ssd-windows-11-pro-15-6-fhd-tasinabilir-bilgisayar-82ku00vntxa147-p-HBCV00002HU9CL",
                            Price = 14723f,
                            ProductId = 104,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 320,
                            Link = "https://www.trendyol.com/lenovo/ideapad-3-amd-ryzen-7-5700u-20gb-512gb-ssd-windows-11-pro-15-6-82ku00vntxa147-p-321488466?boutiqueId=613344&merchantId=155616",
                            Price = 14751f,
                            ProductId = 104,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 321,
                            Link = "https://www.n11.com/urun/lenovo-ideapad-3-15alc6-82ku00vntxa147-r7-5700u-20-gb-512-gb-ssd-156-w11p-dizustu-bilgisayar-17297207?magaza=arcadia-bilisim",
                            Price = 14549f,
                            ProductId = 104,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 322,
                            Link = "https://www.hepsiburada.com/lenovo-v15-gen2-alc-ryzen3-5300u-12gb-ram-256gb-ssd-freedos-tasinabilir-bilgisayar-p-HBCV00002XMJPH",
                            Price = 9199f,
                            ProductId = 105,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 323,
                            Link = "https://www.trendyol.com/lenovo/v15-g2-alc-82kd004atx-amd-ryzen-3-5300u-12gb-256gb-ssd-o-b-vga-15-6-freedos-noteb-p-206644770?boutiqueId=613344&merchantId=183932",
                            Price = 10035f,
                            ProductId = 105,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 324,
                            Link = "https://www.n11.com/urun/lenovo-v15-g2-alc-82kd004atx-r3-5300u-12-gb-256-gb-ssd-156-free-dos-dizustu-bilgisayar-2308751?magaza=nesiltech",
                            Price = 10201f,
                            ProductId = 105,
                            Rate = 4f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 325,
                            Link = "https://www.hepsiburada.com/lenovo-v14-g2-itl-intel-core-i5-1135g7-4gb-256gb-ssd-freedos-14-fhd-tasinabilir-bilgisayar-82ka0026tx-p-HBCV00001XJRAO",
                            Price = 9999f,
                            ProductId = 106,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 326,
                            Link = "https://www.trendyol.com/lenovo/v14-g2-itl-i5-1135g7-4gb-256gb-ssd-freedos-14-fhd-82ka0026tx-p-271400033?boutiqueId=613344&merchantId=107204",
                            Price = 9899f,
                            ProductId = 106,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 327,
                            Link = "https://www.n11.com/urun/lenovo-v14-g2-itl-82ka0026tx-i5-1135g7-4-gb-256-gb-ssd-14-free-dos-fhd-dizustu-bilgisayar-3198735?magaza=bisistem",
                            Price = 10201f,
                            ProductId = 106,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 328,
                            Link = "https://www.hepsiburada.com/lenovo-e15-gen-2-intel-core-i7-1165g7-16gb-512gb-ssd-mx450-2gb-freedos-15-6-fhd-tasinabilir-bilgisayar-20td004ktx-p-HBV00001B6I4X",
                            Price = 21999f,
                            ProductId = 107,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 329,
                            Link = "https://www.trendyol.com/lenovo/e15-20td004ktx-i7-1165g7-16gb-512ssd-2gb-15-6-fullhd-freedos-tasinabilir-bilgisayar-p-81812830?boutiqueId=613344&merchantId=105378",
                            Price = 22289f,
                            ProductId = 107,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 330,
                            Link = "https://www.n11.com/urun/lenovo-e15-g2-20td004ktx-i7-1165g7-16-gb-512-gb-ssd-2-gb-mx450-free-dos-dizustu-bilgisayar-1752008?magaza=victory",
                            Price = 21824f,
                            ProductId = 107,
                            Rate = 2f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 331,
                            Link = "https://www.hepsiburada.com/lenovo-ideapad-3-15itl6-intel-core-i7-1165g7-8gb-512gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-82h802f7tx-p-HBCV00002LBPG3",
                            Price = 13899f,
                            ProductId = 108,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 332,
                            Link = "https://www.trendyol.com/lenovo/ideapad-3-15itl6-intel-core-i7-1165g7-8gb-512gb-ssd-freedos-15-6-fhd-82h802f7tx-p-320139493?boutiqueId=614595&merchantId=106934",
                            Price = 15542f,
                            ProductId = 108,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 333,
                            Link = "https://www.n11.com/urun/lenovo-ideapad-3-15itl6-82h802f7tx-i7-1165g7-8-gb-512-gb-ssd-156-dos-fhd-dizustu-bilgisayar-14717585?magaza=gti-bilisim",
                            Price = 14399f,
                            ProductId = 108,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 334,
                            Link = "https://www.hepsiburada.com/msi-summit-e13-flip-evo-a11mt-232tr-intel-core-i7-1195g7-16gb-512gb-ssd-windows-10-pro-13-4-fhd-tasinabilir-bilgisayar-p-HBCV0000161E5T",
                            Price = 29999f,
                            ProductId = 109,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 335,
                            Link = "https://www.trendyol.com/msi/summit-e13-flip-evo-a11mt-232tr-i7-1195g7-16gb-lpddr4-512gb-ssd-13-4-fhd-touch-w10p-p-220033945?boutiqueId=613344&merchantId=118442",
                            Price = 32399f,
                            ProductId = 109,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 336,
                            Link = "https://www.n11.com/urun/msi-summit-e13-flip-evo-a11mt-232tr-i7-1195g7-16-gb-512-gb-134-w10p-dizustubluetooth-mousem98-box-19594615?magaza=techburada",
                            Price = 38099f,
                            ProductId = 109,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 337,
                            Link = "https://www.trendyol.com/msi/titan-gt77-12uhs-036tr-i9-12900hx-64gb-ddr5-rtx3080ti-gddr6-16gb-2tb-ssd-17-3-uhd-120hz-w11-p-312672514?boutiqueId=613344&merchantId=106740",
                            Price = 121959f,
                            ProductId = 110,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 338,
                            Link = "https://www.n11.com/urun/msi-titan-gt77-12uhs-036tr-i9-12900hx-64-gb-2-tb-ssd-rtx3080ti-120hz-173-w11h-dizustu-bilgisayar-10053496?magaza=techburada",
                            Price = 128931f,
                            ProductId = 110,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 339,
                            Link = "https://www.vatanbilgisayar.com/msi-gt77-titan-12-nesil-core-i9-12900hx-64gb-2tb-ssd-17-3inc-rtx3080ti-16gb-w11.html",
                            Price = 126476f,
                            ProductId = 110,
                            Rate = 5f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 340,
                            Link = "https://www.hepsiburada.com/msi-pulse-gl76-12uek-247xtr-intel-core-i7-12700h-16-gb-1-tb-ssd-rtx3060-freedos-17-3-fhd-tasinabilir-bilgisayar-p-HBCV00001XMTJH",
                            Price = 44849f,
                            ProductId = 111,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 341,
                            Link = "https://www.trendyol.com/msi/pulse-gl76-12uek-247xtr-i7-12700h-16gb-ddr4-rtx3060-gddr6-6gb-1tb-ssd-17-3-fhd-144hz-dos-p-274361591?boutiqueId=613344&merchantId=106740",
                            Price = 45499f,
                            ProductId = 111,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 342,
                            Link = "https://www.n11.com/urun/msi-pulse-gl76-12uek-247xtr-v1-i7-12700h-16-gb-1-tb-ssd-rtx3060-144hz-173-fhd-dos-fhd-dizustu-bilgisayar-18777328?magaza=dey-elektronik",
                            Price = 45029f,
                            ProductId = 111,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 343,
                            Link = "https://www.hepsiburada.com/asus-tuf-gaming-fa507rm-hn052-amd-ryzen-7-6800h-16gb-512gb-ssd-rtx3060-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV000022CJTT",
                            Price = 32399f,
                            ProductId = 112,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 344,
                            Link = "https://www.trendyol.com/asus/tuf-gaming-a15-fa507rm-hn052-ryzen7-6800h-16gb-512ssd-rtx3060-15-6-fullhd-freedos-tasinabilir-p-359035389?boutiqueId=613901&merchantId=106664",
                            Price = 31539f,
                            ProductId = 112,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 345,
                            Link = "https://www.hepsiburada.com/asus-rog-strix-g15-g513rm-hf265-ryzen-7-6800h-16gb-ddr5-ram-512gb-ssd-6gb-rtx3060-15-6-fhd-300hz-tasinabilir-bilgisayar-p-HBCV00002D5X2N",
                            Price = 32499f,
                            ProductId = 113,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 346,
                            Link = "https://www.n11.com/urun/asus-rog-strix-g15-g513rm-hf265-r7-6800h-16-gb-512-gb-ssd-rtx3060-300hz-156-dos-dizustu-bilgisayar-7057945?magaza=gpnteknoloji",
                            Price = 32599f,
                            ProductId = 113,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 347,
                            Link = "https://www.hepsiburada.com/asus-rog-strix-g15-g513rm-hf266-ryzen-7-6800h-16gb-ddr5-ram-512gb-ssd-6gb-rtx3060-15-6-inc-fhd-300hz-tasinabilir-bilgisayar-p-HBCV00002H2C73",
                            Price = 32499f,
                            ProductId = 114,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 348,
                            Link = "https://www.n11.com/urun/asus-rog-strix-g15-g513rm-hf266-r7-6800h-16-gb-512-gb-ssd-rtx3060-300hz-156-dos-dizustu-bilgisayar-11576167?magaza=gpnteknoloji",
                            Price = 32499f,
                            ProductId = 114,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 349,
                            Link = "https://www.trendyol.com/asus/rog-strix-g15-g513rw-hf208-r7-6800h-16gb-1tb-ssd-rtx-3070ti-300hz-dos-15-6-fhd-notebook-p-316653228?boutiqueId=613344&merchantId=106740",
                            Price = 41899f,
                            ProductId = 115,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 350,
                            Link = "https://www.n11.com/urun/asus-rog-strix-g15-g513rw-hf208-r7-6800h-16-gb-1-tb-ssd-rtx3070ti-300hz-156-dos-dizustu-bilgisayar-12998179?magaza=teknoryabilisim",
                            Price = 44198f,
                            ProductId = 115,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 351,
                            Link = "https://www.trendyol.com/asus/rog-strix-g15-g513rw-hf206-ryzen-7-6800h-16gb-ddr5-ram-1tb-ssd-8gb-rtx3070ti-15-6-fhd-300hz-p-313749564?boutiqueId=613344&merchantId=118442",
                            Price = 41999f,
                            ProductId = 116,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 352,
                            Link = "https://www.n11.com/urun/asus-rog-strix-g15-g513rw-hf206-r7-6800h-16-gb-1-tb-ssd-rtx3070ti-300hz-156-dos-dizustu-bilgisayar-11167400?magaza=gpnteknoloji",
                            Price = 42499f,
                            ProductId = 116,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 353,
                            Link = "https://www.trendyol.com/asus/tuf-gaming-a15-fa507rm-hn096-ryzen-7-6800h-16gb-ram-512gb-ssd-6gb-rtx3060-15-6-inc-fhd-144hz-p-314501434?boutiqueId=61&merchantId=118442",
                            Price = 27499f,
                            ProductId = 117,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 354,
                            Link = "https://www.n11.com/urun/asus-tuf-gaming-a15-fa507rm-hn096-r7-6800h-16-gb-512-gb-ssd-rtx3060-144hz-156-dos-dizustu-bilgisayar-11849557?magaza=gpnteknoloji",
                            Price = 27999f,
                            ProductId = 117,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 355,
                            Link = "https://www.hepsiburada.com/asus-d515da-bq9801-ryzen-3-3250u-8gb-256gb-ssd-15-6-fhd-freedos-p-HBCV00002YYZOI",
                            Price = 7923f,
                            ProductId = 118,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 356,
                            Link = "https://www.trendyol.com/asus/d515da-bq9801-ryzen-3-3250u-8gb-256gb-ssd-15-6-fhd-freedos-p-358126667?boutiqueId=61&merchantId=105378",
                            Price = 7869f,
                            ProductId = 118,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 357,
                            Link = "https://www.hepsiburada.com/asus-amd-ryzen-3-3250u-8-gb-256-gb-ssd-freedos-15-6-tasinabilir-bilgisayar-d515da-br114201-p-HBCV000014TENS",
                            Price = 7199f,
                            ProductId = 119,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 358,
                            Link = "https://www.trendyol.com/asus/amd-ryzen-3-3250u-8gb-256gb-ssd-freedos-15-6-tasinabilir-bilgisayar-d515da-br114201-p-214686714?boutiqueId=61&merchantId=409439",
                            Price = 8888f,
                            ProductId = 119,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 359,
                            Link = "https://www.trendyol.com/asus/d515da-ej1426-ryzen-3-3250u-8gb-256gb-ssd-15-6-full-hd-freedos-notebook-p-284583898?boutiqueId=61&merchantId=105061",
                            Price = 9156f,
                            ProductId = 120,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 360,
                            Link = "https://www.n11.com/urun/asus-d515da-ej1426-ryzen-3-3250u-8-gb-256-gb-ssd-156-free-dos-fhd-dizustu-bilgisayar-4190042?magaza=exen",
                            Price = 8063f,
                            ProductId = 120,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 361,
                            Link = "https://www.hepsiburada.com/asus-d515da-br125-amd-ryzen-3-3250u-4gb-256gb-ssd-freedos-15-6-tasinabilir-bilgisayar-p-HBCV00000026CF",
                            Price = 6899f,
                            ProductId = 121,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 362,
                            Link = "https://www.n11.com/urun/asus-d515da-br125-amd-ryzen-3-3250u-4-gb-256-gb-ssd-156-free-dos-dizustu-bilgisayar-1776156?magaza=webdensin",
                            Price = 6899f,
                            ProductId = 121,
                            Rate = 4f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 363,
                            Link = "https://www.hepsiburada.com/asus-d515da-ej819-amd-ryzen-3-3250u-4-gb-256-ssd-15-6-fhd-freedos-tasinabilir-bilgisayar-p-HBCV000029O9M6",
                            Price = 6859f,
                            ProductId = 122,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 364,
                            Link = "https://www.trendyol.com/asus/d515da-ej819-amd-ryzen-3-3250u-4-gb-256-ssd-15-6-fhd-freedos-notebook-p-303398482?boutiqueId=613344&merchantId=313585",
                            Price = 6884f,
                            ProductId = 122,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 365,
                            Link = "https://www.trendyol.com/asus/d515da-br408-amd-ryzen-3-3250u-4gb-ram-256gb-ssd-freedos-15-6-hd-p-165214439?boutiqueId=61&merchantId=104683",
                            Price = 6999f,
                            ProductId = 123,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 366,
                            Link = "https://www.n11.com/urun/asus-d515da-br408-ryzen-3-3250u-4-gb-256-gb-ssd-156-free-dos-hd-dizustu-bilgisayar-2181368?magaza=teknolojimarketatm",
                            Price = 6998f,
                            ProductId = 123,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 367,
                            Link = "https://www.trendyol.com/asus/rog-strix-g15-g513ie-hn085-r7-4800h-16-gb-1tb-ssd-rtx3050ti-144hz-dos-15-6-fhd-canta-ve-mouse-p-356455662?boutiqueId=61&merchantId=106740",
                            Price = 23899f,
                            ProductId = 124,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 368,
                            Link = "https://www.n11.com/urun/asus-rog-strix-g15-g513ie-hn085-r7-4800h-16-gb-1-tb-ssd-rtx3050ti-156-144-hz-dos-dizustu-bilgisayar-19589207?magaza=teknoryabilisim",
                            Price = 25156f,
                            ProductId = 124,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 369,
                            Link = "https://www.hepsiburada.com/asus-rog-strix-g15-g513ic-hn096-amd-ryzen-7-4800h-16gb-1-tb-ssd-rtx3050-144-hz-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00002ERGXZ",
                            Price = 21999f,
                            ProductId = 125,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 370,
                            Link = "https://www.trendyol.com/asus/rog-strix-g15-g513ic-hn096-r7-4800h-16gb-1tb-ssd-rtx3050-144hz-dos-15-6-fhd-dizustu-bilgisayar-p-311539369?boutiqueId=613344&merchantId=106740",
                            Price = 22399f,
                            ProductId = 125,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 371,
                            Link = "https://www.trendyol.com/asus/rog-strix-g15-g513ic-hn049-ryzen-7-4800h-16gb-ram-1tb-ssd-4gb-rtx3050-15-6-inc-fhd-144hz-p-313746774?boutiqueId=613344&merchantId=118442",
                            Price = 28999f,
                            ProductId = 126,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 372,
                            Link = "https://www.n11.com/urun/asus-rog-strix-g15-g513ic-hn049-r7-4800h-16-gb-1-tb-ssd-rtx3050-144hz-156-dos-fhd-dizustu-bilgisayar-11167433?magaza=gpnteknoloji",
                            Price = 28274f,
                            ProductId = 126,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 373,
                            Link = "https://www.hepsiburada.com/asus-x509ua-ej073-intel-core-i3-7020u-4gb-256gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV000014ES3G",
                            Price = 7715f,
                            ProductId = 127,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 374,
                            Link = "https://www.n11.com/urun/asus-x509ua-ej073-i3-7020u-4-gb-256-gb-ssd-156-free-dos-fhd-dizustu-bilgisayar-2177777?magaza=softtekteknoloji",
                            Price = 7993f,
                            ProductId = 127,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 375,
                            Link = "https://www.hepsiburada.com/asus-tuf-gaming-a15-fx506lhb-hn348-intel-core-i5-10300h-8-gb-512-gb-ssd-gtx-1650-144-hz-freedos-15-6-fhd-tasinabilir-bilgisayar-canta-ve-mouse-p-HBCV00002Y1YS9",
                            Price = 15899f,
                            ProductId = 128,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 376,
                            Link = "https://www.trendyol.com/asus/tuf-gaming-f15-fx506lhb-hn348-i5-10300h-8gb-512gb-ssd-gtx1650-144hz-dos-15-6-fhd-notebook-p-343452934?boutiqueId=61&merchantId=106740",
                            Price = 15699f,
                            ProductId = 128,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 377,
                            Link = "https://www.trendyol.com/asus/tuf-gaming-f15-fx506lhb-hn345-i5-10300h-8gb-ram-512gb-ssd-4gb-gtx1650-15-6-inc-fhd-144hz-p-362050907?boutiqueId=61&merchantId=118442",
                            Price = 15999f,
                            ProductId = 129,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 378,
                            Link = "https://www.n11.com/urun/asus-f15-fx506lhb-hn345-i5-10300h-8-gb-512-gb-ssd-gtx1650-144hz-156-dos-dizustu-bilgisayar-24952524?magaza=gpnteknoloji",
                            Price = 15999f,
                            ProductId = 129,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 379,
                            Link = "https://www.hepsiburada.com/asus-tuf-gaming-fx506lhb-hn323-intel-core-i5-10300h-8gb-512gb-ssd-gtx1650-freedos-15-6-tasinabilir-bilgisayar-p-HBCV000028VLR2",
                            Price = 17472f,
                            ProductId = 130,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 380,
                            Link = "https://www.trendyol.com/asus/tuf-gaming-fx506lhb-hn323-intel-core-i5-10300h-8gb-512gb-ssd-gtx1650-freedos-15-6-p-313771149?boutiqueId=613344&merchantId=673006",
                            Price = 17225f,
                            ProductId = 130,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 381,
                            Link = "https://www.hepsiburada.com/asus-tuf-gaming-f15-fx506lhb-hn348-intel-core-i5-10300h-8-gb-512-gb-ssd-gtx-1650-144-hz-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00002SQX6P",
                            Price = 18999f,
                            ProductId = 131,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 382,
                            Link = "https://www.n11.com/urun/asus-tuf-gaming-f15-fx506lhb-hn348-i5-10300h-8-gb-512-gb-ssd-gtx1650-156-144-hz-dos-dizustu-bilgisayar-19589265?magaza=teknoryabilisim",
                            Price = 15089f,
                            ProductId = 131,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 383,
                            Link = "https://www.trendyol.com/asus/x515ea-11-nesil-core-i5-1135g7-8gb-256gb-ssd-15-6inc-freedos-p-350156348?boutiqueId=61&merchantId=624588",
                            Price = 10499f,
                            ProductId = 132,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 384,
                            Link = "https://www.vatanbilgisayar.com/asus-x515ea-11-nesil-core-i5-1135g7-8gb-256gb-ssd-15-6inc-freedos.html",
                            Price = 10599f,
                            ProductId = 132,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 385,
                            Link = "https://www.hepsiburada.com/asus-x415ea-eb976-intel-core-i5-1135g7-8gb-256gb-ssd-freedos-14-fhd-tasinabilir-bilgisayar-p-HBCV00001QQMBY",
                            Price = 10938f,
                            ProductId = 133,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 386,
                            Link = "https://www.trendyol.com/asus/x415ea-eb976-i5-1135g7-8gb-256ssd-14-fullhd-freedos-tasinabilir-bilgisayar-p-313614693?boutiqueId=613344&merchantId=194340",
                            Price = 10299f,
                            ProductId = 133,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 387,
                            Link = "https://www.hepsiburada.com/asus-vivobook-15-oled-k513ep-intel-core-i5-1135g7-16gb-512gb-ssd-mx330-freedos-15-6-fhd-tasinabilir-bilgisayar-l157602-p-HBCV00002EFMG3",
                            Price = 15970f,
                            ProductId = 134,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 388,
                            Link = "https://www.trendyol.com/asus/vivobook-15-oled-k513ep-intel-core-i5-1135g7-16gb-512gb-ssd-mx330-freedos-15-6-fhd-l157602-p-345144522?boutiqueId=613344&merchantId=653256",
                            Price = 15799f,
                            ProductId = 134,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 389,
                            Link = "https://www.hepsiburada.com/asus-vivobook-k513epa4-l1576a4-intel-core-i5-1135g7-16gb-512gb-ssd-mx330-freedos-15-6-fhd-oled-tasinabilir-bilgisayar-p-HBCV00002U70UI",
                            Price = 15924f,
                            ProductId = 135,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 390,
                            Link = "https://www.trendyol.com/asus/vivobook-k513epa4-l1576a4-intel-core-i5-1135g7-16gb-512gb-ssd-mx330-freedos-15-6-p-349816147?boutiqueId=613344&merchantId=155616",
                            Price = 15665f,
                            ProductId = 135,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 391,
                            Link = "https://www.trendyol.com/asus/i5-1135g7-16gb-512-gb-iris-xe-graphics-15-6-fhd-freedos-x515ea-ej122927-p-251095112?boutiqueId=613344&merchantId=107092",
                            Price = 13058f,
                            ProductId = 136,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 392,
                            Link = "https://www.n11.com/urun/asus-x515ea-ej122927-i5-1135g7-16-gb-512-gb-156-free-dos-fhd-dizustu-bilgisayar-2691512?magaza=b-t-teknoloji",
                            Price = 13067f,
                            ProductId = 136,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 393,
                            Link = "https://www.hepsiburada.com/asus-x515ja-ej2112w-intel-i3-1005g1-4gb-256-sdd-w11-15-6-inc-tasinabilir-bilgisayar-p-HBCV00002PZYKE",
                            Price = 7949f,
                            ProductId = 137,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 394,
                            Link = "https://www.trendyol.com/asus/x515ja-ej2112w-core-i3-1005g1-4gb-ram-256gb-ssd-15-6-win-11-laptop-gri-p-313134235?boutiqueId=61&merchantId=115178",
                            Price = 7486f,
                            ProductId = 137,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 395,
                            Link = "https://www.hepsiburada.com/asus-x515ja-ej2137w-intel-core-i3-1005g1-4-gb-256gb-ssd-15-6-windows-11-home-fhd-tasinabilir-bilgisayar-p-HBCV00002PEIXM",
                            Price = 7999f,
                            ProductId = 138,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 396,
                            Link = "https://www.trendyol.com/asus/x515ja-ej2137w-i3-1005g1-4gb-256ssd-15-6-fullhd-w11h-tasinabilir-bilgisayar-p-341072646?boutiqueId=61&merchantId=365547",
                            Price = 7900f,
                            ProductId = 138,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 397,
                            Link = "https://www.trendyol.com/asus/x509fa-10-nesil-core-i5-10210u-8gb-256gb-ssd-15-6-w10-p-257011715?boutiqueId=61&merchantId=624588",
                            Price = 14763f,
                            ProductId = 139,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 398,
                            Link = "https://www.vatanbilgisayar.com/asus-x509fa-core-i5-10210u-1-6ghz-8gb-ram-256gb-ssd-15-6-int-w10.html",
                            Price = 14724f,
                            ProductId = 139,
                            Rate = 4f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 399,
                            Link = "https://www.trendyol.com/asus/x515fa-ej053t-i5-10210u-8gb-ram-256gb-ssd-15-6-fhd-windows-10-home-laptop-gri-p-220049101?boutiqueId=61&merchantId=153715",
                            Price = 11399f,
                            ProductId = 140,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 400,
                            Link = "https://www.n11.com/urun/asus-x515fa-ej053t-i5-10210u-8-gb-256-gb-ssd-156-w10h-fhd-dizustu-bilgisayar-2525767?magaza=exen",
                            Price = 11481f,
                            ProductId = 140,
                            Rate = 4f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 401,
                            Link = "https://www.trendyol.com/asus/x509fa-ej1072t-intel-core-i5-10210u-8gb-ram-256gb-ssd-15-6-fhd-w10h-notebook-p-168664086?boutiqueId=613344&merchantId=107301",
                            Price = 11599f,
                            ProductId = 141,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 402,
                            Link = "https://www.n11.com/urun/asus-x509fa-ej1072t-i5-10210u-8-gb-256-gb-ssd-156-w10h-fhd-dizustu-bilgisayar-2460917?magaza=webdensin",
                            Price = 11499f,
                            ProductId = 141,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 403,
                            Link = "https://www.trendyol.com/asus/x515ea-11-nesil-core-i5-1135g7-8gb-512gb-ssd-15-6inc-w11-p-355662669?boutiqueId=61&merchantId=624588",
                            Price = 11999f,
                            ProductId = 142,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 404,
                            Link = "https://www.vatanbilgisayar.com/asus-x515ea-11-nesil-core-i5-1135g7-8gb-512gb-ssd-15-6inc-w11.html",
                            Price = 11999f,
                            ProductId = 142,
                            Rate = 5f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 405,
                            Link = "https://www.hepsiburada.com/asus-x515ea-bq1185w-intel-core-i5-1135g7-8gb-ram-512gb-ssd-15-6-fhd-windows11-convertible-gri-tasinabilir-bilgisayar-p-HBCV000030FZH1",
                            Price = 12254f,
                            ProductId = 143,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 406,
                            Link = "https://www.trendyol.com/asus/x515ea-bq1185w-intel-i5-1135g7-8gb-ram-512gb-ssd-iris-xe-15-6-fhd-ips-w11-notebook-p-349920496?boutiqueId=61&merchantId=531736",
                            Price = 11469f,
                            ProductId = 143,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 407,
                            Link = "https://www.trendyol.com/asus/vivobook-15-oled-11-nesil-core-i5-1135g7-8gb-512gb-ssd-15-6-mx330-2gb-w11-p-347781821?boutiqueId=613344&merchantId=624588",
                            Price = 17800f,
                            ProductId = 144,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 408,
                            Link = "https://www.vatanbilgisayar.com/asus-vivobook-15-oled-11-nesil-core-i5-1135g7-8gb-512gb-ssd-15-6-mx330-2gb-w11.html",
                            Price = 17961f,
                            ProductId = 144,
                            Rate = 5f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 409,
                            Link = "https://www.hepsiburada.com/asus-rog-strix-g513ie-hn065-amd-ryzen-7-4800h-16gb-512gb-ssd-rtx3050ti-freedos-15-6-tasinabilir-bilgisayar-p-HBCV00001E2064",
                            Price = 21999f,
                            ProductId = 145,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 410,
                            Link = "https://www.trendyol.com/asus/rog-strix-g15-g513ie-hn065-ryzen7-4800h-16gb-512ssd-rtx3050ti-15-6-fullhd-freedos-tasinabilir-p-340612238?boutiqueId=613344&merchantId=181127",
                            Price = 22299f,
                            ProductId = 145,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 411,
                            Link = "https://www.hepsiburada.com/asus-rog-strix-g513ie-hn065a8-amd-ryzen-7-4800h-32gb-1tb-ssd-freedos-rtx3050ti-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00002Y67YI",
                            Price = 25722f,
                            ProductId = 146,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 412,
                            Link = "https://www.trendyol.com/asus/rog-strix-g513ie-hn065a8-amd-ryzen-7-4800h-32gb-1tb-ssd-freedos-rtx3050ti-15-6-p-357954512?boutiqueId=61&merchantId=155616",
                            Price = 26389f,
                            ProductId = 146,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 413,
                            Link = "https://www.hepsiburada.com/asus-rog-strix-g513ie-hn065-amd-ryzen-7-4800h-32-gb-1-tb-ssd-rtx3050ti-freedos-15-6-fhd-tasinabilir-bilgisayar-hn06503-p-HBCV00002MPRDZ",
                            Price = 30085f,
                            ProductId = 147,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 414,
                            Link = "https://www.trendyol.com/asus/rog-strix-g513ie-hn065-amd-ryzen-7-4800h-32gb-1tb-ssd-rtx3050ti-freedos-15-6-fhd-hn06503-p-329717602?boutiqueId=613344&merchantId=106536",
                            Price = 30549f,
                            ProductId = 147,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 415,
                            Link = "https://www.hepsiburada.com/asus-tuf-gaming-fa507rm-hn052a5-amd-ryzen-7-6800h-32-gb-1-tb-ssd-rtx3060-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00002VTQZT",
                            Price = 33860f,
                            ProductId = 148,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 416,
                            Link = "https://www.trendyol.com/asus/tuf-gaming-fa507rm-hn052a5-amd-ryzen-7-6800h-32gb-1tb-ssd-rtx3060-freedos-15-6-p-350245330?boutiqueId=61&merchantId=155616",
                            Price = 34003f,
                            ProductId = 148,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 417,
                            Link = "https://www.hepsiburada.com/asus-x409fa-bv653-intel-core-i7-8565u-8gb-512gb-ssd-freedos-14-hd-tasinabilir-bilgisayar-p-HBCV000011E59A",
                            Price = 10944f,
                            ProductId = 149,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 418,
                            Link = "https://www.trendyol.com/asus/x409fa-bv653-i7-8565u-8gb-512gb-14-hd-dos-p-218676723?boutiqueId=613344&merchantId=107868",
                            Price = 11132f,
                            ProductId = 149,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 419,
                            Link = "https://www.hepsiburada.com/asus-d515da-bq9802-ryzen-3-3250u-12gb-256gb-ssd-15-6-fhd-freedos-p-HBCV00002YYZOK",
                            Price = 8273f,
                            ProductId = 150,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 420,
                            Link = "https://www.trendyol.com/asus/d515da-bq9802-ryzen-3-3250u-12gb-256gb-ssd-15-6-fhd-freedos-p-358114842?boutiqueId=61&merchantId=105378",
                            Price = 8229f,
                            ProductId = 150,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 421,
                            Link = "https://www.hepsiburada.com/asus-amd-ryzen-3-3250u-12-gb-256-gb-ssd-freedos-15-6-tasinabilir-bilgisayar-d515da-br114203-p-HBCV000014TENW",
                            Price = 7299f,
                            ProductId = 151,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 422,
                            Link = "https://www.trendyol.com/asus/amd-ryzen-3-3250u-12gb-256gb-ssd-freedos-15-6-tasinabilir-bilgisayar-d515da-br114203-p-214685541?boutiqueId=61&merchantId=409439",
                            Price = 9199f,
                            ProductId = 151,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 423,
                            Link = "https://www.trendyol.com/asus/k3400ph-km370-14-i5-11300h-16gb-ram-512gb-ssd-gtx1650-4gb-oled-freedos-tasinabilir-bilgisayar-p-305689999?boutiqueId=614348&merchantId=107204",
                            Price = 16799f,
                            ProductId = 152,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 424,
                            Link = "https://www.n11.com/urun/asus-k3400ph-km370-i5-11300h-16-gb-512-gb-ssd-gtx1650-14-free-dos-oled-dizustu-bilgisayar-6455392?magaza=bisistem",
                            Price = 17699f,
                            ProductId = 152,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 425,
                            Link = "https://www.hepsiburada.com/asus-tuf-gaming-fa507rm-hn052a6-amd-ryzen-7-6800h-32-gb-2-tb-ssd-rtx3060-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00002VTQZV",
                            Price = 35082f,
                            ProductId = 153,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 426,
                            Link = "https://www.trendyol.com/asus/tuf-gaming-fa507rm-hn052a6-amd-ryzen-7-6800h-32gb-2tb-ssd-rtx3060-freedos-15-6-p-350245217?boutiqueId=61&merchantId=155616",
                            Price = 35236f,
                            ProductId = 153,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 427,
                            Link = "https://www.trendyol.com/asus/laptop-d515da-br028t-amd-ryzen3-3250u-4gb-ram-256gb-ssd-15-6-w10-notebook-p-140826316?boutiqueId=613344&merchantId=107301",
                            Price = 6929f,
                            ProductId = 154,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 428,
                            Link = "https://www.n11.com/urun/asus-d515da-br028t-ryzen-3-3250u-4-gb-256-gb-ssd-156-w10-hd-dizustu-bilgisayar-2123042?magaza=webdensin",
                            Price = 7299f,
                            ProductId = 154,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 429,
                            Link = "https://www.hepsiburada.com/asus-rog-zephyrus-g14-ga401qc-bm207-amd-ryzen-7-5800hs-8-gb-1-tb-ssd-rtx-3050-freedos-14-fhd-tasinabilir-bilgisayar-p-HBCV000027Z3Y0",
                            Price = 19199f,
                            ProductId = 155,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 430,
                            Link = "https://www.trendyol.com/asus/rog-zephyrus-g14-ga401qc-bm207-ryzen7-5800hs-8gb-1tb-ssd-rtx3050-dos-14-fhd-dizustu-bilgisayar-p-242487936?boutiqueId=61&merchantId=106740",
                            Price = 20499f,
                            ProductId = 155,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 431,
                            Link = "https://www.trendyol.com/asus/vivobook-15-m1502-4-nesil-ryzen-5-4600h-8gb-256gb-ssd-15-6inc-w11-p-354123433?boutiqueId=61&merchantId=441895",
                            Price = 10799f,
                            ProductId = 156,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 432,
                            Link = "https://www.vatanbilgisayar.com/asus-vivobook-15-m1502-4-nesil-ryzen-5-4600h-8gb-256gb-ssd-15-6inc-w11.html",
                            Price = 13470f,
                            ProductId = 156,
                            Rate = 3f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 433,
                            Link = "https://www.trendyol.com/asus/x515jf-10-nesil-core-i5-1035g1-8gb-512gb-ssd-15-6inc-mx130-2gb-w10-p-355677814?boutiqueId=61&merchantId=624588",
                            Price = 17107f,
                            ProductId = 157,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 434,
                            Link = "https://www.vatanbilgisayar.com/asus-x515jf-core-i5-1035g1-1-0ghz-8gb-ram-512gb-ssd-15-6-mx130-2gb-w10.html",
                            Price = 13969f,
                            ProductId = 157,
                            Rate = 4f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 435,
                            Link = "https://www.hepsiburada.com/asus-x409fa-bv659-intel-core-i7-8565u-8gb-512gb-ssd-freedos-14-tasinabilir-bilgisayar-p-HBCV00000H2D7Q",
                            Price = 12699f,
                            ProductId = 158,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 436,
                            Link = "https://www.trendyol.com/asus/x409fa-bv659-intel-core-i7-8565u-8gb-512gb-ssd-freedos-14-tasinabilir-bilgisayar-p-195809659?boutiqueId=61&merchantId=481559",
                            Price = 12007f,
                            ProductId = 158,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 437,
                            Link = "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa506icb-hn178-amd-ryzen-5-4600h-8-gb-512-gb-ssd-rtx-3050-144-hz-freedos-15-6-fhd-tasinabilir-bilgisayar-canta-ve-mouse-p-HBCV00002Y2729",
                            Price = 17199f,
                            ProductId = 159,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 438,
                            Link = "https://www.trendyol.com/asus/tuf-gaming-a15-fa506icb-hn178-r5-4600h-8gb-512gb-ssd-rtx3050-144hz-dos-15-6-fhd-canta-ve-mouse-p-356450292?boutiqueId=61&merchantId=106740",
                            Price = 16879f,
                            ProductId = 159,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 439,
                            Link = "https://www.trendyol.com/asus/rog-strix-scar-17-g733zs-kh011-i9-12900h-16gb-ram-1tb-ssd-8gb-rtx3080-17-3-inc-fhd-360hz-p-353441648?boutiqueId=61&merchantId=118442",
                            Price = 59999f,
                            ProductId = 160,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 440,
                            Link = "https://www.n11.com/urun/asus-rog-strix-scar-17-g733zs-kh011-i9-12900h-16-gb-1-tb-ssd-rtx3080-360hz-173-dos-dizustu-bilgisayar-22482901?magaza=gpnteknoloji",
                            Price = 60004f,
                            ProductId = 160,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 441,
                            Link = "https://www.trendyol.com/asus/rog-strix-g17-g713rs-kh004-ryzen9-6900hx-16gb-1tb-ssd-rtx3080-360hz-dos-17-3-fhd-notebook-p-235557361?boutiqueId=613344&merchantId=106740",
                            Price = 52989f,
                            ProductId = 161,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 442,
                            Link = "https://www.n11.com/urun/asus-rog-strix-g17-g713rs-kh004-r9-6900hx-16-gb-1-tb-ssd-rtx3080-360hz-173-dos-fhd-dizustu-bilgisayar-2529118?magaza=teknoryabilisim",
                            Price = 55777f,
                            ProductId = 161,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 443,
                            Link = "https://www.trendyol.com/asus/rog-strix-g17-g713rs-kh010-ryzen-9-6900hx-16gb-ram-1tb-ssd-8gb-rtx3080-17-3-fhd-360hz-p-317064672?boutiqueId=613344&merchantId=118442",
                            Price = 52999f,
                            ProductId = 162,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 444,
                            Link = "https://www.n11.com/urun/asus-rog-strix-g17-g713rs-kh010-r9-6900hx-16-gb-1-tb-ssd-rtx3080-360hz-173-dos-fhd-dizustu-bilgisayar-13132401?magaza=gpnteknoloji",
                            Price = 54393f,
                            ProductId = 162,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 445,
                            Link = "https://www.hepsiburada.com/asus-x515jf-ej354z13-intel-core-i5-1035g1-16gb-512gb-ssd-2gb-mx130-vga-15-6-freedos-tasinabilir-bilgisayar-p-HBCV00002543U5",
                            Price = 13129f,
                            ProductId = 163,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 446,
                            Link = "https://www.n11.com/urun/asus-x515jf-ej354z13-i5-1035g1-16-gb-512-gb-ssd-2-gb-mx130-156-free-dos-dizustu-bilgisayar-5026682?magaza=atlantisdogu",
                            Price = 13466f,
                            ProductId = 163,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 447,
                            Link = "https://www.hepsiburada.com/asus-vivobook-x571li-bq377a3-intel-core-i7-10870h-16-gb-512-gb-ssd-gtx1650ti-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00002VTPXE",
                            Price = 21999f,
                            ProductId = 164,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 448,
                            Link = "https://www.trendyol.com/asus/vivobook-x571li-bq377a3-intel-core-i7-10870h-16gb-512gb-ssd-gtx1650ti-freedos-15-6-p-350244883?boutiqueId=61&merchantId=155616",
                            Price = 20893f,
                            ProductId = 164,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 449,
                            Link = "https://www.trendyol.com/asus/zenbook-14-oled-um3402-5-nesil-ryzen-5-5625u-16gb-512-ssd-14inc-w11-p-354123882?boutiqueId=61&merchantId=624588",
                            Price = 27689f,
                            ProductId = 165,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 450,
                            Link = "https://www.vatanbilgisayar.com/asus-zenbook-14-oled-um3402-5-nesil-ryzen-5-5625u-16gb-512-ssd-14inc-w11.html",
                            Price = 26206f,
                            ProductId = 165,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 451,
                            Link = "https://www.hepsiburada.com/asus-tuf-gaming-fa507rm-hn052a32-amd-ryzen-7-6800h-32-gb-1-tb-ssd-rtx3060-windows-11-pro-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00002VTR3T",
                            Price = 35082f,
                            ProductId = 166,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 452,
                            Link = "https://www.trendyol.com/asus/tuf-gaming-fa507rm-hn052a32-amd-ryzen-7-6800h-32gb-1tb-ssd-rtx3060-windows-11-pro-15-6-p-362398053?boutiqueId=61&merchantId=155616",
                            Price = 35236f,
                            ProductId = 166,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 453,
                            Link = "https://www.hepsiburada.com/asus-vivobook-15-oled-k513ep-intel-core-i5-1135g7-40gb-2tb-ssd-mx330-windows11pro-15-6-fhd-tasinabilir-bilgisayar-l157624-p-HBCV00002EFMHH",
                            Price = 23323f,
                            ProductId = 167,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 454,
                            Link = "https://www.trendyol.com/asus/vivobook-15-oled-k513ep-intel-core-i5-1135g7-40gb-2tb-ssd-mx330-w11p-15-6-fhd-l157624-p-345113096?boutiqueId=613344&merchantId=106536",
                            Price = 23799f,
                            ProductId = 167,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 455,
                            Link = "https://www.hepsiburada.com/asus-x515fa-br039-intel-core-i3-10110u-4gb-256gb-ssd-freedos-15-6-tasinabilir-bilgisayar-p-HBCV000022YGX0",
                            Price = 9252f,
                            ProductId = 168,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 456,
                            Link = "https://www.trendyol.com/asus/x515fa-br039-i3-10110u-4gb-256gb-ssd-15-6-fhd-freedos-notebook-p-354445040?boutiqueId=61&merchantId=196258",
                            Price = 9515f,
                            ProductId = 168,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 457,
                            Link = "https://www.hepsiburada.com/asus-x509fa-br951t-intel-core-i3-10110u-4gb-256gb-ssd-windows-10-home-15-6-tasinabilir-bilgisayar-p-HBCV000008SRHY",
                            Price = 8499f,
                            ProductId = 169,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 458,
                            Link = "https://www.trendyol.com/asus/x509fa-br951t-intel-core-i3-10110u-4gb-256gb-ssd-windows-10-home-15-6-fhd-p-169573504?boutiqueId=61&merchantId=640802",
                            Price = 7760f,
                            ProductId = 169,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 459,
                            Link = "https://www.trendyol.com/asus/x515ja-ej2119-i7-1065g7-8gb-256ssd-15-6-fullhd-freedos-tasinabilir-bilgisayar-p-346248871?boutiqueId=613344&merchantId=106664",
                            Price = 13363f,
                            ProductId = 170,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 460,
                            Link = "https://www.n11.com/urun/asus-x515ja-ej2119-i7-1065g7-8-gb-256-gb-ssd-156-free-dos-fhd-dizustu-bilgisayar-13987614?magaza=sitebilgisayar",
                            Price = 13440f,
                            ProductId = 170,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 461,
                            Link = "https://www.trendyol.com/asus/x515ja-ej2120a1-intel-core-i7-1065g7-8gb-256gb-ssd-freedos-15-6-fhd-p-286882590?boutiqueId=613344&merchantId=155616",
                            Price = 13886f,
                            ProductId = 171,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 462,
                            Link = "https://www.n11.com/urun/asus-x515ja-ej2120a1-i7-1065g7-8-gb-256-gb-ssd-156-free-dos-fhd-dizustu-bilgisayar-9018319?magaza=arcadia-bilisim",
                            Price = 13071f,
                            ProductId = 171,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 463,
                            Link = "https://www.trendyol.com/asus/x515ja-10-nesil-core-i5-1035g1-8gb-512gb-ssd-15-6inc-w11-p-364304048?boutiqueId=61&merchantId=624588",
                            Price = 15701f,
                            ProductId = 172,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 464,
                            Link = "https://www.vatanbilgisayar.com/asus-x515ja-10-nesil-core-i5-1035g1-8gb-512gb-ssd-15-6inc-w11.html",
                            Price = 14999f,
                            ProductId = 172,
                            Rate = 5f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 465,
                            Link = "https://www.hepsiburada.com/asus-vivobook-k513ep-l1576-intel-core-i5-1135g7-8gb-512gb-ssd-mx330-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001RZGQK",
                            Price = 13499f,
                            ProductId = 173,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 466,
                            Link = "https://www.trendyol.com/asus/vivobook-15-oled-k513ep-l1576-intel-core-i5-1135g7-8gb-512gb-ssd-mx330-freedos-15-6-fhd-p-307982200?boutiqueId=613344&merchantId=121368",
                            Price = 14750f,
                            ProductId = 173,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 467,
                            Link = "https://www.trendyol.com/asus/vivobook-15-x571li-bq377a3-i7-10870h-16gb-1tbssd-gtx1650ti-15-6-fullhd-freedos-tasinabilir-bil-p-337219001?boutiqueId=613344&merchantId=106664",
                            Price = 21539f,
                            ProductId = 174,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 468,
                            Link = "https://www.n11.com/urun/asus-vivobook-15-x571li-bq377a3-i7-10870h-16-gb-1-tb-ssd-gtx1650ti-156-dos-fhd-dizustu-bilgisayar-19292272?magaza=teknoraks",
                            Price = 21620f,
                            ProductId = 174,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 469,
                            Link = "https://www.hepsiburada.com/asus-zenbook-oled-ux325ea-kg654w-intel-core-i7-1165g7-16gb-1tb-ssd-windows-11-home-iris-xe-13-3-fhd-tasinabilir-bilgisayar-p-HBCV00002ETF16",
                            Price = 36499f,
                            ProductId = 175,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 470,
                            Link = "https://www.trendyol.com/asus/ux325ea-kg654w-fhd-oled-intel-i7-1165g7-16gb-1tb-ssd-iris-xe-numberpad-w11-notebook-p-260091480?boutiqueId=613344&merchantId=107870",
                            Price = 21999f,
                            ProductId = 175,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 471,
                            Link = "https://www.trendyol.com/asus/zenbook-14x-oled-ux5401-11-nesil-core-i7-1165g7-16gb-1tb-ssd-14inc-w11-p-353432225?boutiqueId=61&merchantId=624588",
                            Price = 39556f,
                            ProductId = 176,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 472,
                            Link = "https://www.vatanbilgisayar.com/asus-zenbook-14x-oled-ux5401-11-nesil-core-i7-1165g7-16gb-1tb-ssd-14inc-w11.html",
                            Price = 39914f,
                            ProductId = 176,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 473,
                            Link = "https://www.hepsiburada.com/asus-rog-zephyrus-g15-ga503rm-hq124-amd-ryzen-7-6800hs-16-gb-1-tb-ssd-rtx-3060-165-hz-freedos-15-6-wqhd-tasinabilir-bilgisayar-p-HBCV00002FXSSZ",
                            Price = 34499f,
                            ProductId = 177,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 474,
                            Link = "https://www.trendyol.com/asus/rog-zephyrus-g15-ga503rm-hq124-r7-6800hs-16gb-1tb-ssd-rtx3060-165hz-dos-15-6-wqhd-notebook-p-313138240?boutiqueId=613344&merchantId=106740",
                            Price = 35899f,
                            ProductId = 177,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 475,
                            Link = "https://www.trendyol.com/asus/zenbook-14x-um5401-5-nesil-ryzen-9-5900hx-16gb-1tb-ssd-14inc-w11-p-355662286?boutiqueId=61&merchantId=624588",
                            Price = 35600f,
                            ProductId = 178,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 476,
                            Link = "https://www.vatanbilgisayar.com/asus-zenbook-14x-um5401-5-nesil-ryzen-9-5900hx-16gb-1tb-ssd-14inc-w11.html",
                            Price = 35922f,
                            ProductId = 178,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 477,
                            Link = "https://www.trendyol.com/asus/x415ea-eb1360w02-i7-1165g7-16gb-512ssd-14-fullhd-w11h-tasinabilir-bilgisayar-p-359466530?boutiqueId=613901&merchantId=106664",
                            Price = 17859f,
                            ProductId = 179,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 478,
                            Link = "https://www.n11.com/urun/asus-x415ea-eb1360w02-i7-1165g7-16-gb-512-gb-ssd-14-w11h-fhd-dizustu-bilgisayar-25081650?magaza=teknoraks",
                            Price = 19899f,
                            ProductId = 179,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 479,
                            Link = "https://www.trendyol.com/asus/tuf-gaming-a15-fa506ieb-hn066-r5-4600h-16gb-512gb-ssd-rtx3050ti-144hz-dos-15-6-fhd-notebook-p-358807618?boutiqueId=61&merchantId=106740",
                            Price = 20499f,
                            ProductId = 180,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 480,
                            Link = "https://www.n11.com/urun/asus-tuf-gaming-a15-fa506ieb-hn066-r5-4600h-16-gb-512-gb-rtx3050ti-156-dos-dizustu-bilgisayar-24382456?magaza=teknoryabilisim",
                            Price = 26314f,
                            ProductId = 180,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 481,
                            Link = "https://www.trendyol.com/asus/zenbook-14-um425-5-nesil-ryzen-5-5600h-16gb-512gb-ssd-14inc-w11-p-355654772?boutiqueId=61&merchantId=624588",
                            Price = 21755f,
                            ProductId = 181,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 482,
                            Link = "https://www.vatanbilgisayar.com/asus-zenbook-14-um425-5-nesil-ryzen-5-5600h-16gb-512gb-ssd-14inc-w11.html",
                            Price = 19956f,
                            ProductId = 181,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 483,
                            Link = "https://www.trendyol.com/asus/i5-1135g7-24gb-1tb-15-6-dos-tasinabilir-bilgisayar-x515ea-bq1843t11-p-335941601?boutiqueId=613344&merchantId=107204",
                            Price = 14259f,
                            ProductId = 182,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 484,
                            Link = "https://www.n11.com/urun/asus-x515ea-bq1843n11-i5-1135g7-24-gb-1-tb-ssd-156-free-dos-fhd-dizustu-bilgisayar-18592204?magaza=bisistem",
                            Price = 14559f,
                            ProductId = 182,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 485,
                            Link = "https://www.hepsiburada.com/asus-x515ea-bq1186w08-i5-1135g7-24gb-1tbssd-15-6-fullhd-w11h-tasinabilir-bilgisayar-p-HBCV00002RPC9H",
                            Price = 15555f,
                            ProductId = 183,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 486,
                            Link = "https://www.trendyol.com/asus/x515ea-bq1186w08-i5-1135g7-24gb-1tbssd-15-6-fullhd-w11h-tasinabilir-bilgisayar-p-349438134?boutiqueId=613344&merchantId=106664",
                            Price = 15559f,
                            ProductId = 183,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 487,
                            Link = "https://www.hepsiburada.com/asus-tuf-gaming-a15-fa507rm-hn096-amd-ryzen-7-6800h-32-gb-ram-1-tb-ssd-6-gb-rtx3060-windows-11-home-15-6-fhd-tasinabilir-bilgisayar-hn09614-p-HBCV00002OSBI1",
                            Price = 36553f,
                            ProductId = 184,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 488,
                            Link = "https://www.trendyol.com/asus/tuf-a15-fa507rm-hn096-amd-ryzen-7-6800h-32-gb-1-tb-ssd-6-gb-rtx3060-w11h-15-6-fhd-hn09614-p-360950925?boutiqueId=61&merchantId=106536",
                            Price = 37299f,
                            ProductId = 184,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 489,
                            Link = "https://www.trendyol.com/asus/x515ja-10-nesil-core-i3-1005g1-4gb-256gb-ssd-15-6inc-dos-p-347631773?boutiqueId=613344&merchantId=624588",
                            Price = 7416f,
                            ProductId = 185,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 490,
                            Link = "https://www.vatanbilgisayar.com/asus-x515ja-10-nesil-core-i3-1005g1-4gb-256gb-ssd-15-6inc-dos.html",
                            Price = 7416f,
                            ProductId = 185,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 491,
                            Link = "https://www.trendyol.com/asus/x515fa-ej116w-intel-i3-10110u-4gb-ram-256gb-ssd-15-6-fhd-w11-notebook-p-348945479?boutiqueId=613344&merchantId=107870",
                            Price = 7999f,
                            ProductId = 186,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 492,
                            Link = "https://www.n11.com/urun/asus-x515fa-ej116w-i3-10110u-4-gb-256-gb-ssd-156-w11h-fhd-dizustu-bilgisayar-12720348?magaza=exen",
                            Price = 8193f,
                            ProductId = 186,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 493,
                            Link = "https://www.hepsiburada.com/asus-x515jf-br229t-intel-core-i5-1035g1u-4gb-256gb-ssd-mx130-windows-10-home-15-6-tasinabilir-bilgisayar-p-HBCV00000H2D8T",
                            Price = 12759f,
                            ProductId = 187,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 494,
                            Link = "https://www.trendyol.com/asus/x515jf-br229t-intel-core-i5-1035g1u-4gb-256gb-ssd-mx130-windows-10-home-15-6-notebook-p-299656894?boutiqueId=61&merchantId=194340",
                            Price = 10499f,
                            ProductId = 187,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 495,
                            Link = "https://www.hepsiburada.com/asus-d515da-ej1423w-amd-ryzen-3-3250u-4-gb-256-gb-ssd-windows-11-home-15-6-hd-tasinabilir-bilgisayar-p-HBCV00002I0ZVA",
                            Price = 6999f,
                            ProductId = 188,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 496,
                            Link = "https://www.trendyol.com/asus/d515da-ej1423w-amd-ryzen-3-3250u-4gb-256gb-ssd-15-6-win-11-home-p-315305478?boutiqueId=613344&merchantId=201828",
                            Price = 7127f,
                            ProductId = 188,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 497,
                            Link = "https://www.hepsiburada.com/asus-x515fa-ej045-intel-core-i5-10210u-8gb-256gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00001QO5RH",
                            Price = 12999f,
                            ProductId = 189,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 498,
                            Link = "https://www.n11.com/urun/asus-x515fa-ej045-i5-10210u-8-gb-256-gb-ssd-156-free-dos-dizustu-bilgisayar-18608630?magaza=exbilisim",
                            Price = 12599f,
                            ProductId = 189,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 499,
                            Link = "https://www.hepsiburada.com/asus-x415ea-ek977w-intel-core-i5-11135g7-8gb-256gb-ssd-iris-xe-windows-11-14-fhd-numberpad-tasinabilir-bilgisayar-p-HBCV00001U8LG6",
                            Price = 11899f,
                            ProductId = 190,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 500,
                            Link = "https://www.trendyol.com/asus/x415ea-ek977w-i5-11135g7-8gb-256gb-win11-fhd-numberpad-laptop-p-232959944?boutiqueId=613344&merchantId=636533",
                            Price = 11750f,
                            ProductId = 190,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 501,
                            Link = "https://www.trendyol.com/asus/x409fa-bv660-core-i7-8565-8gb-256gb-ssd-14-free-dos-p-132281248?boutiqueId=613344&merchantId=112319",
                            Price = 10799f,
                            ProductId = 191,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 502,
                            Link = "https://www.n11.com/urun/asus-x409fa-bv660-i7-8565u-8-gb-256-gb-ssd-14-free-dos-dizustu-bilgisayar-2104469?magaza=magic",
                            Price = 10649f,
                            ProductId = 191,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 503,
                            Link = "https://www.hepsiburada.com/asus-d415da-ek713-amd-ryzen-3-3250u-8-gb-256-gb-ssd-14-fhd-freedos-tasinabilir-bilgisayar-p-HBCV00001ZQITD",
                            Price = 6899f,
                            ProductId = 192,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 504,
                            Link = "https://www.trendyol.com/asus/d415da-ek713-amd-ryzen-3-3250u-8-gb-256-gb-ssd-14-fhd-freedos-tasinabilir-bilgisayar-p-271424783?boutiqueId=613344&merchantId=105382",
                            Price = 6599f,
                            ProductId = 192,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 505,
                            Link = "https://www.hepsiburada.com/asus-x515ja-bq1827w-intel-core-i5-1035g1u-8gb-512gb-ssd-windows-11-home-15-6-fhd-ips-tasinabilir-bilgisayar-p-HBCV000022XP0D",
                            Price = 12561f,
                            ProductId = 193,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 506,
                            Link = "https://www.trendyol.com/asus/x515ja-bq1827w-i5-1035g1u-8gb-ram-512gb-ssd-15-6-win-11-convertible-laptop-gri-p-282841232?boutiqueId=613344&merchantId=125175",
                            Price = 12869f,
                            ProductId = 193,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 507,
                            Link = "https://www.hepsiburada.com/asus-x571gta44-hn1012a44-intel-core-i5-9300h-8gb-512gb-ssd-gtx1650-windows-10-home-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00000R63VN",
                            Price = 15864f,
                            ProductId = 194,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 508,
                            Link = "https://www.trendyol.com/asus/x571gta44-hn1012a44-intel-core-i5-9300h-8gb-512gb-ssd-gtx1650-144hz-windows-10-home-15-6-fhd-p-165015251?boutiqueId=613344&merchantId=155616",
                            Price = 16199f,
                            ProductId = 194,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 509,
                            Link = "https://www.hepsiburada.com/asus-x515ja-ej2120a36-intel-core-i7-1065g7-8gb-512gb-ssd-windows-10-home-15-6-fhd-tasinabilir-bilgisayar-p-HBCV000023ASTP",
                            Price = 14656f,
                            ProductId = 195,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 510,
                            Link = "https://www.n11.com/urun/asus-x515ja-ej2120a36-i7-1065g7-8-gb-512-gb-ssd-156-w10h-fhd-dizustu-bilgisayar-9018245?magaza=arcadia-bilisim",
                            Price = 14483f,
                            ProductId = 195,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 511,
                            Link = "https://www.hepsiburada.com/asus-x409fa-ek036-intel-core-i7-8565u-8gb-512gb-ssd-windows-10-pro-14-inc-fhd-tasinabilir-bilgisayar-p-HBCV00001CBAT2",
                            Price = 12971f,
                            ProductId = 196,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 512,
                            Link = "https://www.trendyol.com/asus/x409fa-ek036-i7-8565u-8gb-512gb-ssd-14-windows-10-pro-p-231289075?boutiqueId=61&merchantId=481559",
                            Price = 12473f,
                            ProductId = 196,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 513,
                            Link = "https://www.hepsiburada.com/acer-nitro-5-an515-45-amd-ryzen-5-5600h-8-gb-512-gb-ssd-gtx-1650-freedos-15-6-fhd-144-hz-tasinabilir-bilgisayar-nh-qb9ey-003-p-HBCV00002QBQ8O",
                            Price = 14899f,
                            ProductId = 197,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 514,
                            Link = "https://www.n11.com/urun/acer-nitro-5-an515-45-nhqb9ey003-r5-5600h-8-gb-512-gb-ssd-gtx1650-156-dos-dizustu-bilgisayar-18596620?magaza=teknoryabilisim",
                            Price = 14999f,
                            ProductId = 197,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 515,
                            Link = "https://www.trendyol.com/acer/aspire-7-a715-42-amd-ryzen-5-5500u-8gb-256gb-ssd-gtx1650-15-6-fhd-dos-bilgisayar-nh-qbfey-001-p-133370445?boutiqueId=61&merchantId=624588",
                            Price = 14999f,
                            ProductId = 198,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 516,
                            Link = "https://www.vatanbilgisayar.com/acer-aspire-7-5-nesil-ryzen-5-5500u-8gb-256gb-ssd-15-6inc-gtx1650-4gb-freedos.html",
                            Price = 13999f,
                            ProductId = 198,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 517,
                            Link = "https://www.hepsiburada.com/acer-gaming-aspire-7-a715-42g-amd-ryzen-5-5500u-8-gb-256-gb-ssd-gtx-1650-144-hz-freedos-15-6-fhd-tasinabilir-bilgisayar-nh-qbfey-007-canta-ve-mouse-p-HBCV00002P808J",
                            Price = 14299f,
                            ProductId = 199,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 518,
                            Link = "https://www.trendyol.com/acer/gaming-aspire7-a715-42g-r5-5500u-8gb-256gb-ssd-gtx1650-144hz-dos-15-6-fhd-notebook-nh-qbfey-007-p-308650095?boutiqueId=614908&merchantId=106664",
                            Price = 14848f,
                            ProductId = 199,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 519,
                            Link = "https://www.hepsiburada.com/acer-gaming-aspire-7-a715-42g-amd-ryzen-5-5500u-8gb-256gb-ssd-rtx3050-freedos-15-6-fhd-144hz-tasinabilir-bilgisayar-nh-qe5ey-006-p-HBCV00002EGS3E",
                            Price = 15999f,
                            ProductId = 200,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 520,
                            Link = "https://www.trendyol.com/acer/gaming-aspire7-a715-42g-r5-5500u-8gb-256gb-ssd-rtx3050-144hz-dos-15-6-fhd-notebook-nh-qe5ey-006-p-308514668?boutiqueId=61&merchantId=126144",
                            Price = 15299f,
                            ProductId = 200,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 521,
                            Link = "https://www.hepsiburada.com/acer-nitro-5-an515-45-amd-ryzen-7-5800h-16-gb-512-gb-ssd-rtx-3050ti-freedos-15-6-fhd-144-hz-tasinabilir-bilgisayar-nh-qbbey-001-p-HBCV00002QBQ8I",
                            Price = 18999f,
                            ProductId = 201,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 522,
                            Link = "https://www.trendyol.com/acer/nitro-5-an515-45-r7-5800h-16gb-512gb-ssd-rtx3050ti-dos-15-6-fhd-144hz-notebook-nh-qbbey-001-p-335996973?boutiqueId=61&merchantId=106740",
                            Price = 20999f,
                            ProductId = 201,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 523,
                            Link = "https://www.trendyol.com/acer/nitro-5-an515-45-ryzen-5-5600h-16-gb-512-gb-ssd-rtx-3050-144-hz-15-6-fhd-freedos-nh-qbaey-003-p-151453763?boutiqueId=613344&merchantId=106740",
                            Price = 20999f,
                            ProductId = 202,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 524,
                            Link = "https://www.n11.com/urun/acer-nitro-5-an515-45-nhqbaey003-r5-5600h-16-gb-512-gb-ssd-rtx3050-144hz-156-dos-dizustu-bilgisayar-2152260?magaza=teknoryabilisim",
                            Price = 19999f,
                            ProductId = 202,
                            Rate = 4f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 525,
                            Link = "https://www.hepsiburada.com/acer-nitro-5-an515-45-amd-ryzen-5-5600h-16-gb-512-gb-ssd-rtx-3050ti-freedos-15-6-fhd-144-hz-tasinabilir-bilgisayar-nh-qbbey-003-p-HBCV00002QBQ8G",
                            Price = 17999f,
                            ProductId = 203,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 526,
                            Link = "https://www.trendyol.com/acer/nitro-5-an515-45-r5-5600h-16gb-512gb-ssd-rtx3050ti-dos-15-6-fhd-144hz-notebook-nh-qbbey-003-p-335997188?boutiqueId=613344&merchantId=106740",
                            Price = 18699f,
                            ProductId = 203,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 527,
                            Link = "https://www.hepsiburada.com/acer-nitro-5-an515-45-amd-ryzen-5-5600h-16gb-512gb-ssd-rtx3060-freedos-15-6-fhd-144hz-tasinabilir-bilgisayar-nh-qbcey-005-p-HBCV00000I8S7S",
                            Price = 24449f,
                            ProductId = 204,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 528,
                            Link = "https://www.trendyol.com/acer/nitro-5-an515-45-amd-ryzen-5-5600h-16-gb-512-gb-ssd-rtx3060-144-hz-freedos-15-6fhd-nh-qbcey-005-p-133397644?boutiqueId=613344&merchantId=181127",
                            Price = 23999f,
                            ProductId = 204,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 529,
                            Link = "https://www.hepsiburada.com/acer-extensa-15-ex215-54g-58hf-intel-core-i5-1135g7-8gb-512gb-mx350-15-6-fhd-freedos-nx-eghey-001-tasinabilir-bilgisayar-p-HBCV00002V0ZY4",
                            Price = 11449f,
                            ProductId = 205,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 530,
                            Link = "https://www.trendyol.com/acer/extensa-ex215-54g-nx-eghey-001-intel-core-i5-1135g7-8gb-ram-512gb-ssd-mx350-freedos-15-6-p-303745389?boutiqueId=613344&merchantId=150534",
                            Price = 10697f,
                            ProductId = 205,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 531,
                            Link = "https://www.trendyol.com/acer/a315-56-327t-nx-hs5ey-006-i3-1005g1-8gb-256gb-ssd-15-6-fhd-free-dos-tasinabilir-bilgisayar-hc-p-345308080?boutiqueId=61&merchantId=131190",
                            Price = 8300f,
                            ProductId = 206,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 532,
                            Link = "https://www.n11.com/urun/acer-aspire-3-a315-56-327t-nxhs5ey006-i3-1005g1-8-gb-256-gb-ssd-156-free-dos-fhd-dizustu-bilgisayar-2731193?magaza=okyanusteknolojimlt",
                            Price = 8250f,
                            ProductId = 206,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 533,
                            Link = "https://www.trendyol.com/acer/aspire-3-a315-56-intel-core-i3-1005g1-8-gb-256-gb-ssd-15-6-fhd-blue-free-dos-nx-hs6ey-001-p-168683827?boutiqueId=614596&merchantId=106198",
                            Price = 7370f,
                            ProductId = 207,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 534,
                            Link = "https://www.n11.com/urun/acer-aspire-3-a315-56-nxhs6ey001-i3-1005g1-8-gb-256-gb-ssd-156-free-dos-fhd-dizustu-bilgisayar-2186444?magaza=techburada",
                            Price = 8948f,
                            ProductId = 207,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 535,
                            Link = "https://www.hepsiburada.com/acer-aspire-7-a715-75g-53bq-intel-core-i5-10300h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00002I84DE",
                            Price = 14750f,
                            ProductId = 208,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 536,
                            Link = "https://www.trendyol.com/acer/aspire-7-a715-75g-53bq-intel-core-i5-10300h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-p-322857323?boutiqueId=61&merchantId=110963",
                            Price = 13600f,
                            ProductId = 208,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 537,
                            Link = "https://www.trendyol.com/acer/nitro-an515-55-i5-10300h-8gb-512gb-ssd-gtx-1650ti-freedos-15-6-fhd-144-hz-nh-q7jey-006-p-135846151?boutiqueId=613344&merchantId=107748",
                            Price = 19199f,
                            ProductId = 209,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 538,
                            Link = "https://www.n11.com/urun/acer-nitro-an515-55-nhq7jey006-i5-10300h-8-gb-512-gb-ssd-gtx1650ti-156-free-dos-fhd-dizustu-bilgisayar-2105487?magaza=sitem",
                            Price = 18979f,
                            ProductId = 209,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 539,
                            Link = "https://www.hepsiburada.com/acer-nitro-5-an515-58-intel-core-i7-12700h-16-gb-512-gb-ssd-rtx-3050ti-4-gb-freedos-15-6-fhd-tasinabilir-bilgisayar-nh-qfley-003-p-HBCV00002SN3B3",
                            Price = 22499f,
                            ProductId = 210,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 540,
                            Link = "https://www.trendyol.com/acer/nitro-5-an515-58-corei7-12700h-16gb-512gb-ssd-rtx-3050ti-4gb-fdos-15-6-notebook-nh-qfley-003-p-313764704?boutiqueId=614349&merchantId=107007",
                            Price = 24499f,
                            ProductId = 210,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 541,
                            Link = "https://www.hepsiburada.com/acer-nitro-5-an515-58-intel-core-i7-12700h-16-gb-512-gb-ssd-rtx-3060-6-gb-freedos-15-6-fhd-tasinabilir-bilgisayar-nh-qfmey-003-p-HBCV00002SND6K",
                            Price = 27699f,
                            ProductId = 211,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 542,
                            Link = "https://www.trendyol.com/acer/nitro-5-an515-58-corei7-12700h-16gb-512gb-ssd-rtx-3060-6gb-fdos-15-6-fhd-notebook-nh-qfmey-003-p-343073354?boutiqueId=614349&merchantId=107007",
                            Price = 28999f,
                            ProductId = 211,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 543,
                            Link = "https://www.trendyol.com/acer/extensa-15-11-nesil-core-i5-1135g7-8gb-256gb-ssd-15-6inc-freedos-p-347140717?boutiqueId=613344&merchantId=624588",
                            Price = 9999f,
                            ProductId = 212,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 544,
                            Link = "https://www.vatanbilgisayar.com/acer-extensa-15-11-nesil-core-i5-1135g7-8gb-256gb-ssd-15-6inc-freedos.html",
                            Price = 9999f,
                            ProductId = 212,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 545,
                            Link = "https://www.trendyol.com/acer/aspire-3-a315-58-i5-1135g7-8gb-256gb-ssd-fdos-15-6-fhd-ips-tasinabilir-bilgisayar-nx-addey-004-p-320269481?boutiqueId=613344&merchantId=109239",
                            Price = 10849f,
                            ProductId = 213,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 546,
                            Link = "https://www.n11.com/urun/acer-aspire-3-a315-58-nxaddey004-i5-1135g7-8-gb-256-gb-ssd-156-free-dos-dizustu-bilgisayar-20490177?magaza=ulkemgy",
                            Price = 10359f,
                            ProductId = 213,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 547,
                            Link = "https://www.hepsiburada.com/acer-gaming-aspire-7-a715-42g-amd-ryzen-5-5500u-8-gb-512-gb-ssd-rtx3050-freedos-15-6-fhd-tasinabilir-bilgisayar-nh-qe5ey-004-p-HBCV00002EG8TH",
                            Price = 13998f,
                            ProductId = 214,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 548,
                            Link = "https://www.trendyol.com/acer/gaming-aspire7-a715-42g-r5-5500u-8gb-512gb-ssd-rtx3050-144hz-dos-15-6-fhd-notebook-nh-qe5ey-004-p-308655631?boutiqueId=61&merchantId=247563",
                            Price = 16649f,
                            ProductId = 214,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 549,
                            Link = "https://www.trendyol.com/acer/predator-pt315-52-57pn-10-nesil-core-i5-10300h-16gb-512gb-ssd-15-6inch-gtx1660ti-6gb-w10-p-262590081?boutiqueId=61&merchantId=624588",
                            Price = 29153f,
                            ProductId = 215,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 550,
                            Link = "https://www.vatanbilgisayar.com/acer-predator-core-i5-10300h-2-5ghz-16gb-512gb-ssd-15-6-gtx1660ti-6gb-w10-126441.html",
                            Price = 29153f,
                            ProductId = 215,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 551,
                            Link = "https://www.hepsiburada.com/acer-swift-3-sf314-511-intel-core-i7-1165g7-16gb-512gb-ssd-windows-10-home-14-tasinabilir-bilgisayar-nx-abney-002-p-HBCV00001D1U3L",
                            Price = 17750f,
                            ProductId = 216,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 552,
                            Link = "https://www.trendyol.com/acer/swift-3-sf314-511-nx-abney-002-intel-core-i7-1165g7-16gb-ram-512gb-ssd-14-fhd-win10-home-noteb-p-275956315?boutiqueId=61&merchantId=190694",
                            Price = 17300f,
                            ProductId = 216,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 553,
                            Link = "https://www.hepsiburada.com/acer-extensa-amd-ryzen-3-3250u-8-gb-256-gb-freedos-15-6-fhd-tasinabilir-bilgisayar-nx-eg9ey-004-p-HBCV0000291LX9",
                            Price = 7499f,
                            ProductId = 217,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 554,
                            Link = "https://www.trendyol.com/acer/extensa-15-ex215-22-nx-eg9ey-004-amd-ryzen-3-3250u-8gb-256gb-ssd-15-6-freedos-pc-p-303390669?boutiqueId=613344&merchantId=121153",
                            Price = 7399f,
                            ProductId = 217,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 555,
                            Link = "https://www.hepsiburada.com/acer-swift-3-sf314-511-intel-core-i5-1135g7-8gb-512gb-ssd-14-fhd-windows-11-home-tasinabilir-bilgisayar-nx-abney-003-p-HBCV000019XOHE",
                            Price = 11599f,
                            ProductId = 218,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 556,
                            Link = "https://www.trendyol.com/acer/swift-3-sf314-511-evo-i5-1135g7-8gb-512gb-ssd-14-w11-fhd-laptop-acer-turkiye-garantili-p-304198382?boutiqueId=614790&merchantId=968",
                            Price = 10998f,
                            ProductId = 218,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 557,
                            Link = "https://www.trendyol.com/acer/aspire-3-11-nesil-core-i5-1135g7-8gb-512gb-ssd-15-6inc-mx350-2gb-w11-p-368505860?boutiqueId=61&merchantId=624588",
                            Price = 13599f,
                            ProductId = 219,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 558,
                            Link = "https://www.vatanbilgisayar.com/acer-aspire-3-11-nesil-core-i5-1135g7-8gb-512gb-ssd-15-6inc-mx350-2gb-w11.html",
                            Price = 13599f,
                            ProductId = 219,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 559,
                            Link = "https://www.hepsiburada.com/acer-nitro-5-an515-57-intel-core-i7-11800h-16-gb-512-gb-ssd-rtx-3070-8-gb-freedos-15-6-fhd-tasinabilir-bilgisayar-nh-qfgey-002-p-HBCV00002SMT5Z",
                            Price = 29959f,
                            ProductId = 220,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 560,
                            Link = "https://www.trendyol.com/acer/nitro-5-an515-57-corei7-11800h-16gb-512gb-ssd-rtx-3070-8gb-fdos-15-6-notebook-nh-qfgey-002-p-343021074?boutiqueId=614349&merchantId=107007",
                            Price = 29959f,
                            ProductId = 220,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 561,
                            Link = "https://www.trendyol.com/apple/macbook-pro-13-3-inc-m2-cip-8cpu-10gpu-8gb-512gb-ssd-uzay-grisi-mnej3tu-a-p-327464261?boutiqueId=613344&merchantId=141868",
                            Price = 31500f,
                            ProductId = 221,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 562,
                            Link = "https://www.vatanbilgisayar.com/macbook-pro-mnej3tu-a-m2-8gb-512gb-ssd-retina-13-3inc-uzay-grisi.html",
                            Price = 31499f,
                            ProductId = 221,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 563,
                            Link = "https://www.trendyol.com/apple/macbook-pro-13-3-inc-m2-cip-8cpu-10gpu-8gb-512gb-ssd-2022-mneq3tu-a-p-335849690?boutiqueId=61&merchantId=107032",
                            Price = 31999f,
                            ProductId = 222,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 564,
                            Link = "https://www.vatanbilgisayar.com/macbook-pro-mneq3tu-a-m2-8gb-512gb-ssd-retina-13-3inc-gumus.html",
                            Price = 31499f,
                            ProductId = 222,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 565,
                            Link = "https://www.hepsiburada.com/apple-macbook-air-m1-cip-16gb-512gb-ssd-macos-13-tasinabilir-bilgisayar-uzay-grisi-z125000bv-p-HBCV000002416N",
                            Price = 27981f,
                            ProductId = 223,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 566,
                            Link = "https://www.trendyol.com/apple/macbook-air-13-inc-m1-8c-16gb-ram-512gb-ssd-space-gray-z125000bv-p-90773423?boutiqueId=613344&merchantId=141868",
                            Price = 33783f,
                            ProductId = 223,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 567,
                            Link = "https://www.hepsiburada.com/apple-macbook-pro-m1-cip-16gb-512gb-ssd-macos-13-tasinabilir-bilgisayar-uzay-grisi-z11c0007y-p-HBCV000002416P",
                            Price = 34498f,
                            ProductId = 224,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 568,
                            Link = "https://www.trendyol.com/apple/macbook-pro-13-inc-m1-8c-16gb-ram-512gb-ssd-space-gray-z11c0007y-p-90779426?boutiqueId=613344&merchantId=141868",
                            Price = 33291f,
                            ProductId = 224,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 569,
                            Link = "https://www.trendyol.com/apple/macbook-pro-13-3-inc-m2-cip-8cpu-10gpu-8gb-256gb-ssd-2022-mnep3tu-a-p-335860193?boutiqueId=613344&merchantId=107032",
                            Price = 27999f,
                            ProductId = 225,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 570,
                            Link = "https://www.vatanbilgisayar.com/macbook-pro-mnep3tu-a-m2-8gb-256gb-ssd-retina-13-3inc-gumus.html",
                            Price = 26699f,
                            ProductId = 225,
                            Rate = 5f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 571,
                            Link = "https://www.trendyol.com/apple/macbook-m1-pro-cip-10c-cpu-16c-gpu-16gb-1tb-ssd-macos-16-qhd-tasinabilir-bilgisayar-uzay-grisi-p-187057410?boutiqueId=613344&merchantId=141868",
                            Price = 52660f,
                            ProductId = 226,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 572,
                            Link = "https://www.n11.com/urun/apple-macbook-pro-z14vm1pnw161-tq6-m1-10-cpu-16-gpu-16-gb-1-tb-ssd-16-macos-dizustu-bilgisayar-23548744?magaza=gpnteknoloji",
                            Price = 49999f,
                            ProductId = 226,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 573,
                            Link = "https://www.hepsiburada.com/apple-macbook-m1-pro-cip-16gb-1tb-ssd-macos-16-qhd-tasinabilir-bilgisayar-uzay-grisi-mk193tu-a-p-HBCV00000U6WE7",
                            Price = 54399f,
                            ProductId = 227,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 574,
                            Link = "https://www.vatanbilgisayar.com/macbook-pro-mk193tu-a-m1-pro-16gb-1tb-ssd-liquid-retina-16-space-grey.html",
                            Price = 55599f,
                            ProductId = 227,
                            Rate = 5f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 575,
                            Link = "https://www.hepsiburada.com/apple-macbook-air-m1-cip-16gb-256gb-ssd-macos-13-tasinabilir-bilgisayar-uzay-grisi-z1240009k-p-HBCV000002416L",
                            Price = 27899f,
                            ProductId = 228,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 576,
                            Link = "https://www.n11.com/urun/apple-macbook-air-z1240009k-apple-m1-16-gb-256-gb-ssd-133-macos-dizustu-bilgisayar-1835022?magaza=rtmteknoloji",
                            Price = 23499f,
                            ProductId = 228,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 577,
                            Link = "https://www.trendyol.com/apple/macbook-air-m1-cip-16-gb-256-gb-macos-13-3-inc-qhd-tasinabilir-bilgisayar-gumus-p-235300761?boutiqueId=613344&merchantId=106740",
                            Price = 24999f,
                            ProductId = 229,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 578,
                            Link = "https://www.n11.com/urun/apple-macbook-air-z127m116256-tq6-m1-cip-16-gb-256-gb-macos-133-qhd-dizustu-bilgisayar-2516705?magaza=teknoryabilisim",
                            Price = 25609f,
                            ProductId = 229,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 579,
                            Link = "https://www.hepsiburada.com/apple-macbook-pro-m1-cip-16-gb-256-gb-ssd-macos-13-qhd-tasinabilir-bilgisayar-uzay-grisi-z11b00098-p-HBCV00002QVT69",
                            Price = 28199f,
                            ProductId = 230,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 580,
                            Link = "https://www.n11.com/urun/apple-macbook-pro-z11b00098-apple-m1-8c-16-gb-256-gb-ssd-133-dizustu-bilgisayar-1795591?magaza=dey-elektronik",
                            Price = 32137f,
                            ProductId = 230,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 581,
                            Link = "https://www.hepsiburada.com/apple-macbook-air-m1-cip-16-gb-512-gb-macos-13-3-inc-qhd-tasinabilir-bilgisayar-gumus-z127m116512-tq6-p-HBCV00001D35VF",
                            Price = 27885f,
                            ProductId = 231,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 582,
                            Link = "https://www.trendyol.com/apple/macbook-air-m1-cip-16-gb-512-gb-macos-13-3-inc-qhd-tasinabilir-bilgisayar-gumus-z127m116512-tq6-p-234010451?boutiqueId=613344&merchantId=106740",
                            Price = 27999f,
                            ProductId = 231,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 583,
                            Link = "https://www.hepsiburada.com/apple-macbook-air-m1-cip-16-gb-512-gb-macos-13-3-inc-qhd-tasinabilir-bilgisayar-uzay-grisi-z124m116512-tq6-p-HBCV00001D3U83",
                            Price = 28189f,
                            ProductId = 232,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 584,
                            Link = "https://www.trendyol.com/apple/macbook-air-m1-cip-16gb-512gb-macos-13-3-inc-qhd-tasinabilir-bilgisayar-uzay-grisi-p-235459238?boutiqueId=613344&merchantId=118352",
                            Price = 27224f,
                            ProductId = 232,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 585,
                            Link = "https://www.trendyol.com/apple/macbook-pro-m1-8-gb-512-gb-ssd-13-3-myd92tu-a-uzay-grisi-dizustu-bilgisayar-appleturkiyegarantili-p-72243026?boutiqueId=61&merchantId=624588",
                            Price = 26999f,
                            ProductId = 233,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 586,
                            Link = "https://www.n11.com/urun/apple-macbook-pro-myd92tua-apple-m1-8-gb-512-gb-13-macos-dizustu-bilgisayar-gri-1814812?magaza=exen",
                            Price = 29999f,
                            ProductId = 233,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 587,
                            Link = "https://www.hepsiburada.com/apple-macbook-air-m1-cip-8gb-512gb-ssd-macos-13-qhd-tasinabilir-bilgisayar-gumus-mgna3tu-a-p-HBV0000130VO5",
                            Price = 22859f,
                            ProductId = 234,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 588,
                            Link = "https://www.n11.com/urun/apple-macbook-air-mgna3tua-apple-m1-8-gb-ram-512-gb-ssd-133-macos-dizustu-bilgisayar-gumus-1817999?magaza=gpnteknoloji",
                            Price = 22899f,
                            ProductId = 234,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 589,
                            Link = "https://www.hepsiburada.com/apple-macbook-air-m1-cip-8gb-512gb-ssd-macos-13-qhd-tasinabilir-bilgisayar-uzay-grisi-mgn73tu-a-p-HBV0000130VNZ",
                            Price = 23699f,
                            ProductId = 235,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 590,
                            Link = "https://www.trendyol.com/apple/macbook-air-13-m1-8gb-512gb-ssd-uzay-grisi-p-67587399?boutiqueId=613344&merchantId=141868",
                            Price = 22835f,
                            ProductId = 235,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 591,
                            Link = "https://www.hepsiburada.com/apple-macbook-pro-m1-8c-11800h-16gb-256gb-ssd-macos-13-tasinabilir-bilgisayar-z11d116256tq6-p-HBCV00000JN9UQ",
                            Price = 29373f,
                            ProductId = 236,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 592,
                            Link = "https://www.trendyol.com/apple/macbook-pro-13-m1-8c-16gb-ram-256gb-ssd-gumus-p-134305795?boutiqueId=613344&merchantId=141868",
                            Price = 33660f,
                            ProductId = 236,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 593,
                            Link = "https://www.trendyol.com/apple/macbook-air-13-6-m2-16gb-512gb-ssd-uzay-grisi-p-355677851?boutiqueId=61&merchantId=106740",
                            Price = 33999f,
                            ProductId = 237,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 594,
                            Link = "https://www.vatanbilgisayar.com/mba-13inc-ug-m2-16gb-512gbssd-ozel-siparis.html",
                            Price = 33999f,
                            ProductId = 237,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 595,
                            Link = "https://www.trendyol.com/apple/macbook-pro-16-m1-max-32gb-1tb-ssd-gumus-p-184544045?boutiqueId=61&merchantId=105061",
                            Price = 65499f,
                            ProductId = 238,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 596,
                            Link = "https://www.vatanbilgisayar.com/macbook-pro-mk1h3tu-a-m1-max-16gb-1tb-ssd-liquid-retina-16-silver.html",
                            Price = 71999f,
                            ProductId = 238,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 597,
                            Link = "https://www.trendyol.com/apple/macbook-air-mlxx3tu-a-m2-8gb-512gb-ssd-liquid-retina-13-6inc-uzay-grisi-p-355674850?boutiqueId=61&merchantId=624588",
                            Price = 30599f,
                            ProductId = 239,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 598,
                            Link = "https://www.vatanbilgisayar.com/macbook-air-mlxx3tu-a-m2-8gb-512gb-ssd-liquid-retina-13-6inc-uzay-grisi.html",
                            Price = 30599f,
                            ProductId = 239,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 599,
                            Link = "https://www.trendyol.com/apple/macbook-air-mly03tu-a-m2-8gb-512gb-ssd-liquid-retina-13-6inc-gumus-p-358555830?boutiqueId=61&merchantId=624588",
                            Price = 30599f,
                            ProductId = 240,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 600,
                            Link = "https://www.vatanbilgisayar.com/macbook-air-mly03tu-a-m2-8gb-512gb-ssd-liquid-retina-13-6inc-gumus.html",
                            Price = 30599f,
                            ProductId = 240,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 601,
                            Link = "https://www.trendyol.com/apple/macbook-air-13-6-m2-8gb-512gb-ssd-yildiz-isigi-p-355654214?boutiqueId=61&merchantId=624588",
                            Price = 30599f,
                            ProductId = 241,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 602,
                            Link = "https://www.vatanbilgisayar.com/macbook-air-mly23tu-a-m2-8gb-512gb-ssd-liquid-retina-13-6inc-yildiz-isigi.html",
                            Price = 30599f,
                            ProductId = 241,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 603,
                            Link = "https://www.hepsiburada.com/apple-macbook-pro-m1-max-10c-cpu-32c-gpu-64-gb-2-tb-ssd-macos-16-qhd-uzay-grisi-z14vm1mny642-tq6-p-HBCV00002R0TI6",
                            Price = 87999f,
                            ProductId = 242,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 604,
                            Link = "https://www.trendyol.com/apple/macbook-pro-m1-max-10c-cpu-32c-gpu-64gb-2-tb-ssd-macos-16-qhd-uzay-grisi-p-337815767?boutiqueId=613344&merchantId=106740",
                            Price = 84799f,
                            ProductId = 242,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 605,
                            Link = "https://www.trendyol.com/apple/macbook-pro-mkgt3tu-a-m1-pro-16gb-1tb-ssd-liquid-retina-14-silver-dizustu-bilgisayar-p-269349224?boutiqueId=61&merchantId=414086",
                            Price = 49000f,
                            ProductId = 243,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 606,
                            Link = "https://www.vatanbilgisayar.com/macbook-pro-mkgt3tu-a-m1-pro-16gb-1tb-ssd-liquid-retina-14-silver.html",
                            Price = 46499f,
                            ProductId = 243,
                            Rate = 5f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 607,
                            Link = "https://www.hepsiburada.com/apple-macbook-air-m1-cip-8gb-256gb-ssd-macos-13-qhd-tasinabilir-bilgisayar-gumus-mgn93tu-a-p-HBV0000130VNJ",
                            Price = 19399f,
                            ProductId = 244,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 608,
                            Link = "https://www.trendyol.com/apple/macbook-air-13-m1-8gb-256gb-ssd-gumus-p-67975626?boutiqueId=614307&merchantId=436484",
                            Price = 19977f,
                            ProductId = 244,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 609,
                            Link = "https://www.hepsiburada.com/apple-macbook-air-m1-cip-8gb-256gb-ssd-macos-13-qhd-tasinabilir-bilgisayar-altin-mgnd3tu-a-p-HBV0000130VNH",
                            Price = 19399f,
                            ProductId = 245,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 610,
                            Link = "https://www.trendyol.com/apple/macbook-air-13-m1-8gb-256gb-ssd-altin-p-67940132?boutiqueId=613344&merchantId=112652",
                            Price = 19936f,
                            ProductId = 245,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 611,
                            Link = "https://www.hepsiburada.com/apple-macbook-pro-m1-cip-8gb-256gb-ssd-macos-13-qhd-tasinabilir-bilgisayar-gumus-myda2tu-a-p-HBV0000130VNQ",
                            Price = 24440f,
                            ProductId = 246,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 612,
                            Link = "https://www.trendyol.com/apple/macbook-pro-13-m1-8gb-256gb-ssd-gumus-dizustu-bilgisayar-apple-turkiye-garantili-p-72183628?boutiqueId=613344&merchantId=141868",
                            Price = 23320f,
                            ProductId = 246,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 613,
                            Link = "https://www.hepsiburada.com/dell-inspiron-3511-intel-core-i5-1135g7-8gb-512gb-ssd-mx350-ubuntu-15-6-tasinabilir-bilgisayar-f1135f85n-p-HBCV00001504UD",
                            Price = 13299f,
                            ProductId = 247,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 614,
                            Link = "https://www.trendyol.com/dell/inspiron-3511-intel-core-i5-1135g7-8gb-512gb-ssd-mx350-ubuntu-15-6-f1135f85n-p-211927063?boutiqueId=613344&merchantId=105378",
                            Price = 12999f,
                            ProductId = 247,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 615,
                            Link = "https://www.hepsiburada.com/dell-latitude-3520-intel-core-i7-1165g7-16gb-512gb-ssd-freedos15-6-fhd-tasinabilir-bilgisayar-n014l352017emea-u-p-HBCV0000258RET",
                            Price = 20174f,
                            ProductId = 248,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 616,
                            Link = "https://www.trendyol.com/dell/latitude-3520-n014l352017emea-u-i7-1165g7-16gb-512gb-ssd-freedos15-6-fhd-laptop-p-288446413?boutiqueId=613344&merchantId=121347",
                            Price = 19060f,
                            ProductId = 248,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 617,
                            Link = "https://www.hepsiburada.com/dell-latitude-5430-n213l543014emea-w-intel-core-i7-1255u-16gb-512gb-ssd-14-fhd-windows-10-pro-tasinabilir-bilgisayar-p-HBCV00002LCO8W",
                            Price = 29002f,
                            ProductId = 249,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 618,
                            Link = "https://www.trendyol.com/dell/latitude-5430-i7-1255u-16gb-512gb-ssd-14-fhd-windows-10-pro-p-348812217?boutiqueId=613344&merchantId=105378",
                            Price = 29569f,
                            ProductId = 249,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 619,
                            Link = "https://www.hepsiburada.com/dell-gaming-g5-15-g55201800u-i7-12700h-16gb-512gb-ssd-rtx3060-6gb-15-6-120hz-fhd-ubuntu-p-HBCV00002BG8IP",
                            Price = 32299f,
                            ProductId = 250,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 620,
                            Link = "https://www.trendyol.com/dell/gaming-g5-15-g55201800u-i7-12700h-16gb-512gb-ssd-rtx3060-6gb-15-6-120hz-fhd-ubuntu-p-322207518?boutiqueId=613344&merchantId=105369",
                            Price = 32389f,
                            ProductId = 250,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 621,
                            Link = "https://www.hepsiburada.com/dell-inspiron-3511-intel-core-i3-1115g4-8gb-256gb-ssd-15-6-fhd-ubuntu-tasinabilir-bilgisayar-fb11f82n-p-HBCV00001ESPHR",
                            Price = 10399f,
                            ProductId = 251,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 622,
                            Link = "https://www.trendyol.com/dell/inspiron-3511-intel-i3-1115g4-8gb-256gb-ssd-15-6-fhd-ubuntu-tasinabilir-bilgisayar-fb11f82n-p-344039031?boutiqueId=61&merchantId=109239",
                            Price = 8513f,
                            ProductId = 251,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 623,
                            Link = "https://www.hepsiburada.com/dell-g15-5510-i5-10500h-8gb-ram-512gb-ssd-4gb-gtx1650-15-6-fhd-120hz-windows-10-4b500w85c-tasinabilir-bilgisayar-p-HBCV00002ORFBH",
                            Price = 17354f,
                            ProductId = 252,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 624,
                            Link = "https://www.trendyol.com/dell/g15-5510-i5-10500h-8gb-ram-512gb-ssd-4gb-gtx1650-15-6-fhd-120hz-windows-10-4b500w85c-p-331847581?boutiqueId=613344&merchantId=106664",
                            Price = 16699f,
                            ProductId = 252,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 625,
                            Link = "https://www.hepsiburada.com/dell-inspiron-3511-intel-core-i5-1135g7-16gb-256gb-ssd-linux-15-6-tasinabilir-bilgisayar-f35obf821na3-p-HBCV00001DZIYL",
                            Price = 12104f,
                            ProductId = 253,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 626,
                            Link = "https://www.trendyol.com/dell/inspiron-3511-intel-core-i5-1135g7-16gb-256gb-ssd-linux-15-6-f35obf821na3-p-247553262?boutiqueId=613344&merchantId=155616",
                            Price = 12257f,
                            ProductId = 253,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 627,
                            Link = "https://www.hepsiburada.com/dell-inspiron-3511-intel-core-i5-1135g7-16gb-256gb-ssd-windows-10-home-15-6-tasinabilir-bilgisayar-f35obf821na24-p-HBCV00001DZIZR",
                            Price = 12811f,
                            ProductId = 254,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 628,
                            Link = "https://www.trendyol.com/dell/inspiron-3511-intel-core-i5-1135g7-16gb-256gb-ssd-windows-10-home-15-6-f35obf821na24-p-247748341?boutiqueId=613344&merchantId=155616",
                            Price = 12971f,
                            ProductId = 254,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 629,
                            Link = "https://www.hepsiburada.com/dell-inspiron-3511-intel-core-i5-1135g7-16gb-512gb-ssd-linux-15-6-tasinabilir-bilgisayar-f35obf821na4-p-HBCV00001DZIYN",
                            Price = 12912f,
                            ProductId = 255,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 630,
                            Link = "https://www.trendyol.com/dell/inspiron-3511-intel-core-i5-1135g7-16gb-512gb-ssd-linux-15-6-f35obf821na4-p-247553283?boutiqueId=613344&merchantId=155616",
                            Price = 13073f,
                            ProductId = 255,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 631,
                            Link = "https://www.hepsiburada.com/dell-inspiron-3511-intel-core-i5-1135g7-16gb-512gb-ssd-windows-10-home-15-6-tasinabilir-bilgisayar-f35obf821na25-p-HBCV00001DZIZT",
                            Price = 13620f,
                            ProductId = 256,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 632,
                            Link = "https://www.trendyol.com/dell/inspiron-3511-intel-core-i5-1135g7-16gb-512gb-ssd-windows-10-home-15-6-f35obf821na25-p-247579155?boutiqueId=613344&merchantId=155616",
                            Price = 13787f,
                            ProductId = 256,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 633,
                            Link = "https://www.hepsiburada.com/dell-g15-5515-amd-ryzen-7-5800h-16gb-512gb-ssd-rtx3060-windows-11-home-15-6-fhd-tasinabilir-bilgisayar-6gr7w165n-p-HBCV000015TJ4I",
                            Price = 26998f,
                            ProductId = 257,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 634,
                            Link = "https://www.trendyol.com/dell/g15-5515-amd-ryzen-7-5800h-16gb-512gb-ssd-rtx3060-windows-11-home-15-6-fhd-6gr7w165n-p-241212492?boutiqueId=613344&merchantId=118442",
                            Price = 26999f,
                            ProductId = 257,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 635,
                            Link = "https://www.hepsiburada.com/dell-inspiron-14-7400-intel-core-i5-1135g7-8gb-256gb-ssd-14-5-windows-10-pro-tasinabilir-bilgisayar-7400-s35wp82n-p-HBCV0000065F8Z",
                            Price = 13798f,
                            ProductId = 258,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 636,
                            Link = "https://www.trendyol.com/dell/inspiron-14-7400-ci5-1135g7-8gb-256gb-ssd-14-5-win-10-pro-7400-s35wp82n-p-104200339?boutiqueId=613344&merchantId=105013",
                            Price = 17999f,
                            ProductId = 258,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 637,
                            Link = "https://www.hepsiburada.com/casper-excalibur-g770-1140-8el0t-b-intel-core-i5-11400h-8gb-500gb-ssd-rtx3050ti-windows-11-home-15-6-tasinabilir-bilgisayar-p-HBCV00001D8UF8",
                            Price = 19998f,
                            ProductId = 259,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 638,
                            Link = "https://www.trendyol.com/casper/excalibur-g770-1140-8vj0t-b-intel-core-i5-11400h-8gb-ram-500gb-nvme-ssd-4gb-rtx3050-w11-p-119869815?boutiqueId=613344&merchantId=114258",
                            Price = 19799f,
                            ProductId = 259,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 639,
                            Link = "https://www.hepsiburada.com/casper-nirvana-s500-1135-8e00t-g-f-intel-core-i5-1135g7-8gb-500gb-ssd-windows-11-home-15-6-fhd-tasinabilir-bilgisayar-p-HBCV000017G4PQ",
                            Price = 12500f,
                            ProductId = 260,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 640,
                            Link = "https://www.n11.com/urun/casper-nirvana-s500-1135-8e00t-g-f-i5-1135g7-8-gb-500-gb-156-w11h-fhd-dizustu-bilgisayar-13017197?magaza=teknosepeti",
                            Price = 13199f,
                            ProductId = 260,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 641,
                            Link = "https://www.trendyol.com/casper/nirvana-11-nesil-core-i5-1135g7-8gb-500gb-ssd-15-6inc-w11-p-358435374?boutiqueId=61&merchantId=624588",
                            Price = 12999f,
                            ProductId = 261,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 642,
                            Link = "https://www.vatanbilgisayar.com/casper-nirvana-11-nesil-core-i5-1135g7-8gb-500gb-ssd-15-6inc-w11.html",
                            Price = 12999f,
                            ProductId = 261,
                            Rate = 5f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 643,
                            Link = "https://www.hepsiburada.com/casper-nirvana-x500-1021-8d00x-g-f-intel-core-i5-10210u-8gb-240gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV0000042AML",
                            Price = 11999f,
                            ProductId = 262,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 644,
                            Link = "https://www.trendyol.com/casper/nirvana-x500-1021-8d00x-g-f-intel-core-i5-10210u-8gb-240gb-ssd-freedos-dizustu-bilgisayar-p-138056911?boutiqueId=613344&merchantId=259994",
                            Price = 11999f,
                            ProductId = 262,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 645,
                            Link = "https://www.hepsiburada.com/casper-excalibur-g770-1245-8vj0x-b-intel-core-i5-12450h-8gb-ram-500gb-nvme-ssd-4gb-rtx3050-freedos-tasinabilir-bilgisayar-p-HBCV00002FCZHW",
                            Price = 20998f,
                            ProductId = 263,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 646,
                            Link = "https://www.trendyol.com/casper/excalibur-g770-1245-8vj0x-b-intel-12-nesil-i5-12450h-8gb-ram-500gb-nvme-ssd-4gb-rtx3050-freedos-p-311975826?boutiqueId=613344&merchantId=114258",
                            Price = 19599f,
                            ProductId = 263,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 647,
                            Link = "https://www.trendyol.com/casper/excalibur-g770-1160-bvh0x-b-intel-core-i7-11600h-16gb-ram-500gb-nvme-ssd-4gb-gtx1650-freedos-15-6-p-211200793?boutiqueId=614790&merchantId=968",
                            Price = 18998f,
                            ProductId = 264,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 648,
                            Link = "https://www.vatanbilgisayar.com/casper-excalibur-11-nesil-core-i7-11600h-16gb-500gb-ssd-15-6inc-gtx1650-4gb-dos.html",
                            Price = 19999f,
                            ProductId = 264,
                            Rate = 5f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 649,
                            Link = "https://www.trendyol.com/hp/250-g9-6q8m6es-i5-1235u-8gb-512gb-ssd-15-6-full-hd-freedos-notebook-p-353769658?boutiqueId=61&merchantId=133639",
                            Price = 13549f,
                            ProductId = 265,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 650,
                            Link = "https://www.n11.com/urun/hp-250-g9-6q8m6es-i5-1235u-8-gb-512-gb-ssd-mx550-156-free-dos-fhd-dizustu-bilgisayar-24330001?magaza=sitebilgisayar",
                            Price = 13248f,
                            ProductId = 265,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 651,
                            Link = "https://www.trendyol.com/hp/250-g8-5n2y4es-i5-1135g7-8gb-512gb-ssd-2gb-mx350-vga-15-6-dos-p-338995087?boutiqueId=613344&merchantId=230901",
                            Price = 12851f,
                            ProductId = 266,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 652,
                            Link = "https://www.n11.com/urun/hp-250-g8-5n2y4es-i5-1135g7-8-gb-512-gb-ssd-mx130-156-free-dos-dizustu-bilgisayar-17998492?magaza=sastar",
                            Price = 12590f,
                            ProductId = 266,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 653,
                            Link = "https://www.hepsiburada.com/hp-pavilion-gaming-laptop-15-ec2057nt-amd-ryzen-5-5600h-8-gb-512-gb-ssd-rtx-3050-144-hz-freedos-15-6-fhd-tasinabilir-bilgisayar-68n72ea-p-HBCV000022Q786",
                            Price = 16099f,
                            ProductId = 267,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 654,
                            Link = "https://www.trendyol.com/hp/pavilion-gaming-laptop-ryzen5-5600h-8gb-512-ssd-rtx3050-144hz-dos-15-6-fhd-68n72ea-p-280779449?boutiqueId=614908&merchantId=216294",
                            Price = 16199f,
                            ProductId = 267,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 655,
                            Link = "https://www.hepsiburada.com/hp-elitebook-840-g8-336d6ea01-i7-1165g7-16gb-1tbssd-14-fullhd-w10p-tasinabilir-bilgisayar-p-HBCV00002GPIVJ",
                            Price = 25900f,
                            ProductId = 268,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 656,
                            Link = "https://www.trendyol.com/hp/elitebook-840-g8-intel-i7-1165g7-16gb-1tb-ssd-win10p-14-fhd-336d6ea01-p-329728169?boutiqueId=613344&merchantId=106536",
                            Price = 29139f,
                            ProductId = 268,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 657,
                            Link = "https://www.hepsiburada.com/hp-probook-450-g8-3-1115g4-4-gb-256-gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-32m62ea-p-HBCV00000UA30K",
                            Price = 8929f,
                            ProductId = 269,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 658,
                            Link = "https://www.n11.com/urun/hp-probook-450-g8-32m62ea-i3-1115g4-4-gb-256-gb-ssd-156-free-dos-dizustu-bilgisayar-1918895?magaza=vesmark",
                            Price = 8529f,
                            ProductId = 269,
                            Rate = 4f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 659,
                            Link = "https://www.trendyol.com/hp/dizustu-bilgisayar-15-6-fhd-intel-i3-1115g4-4-gb-ram-256-gb-ssd-freedos-2n2q9ea-p-125684008?boutiqueId=613344&merchantId=607612",
                            Price = 9899f,
                            ProductId = 270,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 660,
                            Link = "https://www.n11.com/urun/hp-15s-fq2046nt-2n2q9ea-i3-1115g4-4-gb-256-gb-ssd-156-free-dos-fhd-dizustu-bilgisayar-2064945?magaza=c1teknoloji",
                            Price = 8966f,
                            ProductId = 270,
                            Rate = 4f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 661,
                            Link = "https://www.hepsiburada.com/hp-250-g8-intel-core-i7-1165g7-16gb-512gb-ssd-15-6-fhd-freedos-tasinabilir-bilgisayar-34n99esa4-p-HBCV00000UB8RS",
                            Price = 16102f,
                            ProductId = 271,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 662,
                            Link = "https://www.trendyol.com/hp/250-g8-intel-core-i7-1165g7-16gb-512gb-ssd-15-6-fhd-freedos-34n99esa4-p-177301676?boutiqueId=613344&merchantId=155616",
                            Price = 16389f,
                            ProductId = 271,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 663,
                            Link = "https://www.trendyol.com/hp/elitebook-850-g8-401f0ea-i7-1165g7-16gb-512gb-ssd-15-6-dos-p-335916899?boutiqueId=613344&merchantId=207789",
                            Price = 22648f,
                            ProductId = 272,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 664,
                            Link = "https://www.n11.com/urun/hp-elitebook-850-g8-401f0ea-i7-1165g7-16-gb-512-gb-ssd-156-free-dos-dizustu-bilgisayar-2060479?magaza=indeokurumsal",
                            Price = 25164f,
                            ProductId = 272,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 665,
                            Link = "https://www.hepsiburada.com/hp-255-g8-amd-ryzen7-5700u-16gb-512-gb-ssd-windows-10-home-15-6-fhd-tasinabilir-bilgisayar-4p3m3es04-p-HBCV00001CJAS2",
                            Price = 13939f,
                            ProductId = 273,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 666,
                            Link = "https://www.trendyol.com/hp/255-g8-4p3m3es04-ryzen7-5700u-16gb-512ssd-15-6-fullhd-w10h-tasinabilir-bilgisayar-p-237060602?boutiqueId=613344&merchantId=106664",
                            Price = 13388f,
                            ProductId = 273,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 667,
                            Link = "https://www.hepsiburada.com/hp-proobok-440-g9-intel-core-i7-1255u-64gb-1tb-ssd-2gb-mx570a-windows11pro-14-fhd-tasinabilir-bilgisayar-6s6w2ea28-p-HBCV00002Z1TCN",
                            Price = 36485f,
                            ProductId = 274,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 668,
                            Link = "https://www.trendyol.com/hp/proobok-440-g9-intel-core-i7-1255u-64gb-1tb-ssd-2gb-mx570a-windows11pro-14-fhd-6s6w2ea28-p-360740407?boutiqueId=61&merchantId=106536",
                            Price = 37229f,
                            ProductId = 274,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 669,
                            Link = "https://www.hepsiburada.com/hp-proobok-450-g9-intel-core-i7-1255u-64-gb-2-tb-ssd-windows-11-pro-15-6-fhd-tasinabilir-bilgisayar-6s6x1ea29-p-HBCV00002Y85XL",
                            Price = 31457f,
                            ProductId = 275,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 670,
                            Link = "https://www.trendyol.com/hp/proobok-450-g9-intel-core-i7-1255u-64gb-2tb-ssd-windows-11-pro-15-6-fhd-6s6x1ea29-p-361915343?boutiqueId=61&merchantId=106536",
                            Price = 32099f,
                            ProductId = 275,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 671,
                            Link = "https://www.hepsiburada.com/hp-pavilion-15-dk207nt-intel-core-i5-11300h-8gb-512gb-ssd-rtx3050-freedos-15-6-tasinabilir-bilgisayar-54t32ea-p-HBCV00001XOSZ7",
                            Price = 18499f,
                            ProductId = 276,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 672,
                            Link = "https://www.trendyol.com/hp/pavilion-15-dk2076nt-54t32ea-i5-11300h-8gb-512ssd-rtx3050-15-6-fullhd-freedos-tasinabilir-bilgis-p-308279022?boutiqueId=613344&merchantId=412659",
                            Price = 19399f,
                            ProductId = 276,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 673,
                            Link = "https://www.hepsiburada.com/hp-15-dw4010nta4-intel-core-i5-1235u-16gb-512gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-6y7z9eaa4-p-HBCV00002XX04W",
                            Price = 12650f,
                            ProductId = 277,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 674,
                            Link = "https://www.trendyol.com/hp/15-dw4010nta4-intel-core-i5-1235u-16gb-512gb-ssd-freedos-15-6-6y7z9eaa4-p-357954241?boutiqueId=61&merchantId=155616",
                            Price = 12760f,
                            ProductId = 277,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 675,
                            Link = "https://www.hepsiburada.com/hp-15-dw4010nt-intel-core-i5-1235u-16gb-512gb-ssd-w10-pro-15-6-tasinabilir-bilgisayar-6y7z9eac14-p-HBCV00002YLX45",
                            Price = 14399f,
                            ProductId = 278,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 676,
                            Link = "https://www.trendyol.com/hp/15-dw4010nt-intel-core-i5-1235u-16gb-512gb-ssd-w10-pro-15-6-tasinabilir-bilgisayar-6y7z9eac14-p-357614935?boutiqueId=61&merchantId=167131",
                            Price = 14601f,
                            ProductId = 278,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 677,
                            Link = "https://www.hepsiburada.com/hp-omen-15-ek1012nt-intel-core-i7-10870h-16gb-512gb-ssd-rtx-3060-6gb-freedos-15-6-144hz-ips-fhd-gaming-tasinabilir-bilgisayar-4h0j0ea-p-HBCV00001OCNIL",
                            Price = 28999f,
                            ProductId = 279,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 678,
                            Link = "https://www.trendyol.com/hp/omen-15-ek1012nt-intel-core-i7-10870h-16gb-512gb-ssd-rtx-3060-6gb-freedos-15-6-144hz-ips-fhd-gam-p-250201124?boutiqueId=614908&merchantId=216294",
                            Price = 26999f,
                            ProductId = 279,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 679,
                            Link = "https://www.hepsiburada.com/hp-probook-450-g9-6a180ea-intel-core-i7-1255u-16-gb-512-gb-ssd-windows-11-pro-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00002Y5XK0",
                            Price = 22150f,
                            ProductId = 280,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 680,
                            Link = "https://www.trendyol.com/hp/probook-450-g9-6a180ea-intel-core-i7-1255u-16gb-512gb-ssd-15-6-fullhd-windows11pro-tasinabilir-b-p-358472024?boutiqueId=61&merchantId=105149",
                            Price = 29639f,
                            ProductId = 280,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 681,
                            Link = "https://www.hepsiburada.com/hp-250-g8-intel-core-i7-1165g7-32gb-1tb-ssd-15-6-fhd-windows-10-pro-tasinabilir-bilgisayar-34n99esa25-p-HBCV00000UB8SY",
                            Price = 19792f,
                            ProductId = 281,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 682,
                            Link = "https://www.n11.com/urun/hp-250-g8-34n99esa25-i7-1165g7-32-gb-1-tb-ssd-156-w10p-fhd-dizustu-bilgisayar-17999547?magaza=arcadia-bilisim",
                            Price = 19557f,
                            ProductId = 281,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 683,
                            Link = "https://www.hepsiburada.com/hp-14s-fq1014nt-amd-ryzen-5-5500u-8gb-256gb-ssd-windows-10-home-14-tasinabilir-bilgisayar-4h0v4ea-p-HBCV000013LNEQ",
                            Price = 8900f,
                            ProductId = 282,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 684,
                            Link = "https://www.n11.com/urun/hp-14s-fq1014nt-4h0v4ea-ryzen-5-5500u-8-gb-256-gb-ssd-14-w10h-dizustu-bilgisayar-2480844?magaza=enfiyat",
                            Price = 8890f,
                            ProductId = 282,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 685,
                            Link = "https://www.hepsiburada.com/hp-laptop-14s-fq1012nt-amd-ryzen-5-5500u-8-gb-256-gb-ssd-14-hd-windows-10-home-tasinabilir-bilgisayar-4h0v3ea-p-HBCV0000113TFA",
                            Price = 9989f,
                            ProductId = 283,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 686,
                            Link = "https://www.trendyol.com/hp/laptop-14s-fq1012nt-amd-ryzen-5-5500u-8-gb-256-gb-ssd-14-hd-w10h-tasinabilir-bilgisayar-4h0v3ea-p-194935533?boutiqueId=613344&merchantId=106740",
                            Price = 9989f,
                            ProductId = 283,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 687,
                            Link = "https://www.hepsiburada.com/hp-15s-eq3014nt-amd-ryzen-5-5625u-8gb-256gb-ssd-freedos-15-6-tasinabilir-bilgisayar-68n46ea-p-HBCV00002NZUVF",
                            Price = 9298f,
                            ProductId = 284,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 688,
                            Link = "https://www.trendyol.com/hp/15s-eq3014nt-amd-ryzen-5-5625u-8gb-256gb-ssd-freedos-15-6-tasinabilir-bilgisayar-p-359464189?boutiqueId=61&merchantId=227581",
                            Price = 11500f,
                            ProductId = 284,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 689,
                            Link = "https://www.trendyol.com/hp/255-g9-6q8n1es-ryzen-5-5625u-8-gb-256-gb-ssd-15-6-free-dos-fhd-dizustu-bilgisayar-p-353251293?boutiqueId=61&merchantId=338337",
                            Price = 8999f,
                            ProductId = 285,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 690,
                            Link = "https://www.n11.com/urun/hp-255-g9-6q8n1es-ryzen-5-5625u-8-gb-256-gb-ssd-156-free-dos-fhd-dizustu-bilgisayar-22213326?magaza=iletisimbilgisayar",
                            Price = 9071f,
                            ProductId = 285,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 691,
                            Link = "https://www.trendyol.com/hp/250-g8-5n2y4es02-i5-1135g7-16gb-512ssd-mx350-15-6-fullhd-freedos-tasinabilir-bilgisayar-p-343962502?boutiqueId=613344&merchantId=106664",
                            Price = 16226f,
                            ProductId = 286,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 692,
                            Link = "https://www.n11.com/urun/hp-250-g8-5n2y4es02-i5-1135g7-16-gb-512-gb-ssd-mx350-156-free-dos-fhd-dizustu-bilgisayar-20932314?magaza=teknoraks",
                            Price = 14145f,
                            ProductId = 286,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 693,
                            Link = "https://www.trendyol.com/hp/250-g8-5n2y5es04-i5-1135g7-16gb-512ssd-mx130-15-6-fullhd-freedos-tasinabilir-bilgisayar-p-313143638?boutiqueId=613344&merchantId=106664",
                            Price = 13799f,
                            ProductId = 287,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 694,
                            Link = "https://www.n11.com/urun/hp-250-g8-5n2y5es04-i5-1135g7-16-gb-512-gb-ssd-mx130-156-free-dos-fhd-dizustu-bilgisayar-10569998?magaza=teknoraks",
                            Price = 13991f,
                            ProductId = 287,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 695,
                            Link = "https://www.trendyol.com/hp/omen-16-c0053nt-amd-ryzen-7-5800h-16gb-512gb-ssd-8gb-rx-6600m-16-1-inc-fhd-win11-144hz-68p69ea-p-316792896?boutiqueId=614596&merchantId=467452",
                            Price = 25799f,
                            ProductId = 288,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 696,
                            Link = "https://www.n11.com/urun/hp-omen-16-c0053nt-68p69ea-r7-5800h-16-gb-512-gb-ssd-rx6600m-144hz-161-w11h-dizustu-bilgisayar-13049149?magaza=tekramarket",
                            Price = 24287f,
                            ProductId = 288,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 697,
                            Link = "https://www.hepsiburada.com/hp-victus-laptop-16-e1004nt-amd-ryzen-7-6800h-16-gb-512gb-ssd-rtx-3050ti-16-1-fhd-144-hz-freedos-tasinabilir-bilgisayar-68s20ea-p-HBCV00002N9X8T",
                            Price = 27819f,
                            ProductId = 289,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 698,
                            Link = "https://www.trendyol.com/hp/victus-16-e1004nt-68s20ea-ryzen7-6800h-16gb-512ssd-rtx3050ti-16-1-fullhd-freedos-tasinabilir-bil-p-353978839?boutiqueId=613901&merchantId=106664",
                            Price = 23099f,
                            ProductId = 289,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 699,
                            Link = "https://www.hepsiburada.com/hp-proobok-450-g9-intel-core-i7-1255u-32gb-1tb-ssd-mx570a-windows11pro-15-6-fhd-tasinabilir-bilgisayar-6s748ea24-p-HBCV00002Z1TLN",
                            Price = 31771f,
                            ProductId = 290,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 700,
                            Link = "https://www.trendyol.com/hp/proobok-450-g9-intel-core-i7-1255u-32gb-1tb-ssd-mx570a-windows11pro-15-6-fhd-6s748ea24-p-360740605?boutiqueId=61&merchantId=106536",
                            Price = 32419f,
                            ProductId = 290,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 701,
                            Link = "https://www.trendyol.com/hp/240-g9-6q8l8es-i5-1235u-8gb-256gb-ssd-14-fdos-p-355212797?boutiqueId=61&merchantId=109239",
                            Price = 11429f,
                            ProductId = 291,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 702,
                            Link = "https://www.n11.com/urun/hp-240-g9-6q8l8es-i5-1235u-8-gb-256-gb-ssd-14-free-dos-fhd-dizustu-bilgisayar-22309577?magaza=ennet",
                            Price = 11549f,
                            ProductId = 291,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 703,
                            Link = "https://www.trendyol.com/hp/6q8n9es-250-g9-i5-1235u-8gb-256gb-15-6-freedos-tasinabilir-bilgisayar-p-353204913?boutiqueId=61&merchantId=238093",
                            Price = 11529f,
                            ProductId = 292,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 704,
                            Link = "https://www.n11.com/urun/hp-250-g9-6q8n9es-i5-1235u-8-gb-256-gb-ssd-156-free-dos-dizustu-bilgisayar-24895376?magaza=ennet",
                            Price = 12299f,
                            ProductId = 292,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 705,
                            Link = "https://www.hepsiburada.com/hp-255-g8-amd-ryzen-5-3500u-8gb-256gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-27k40ea-p-HBCV000006MYSO",
                            Price = 9199f,
                            ProductId = 293,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 706,
                            Link = "https://www.n11.com/urun/hp-255-g8-27k40ea-ryzen-5-3500u-8-gb-256-gb-ssd-156-free-dos-dizustu-bilgisayar-1988621?magaza=teknogros",
                            Price = 9389f,
                            ProductId = 293,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 707,
                            Link = "https://www.hepsiburada.com/hp-envy-13-ba1002nt-intel-core-i5-1135g7-8gb-ram-512gb-ssd-intel-irisx-windows-10-home-13-3-fhd-tasinabilir-bilgisayar-siyah-4h0t9ea-p-HBCV000013B5NQ",
                            Price = 12799f,
                            ProductId = 294,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 708,
                            Link = "https://www.trendyol.com/hp/envy-laptop-13-ba1002nt-4h0t9ea-intel-i5-1135g7-8gb-ram-512gb-ssd-iris-xe-13-3-w10h-notebook-p-232226663?boutiqueId=613344&merchantId=121368",
                            Price = 13364f,
                            ProductId = 294,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 709,
                            Link = "https://www.hepsiburada.com/hp-840-g8-2m5u1es-intel-core-i7-1165g7-8gb-512gb-ssd-freedos-14-tasinabilir-bilgisayar-p-HBCV000003A9XI",
                            Price = 20899f,
                            ProductId = 295,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 710,
                            Link = "https://www.n11.com/urun/hp-840-g8-2m5u1es-i7-1165g7-8-gb-512-gb-ssd-14-free-dos-dizustu-bilgisayar-1919499?magaza=vesmark",
                            Price = 20699f,
                            ProductId = 295,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 711,
                            Link = "https://www.trendyol.com/hp/255-g8-5-nesil-ryzen-5-5500u-8gb-512gb-ssd-w10h-15-6-w-10-p-282088521?boutiqueId=61&merchantId=650628",
                            Price = 11631f,
                            ProductId = 296,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 712,
                            Link = "https://www.vatanbilgisayar.com/hp-255-g8-5-nesil-ryzen-5-5500u-8gb-512gb-ssd-15-6-w10.html",
                            Price = 11099f,
                            ProductId = 296,
                            Rate = 4f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 713,
                            Link = "https://www.trendyol.com/hp/omen-laptop-15-ek1000nt-omen-core-i7-10870h-16gb-512gb-ssd-15-6-w10h-39c40ea-p-141068599?boutiqueId=613344&merchantId=154426",
                            Price = 36900f,
                            ProductId = 297,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 714,
                            Link = "https://www.n11.com/urun/hp-omen-15-ek1000nt-39c40ea-i7-10870h-16-gb-512-gb-ssd-rtx3070-156-w10h-fhd-dizustu-bilgisayar-2088127?magaza=notisteknoloji",
                            Price = 34900f,
                            ProductId = 297,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 715,
                            Link = "https://www.trendyol.com/hp/elitebook-860-g9-6f5w9ea-i7-1255u-16gb-512gb-ssd-16-fhd-windows-11-pro-p-368066322?boutiqueId=61&merchantId=105378",
                            Price = 29239f,
                            ProductId = 298,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 716,
                            Link = "https://www.n11.com/urun/hp-elitebook-860-g9-6f5w9ea-i7-1255u-16-gb-512-gb-ssd-16-w11p-wuxga-dizustu-bilgisayar-24300213?magaza=vesmark",
                            Price = 27999f,
                            ProductId = 298,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 717,
                            Link = "https://www.trendyol.com/hp/zbook-fury-17-g8-4a6b2ea-intel-core-i9-11950h-32gb-1tb-ssd-8gb-rtx-a4000-17-3-uhd-w10p-p-215402542?boutiqueId=613344&merchantId=105061",
                            Price = 89099f,
                            ProductId = 299,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 718,
                            Link = "https://www.n11.com/urun/hp-zbook-fury-17-g8-4a6b2ea-i9-11950h-32-gb-1-tb-ssd-rtx-a4000-173-w10p-uhd-dizustu-bilgisayar-2290967?magaza=vizyonbilgisayar",
                            Price = 89549f,
                            ProductId = 299,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 719,
                            Link = "https://www.hepsiburada.com/hp-250-g8-5n2y4es04-intel-core-i5-1135g7-32-gb-512-ssd-mx350-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00002SYSF9",
                            Price = 16359f,
                            ProductId = 300,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 720,
                            Link = "https://www.trendyol.com/hp/250-g8-5n2y4es04-i5-1135g7-32gb-512ssd-mx350-15-6-fullhd-freedos-tasinabilir-bilgisayar-p-343962540?boutiqueId=613344&merchantId=106664",
                            Price = 15299f,
                            ProductId = 300,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 721,
                            Link = "https://www.hepsiburada.com/hp-250-intel-core-i3-1115g4-4gb-256gb-ssd-windows-10-home-15-6-hd-tasinabilir-bilgisayar-34n69es-p-HBCV000004VVZ0",
                            Price = 8499f,
                            ProductId = 301,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 722,
                            Link = "https://www.trendyol.com/hp/250-intel-core-i3-1115g4-4gb-256gb-ssd-w10-15-6-34n69es-p-198752277?boutiqueId=61&merchantId=544545",
                            Price = 9199f,
                            ProductId = 301,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 723,
                            Link = "https://www.hepsiburada.com/hp-probook-430-g8-intel-core-i7-1165g7-64gb-1tb-ssd-windows-10-pro-13-3-fhd-tasinabilir-bilgisayar-4p3r0es11-p-HBCV000027PTAQ",
                            Price = 26529f,
                            ProductId = 302,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 724,
                            Link = "https://www.trendyol.com/hp/probook-430-g8-intel-core-i7-1165g7-64gb-1tb-ssd-win10p-13-3-fhd-4p3r0es11-p-329719872?boutiqueId=613344&merchantId=106536",
                            Price = 27070f,
                            ProductId = 302,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 725,
                            Link = "https://www.hepsiburada.com/hp-14s-dq2006nt-g7-intel-core-i5-1135g7-8gb-256gb-ssd-freedos-14-fhd-tasinabilir-bilgisayar-4g6a5ea-p-HBCV00000P9N2S",
                            Price = 10870f,
                            ProductId = 303,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 726,
                            Link = "https://www.trendyol.com/hp/laptop-14s-dq2006nt-g7-i5-1135g7-8gb-256ssd-14-inc-freedos-4g6a5ea-p-144141356?boutiqueId=613344&merchantId=449692",
                            Price = 10555f,
                            ProductId = 303,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 727,
                            Link = "https://www.trendyol.com/hp/probook-440-uyumlu-g9-5y3z1ea-i5-1235u-8gb-256ssd-14-fullhd-w11p-tasinabilir-bilgisayar-p-365973260?boutiqueId=61&merchantId=106664",
                            Price = 25999f,
                            ProductId = 304,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 728,
                            Link = "https://www.n11.com/urun/hp-probook-440-g9-5y3z1ea-i5-1235u-8-gb-256gb-ssd-14-w11p-fhd-dizustu-bilgisayar-24300184?magaza=vesmark",
                            Price = 16999f,
                            ProductId = 304,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 729,
                            Link = "https://www.hepsiburada.com/hp-255-g7-amd-ryzen-3-3200u-8gb-256gb-ssd-windows-10-home-15-6-tasinabilir-bilgisayar-255f6es-s8-p-HBCV00000645AX",
                            Price = 8499f,
                            ProductId = 305,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 730,
                            Link = "https://www.n11.com/urun/hp-255-g7-255f6es-s8-ryzen-3-3200u-8-gb-256-gb-ssd-156-w10h-dizustu-bilgisayar-1985622?magaza=tezbilgisayar",
                            Price = 8730f,
                            ProductId = 305,
                            Rate = 4f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 731,
                            Link = "https://www.trendyol.com/hp/255-g9-6q8n2es-r5-5625u-8gb-512ssd-15-6-fdos-p-354471710?boutiqueId=61&merchantId=124635",
                            Price = 9889f,
                            ProductId = 306,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 732,
                            Link = "https://www.n11.com/urun/hp-255-g9-6q8n2es-ryzen-5-5625u-8-gb-512-gb-ssd-156-free-dos-dizustu-bilgisayar-21026959?magaza=7renk",
                            Price = 9949f,
                            ProductId = 306,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 733,
                            Link = "https://www.trendyol.com/hp/envy-x360-amd-ryzen7-4700u-8-gb-512ssd-13-3-touch-ekran-windows-10-home-tasi-4h0n8ea-p-122259621?boutiqueId=613344&merchantId=106740",
                            Price = 16989f,
                            ProductId = 307,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 734,
                            Link = "https://www.n11.com/urun/hp-envy-x360-convert-13-ay0007nt-4h0n8ea-r7-4700u-8-gb-512-gb-ssd-133-w10h-dizustu-bilgisayar-2073312?magaza=teknoryabilisim",
                            Price = 16999f,
                            ProductId = 307,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 735,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t15-i7-1165g7-16-gb-500-gb-ssd-15-6-fhd-2gb-mx450-freedos-20w4s0b3tx004-p-356796523?boutiqueId=613901&merchantId=114271",
                            Price = 34270f,
                            ProductId = 308,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 736,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-t15-g2-20w4s0b3tx004-i7-1165g7-16-gb-500-gb-ssd-mx450-156-dos-dizustu-bilgisayar-25041448?magaza=victory",
                            Price = 35304f,
                            ProductId = 308,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 737,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e15-gen-2-i7-1165g7-16gb-512gb-ssd-2gb-mx450-freedos-15-6-fhd-20tds02vtx004-p-101180960?boutiqueId=613344&merchantId=114271",
                            Price = 23247f,
                            ProductId = 309,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 738,
                            Link = "https://www.n11.com/urun/lenovo-e15-gen2-20tds02vtx004-i7-1165g7-16-gb-512-gb-ssd-2-gb-mx450-156-free-dos-dizustu-bilgisayar-1977355?magaza=victory",
                            Price = 23029f,
                            ProductId = 309,
                            Rate = 4f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 739,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e15-g2-20tds08k00-intel-core-i7-1165g7-16gb-512gb-ssd-2gb-mx450-15-6-fullhd-freedos-p-345886443?boutiqueId=613344&merchantId=105149",
                            Price = 30059f,
                            ProductId = 310,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 740,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-e15-g2-20tds08k00-i7-1165g7-16-gb-512-gb-ssd-mx450-156-dos-dizustu-bilgisayar-2086573?magaza=indeokurumsal",
                            Price = 21432f,
                            ProductId = 310,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 741,
                            Link = "https://www.hepsiburada.com/lenovo-v15-intel-core-i7-1165g7-16gb-512gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-82kb00cdtx-p-HBCV00002DB00Z",
                            Price = 16999f,
                            ProductId = 311,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 742,
                            Link = "https://www.trendyol.com/lenovo/v15-82kb00cdtx-i7-1165g7-16gb-512gb-ssd-15-6-fhd-freedos-p-308124050?boutiqueId=614348&merchantId=534573",
                            Price = 17499f,
                            ProductId = 311,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 743,
                            Link = "https://www.hepsiburada.com/lenovo-v15-g2-intel-core-i7-1165g7-16gb-512gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-82kb00cbtx06-p-HBCV00002LFIE4",
                            Price = 19697f,
                            ProductId = 312,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 744,
                            Link = "https://www.trendyol.com/lenovo/v15-g2-intel-core-i7-1165g7-16gb-512gb-ssd-freedos-15-6-fhd-82kb00cbtx06-p-329716410?boutiqueId=61&merchantId=109239",
                            Price = 14948f,
                            ProductId = 312,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 745,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e15-gen-2-i7-1165g7-32gb-1tb-ssd-2gb-mx450-freedos-15-6-fhd-20tds02vtx008-p-101180904?boutiqueId=613344&merchantId=114271",
                            Price = 24999f,
                            ProductId = 313,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 746,
                            Link = "https://www.n11.com/urun/lenovo-e15-gen2-20tds02vtx008-i7-1165g7-32-gb-1-tb-ssd-2-gb-mx450-156-free-dos-dizustu-bilgisayar-1977359?magaza=victory",
                            Price = 24606f,
                            ProductId = 313,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 747,
                            Link = "https://www.hepsiburada.com/lenovo-thinkpad-e15-gen-2-intel-core-i7-1165g7-16-gb-512-gb-ssd-windows-11-pro-mx450-15-6-fhd-20td004htx047-p-HBCV00002CSPR7",
                            Price = 25875f,
                            ProductId = 314,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 748,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e15-gen-2-core-i7-1165g7-16gb-512gb-ssd-win-11-pro-mx450-15-6-fhd-20td004htx047-p-307290612?boutiqueId=613344&merchantId=114271",
                            Price = 26269f,
                            ProductId = 314,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 749,
                            Link = "https://www.hepsiburada.com/lenovo-thinkpad-t15-i7-1165g7-16-gb-512-gb-ssd-15-6-fhd-2-gb-mx450-windows-11-pro-20w4s0b3tx051-p-HBCV00002Y84IF",
                            Price = 38207f,
                            ProductId = 315,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 750,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t15-i7-1165g7-16-gb-512-gb-ssd-15-6-fhd-2gb-mx450-windows-11-pro-20w4s0b3tx051-p-356792432?boutiqueId=613901&merchantId=114271",
                            Price = 37840f,
                            ProductId = 315,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 751,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t15-i7-1165g7-16-gb-500-gb-ssd-15-6-fhd-2gb-mx450-windows-10-pro-20w4s0b3tx018-p-356800506?boutiqueId=613901&merchantId=114271",
                            Price = 37840f,
                            ProductId = 316,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 752,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-t15-g2-20w4s0b3tx018-i7-1165g7-16-gb-500-gb-ssd-mx450-156-w10p-dizustu-bilgisayar-25041431?magaza=victory",
                            Price = 38982f,
                            ProductId = 316,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 753,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t15-i7-1165g7-16-gb-1-tb-ssd-15-6-fhd-2gb-mx450-freedos-20w4s0b3tx009-p-356799305?boutiqueId=613901&merchantId=114271",
                            Price = 35366f,
                            ProductId = 317,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 754,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-t15-g2-20w4s0b3tx009-i7-1165g7-16-gb-1-tb-ssd-mx450-156-dos-dizustu-bilgisayar-25041434?magaza=victory",
                            Price = 36434f,
                            ProductId = 317,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 755,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e15-gen-2-i7-1165g7-32gb-1tb-ssd-2gb-mx450-windows-10-pro-15-6-fhd-20tds02vtx026-p-101217399?boutiqueId=613344&merchantId=114271",
                            Price = 27507f,
                            ProductId = 318,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 756,
                            Link = "https://www.n11.com/urun/lenovo-e15-gen2-20tds02vtx026-i7-1165g7-32-gb-1-tb-ssd-2-gb-mx450-156-w10p-dizustu-bilgisayar-1977417?magaza=victory",
                            Price = 26364f,
                            ProductId = 318,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 757,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t15-i7-1165g7-32-gb-1-tb-ssd-15-6-fhd-2gb-mx450-windows-10-pro-20w4s0b3tx026-p-356793844?boutiqueId=613901&merchantId=114271",
                            Price = 40695f,
                            ProductId = 319,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 758,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-t15-g2-20w4s0b3tx026-i7-1165g7-32-gb-1-tb-ssd-mx450-156-w10p-dizustu-bilgisayar-25041403?magaza=victory",
                            Price = 41924f,
                            ProductId = 319,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 759,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t15-i7-1165g7-32-gb-512-gb-ssd-15-6-fhd-2gb-mx450-windows-10-pro-20w4s0b3tx023-p-356796449?boutiqueId=613901&merchantId=114271",
                            Price = 39553f,
                            ProductId = 320,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 760,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-t15-g2-20w4s0b3tx023-i7-1165g7-32-gb-512-gb-ssd-mx450-156-w10p-dizustu-bilgisayar-25041426?magaza=victory",
                            Price = 40747f,
                            ProductId = 320,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 761,
                            Link = "https://www.hepsiburada.com/lenovo-v14-g2-itl-intel-core-i5-1135g7-8gb-256gb-ssd-mx350-freedos-14-fhd-tasinabilir-bilgisayar-82ka00ectx-p-HBCV00001HFW6I",
                            Price = 10399f,
                            ProductId = 321,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 762,
                            Link = "https://www.trendyol.com/lenovo/v14-g2-itl-i5-1135g7-8-gb-256-gb-ssd-nvidia-geforce-mx350-2gb-freedos-14-fhd-82ka00ectx-p-261723270?boutiqueId=614347&merchantId=107007",
                            Price = 10499f,
                            ProductId = 321,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 763,
                            Link = "https://www.trendyol.com/lenovo/v15-intel-core-i5-1135g7-16-gb-512-gb-ssd-freedos-15-6-fhd-82kb00catx012-p-338614607?boutiqueId=613344&merchantId=114271",
                            Price = 13949f,
                            ProductId = 322,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 764,
                            Link = "https://www.n11.com/urun/lenovo-v15-g2-itl-82kb00catx012-i5-1135g7-16-gb-512-gb-ssd-156-free-dos-dizustu-bilgisayar-18795567?magaza=victory",
                            Price = 14657f,
                            ProductId = 322,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 765,
                            Link = "https://www.trendyol.com/lenovo/v15-82kd0045tx-ryzen-r7-5700u-16gb-512gb-ssd-15-6-fhd-freedos-tasinabilir-bilgisayar-p-362235473?boutiqueId=61&merchantId=104683",
                            Price = 12999f,
                            ProductId = 323,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 766,
                            Link = "https://www.n11.com/urun/lenovo-v15-g2-alc-82kd0045tx-ryzen-7-5700u-16-gb-512-gb-ssd-156-free-dos-dizustu-bilgisayar-24918679?magaza=techburada",
                            Price = 14195f,
                            ProductId = 323,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 767,
                            Link = "https://www.hepsiburada.com/lenovo-thinkbook-15-gen3-acl-amd-ryzen7-5700u-16-gb-512-gb-ssd-freedos-15-6-tasinabilir-bilgisayar-21a40037tx01-p-HBCV000024AAVY",
                            Price = 14799f,
                            ProductId = 324,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 768,
                            Link = "https://www.trendyol.com/lenovo/thinkbook-15-gen3-acl-amd-ryzen7-5700u-16-gb-512-gb-ssd-freedos-15-6-21a40037tx01-p-329465693?boutiqueId=61&merchantId=668931",
                            Price = 13859f,
                            ProductId = 324,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 769,
                            Link = "https://www.trendyol.com/lenovo/thinkbook-15-g3-21a40036tx-ryzen7-5700u-16gb-512gb-15-6-freedos-tasinabilir-bilgisayar-p-215491714?boutiqueId=613344&merchantId=105378",
                            Price = 14449f,
                            ProductId = 325,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 770,
                            Link = "https://www.n11.com/urun/lenovo-thinkbook-15-g3-21a40036tx-ryzen-7-5700u-16-gb-512-gb-ssd-156-free-dos-fhd-dizustu-bilgisayar-2431246?magaza=bszelektronik",
                            Price = 15799f,
                            ProductId = 325,
                            Rate = 4f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 771,
                            Link = "https://www.hepsiburada.com/lenovo-ideapad-3-amd-ryzen-7-5700u-8gb-512gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-82ku00vntx-p-HBCV000021REF9",
                            Price = 10998f,
                            ProductId = 326,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 772,
                            Link = "https://www.trendyol.com/lenovo/ideapad-3-amd-ryzen-7-5700u-8gb-512gb-ssd-freedos-15-6-82ku00vntx-p-343935047?boutiqueId=61&merchantId=481559",
                            Price = 12176f,
                            ProductId = 326,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 773,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e14-gen-2-core-i5-1135g7-8gb-256gb-ssd-2gb-mx450-freedos-14-fhd-20ta0054tx-p-121793653?boutiqueId=614348&merchantId=106664",
                            Price = 15599f,
                            ProductId = 327,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 774,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-e14-20ta0054tx-i5-1135g7-8-gb-256-gb-ssd-14-free-dos-dizustu-bilgisayar-18087501?magaza=kuantumsanal",
                            Price = 20209f,
                            ProductId = 327,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 775,
                            Link = "https://www.hepsiburada.com/lenovo-v14-g2-itl-intel-core-i5-1135g7-8gb-256gb-ssd-14-full-hd-freedos-tasinabilir-bilgisayar-82ka0025tx-p-HBCV00000R3940",
                            Price = 9999f,
                            ProductId = 328,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 776,
                            Link = "https://www.trendyol.com/lenovo/v14-g2-itl-82ka0025tx-i5-1135g7-8gb-256-gb-ssd-14-free-dos-fhd-dizustu-bilgisayar-p-137266259?boutiqueId=614347&merchantId=107007",
                            Price = 10499f,
                            ProductId = 328,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 777,
                            Link = "https://www.hepsiburada.com/lenovo-thinkpad-e15-gen-2-intel-core-i71165g7-32gb-1tb-ssd-512gb-ssd-2gb-mx450-freedos-15-6-fhd-tasinabilir-bilgisayar-20td004ktx012-p-HBCV00000017DW",
                            Price = 26644f,
                            ProductId = 329,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 778,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e15-gen2-core-i7-1165g7-32gb-1tb-512gb-ssd-2gb-mx450-dos-15-6-fhd-20td004ktx012-p-82376928?boutiqueId=613344&merchantId=114271",
                            Price = 26388f,
                            ProductId = 329,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 779,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t15-i7-1165g7-32-gb-500-gb-ssd-15-6-fhd-2gb-mx450-freedos-20w4s0b3tx006-p-356802559?boutiqueId=613901&merchantId=114271",
                            Price = 35915f,
                            ProductId = 330,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 780,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-t15-g2-20w4s0b3tx006-i7-1165g7-32-gb-500-gb-ssd-mx450-156-dos-dizustu-bilgisayar-25041429?magaza=victory",
                            Price = 36999f,
                            ProductId = 330,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 781,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t15-i7-1165g7-32-gb-512-gb-ssd-15-6-fhd-2gb-mx450-windows-11-home-20w4s0b3tx038-p-356792609?boutiqueId=613901&merchantId=114271",
                            Price = 38839f,
                            ProductId = 331,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 782,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-t15-g2-20w4s0b3tx038-i7-1165g7-32-gb-512-gb-ssd-mx450-156-w11h-dizustu-bilgisayar-25041470?magaza=victory",
                            Price = 40012f,
                            ProductId = 331,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 783,
                            Link = "https://www.hepsiburada.com/lenovo-e14-g2-20tas0cx00-i7-1165g7-16gb-512gb-ssd-2gb-mx450-14-fhd-freedos-p-HBCV00002YYZOU",
                            Price = 24578f,
                            ProductId = 332,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 784,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-e14-g2-20tas0cx00-i7-1165g7-16-gb-512-gb-ssd-mx450-14-free-dos-dizustu-bilgisayar-5286163?magaza=ek-ay",
                            Price = 22700f,
                            ProductId = 332,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 785,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t15-i7-1165g7-32-gb-1-tb-ssd-15-6-fhd-2gb-mx450-windows-11-pro-20w4s0b3tx056-p-356793499?boutiqueId=613901&merchantId=114271",
                            Price = 40695f,
                            ProductId = 333,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 786,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-t15-g2-20w4s0b3tx056-i7-1165g7-32-gb-1-tb-ssd-mx450-156-w11p-dizustu-bilgisayar-25041436?magaza=victory",
                            Price = 41924f,
                            ProductId = 333,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 787,
                            Link = "https://www.hepsiburada.com/lenovo-e14-g2-20ta00jxtx-i7-1165g7-16gb-512gb-ssd-2gb-mx450-14-fhd-windows-11-pro-p-HBCV00002YYZOW",
                            Price = 29302f,
                            ProductId = 334,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 788,
                            Link = "https://www.trendyol.com/lenovo/e14-g2-20ta00jxtx-i7-1165g7-16gb-512gb-ssd-2gb-mx450-14-fhd-windows-11-pro-p-358132426?boutiqueId=61&merchantId=631325",
                            Price = 25994f,
                            ProductId = 334,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 789,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t15-i7-1165g7-16-gb-1-tb-ssd-15-6-fhd-2gb-mx450-windows-11-pro-20w4s0b3tx054-p-357822077?boutiqueId=613901&merchantId=114271",
                            Price = 38982f,
                            ProductId = 335,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 790,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-t15-g2-20w4s0b3tx054-i7-1165g7-16-gb-1-tb-ssd-mx450-156-w11p-dizustu-bilgisayar-25041407?magaza=victory",
                            Price = 40159f,
                            ProductId = 335,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 791,
                            Link = "https://www.hepsiburada.com/lenovo-v15-gen2-itl-intel-core-i5-1135g7-8g-512-gb-2-gb-mx350-freedos-15-6-fhd-tasinabilir-bilgisayar-82kb00hwtx-p-HBCV00002GVQ8R",
                            Price = 12429f,
                            ProductId = 336,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 792,
                            Link = "https://www.trendyol.com/lenovo/v15-82kb00hwtx-intel-core-i5-1135g7-8gb-512gb-ssd-geforce-mx350-2gb-gddr5-15-6-fhd-freedos-p-316447795?boutiqueId=614347&merchantId=153592",
                            Price = 13000f,
                            ProductId = 336,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 793,
                            Link = "https://www.hepsiburada.com/lenovo-v15-g2-itl-intel-core-i5-1135g7-8gb-512gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-82kb00catx-p-HBCV00002N8XE7",
                            Price = 11999f,
                            ProductId = 337,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 794,
                            Link = "https://www.trendyol.com/lenovo/v15-82kb00catx-i5-1135g7-8gb-512gb-ssd-15-6-tumlesik-vga-free-dos-p-329082240?boutiqueId=613344&merchantId=106934",
                            Price = 11999f,
                            ProductId = 337,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 795,
                            Link = "https://www.hepsiburada.com/lenovo-thinkpad-l15-g2-20x300ghtx-intel-core-i5-1135g7-8-gb-256-gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV000022AN15",
                            Price = 15892f,
                            ProductId = 338,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 796,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-l15-g2-20x300ghtx-i5-1135g7-8-gb-256-gb-ssd-156-free-dos-dizustu-bilgisayar-3725540?magaza=indeokurumsal",
                            Price = 15346f,
                            ProductId = 338,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 797,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e15-intel-core-i5-1135g7-8gb-256gb-ssd-15-6-fd-20td004gtx-p-148291526?boutiqueId=613344&merchantId=120019",
                            Price = 15839f,
                            ProductId = 339,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 798,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-e15-g2-20td004gtx-i5-1135g7-8-gb-256-gb-ssd-156-free-dos-fhd-dizustu-bilgisayar-2098018?magaza=yorungeonline",
                            Price = 14329f,
                            ProductId = 339,
                            Rate = 4f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 799,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e14-gen-2-i7-1165g7-32-gb-ram-1-tb-ssd-2gb-mx450-win10p-14-fhd-20ta0056tx041-p-125967028?boutiqueId=613344&merchantId=114271",
                            Price = 28548f,
                            ProductId = 340,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 800,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-e14-g2-20ta0056tx041-i7-1165g7-32-gb-1-tb-ssd-mx450-14-w10p-fhd-dizustu-bilgisayar-2087255?magaza=victory",
                            Price = 26299f,
                            ProductId = 340,
                            Rate = 4f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 801,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e14-gen-2-i7-1165g7-16gb-1-tbssd-fhd-mx450-14-w10pro-20tas0cxta32-p-355644271?boutiqueId=61&merchantId=107092",
                            Price = 26223f,
                            ProductId = 341,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 802,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-e14-g2-20tas0cxta32-i7-1165g7-16-gb-1-tb-ssd-mx450-14-w10p-dizustu-bilgisayar-24194699?magaza=b-t-teknoloji",
                            Price = 27053f,
                            ProductId = 341,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 803,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e14-gen2-i7-1165g7-16gb-1tb-ssd-windows-10-pro-14-fhd-20tbs44ctx018-p-220189884?boutiqueId=613344&merchantId=114271",
                            Price = 26379f,
                            ProductId = 342,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 804,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-e14-gen-2-20tbs44ctx018-i7-1165g7-16-gb-1-tb-ssd-14-w10p-dizustu-bilgisayar-2462459?magaza=victory",
                            Price = 24599f,
                            ProductId = 342,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 805,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t14-gen2-i7-1165g7-16-gb-1-tb-ssd-14-2gb-mx450-windows-11-pro-20wm0aehtx054-p-357151138?boutiqueId=613901&merchantId=114271",
                            Price = 38982f,
                            ProductId = 343,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 806,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-t14-g2-20wm0aehtx054-i7-1165g7-16-gb-1-tb-ssd-mx450-14-w11p-fhd-dizustu-bilgisayar-24321334?magaza=victory",
                            Price = 38346f,
                            ProductId = 343,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 807,
                            Link = "https://www.hepsiburada.com/lenovo-yoga-7-intel-core-i7-1165g7-16gb-512gb-ssd-windows-11-home-15-6-fhd-ikisi-bir-arada-bilgisayar-82bj00dmtx-p-HBCV000021REFR",
                            Price = 24999f,
                            ProductId = 344,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 808,
                            Link = "https://www.vatanbilgisayar.com/lenovo-yoga-7-11-nesil-core-i7-1165g7-16gb-512gb-ssd-14inc-w11.html",
                            Price = 28999f,
                            ProductId = 344,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 809,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t15-i7-1165g7-16-gb-256-gb-ssd-15-6-fhd-2gb-mx450-windows-11-pro-20w4s0b3tx045-p-357850068?boutiqueId=613901&merchantId=114271",
                            Price = 37126f,
                            ProductId = 345,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 810,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-t15-g2-20w4s0b3tx045-i7-1165g7-16-gb-256-gb-ssd-mx450-156-w11p-dizustu-bilgisayar-25041423?magaza=victory",
                            Price = 38246f,
                            ProductId = 345,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 811,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e14-gen-2-i7-1165g7-16gb-256gb-ssd-mx450-w10-pro-14-fhd-20ta0053tx25-p-133675754?boutiqueId=61&merchantId=107092",
                            Price = 25790f,
                            ProductId = 346,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 812,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-e14-g2-20ta0053tx25-i7-1165g7-16-gb-256-gb-ssd-mx450-14-w10p-fhd-dizustu-bilgisayar-2078039?magaza=victory",
                            Price = 24195f,
                            ProductId = 346,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 813,
                            Link = "https://www.hepsiburada.com/lenovo-v14-g2-itl-intel-core-i5-1135g7-16-gb-256-gb-ssd-mx350-2gb-freedos-14-fhd-tasinabilir-bilgisayar-82ka00ectx005-p-HBCV00002DLDLP",
                            Price = 12899f,
                            ProductId = 347,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 814,
                            Link = "https://www.trendyol.com/lenovo/v14-g2-intel-core-i5-1135g7-16-gb-256-gb-ssd-mx350-2gb-freedos-14-fhd-82ka00ectx005-p-309506790?boutiqueId=613344&merchantId=339221",
                            Price = 12899f,
                            ProductId = 347,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 815,
                            Link = "https://www.hepsiburada.com/lenovo-thinkpad-e14-gen-2-intel-core-i5-1135g7-16gb-256gb-freedos-14-fhd-tasinabilir-bilgisayar-20ta004ytx-p-HBCV00000BAWLT",
                            Price = 16999f,
                            ProductId = 348,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 816,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-e14-g2-20ta004ytx-i5-1135g7-16-gb-256-gb-ssd-14-free-dos-fhd-dizustu-bilgisayar-2082793?magaza=tekboyut",
                            Price = 16999f,
                            ProductId = 348,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 817,
                            Link = "https://www.hepsiburada.com/lenovo-ideapad-l3-intel-core-i7-1165g7-8gb-ram-512gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-82hl009htx-p-HBCV000015GG0U",
                            Price = 15999f,
                            ProductId = 349,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 818,
                            Link = "https://www.n11.com/urun/lenovo-ideapad-l3-82hl009htx-i7-1165g7-8-gb-512-gb-ssd-156-free-dos-fhd-dizustu-bilgisayar-2507354?magaza=bszelektronik",
                            Price = 16169f,
                            ProductId = 349,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 819,
                            Link = "https://www.hepsiburada.com/lenovo-thinkpad-e14-gen-2-intel-core-i7-1165g7-32-gb-1-tb-ssd-windows-11-pro-14-fhd-tasinabilir-bilgisayar-20tdr2abx45-p-HBCV00002R9UAN",
                            Price = 27546f,
                            ProductId = 350,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 820,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e14-gen-2-i7-1165g7-32gb-1-tbssd-w11pro14-20tdr2abx45-p-338901495?boutiqueId=613344&merchantId=107092",
                            Price = 27134f,
                            ProductId = 350,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 821,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t15-i7-1165g7-16-gb-256-gb-ssd-15-6-fhd-2gb-mx450-windows-10-pro-20w4s0b3tx015-p-356796429?boutiqueId=613901&merchantId=114271",
                            Price = 37126f,
                            ProductId = 351,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 822,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-t15-g2-20w4s0b3tx015-i7-1165g7-16-gb-256-gb-ssd-mx450-156-w10p-dizustu-bilgisayar-25041427?magaza=victory",
                            Price = 38246f,
                            ProductId = 351,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 823,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e14-gen-2-intel-core-i7-1165g7-16gb-1tb-ssd-w10h-14-fhd-20ta0050tx019-p-135044411?boutiqueId=613901&merchantId=114271",
                            Price = 26511f,
                            ProductId = 352,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 824,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-e14-g2-20ta0050tx019-i7-1165g7-16-gb-1-tb-ssd-14-w10h-fhd-dizustu-bilgisayar-2098193?magaza=victory",
                            Price = 26511f,
                            ProductId = 352,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 825,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e14-gen-2-i7-1165g7-16gb-2-tbssd-fhd-mx450-14-freedos-20tas0cxta11-p-356082596?boutiqueId=61&merchantId=107092",
                            Price = 25728f,
                            ProductId = 353,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 826,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-e14-g2-20tas0cxta11-i7-1165g7-16-gb-2-tb-ssd-mx450-14-free-dos-dizustu-bilgisayar-24194676?magaza=b-t-teknoloji",
                            Price = 27218f,
                            ProductId = 353,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 827,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t15-i7-1165g7-16-gb-2-tb-ssd-15-6-fhd-2gb-mx450-freedos-20w4s0b3tx012-p-356793385?boutiqueId=613901&merchantId=114271",
                            Price = 37971f,
                            ProductId = 354,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 828,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-t15-g2-20w4s0b3tx012-i7-1165g7-16-gb-2-tb-ssd-mx450-156-dos-dizustu-bilgisayar-25041433?magaza=victory",
                            Price = 39117f,
                            ProductId = 354,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 829,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e14-gen-2-core-i5-1135g7-16gb-512gb-ssd-2gb-mx450-freedos-14-fhd-20ta0054tx004-p-121932417?boutiqueId=613901&merchantId=114271",
                            Price = 18898f,
                            ProductId = 355,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 830,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-e14-g2-20ta0054tx004-i5-1135g7-16-gb-512-gb-ssd-mx450-14-dos-fhd-dizustu-bilgisayar-2074181?magaza=victory",
                            Price = 16805f,
                            ProductId = 355,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 831,
                            Link = "https://www.hepsiburada.com/lenovo-v14-g2-itl-intel-core-i5-1135g7-16-gb-512-gb-ssd-mx350-2gb-windows-11-home-14-fhd-tasinabilir-bilgisayar-82ka00ectx041-p-HBCV00002DL9C9",
                            Price = 17634f,
                            ProductId = 356,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 832,
                            Link = "https://www.trendyol.com/lenovo/v14-g2-intel-core-i5-1135g7-16-gb-512-gb-ssd-mx350-2gb-windows-11-home-14-fhd-82ka00ectx041-p-309503654?boutiqueId=613901&merchantId=114271",
                            Price = 17464f,
                            ProductId = 356,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 833,
                            Link = "https://www.hepsiburada.com/lenovo-ideapad-flex-5-intel-core-i5-1135g7-16gb-512gb-ssd-mx450-windows-11-home-14-ikisi-bir-arada-bilgisayar-82hs00mvtx-p-HBCV000021REFH",
                            Price = 19269f,
                            ProductId = 357,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 834,
                            Link = "https://www.trendyol.com/lenovo/ideapad-flex5-i5-1135g7-16gb-512gb-ssd-mx450-win11-14-2in1-dokunmatik-ekran-82hs00mvtx-p-331316346?boutiqueId=613344&merchantId=482979",
                            Price = 19598f,
                            ProductId = 357,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 835,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e14-gen-2-i7-1165g7-32gb-2-tbssd-fhd-mx450-14-w10pro-20tas0cxta36-p-358138037?boutiqueId=61&merchantId=107092",
                            Price = 28887f,
                            ProductId = 358,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 836,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-e14-g2-20tas0cxta36-i7-1165g7-32-gb-2-tb-ssd-mx450-14-w10p-dizustu-bilgisayar-24194714?magaza=b-t-teknoloji",
                            Price = 29803f,
                            ProductId = 358,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 837,
                            Link = "https://www.hepsiburada.com/lenovo-flex-5-intel-core-i3-1115g4-4gb-256gb-ssd-windows-11-home-14-fhd-tasinabilir-bilgisayar-82hs00jxtx-p-HBCV000015DA09",
                            Price = 9999f,
                            ProductId = 359,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 838,
                            Link = "https://www.trendyol.com/lenovo/flex-5-intel-core-i3-1115g4-4gb-256gb-ssd-windows-11-home-14-fhd-82hs00jxtx-p-358142781?boutiqueId=61&merchantId=125175",
                            Price = 11829f,
                            ProductId = 359,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 839,
                            Link = "https://www.hepsiburada.com/lenovo-thinkpad-p15-20yq001ntx07-intel-core-i7-11800h-64-gb-1-tb-ssd-t1200-windows-10-pro-15-6-fhd-tasinabilir-is-istasyonu-p-HBCV00002VYDZ3",
                            Price = 66549f,
                            ProductId = 360,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 840,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-p15-20yq001ntx07-i7-11800h-64gb-1tbssd-t1200-15-6-fullhd-w10p-tasinabilir-is-istasy-p-350424649?boutiqueId=613901&merchantId=106664",
                            Price = 63199f,
                            ProductId = 360,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 841,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-p17-20yu0022tx02-i7-11800h-64gb-1tbssd-a3000-17-3-fullhd-w10p-tasinabilir-is-istasy-p-266443390?boutiqueId=613901&merchantId=106664",
                            Price = 73909f,
                            ProductId = 361,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 842,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-p17-g2-20yu0022tx02-i7-11800h-64-gb-1-tb-ssd-a3000-173-w10p-fhd-dizustu-bilgisayar-2899541?magaza=teknoraks",
                            Price = 76219f,
                            ProductId = 361,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 843,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-p17-20yu0022tx05-i7-11800h-128gb-1tbssd-a3000-17-3-fullhd-w10p-tasinabilir-is-istas-p-266443990?boutiqueId=613901&merchantId=106664",
                            Price = 80599f,
                            ProductId = 362,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 844,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-p17-g2-20yu0022tx05-i7-11800h-128-gb-1-tb-ssd-a3000-173-w10p-fhd-dizustu-bilgisayar-2899476?magaza=teknoraks",
                            Price = 83149f,
                            ProductId = 362,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 845,
                            Link = "https://www.hepsiburada.com/lenovo-82hs00nstx-ideapad-flex-5-intel-core-i5-1135g7-8-gb-ram-256-gb-ssd-windows-10-home-14-fhd-tasinabilir-bilgisayar-p-HBCV00002ADG28",
                            Price = 17499f,
                            ProductId = 363,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 846,
                            Link = "https://www.trendyol.com/lenovo/82hs00nstx-ideapad-flex-5-i5-1135g7-8-gb-ram-256-gb-ssd-14-w10-dizustu-bilgisayar-p-302881329?boutiqueId=614348&merchantId=110963",
                            Price = 14590f,
                            ProductId = 363,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 847,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t15-i7-1165g7-16-gb-256-gb-ssd-15-6-fhd-2gb-mx450-freedos-20w4s0b3tx001-p-356795938?boutiqueId=613901&merchantId=114271",
                            Price = 33584f,
                            ProductId = 364,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 848,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-t15-g2-20w4s0b3tx001-i7-1165g7-16-gb-256-gb-ssd-mx450-156-dos-dizustu-bilgisayar-25041437?magaza=victory",
                            Price = 34598f,
                            ProductId = 364,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 849,
                            Link = "https://www.hepsiburada.com/lenovo-thinkpad-x1-carbon-gen-9-intel-core-i7-1165g7-16gb-2tb-ssd-14-windows-10-pro-tasinabilir-bilgisayar-20xws09xcg2-p-HBCV00000OQ6LI",
                            Price = 45836f,
                            ProductId = 365,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 850,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-x1-carbon-gen-9-i7-1165g7-16gb-2tb-ssd-14-w10-pro-20xws09xcg2-p-177289681?boutiqueId=613344&merchantId=107092",
                            Price = 47516f,
                            ProductId = 365,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 851,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e14-gen-2-i7-1165g7-16gb-2-tbssd-fhd-mx450-14-w10pro-20tas0cxta35-p-355644728?boutiqueId=61&merchantId=107092",
                            Price = 27293f,
                            ProductId = 366,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 852,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-e14-g2-20tas0cxta35-i7-1165g7-16-gb-2-tb-ssd-mx450-14-w10p-dizustu-bilgisayar-24194685?magaza=b-t-teknoloji",
                            Price = 28158f,
                            ProductId = 366,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 853,
                            Link = "https://www.hepsiburada.com/lenovo-thinkpad-e15-gen-2-intel-core-i7-1165g7-32-gb-2-tb-ssd-mx450-windows-11-pro-15-6-fhd-tasinabilir-bilgisayar-20td004htx48-p-HBCV00002R2NA2",
                            Price = 29697f,
                            ProductId = 367,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 854,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e15-gen-2-intel-core-i7-1165g7-32gb-2-tbssd-mx450-15-6-fhd-w11pro-20td004htx48-p-339324180?boutiqueId=613344&merchantId=107092",
                            Price = 29252f,
                            ProductId = 367,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 855,
                            Link = "https://www.trendyol.com/lenovo/yoga-7-82bh00agtx01-i7-1165g7-8gb-1tbssd-14-fullhd-touch-w10h-tasinabilir-bilgisayar-p-316658525?boutiqueId=613344&merchantId=106664",
                            Price = 22017f,
                            ProductId = 368,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 856,
                            Link = "https://www.n11.com/urun/lenovo-yoga-7-14itl5-82bh00agtx01-i7-1165g7-8-gb-1-tb-ssd-14-w10h-fhd-touch-dizustu-bilgisayar-13198733?magaza=teknoraks",
                            Price = 21311f,
                            ProductId = 368,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 857,
                            Link = "https://www.trendyol.com/lenovo/ideapad-3-11-nesil-core-i3-1115g4-8gb-256gb-ssd-15-6inc-w11-p-368373707?boutiqueId=61&merchantId=624588",
                            Price = 8499f,
                            ProductId = 369,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 858,
                            Link = "https://www.vatanbilgisayar.com/lenovo-ideapad-3-11-nesil-core-i3-1115g4-8gb-256gb-ssd-15-6inc-w11.html",
                            Price = 8499f,
                            ProductId = 369,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 859,
                            Link = "https://www.trendyol.com/lenovo/ideapad-3-82h80144tx-i5-1135g7-8gb-256gb-ssd-15-6-fhd-win-10-home-tasinabilir-bilgisayar-p-341079214?boutiqueId=613344&merchantId=550671",
                            Price = 13725f,
                            ProductId = 370,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 860,
                            Link = "https://www.n11.com/urun/lenovo-ideapad-3-15itl6-82h80144tx-i5-1135g7-8-gb-256-gb-ssd-156-w10h-fhd-dizustu-bilgisayar-8041353?magaza=truvaplaystation",
                            Price = 14000f,
                            ProductId = 370,
                            Rate = 4f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 861,
                            Link = "https://www.hepsiburada.com/lenovo-v15-g2-intel-core-i5-1135g7-8gb-ram-256gb-ssd-windows-10-home-15-6-fhd-tasinabilir-bilgisayar-82kb000rtx-p-HBCV00000YOLKK",
                            Price = 13724f,
                            ProductId = 371,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 862,
                            Link = "https://www.trendyol.com/lenovo/v15-g2-itl-intel-core-i5-1135g7-8-gb-256-gb-ssd-windows-10-home-15-6-fhd-82kb000rtx-p-204942968?boutiqueId=613344&merchantId=109239",
                            Price = 13364f,
                            ProductId = 371,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 863,
                            Link = "https://www.hepsiburada.com/lenovo-ideapad-3-15itl6-intel-core-i5-1135g7-8gb-512gb-ssd-notebook-82h802c5tx-p-HBCV00002NE0N9",
                            Price = 12399f,
                            ProductId = 372,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 864,
                            Link = "https://www.trendyol.com/lenovo/ideapad-3-82h802c5tx-i5-1135g7-8gb-512ssd-15-6-fullhd-w11h-tasinabilir-bilgisayar-p-359464664?boutiqueId=614908&merchantId=106664",
                            Price = 12998f,
                            ProductId = 372,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 865,
                            Link = "https://www.hepsiburada.com/lenovo-ideapad-intel-core-i5-1135g7-8gb-512gb-ssd-windows-11-home-15-6-fhd-tasinabilir-bilgisayar-82h801gjtx-p-HBCV000028I8UB",
                            Price = 12999f,
                            ProductId = 373,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 866,
                            Link = "https://www.trendyol.com/lenovo/ideapad-intel-core-i5-1135g7-8gb-512gb-ssd-15-6-fhd-notebook-82h801gjtx-win-11-home-p-334705788?boutiqueId=61&merchantId=426373",
                            Price = 13129f,
                            ProductId = 373,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 867,
                            Link = "https://www.trendyol.com/lenovo/yoga-7-82bh00agtx-i7-1165g7-8gb-512ssd-14-fullhd-touch-w10h-tasinabilir-bilgisayar-p-316653432?boutiqueId=613344&merchantId=106664",
                            Price = 21288f,
                            ProductId = 374,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 868,
                            Link = "https://www.n11.com/urun/lenovo-yoga-7-14itl5-82bh00agtx-i7-1165g7-8-gb-512-gb-ssd-14-w10h-fhd-dizustu-bilgisayar-2537628?magaza=teknoraks",
                            Price = 20543f,
                            ProductId = 374,
                            Rate = 3f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 869,
                            Link = "https://www.hepsiburada.com/lenovo-v15-alc-gen2-amd-ryzen-5-5500u-16gb-512gb-ssd-15-6-freedos-fhd-tasinabilir-bilgisayar-82kd0042tx04-p-HBCV00002LI53H",
                            Price = 12899f,
                            ProductId = 375,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 870,
                            Link = "https://www.trendyol.com/lenovo/v15-82kd0042tx04-ryzen5-5500u-16gb-512ssd-15-6-fullhd-freedos-tasinabilir-bilgisayar-p-344599309?boutiqueId=613344&merchantId=106664",
                            Price = 12048f,
                            ProductId = 375,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 871,
                            Link = "https://www.hepsiburada.com/lenovo-thinkpad-e14-gen-3-amd-ryzen-7-5700u-16-gb-512-gb-ssd-freedos-14-fhd-20y7004etx-tasinabilir-bilgisayar-p-HBCV00000S98SE",
                            Price = 19399f,
                            ProductId = 376,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 872,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-e14-g3-20y7004etx-r7-5700u-16-gb-512-gb-ssd-14-free-dos-fhd-dizustu-bilgisayar-2137140?magaza=thbilisim",
                            Price = 19299f,
                            ProductId = 376,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 873,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e14-gen-2-i7-1165g7-32gb-2-tbssd-fhd-mx450-14-freedos-20tas0cxta12-p-355645152?boutiqueId=61&merchantId=107092",
                            Price = 27339f,
                            ProductId = 377,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 874,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-e14-g2-20tas0cxta12-i7-1165g7-32-gb-2-tb-ssd-mx450-14-free-dos-dizustu-bilgisayar-24194604?magaza=b-t-teknoloji",
                            Price = 28863f,
                            ProductId = 377,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 875,
                            Link = "https://www.hepsiburada.com/lenovo-thinkpad-e14-20y7s04100-r5-5500u-8gb-256gb-ssd-14-fdos-p-HBCV00002N67X5",
                            Price = 14249f,
                            ProductId = 378,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 876,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e14-20y7s04100-r5-5500u-8gb-256gb-ssd-14-fdos-p-328965416?boutiqueId=613901&merchantId=131190",
                            Price = 14066f,
                            ProductId = 378,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 877,
                            Link = "https://www.hepsiburada.com/lenovo-thinkpad-e14-gen-2-intel-core-i5-1135g7-16gb-256gb-ssd-2gb-mx450-freedos-14-fhd-tasinabilir-bilgisayar-20ta0054tx003-p-HBCV00000DBWJ9",
                            Price = 18470f,
                            ProductId = 379,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 878,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e14-gen-2-core-i5-1135g7-16gb-256gb-ssd-2gb-mx450-freedos-14-fhd-20ta0054tx003-p-123872671?boutiqueId=613901&merchantId=114271",
                            Price = 18292f,
                            ProductId = 379,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 879,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e14-gen-3-amd-ryzen-5-5500u-8gb-256gb-ssd-freedos-14-inc-notebook-20y7004ftx-p-150734314?boutiqueId=61&merchantId=114271",
                            Price = 13999f,
                            ProductId = 380,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 880,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-e14-g3-20y7004ftx-ryzen-5-5500u-8-gb-256-gb-ssd-14-free-dos-fhd-dizustu-bilgisayar-2140454?magaza=thbilisim",
                            Price = 13549f,
                            ProductId = 380,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 881,
                            Link = "https://www.hepsiburada.com/lenovo-thinkpad-e15-gen-3-amd-ryzen-5500u-8gb-256gb-ssd-15-6-fhd-freedos-tasinabilir-bilgisayar-20yg0046tx-p-HBCV000027FWHF",
                            Price = 12990f,
                            ProductId = 381,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 882,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-e15-g3-20yg0046tx-r5-5500u-8-gb-256-gb-156-free-dos-dizustu-bilgisayar-4325624?magaza=btcanal",
                            Price = 12989f,
                            ProductId = 381,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 883,
                            Link = "https://www.hepsiburada.com/lenovo-v14-g2-itl-intel-core-i5-1135g7-8gb-512gb-ssd-freedos-14-fhd-tasinabilir-bilgisayar-82ka006xtx-p-HBCV00000DBWL5",
                            Price = 10749f,
                            ProductId = 382,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 884,
                            Link = "https://www.trendyol.com/lenovo/e15-v14-gen2-itl-i5-1135g7-8-gb-512-gb-ssd-14-free-dos-82ka006xtx-p-136177399?boutiqueId=613344&merchantId=357608",
                            Price = 10575f,
                            ProductId = 382,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 885,
                            Link = "https://www.trendyol.com/lenovo/ideapad-gaming-3-82k100cwtx03-i5-11300h-16gb-512ssd-rtx3050-15-6-fullhd-freedos-tasinabilir-p-292864775?boutiqueId=613901&merchantId=106664",
                            Price = 20529f,
                            ProductId = 383,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 886,
                            Link = "https://www.n11.com/urun/lenovo-ip-gaming-3-82k100cwtx03-i5-11300h-16-gb-512-gb-ssd-rtx3050-156-dos-tr-q-klavye-dizustu-bilgisayar-4503089?magaza=teknoraks",
                            Price = 21132f,
                            ProductId = 383,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 887,
                            Link = "https://www.hepsiburada.com/lenovo-ideapad-gaming-3-intel-core-i5-11300h-16gb-512gb-ssd-rtx-3050ti-freedos-15-6-165-hz-fhd-tasinabilir-bilgisayar-82k100cstx-p-HBCV00000BDM1O",
                            Price = 19999f,
                            ProductId = 384,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 888,
                            Link = "https://www.trendyol.com/lenovo/ideapad-gaming-3-i5-11300h-16gb-512gb-ssd-rtx3050ti-dos-15-6-165-hz-fhd-notebook-82k100cstx-p-236963385?boutiqueId=614595&merchantId=106740",
                            Price = 19999f,
                            ProductId = 384,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 889,
                            Link = "https://www.trendyol.com/lenovo/e15-20td004ctx-i5-1135g7-16gb-512gb-ssd-2gb-mx450-15-6-w10pro-p-364262664?boutiqueId=61&merchantId=197602",
                            Price = 26547f,
                            ProductId = 385,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 890,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-e15-gen-2-20td004ctx-i5-1135g7-16-gb-512-gb-ssd-mx450-156-w10p-dizustu-bilgisayar-2116978?magaza=techmarketim",
                            Price = 22289f,
                            ProductId = 385,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 891,
                            Link = "https://www.hepsiburada.com/lenovo-ideapad-3-intel-core-i3-1115g4-4gb-256gb-15-6-fhd-windows-11-home-tasinabilir-bilgisayar-82h80253tx-p-HBCV00002CQCI8",
                            Price = 8499f,
                            ProductId = 386,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 892,
                            Link = "https://www.trendyol.com/lenovo/ideapad-3-82h80252tx-i3-1115g4-4gb-256gb-ssd-15-6-fhd-windows-11-home-dizustu-bilgisayar-p-334902026?boutiqueId=61&merchantId=624588",
                            Price = 8499f,
                            ProductId = 386,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 893,
                            Link = "https://www.hepsiburada.com/lenovo-v15-g2-alc-amd-ryzen-3-5300u-8gb-256gb-ssd-15-6-freedos-fhd-tasinabilir-bilgisayar-82kd0041tx-p-HBCV00002WUG5N",
                            Price = 9311f,
                            ProductId = 387,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 894,
                            Link = "https://www.trendyol.com/lenovo/v15-g2-alc-82kd0041tx-amd-ryzen-3-5300u-8gb-256gb-ssd-15-6-fredos-p-353992450?boutiqueId=61&merchantId=591335",
                            Price = 9499f,
                            ProductId = 387,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 895,
                            Link = "https://www.trendyol.com/lenovo/thinkbook-15-g3-ryzen-5-5500u-8gb-ram-512g-ssd-15-6-fhd-freedos-21a4009utx-p-213071210?boutiqueId=613344&merchantId=104683",
                            Price = 10999f,
                            ProductId = 388,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 896,
                            Link = "https://www.n11.com/urun/lenovo-thinkbook-15-g3-21a4009utx-r5-5500u-8-gb-512-gb-ssd-156-free-dos-fhd-dizustu-bilgisayar-2186810?magaza=nethouse",
                            Price = 13999f,
                            ProductId = 388,
                            Rate = 4f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 897,
                            Link = "https://www.hepsiburada.com/lenovo-ideapad-gaming-3-amd-ryzen-7-5800h-16gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-82k200jxtx-p-HBCV00000BDM20",
                            Price = 18999f,
                            ProductId = 389,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 898,
                            Link = "https://www.trendyol.com/lenovo/82k200jxtx-amd-ryzen-7-5800h-16gb-512gb-ssd-gtx1650-15-6-fhd-freedos-dizustu-bilgisayar-p-314568436?boutiqueId=613344&merchantId=110963",
                            Price = 18423f,
                            ProductId = 389,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 899,
                            Link = "https://www.hepsiburada.com/lenovo-ideapad-gaming-3-amd-ryzen-7-5800h-16gb-512gb-ssd-rtx3050ti-freedos-15-6-fhd-tasinabilir-bilgisayar-82k200jwtx-p-HBCV00000BDM22",
                            Price = 22998f,
                            ProductId = 390,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 900,
                            Link = "https://www.trendyol.com/lenovo/ideapad-gaming3-ryzen7-5800h-16gb-512gb-ssd-rtx-3050ti-4gb-fdos-15-6-fhd-notebook-82k200jwtx-p-236657729?boutiqueId=614600&merchantId=107007",
                            Price = 22089f,
                            ProductId = 390,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 901,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t15-i7-1165g7-24-gb-500-gb-ssd-15-6-fhd-2gb-mx450-freedos-20w4s0b3tx005-p-356821469?boutiqueId=613901&merchantId=114271",
                            Price = 35092f,
                            ProductId = 391,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 902,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-t15-g2-20w4s0b3tx005-i7-1165g7-24-gb-500-gb-ssd-mx450-156-dos-dizustu-bilgisayar-25041387?magaza=victory",
                            Price = 36152f,
                            ProductId = 391,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 903,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t15-i7-1165g7-24-gb-512-gb-ssd-15-6-fhd-2gb-mx450-freedos-20w4s0b3tx007-p-356799308?boutiqueId=613901&merchantId=114271",
                            Price = 35092f,
                            ProductId = 392,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 904,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-t15-g2-20w4s0b3tx007-i7-1165g7-24-gb-512-gb-ssd-mx450-156-dos-dizustu-bilgisayar-25041415?magaza=victory",
                            Price = 36152f,
                            ProductId = 392,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 905,
                            Link = "https://www.hepsiburada.com/lenovo-v14-g2-itl-intel-core-i5-1135g7-12-gb-256-gb-ssd-mx350-2gb-windows-10-pro-14-fhd-tasinabilir-bilgisayar-82ka00ectx019-p-HBCV00002DLD16",
                            Price = 17210f,
                            ProductId = 393,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 906,
                            Link = "https://www.n11.com/urun/lenovo-v14-g2-itl-82ka00ectx019-i5-1135g7-12-gb-256-gb-ssd-mx350-14-w10p-dizustu-bilgisayar-8439384?magaza=victory",
                            Price = 18358f,
                            ProductId = 393,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 907,
                            Link = "https://www.hepsiburada.com/lenovo-v14-82kc000qtx06-ryzen3-5300u-12gb-256ssd-14-fullhd-freedos-tasinabilir-bilgisayar-p-HBCV00002LYJTR",
                            Price = 7999f,
                            ProductId = 394,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 908,
                            Link = "https://www.trendyol.com/lenovo/v14-82kc000qtx06-ryzen3-5300u-12gb-256ssd-14-fullhd-freedos-tasinabilir-bilgisayar-p-322911192?boutiqueId=613901&merchantId=106664",
                            Price = 7568f,
                            ProductId = 394,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 909,
                            Link = "https://www.trendyol.com/lenovo/ideapad-5-82fe00aytx-i7-1165g7-16gb-1tbssd-mx450-14-fullhd-freedos-tasinabilir-bilgisayar-p-280870734?boutiqueId=613901&merchantId=106664",
                            Price = 19599f,
                            ProductId = 395,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 910,
                            Link = "https://www.n11.com/urun/lenovo-ideapad-5-14itl05-82fe00aytx-i7-1165g7-16-gb-1-tb-ssd-mx450-14-free-dos-fhd-dizustu-bilgisayar-2118441?magaza=yorungeonline",
                            Price = 17898f,
                            ProductId = 395,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 911,
                            Link = "https://www.hepsiburada.com/lenovo-v14-amd-ryzen-3-5300u-12gb-256gb-ssd-freedos-14-fhd-tasinabilir-bilgisayar-82kc0005tx05-p-HBCV00001CA4XV",
                            Price = 7899f,
                            ProductId = 396,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 912,
                            Link = "https://www.trendyol.com/lenovo/v14-82kc0005tx05-ryzen3-5300u-12gb-256ssd-14-fullhd-freedos-tasinabilir-bilgisayar-p-230411960?boutiqueId=613344&merchantId=106664",
                            Price = 7499f,
                            ProductId = 396,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 913,
                            Link = "https://www.hepsiburada.com/lenovo-ideapad-gaming-3-amd-ryzen-5-5600h-16gb-ram-1tb-m2-ssd-rtx3060-freedos-15-6-fhd-tasinabilir-bilgisayar-82k200t4tx-p-HBCV00001ZL25U",
                            Price = 29899f,
                            ProductId = 397,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 914,
                            Link = "https://www.n11.com/urun/lenovo-ip-gaming-3-15ach6-82k200t4tx-r5-5600h-16-gb-1-tb-ssd-rtx3060-165hz-156-dos-dizustu-bilgisayar-3149580?magaza=techburada",
                            Price = 29301f,
                            ProductId = 397,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 915,
                            Link = "https://www.hepsiburada.com/lenovo-thinkpad-e15-gen3-amd-ryzen-7-5700u-16gb-512gb-ssd-windows-10-pro-15-6-fhd-tasinabilir-bilgisayar-20ygs04400z36-p-HBCV00002WM5IW",
                            Price = 17290f,
                            ProductId = 398,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 916,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-e15-g3-20ygs04400z36-r7-5700u-16-gb-512-gb-ssd-156-w10p-fhd-dizustu-bilgisayar-23954233?magaza=atlantisdogu",
                            Price = 19585f,
                            ProductId = 398,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 917,
                            Link = "https://www.hepsiburada.com/lenovo-thinkbook-15-gen3-acl-amd-ryzen7-5700u-16-gb-512-gb-ssd-windows-11-pro-15-6-tasinabilir-bilgisayar-21a40037tx12-p-HBCV000024AB30",
                            Price = 15699f,
                            ProductId = 399,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 918,
                            Link = "https://www.trendyol.com/lenovo/thinkbook-15-gen3-acl-amd-ryzen7-5700u-16-gb-512-gb-ssd-windows-11-pro-15-6-21a40037tx12-p-329452708?boutiqueId=613344&merchantId=214484",
                            Price = 16235f,
                            ProductId = 399,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 919,
                            Link = "https://www.hepsiburada.com/lenovo-thinkpad-e15-gen3-amd-ryzen-7-5700u-16gb-512gb-ssd-windows-11-pro-15-6-fhd-tasinabilir-bilgisayar-20ygs04400z62-canta-p-HBCV00002YN9KN",
                            Price = 17826f,
                            ProductId = 400,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 920,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e15-gen3-amd-ryzen-7-5700u-16gb-512gb-ssd-win11-pro-15-6-fhd-20ygs04400z62-canta-p-357804062?boutiqueId=61&merchantId=109354",
                            Price = 19771f,
                            ProductId = 400,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 921,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t15-i7-1165g7-24-gb-500-gb-ssd-15-6-fhd-2gb-mx450-windows-11-pro-20w4s0b3tx049-p-356793404?boutiqueId=613901&merchantId=114271",
                            Price = 38696f,
                            ProductId = 401,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 922,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-t15-g2-20w4s0b3tx049-i7-1165g7-24-gb-500-gb-ssd-mx450-156-w11p-dizustu-bilgisayar-25041382?magaza=victory",
                            Price = 39865f,
                            ProductId = 401,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 923,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t15-i7-1165g7-24-gb-512-gb-ssd-15-6-fhd-2gb-mx450-windows-11-pro-20w4s0b3tx052-p-356796014?boutiqueId=613901&merchantId=114271",
                            Price = 38696f,
                            ProductId = 402,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 924,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-t15-g2-20w4s0b3tx052-i7-1165g7-24-gb-512-gb-ssd-mx450-156-w11p-dizustu-bilgisayar-25041398?magaza=victory",
                            Price = 39865f,
                            ProductId = 402,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 925,
                            Link = "https://www.hepsiburada.com/lenovo-v14-g2-itl-intel-core-i5-1135g7-8-gb-1-tb-ssd-mx350-2gb-windows-11-home-14-fhd-tasinabilir-bilgisayar-82ka00ectx042-p-HBCV00002DLDD7",
                            Price = 17916f,
                            ProductId = 403,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 926,
                            Link = "https://www.n11.com/urun/lenovo-v14-g2-itl-82ka00ectx042-i5-1135g7-8-gb-1-tb-ssd-mx350-14-w11h-dizustu-bilgisayar-8439371?magaza=victory",
                            Price = 18782f,
                            ProductId = 403,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 927,
                            Link = "https://www.trendyol.com/lenovo/yoga-7-82bh00dhtx01-i5-1135g7-8gb-1tbssd-14-fullhd-touch-w11h-tasinabilir-bilgisayar-p-334596403?boutiqueId=613901&merchantId=106664",
                            Price = 18199f,
                            ProductId = 404,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 928,
                            Link = "https://www.n11.com/urun/lenovo-yoga-7-14itl5-82bh00dhtx01-i5-1135g7-8-gb-1-tb-ssd-14-w11h-touch-fhd-dizustu-bilgisayar-18062908?magaza=teknoraks",
                            Price = 18334f,
                            ProductId = 404,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 929,
                            Link = "https://www.hepsiburada.com/lenovo-v15-82kb0005txx-c-intel-core-i3-1115g4-8gb-256gb-ssd-15-6-fhd-freedos-tasinabilir-bilgisayar-p-HBCV00002KOPK9",
                            Price = 9021f,
                            ProductId = 405,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 930,
                            Link = "https://www.trendyol.com/lenovo/v15-82kb0005txx-ci3-1115g4-8gb-256gb-ssd-15-6-fhd-freedos-p-320142183?boutiqueId=61&merchantId=125175",
                            Price = 9999f,
                            ProductId = 405,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 931,
                            Link = "https://www.hepsiburada.com/lenovo-ideapad-i5-10210u-8-gb-256-gb-ssd-15-6-inc-fhd-w11h-gri-tasinabilir-bilgisayar-81wb01ejtx-p-HBCV00002QANIR",
                            Price = 10999f,
                            ProductId = 406,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 932,
                            Link = "https://www.trendyol.com/lenovo/ideapad-3-81wb01ejtx-i5-10210u-8gb-256ssd-15-6-fullhd-w11h-tasinabilir-bilgisayar-p-349343304?boutiqueId=61&merchantId=114738",
                            Price = 11038f,
                            ProductId = 406,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 933,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e14-gen-2-i7-1165g7-8gb-2-tbssd-fhd-mx450-14-freedos-20tas0cxta10-p-355644720?boutiqueId=61&merchantId=107092",
                            Price = 25130f,
                            ProductId = 407,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 934,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-e14-g2-20tas0cxta10-i7-1165g7-8-gb-2-tb-ssd-mx450-14-free-dos-dizustu-bilgisayar-24194679?magaza=b-t-teknoloji",
                            Price = 26607f,
                            ProductId = 407,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 935,
                            Link = "https://www.hepsiburada.com/lenovo-l3-15iml05-intel-core-i5-10210u-8gb-512gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-81y300mdtx-p-HBCV00000D5Z9N",
                            Price = 12499f,
                            ProductId = 408,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 936,
                            Link = "https://www.trendyol.com/lenovo/l3-intel-core-i5-10210u-8gb-512gb-ssd-mx330-fdos-15-6-fhd-tasinabilir-bilgisayar-81y300mdtx-p-336360671?boutiqueId=613344&merchantId=557390",
                            Price = 12999f,
                            ProductId = 408,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 937,
                            Link = "https://www.trendyol.com/lenovo/ideapad-3-10-nesil-core-i5-10210u-8gb-512gb-ssd-15-6inc-w11-p-354149575?boutiqueId=61&merchantId=624588",
                            Price = 13499f,
                            ProductId = 409,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 938,
                            Link = "https://www.vatanbilgisayar.com/lenovo-ideapad-3-10-nesil-core-i5-10210u-8gb-512gb-ssd-15-6inc-w11.html",
                            Price = 13499f,
                            ProductId = 409,
                            Rate = 4f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 939,
                            Link = "https://www.hepsiburada.com/lenovo-v15-iil-intel-core-i5-1035g1-8gb-512gb-ssd-mx330-freedos-15-6-fhd-tasinabilir-bilgisayar-82c500r2tx01-p-HBV000014SZYV",
                            Price = 11799f,
                            ProductId = 410,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 940,
                            Link = "https://www.trendyol.com/lenovo/v15-82c500r2tx-01-i5-1035g1-8gb-512gb-ssd-2gb-geforce-mx330-15-6-inc-full-hd-freedos-notebook-p-211941077?boutiqueId=613901&merchantId=4367",
                            Price = 12249f,
                            ProductId = 410,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 941,
                            Link = "https://www.hepsiburada.com/lenovo-ideapad-3-amd-ryzen-7-3700u-8gb-512gb-ssd-windows-10-home-15-6-fhd-tasinabilir-bilgisayar-81w1005rtx-p-HBCV0000091LHD",
                            Price = 11039f,
                            ProductId = 411,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 942,
                            Link = "https://www.trendyol.com/lenovo/ideapad-3-81w1005rtx-ryzen-7-3700u-512gb-8gb-vega10-win10-p-82285974?boutiqueId=613344&merchantId=216294",
                            Price = 11999f,
                            ProductId = 411,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 943,
                            Link = "https://www.hepsiburada.com/lenovo-v17-iil-intel-core-i7-1065g7-12gb-512gb-ssd-mx330-freedos-17-3-fhd-tasinabilir-bilgisayar-82gx007vtx-p-HBCV000001IQRS",
                            Price = 15999f,
                            ProductId = 412,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 944,
                            Link = "https://www.trendyol.com/lenovo/v17-82gx007vtx-i7-1065g7-12gb-512ssd-17-3-freedos-ips-full-hd-mx330-p-91653211?boutiqueId=613901&merchantId=247393",
                            Price = 15499f,
                            ProductId = 412,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 945,
                            Link = "https://www.trendyol.com/lenovo/v14-82kc0005tx06-ryzen3-5300u-12gb-512ssd-14-fullhd-freedos-tasinabilir-bilgisayar-p-230432075?boutiqueId=613901&merchantId=106664",
                            Price = 8548f,
                            ProductId = 413,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 946,
                            Link = "https://www.n11.com/urun/lenovo-v14-g2-alc-82kc0005tx06-ryzen-3-5300u-12-gb-512-gb-ssd-14-free-dos-dizustu-bilgisayar-2507847?magaza=teknoraks",
                            Price = 8583f,
                            ProductId = 413,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 947,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t14-gen3-i7-1255u-16-gb-1-tb-ssd-14-w11p-fhd-tasinabilir-bilgisayar-21ah00cstx050-p-364424989?boutiqueId=613901&merchantId=114271",
                            Price = 35840f,
                            ProductId = 414,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 948,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-t14-gen-3-21ah00cstx050-i7-1255u-16-gb-1-tb-ssd-14-w11p-dizustu-bilgisayar-24942943?magaza=victory",
                            Price = 36922f,
                            ProductId = 414,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 949,
                            Link = "https://www.hepsiburada.com/lenovo-ideapad-gaming-3-intel-core-i7-11370h-16gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-82k100cmtx-p-HBCV00000BDM1Q",
                            Price = 22959f,
                            ProductId = 415,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 950,
                            Link = "https://www.trendyol.com/lenovo/ideapad-gaming-3-15ihu6-i7-11370h-16gb-ddr4-gtx-1650-gddr6-4gb-512-120hz-freedos-82k100cmtx-p-304649292?boutiqueId=613344&merchantId=449692",
                            Price = 25629f,
                            ProductId = 415,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 951,
                            Link = "https://www.trendyol.com/lenovo/legion-5-82jh002jtx03-i7-11600h-16gb-512ssd-rtx3060-15-6-wqhd-freedos-tasinabilir-bilgisaya-p-251038276?boutiqueId=613344&merchantId=106664",
                            Price = 34398f,
                            ProductId = 416,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 952,
                            Link = "https://www.n11.com/urun/lenovo-legion-5-82jh002jtx03-i7-11600h-16-gb-512-gb-ssd-rtx3060-156-dos-wqhd-dizustu-bilgisayar-2691636?magaza=teknoraks",
                            Price = 33949f,
                            ProductId = 416,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 953,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t14-gen3-i7-1255u-16-gb-512-gb-ssd-14-w11h-fhd-tasinabilir-bilgisayar-21ah00cstx025-p-358484089?boutiqueId=613901&merchantId=114271",
                            Price = 33984f,
                            ProductId = 417,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 954,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-t14-gen-3-21ah00cstx025-i7-1255u-16-gb-512-gb-ssd-14-w11h-dizustu-bilgisayar-24942887?magaza=victory",
                            Price = 35010f,
                            ProductId = 417,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 955,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t15-i7-1165g7-24-gb-512-gb-ssd-15-6-fhd-2gb-mx450-windows-11-home-20w4s0b3tx037-p-356792678?boutiqueId=613901&merchantId=114271",
                            Price = 37982f,
                            ProductId = 418,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 956,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-t15-g2-20w4s0b3tx037-i7-1165g7-24-gb-512-gb-ssd-mx450-156-w11h-dizustu-bilgisayar-25041435?magaza=victory",
                            Price = 39129f,
                            ProductId = 418,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 957,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t14-gen3-i7-1255u-32-gb-1-tb-ssd-14-fdos-fhd-tasinabilir-bilgisayar-21ah00cstx013-p-358465887?boutiqueId=61&merchantId=114271",
                            Price = 32499f,
                            ProductId = 419,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 958,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-t14-gen-3-21ah00cstx013-i7-1255u-32-gb-1-tb-ssd-14-free-dos-dizustu-bilgisayar-24942918?magaza=victory",
                            Price = 35163f,
                            ProductId = 419,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 959,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t14-gen3-i7-1255u-32-gb-512-gb-ssd-14-w11h-fhd-tasinabilir-bilgisayar-21ah00cstx028-p-364426124?boutiqueId=613901&merchantId=114271",
                            Price = 35840f,
                            ProductId = 420,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 960,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-t14-gen-3-21ah00cstx028-i7-1255u-32-gb-512-gb-ssd-14-w11h-dizustu-bilgisayar-24942989?magaza=victory",
                            Price = 36922f,
                            ProductId = 420,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 961,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-t14-gen3-i7-1255u-32-gb-512-gb-ssd-14-w11p-fhd-tasinabilir-bilgisayar-21ah00cstx048-p-365755010?boutiqueId=61&merchantId=114271",
                            Price = 36554f,
                            ProductId = 421,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 962,
                            Link = "https://www.n11.com/urun/lenovo-thinkpad-t14-gen-3-21ah00cstx048-i7-1255u-32-gb-512-gb-ssd-14-w11p-dizustu-bilgisayar-24942938?magaza=victory",
                            Price = 37658f,
                            ProductId = 421,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 963,
                            Link = "https://www.hepsiburada.com/lenovo-thinkbook-14-g2-intel-core-i7-1165g7-40-gb-1-tb-ssd-windows-11-pro-14-fhd-tasinabilir-bilgisayar-20vd0045tx31-p-HBCV00002LUYRX",
                            Price = 31045f,
                            ProductId = 422,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 964,
                            Link = "https://www.trendyol.com/lenovo/thinkbook-14-g2-intel-core-i7-1165g7-40-gb-1tb-ssd-win11p-14-fhd-20vd0045tx31-p-329724737?boutiqueId=61&merchantId=106536",
                            Price = 31679f,
                            ProductId = 422,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 965,
                            Link = "https://www.trendyol.com/lenovo/v17-g2-itl-core-i7-1165g7-40-gb-500-gb-ssd-2gb-mx350-win-11-pro-17-3-fhd-82nx00ectx081-p-263314120?boutiqueId=613901&merchantId=114271",
                            Price = 25574f,
                            ProductId = 423,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 966,
                            Link = "https://www.n11.com/urun/lenovo-v17-g2-itl-82nx00ectx081-i7-1165g7-40-gb-500-gb-ssd-mx350-173-w11p-fhd-dizustu-bilgisayar-2797659?magaza=victory",
                            Price = 25849f,
                            ProductId = 423,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 967,
                            Link = "https://www.hepsiburada.com/lenovo-ideapad-3-amd-ryzen-3-3250u-4gb-128gb-ssd-windows-10-home-15-6-tasinabilir-bilgisayar-81w1005vtx-p-HBV000014JL1A",
                            Price = 7299f,
                            ProductId = 424,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 968,
                            Link = "https://www.trendyol.com/lenovo/15ada05-amd-reyzen-3-3250u-4gb-128gb-ssd-windows-10-home-sl-15-6-hd-81w1005vtx-p-62856455?boutiqueId=61&merchantId=559937",
                            Price = 6731f,
                            ProductId = 424,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 969,
                            Link = "https://www.hepsiburada.com/lenovo-v15-ci3-1115g4-4-gb-256gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-82kb0005tx-p-HBCV00002KBDCO",
                            Price = 8899f,
                            ProductId = 425,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 970,
                            Link = "https://www.trendyol.com/lenovo/v15-82kb0005tx-ci3-1115g4-4-gb-256gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-p-319945196?boutiqueId=61&merchantId=125175",
                            Price = 8999f,
                            ProductId = 425,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 971,
                            Link = "https://www.hepsiburada.com/lenovo-ideapad-flex-5-intel-core-i3-1115g4-4gb-256-gb-ssd-integrated-intel-uhd-graphics-14-windows-10-fhd-tasinabilir-bilgisayar-82hs00fftx-p-HBCV00001OLZNQ",
                            Price = 9699f,
                            ProductId = 426,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 972,
                            Link = "https://www.trendyol.com/lenovo/82hs00fftx-ideapad-flex-5-i3-1115g4-4gb-ram-256gb-ssd-14-fhd-windows-10-home-2in1-laptop-pla-p-219575639?boutiqueId=614596&merchantId=288515",
                            Price = 10670f,
                            ProductId = 426,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 973,
                            Link = "https://www.hepsiburada.com/lenovo-v15-itl-intel-core-i5-1135g7-4-gb-256-gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-82kb000stx-p-HBCV00000S95KM",
                            Price = 9999f,
                            ProductId = 427,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 974,
                            Link = "https://www.trendyol.com/lenovo/v15-82kb000stx-i5-1135g7-4gb-256gb-ssd-15-6-fhd-freedos-p-123208984?boutiqueId=61&merchantId=107204",
                            Price = 10299f,
                            ProductId = 427,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 975,
                            Link = "https://www.trendyol.com/lenovo/legion-5-82jh002jtx08-i7-11600h-64gb-2tbssd-rtx3060-15-6-wqhd-freedos-tasinabilir-bilgisaya-p-251037990?boutiqueId=613344&merchantId=106664",
                            Price = 41398f,
                            ProductId = 428,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 976,
                            Link = "https://www.n11.com/urun/lenovo-legion-5-82jh002jtx08-i7-11600h-64-gb-2-tb-ssd-rtx3060-156-free-dos-wqhd-dizustu-bilgisayar-2691631?magaza=teknoraks",
                            Price = 40836f,
                            ProductId = 428,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 977,
                            Link = "https://www.hepsiburada.com/lenovo-thinkpad-e15-intel-core-i5-10210u-8gb-256gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-20rd0061tx-p-HBV00000TXUBN",
                            Price = 14349f,
                            ProductId = 429,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 978,
                            Link = "https://www.trendyol.com/lenovo/thinkpad-e15-intel-core-i5-10210u-8gb-256gb-ssd-uhd-fdos-15-6-fhd-dizustu-bilgisayar-20rd0061tx-p-37680630?boutiqueId=61&merchantId=693541",
                            Price = 13999f,
                            ProductId = 429,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 979,
                            Link = "https://www.hepsiburada.com/lenovo-thinkbook-13s-g2-itl-intel-core-i5-1135g7-8gb-256gb-ssd-freedos-13-3-fhd-tasinabilir-bilgisayar-20v9005vtx-p-HBCV000002O9VB",
                            Price = 14299f,
                            ProductId = 430,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 980,
                            Link = "https://www.trendyol.com/lenovo/thinkbook-13s-g2-itl-i5-1135g7-8gb-256gb-ssd-13-3-freedos-20v9005vtx-p-94704471?boutiqueId=613344&merchantId=228212",
                            Price = 14899f,
                            ProductId = 430,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 981,
                            Link = "https://www.hepsiburada.com/lenovo-v15-iil-intel-core-i7-1065g7-8gb-256gb-ssd-freedos-15-6-fhd-tasinabilir-bilgisayar-82c500gdtx-p-HBV00000V7Y36",
                            Price = 15517f,
                            ProductId = 431,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 982,
                            Link = "https://www.trendyol.com/lenovo/v15-iil-intel-core-i7-1065g7-8gb-256gb-ssd-iris-fdos-15-6-fhd-dizustu-bilgisayar-82c500gdtx-p-42762059?boutiqueId=613344&merchantId=166082",
                            Price = 14875f,
                            ProductId = 431,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 983,
                            Link = "https://www.hepsiburada.com/lenovo-v14-amd-ryzen-5-5500u-8gb-256gb-ssd-windows-10-home-14-fhd-tasinabilir-bilgisayar-82kc0009tx-p-HBCV000008YQB5",
                            Price = 9998f,
                            ProductId = 432,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 984,
                            Link = "https://www.trendyol.com/lenovo/v14-82kc0009tx-ryzen-5-5500u-8-gb-256-gb-ssd-14-w10-home-fhd-dizustu-bilgisayar-p-113476500?boutiqueId=614600&merchantId=104683",
                            Price = 9399f,
                            ProductId = 432,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 985,
                            Link = "https://www.trendyol.com/lenovo/yoga-7-evo-11-nesil-core-i7-1165g7-8gb-512gb-ssd-14inc-w11-p-355654431?boutiqueId=61&merchantId=624588",
                            Price = 24199f,
                            ProductId = 433,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 986,
                            Link = "https://www.vatanbilgisayar.com/lenovo-yoga-7-evo-11-nesil-core-i7-1165g7-8gb-512gb-ssd-14-w11.html",
                            Price = 26999f,
                            ProductId = 433,
                            Rate = 4f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 987,
                            Link = "https://www.hepsiburada.com/lenovo-v15-ada-amd-ryzen-3-3250u-8gb-512gb-ssd-windows-10-home-15-6-fhd-tasinabilir-bilgisayar-82c7005wtx-p-HBCV00000C73B4",
                            Price = 9499f,
                            ProductId = 434,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 988,
                            Link = "https://www.trendyol.com/lenovo/v15-ada-amd-ryzen-3-3250u-8gb-512gb-ssd-windows-10-home-15-6-fhd-82c7005wtx-p-121324734?boutiqueId=613344&merchantId=655835",
                            Price = 9799f,
                            ProductId = 434,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 989,
                            Link = "https://www.hepsiburada.com/lenovo-v14-82kc000qtx03-ryzen3-5300u-8gb-512ssd-14-fullhd-freedos-tasinabilir-bilgisayar-p-HBCV00002LYJTL",
                            Price = 7760f,
                            ProductId = 435,
                            Rate = 0f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 990,
                            Link = "https://www.trendyol.com/lenovo/v14-82kc000qtx03-ryzen3-5300u-8gb-512ssd-14-fullhd-freedos-tasinabilir-bilgisayar-p-322907261?boutiqueId=613344&merchantId=106664",
                            Price = 7989f,
                            ProductId = 435,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 991,
                            Link = "https://www.hepsiburada.com/lenovo-v14-g2-alc-amd-ryzen-5-5500u-8gb-512gb-ssd-windows-10-home-14-fhd-tasinabilir-bilgisayar-82kc0002tx-p-HBCV00000ZWF24",
                            Price = 10631f,
                            ProductId = 436,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 992,
                            Link = "https://www.trendyol.com/lenovo/v14-g2-alc-ryzen-5-5500u-8gb-512gb-ssd-14-fhd-windows-10-home-82kc0002tx-p-193165598?boutiqueId=613344&merchantId=324625",
                            Price = 11055f,
                            ProductId = 436,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 993,
                            Link = "https://www.trendyol.com/msi/crosshair-17-b12ugz-298xtr-i7-12700h-16gb-ddr4-rtx3070-gddr6-8gb-1tb-ssd-17-3-fhd-144hz-dos-p-284159397?boutiqueId=613344&merchantId=106740",
                            Price = 49889f,
                            ProductId = 437,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 994,
                            Link = "https://www.n11.com/urun/msi-crosshair-17-b12ugz-298xtr-i7-12700h-16-gb-1-tb-ssd-rtx3070-173-dos-fhd-dizustu-bilgisayar-7537271?magaza=bilisimstore",
                            Price = 50291f,
                            ProductId = 437,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 995,
                            Link = "https://www.hepsiburada.com/msi-katana-gf76-12ud-217xtr-intel-core-i7-12700h-16gb-1tb-ssd-rtx3050ti-freedos-17-3-fhd-144hz-tasinabilir-bilgisayar-p-HBCV00002G7ZPK",
                            Price = 34990f,
                            ProductId = 438,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 996,
                            Link = "https://www.trendyol.com/msi/katana-gf76-12ud-217xtr-i7-12700h-16gb-ddr4-rtx3050ti-gddr6-4gb-1tb-ssd-17-3-fhd-144hz-dos-p-314029831?boutiqueId=61&merchantId=259994",
                            Price = 33999f,
                            ProductId = 438,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 997,
                            Link = "https://www.trendyol.com/msi/crosshair-15-r6e-b12ugz-414tr-i7-12700h-32gb-ddr4-rtx3070-gddr6-8gb-1tbssd-15-6-qhd-165hz-w11-p-274367515?boutiqueId=613344&merchantId=106740",
                            Price = 57979f,
                            ProductId = 439,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 998,
                            Link = "https://www.n11.com/urun/msi-crosshair-15-r6e-b12ugz-414tr-i7-12700h-32-gb-1-tb-ssd-rtx3070-165hz-156-w11h-qhd-dizustu-bilgisayar-3401850?magaza=bilisimstore",
                            Price = 59627f,
                            ProductId = 439,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 999,
                            Link = "https://www.trendyol.com/msi/crosshair-15-12-nesil-core-i7-12700h-32gb-1tb-ssd-15-6inc-rtx3070ti-8gb-w11-p-349608337?boutiqueId=613344&merchantId=624588",
                            Price = 60458f,
                            ProductId = 440,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 1000,
                            Link = "https://www.vatanbilgisayar.com/msi-crosshair-15-12-nesil-core-i7-12700h-32gb-1tb-ssd-15-6inc-rtx3070ti-8gb-w11.html",
                            Price = 63238f,
                            ProductId = 440,
                            Rate = 0f,
                            SiteName = "vatanbilgisayar"
                        },
                        new
                        {
                            SitesInformationId = 1001,
                            Link = "https://www.trendyol.com/msi/raider-ge66-12ugs-033tr-i7-12700h-32gb-ddr5-rtx3070ti-gddr6-8gb-1tb-ssd-15-6-fhd-360hz-w11-p-237871041?boutiqueId=613344&merchantId=118442",
                            Price = 73899f,
                            ProductId = 441,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 1002,
                            Link = "https://www.n11.com/urun/msi-raider-ge66-12ugs-033tr-i7-12700h-32-gb-1-tb-ssd-rtx3070ti-360-ghz-156-w11-fhd-dizustu-bilgisayar-2540695?magaza=gpnteknoloji",
                            Price = 70204f,
                            ProductId = 441,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 1003,
                            Link = "https://www.trendyol.com/msi/stealth-gs66-12ugs-016tr-i7-12700h-32gb-ddr5-rtx3070ti-gddr6-8gb-1tb-ssd-15-6-qhd-240hz-w11-p-230344887?boutiqueId=613344&merchantId=118442",
                            Price = 64599f,
                            ProductId = 442,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 1004,
                            Link = "https://www.n11.com/urun/msi-stealth-gs66-12ugs-016tr-i7-12700h-32-gb-1-tb-ssd-rtx3070ti-156-w11h-dizustu-bilgisayar-2504443?magaza=dey-elektronik",
                            Price = 69416f,
                            ProductId = 442,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 1005,
                            Link = "https://www.hepsiburada.com/msi-katana-gf76-11ud-059xtr-intel-core-i7-11800h-16gb-512gb-ssd-rtx-3050ti-freedos-17-3-fhd-tasinabilir-bilgisayar-p-HBCV000006G7VU",
                            Price = 29299f,
                            ProductId = 443,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 1006,
                            Link = "https://www.trendyol.com/msi/katana-gf76-11ud-059xtr-i7-11800h-16gb-ddr4-rtx3050ti-gddr6-4gb-512gb-ssd-17-3-fhd-144hz-dos-p-105122726?boutiqueId=613344&merchantId=197602",
                            Price = 29599f,
                            ProductId = 443,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 1007,
                            Link = "https://www.hepsiburada.com/msi-katana-gf76-11ug-254xtr-intel-core-i7-11800h-16gb-512gb-ssd-rtx3070-freedos-17-3-fhd-tasinabilir-bilgisayar-p-HBCV000013ILTA",
                            Price = 43697f,
                            ProductId = 444,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 1008,
                            Link = "https://www.trendyol.com/msi/katana-gf76-11ug-254xtr-i7-11800h-16gb-ddr4-rtx3070-gddr6-8gb-512gb-ssd-17-3-fhd-144hz-dos-p-222742991?boutiqueId=613344&merchantId=106740",
                            Price = 43989f,
                            ProductId = 444,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 1009,
                            Link = "https://www.hepsiburada.com/msi-gf63-thin-11sc-035xtr-intel-core-i5-11400h-8gb-512gb-ssd-gtx1650-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV00000TJJWL",
                            Price = 17339f,
                            ProductId = 445,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 1010,
                            Link = "https://www.trendyol.com/msi/gf63-thin-11sc-035xtr-i5-11400h-8gb-ddr4-gtx1650-gddr6-4gb-512gb-ssd-15-6-fhd-dos-p-163858296?boutiqueId=613344&merchantId=357608",
                            Price = 17313f,
                            ProductId = 445,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 1011,
                            Link = "https://www.hepsiburada.com/msi-gf63-thin-11uc-617xtr-intel-core-i5-11400h-8gb-512gb-ssd-rtx3050-freedos-15-6-fhd-tasinabilir-bilgisayar-p-HBCV000023XXVG",
                            Price = 19499f,
                            ProductId = 446,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 1012,
                            Link = "https://www.trendyol.com/msi/gf63-thin-11uc-617xtr-i5-11400h-8gb-ddr4-rtx3050-gddr6-4gb-512gb-ssd-15-6-fhd-dos-p-284885322?boutiqueId=61&merchantId=600624",
                            Price = 19479f,
                            ProductId = 446,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 1013,
                            Link = "https://www.trendyol.com/msi/stealth-gs77-12uhs-081tr-i7-12700h-32gb-ddr5-rtx3080ti-gddr6-16gb-2tb-ssd-17-3-uhd-120hz-w11-p-266109922?boutiqueId=613344&merchantId=316311",
                            Price = 85939f,
                            ProductId = 447,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 1014,
                            Link = "https://www.n11.com/urun/msi-stealth-gs77-12uhs-081tr-i7-12700h-32-gb-2-tb-rtx3080ti-120hz-173-w11h-uhd-dizustu-bilgisayar-2743004?magaza=dey-elektronik",
                            Price = 99227f,
                            ProductId = 447,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 1015,
                            Link = "https://www.trendyol.com/msi/raider-ge76-12uhs-022tr-i7-12700h-32gb-ddr5-rtx3080ti-gddr6-16gb-2tb-ssd-17-3-fhd-360hz-w11-p-237309076?boutiqueId=613344&merchantId=118442",
                            Price = 86399f,
                            ProductId = 448,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 1016,
                            Link = "https://www.n11.com/urun/msi-raider-ge76-12uhs-022tr-i7-12700h-32-gb-2-tb-ssd-rtx3080ti-360hz-173-w11h-fhd-dizustu-bilgisayar-2540478?magaza=gpnteknoloji",
                            Price = 98799f,
                            ProductId = 448,
                            Rate = 0f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 1017,
                            Link = "https://www.hepsiburada.com/msi-raider-ge76-12uhs-037tr-intel-core-i9-12900hk-64gb-2tb-ssd-rtx3080ti-windows-11-home-17-3-tasinabilir-bilgisayar-p-HBCV00002BP754",
                            Price = 116672f,
                            ProductId = 449,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 1018,
                            Link = "https://www.trendyol.com/msi/raider-ge76-12uhs-037tr-i9-12900hk-64gb-ddr5-rtx3080ti-gddr6-16gb-2tb-ssd-17-3-uhd-120hz-w11-p-309003150?boutiqueId=613344&merchantId=118442",
                            Price = 104899f,
                            ProductId = 449,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 1019,
                            Link = "https://www.hepsiburada.com/msi-katana-gf76-11ue-414tr-intel-core-i7-11800h-16gb-1tb-ssd-rtx3060-windows-11-home-17-3-fhd-tasinabilir-bilgisayar-p-HBCV000013ILT8",
                            Price = 43697f,
                            ProductId = 450,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 1020,
                            Link = "https://www.trendyol.com/msi/katana-gf76-11ue-414tr-i7-11800h-16gb-ddr4-rtx3060-gddr6-6gb-1tb-ssd-17-3-fhd-144hz-w11-p-213451132?boutiqueId=613344&merchantId=186891",
                            Price = 46979f,
                            ProductId = 450,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 1021,
                            Link = "https://www.hepsiburada.com/msi-crosshair-15-b12ugz-476xtr-intel-core-i7-12700h-16gb-1tb-ssd-rtx3070-freedos-15-6-fhd-144hz-tasinabilir-bilgisayar-p-HBCV00001XOSQP",
                            Price = 44299f,
                            ProductId = 451,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 1022,
                            Link = "https://www.trendyol.com/msi/crosshair-15-b12ugz-476xtr-i7-12700h-16gb-ddr4-rtx3070-gddr6-8gb-1tb-ssd-15-6-fhd-144hz-dos-p-274352163?boutiqueId=613344&merchantId=121368",
                            Price = 44549f,
                            ProductId = 451,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 1023,
                            Link = "https://www.trendyol.com/msi/katana-gf76-11uc-058xtr-i7-11800h-16gb-ddr4-rtx3050-gddr6-4gb-1tb-ssd-17-3-fhd-144hz-dos-p-119798421?boutiqueId=614349&merchantId=106740",
                            Price = 26199f,
                            ProductId = 452,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 1024,
                            Link = "https://www.n11.com/urun/msi-katana-gf76-11uc-058xtr-i7-11800h-16-gb-1-tb-ssd-4-gb-rtx3050-173-free-dos-dizustu-bilgisayar-2062964?magaza=tekramarket",
                            Price = 35573f,
                            ProductId = 452,
                            Rate = 5f,
                            SiteName = "n11"
                        },
                        new
                        {
                            SitesInformationId = 1025,
                            Link = "https://www.hepsiburada.com/msi-katana-gf76-12ud-218tr-intel-core-i7-12700h-16gb-512gb-ssd-rtx3050ti-windows-11-home-17-3-fhd-144hz-tasinabilir-bilgisayar-p-HBCV00002G7ZPI",
                            Price = 36999f,
                            ProductId = 453,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 1026,
                            Link = "https://www.trendyol.com/msi/katana-gf76-12ud-218tr-i7-12700h-16gb-ddr4-rtx3050ti-gddr6-4gb-512gb-ssd-17-3-fhd-144hz-w11-p-314383769?boutiqueId=614724&merchantId=230901",
                            Price = 29990f,
                            ProductId = 453,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 1027,
                            Link = "https://www.hepsiburada.com/msi-alpha-17-b5eek-018xtr-amd-ryzen-7-5800h-16gb-512gb-ssd-rx6600m-freedos-17-3-144hz-fhd-tasinabilir-bilgisayar-p-HBCV00000ZAY8L",
                            Price = 34089f,
                            ProductId = 454,
                            Rate = 5f,
                            SiteName = "hepsiburada"
                        },
                        new
                        {
                            SitesInformationId = 1028,
                            Link = "https://www.trendyol.com/msi/alpha-17-b5eek-018xtr-r7-5800h-16gb-ddr4-rx6600m-gddr6-8gb-512gb-ssd-17-3-fhd-144hz-dos-p-193789020?boutiqueId=61&merchantId=645935",
                            Price = 34300f,
                            ProductId = 454,
                            Rate = 5f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 1029,
                            Link = "https://www.trendyol.com/msi/raider-ge77hx-12uhs-042tr-i7-12800hx-32gb-ddr5-rtx3080ti-gddr6-16gb-2tb-ssd-17-3-qhd-240hz-w11-p-312669810?boutiqueId=613344&merchantId=118442",
                            Price = 90899f,
                            ProductId = 455,
                            Rate = 0f,
                            SiteName = "trendyol"
                        },
                        new
                        {
                            SitesInformationId = 1030,
                            Link = "https://www.n11.com/urun/msi-raider-ge77hx-12uhs-042tr-i7-12800hx-32-gb-2-tb-ssd-rtx3080ti-240hz-173-w11h-dizustu-bilgisayar-10526514?magaza=techburada",
                            Price = 101791f,
                            ProductId = 455,
                            Rate = 0f,
                            SiteName = "n11"
                        });
                });

            modelBuilder.Entity("scrapapp.entity.CartItem", b =>
                {
                    b.HasOne("scrapapp.entity.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("scrapapp.entity.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("scrapapp.entity.Detail", b =>
                {
                    b.HasOne("scrapapp.entity.Product", "Product")
                        .WithOne("Detail")
                        .HasForeignKey("scrapapp.entity.Detail", "DetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("scrapapp.entity.OrderItem", b =>
                {
                    b.HasOne("scrapapp.entity.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("scrapapp.entity.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
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

            modelBuilder.Entity("scrapapp.entity.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("scrapapp.entity.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("scrapapp.entity.Product", b =>
                {
                    b.Navigation("Detail")
                        .IsRequired();

                    b.Navigation("SitesInformation");
                });
#pragma warning restore 612, 618
        }
    }
}
