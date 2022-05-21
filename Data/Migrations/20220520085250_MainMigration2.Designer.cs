﻿// <auto-generated />
using System;
using EDSU_SMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EDSU_SMS.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220520085250_MainMigration2")]
    partial class MainMigration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EDSU_SMS.Models.Applicant", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("BirthCertificate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseChoseInJamb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("DirectEntryUpload")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstChoice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Indigine")
                        .HasColumnType("bit");

                    b.Property<string>("Jamb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LGA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LGAUpload")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaritalStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModeOfEntry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoOfSittings")
                        .HasColumnType("int");

                    b.Property<string>("OtherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentAlternatePhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentOccupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Passport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermanentHomeAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreviousGrade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreviousInstitution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreviousLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimarySchool")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondChoice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondarySchool")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ssce1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ssce1Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ssce1Subject1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ssce1Subject1Grade")
                        .HasColumnType("int");

                    b.Property<string>("Ssce1Subject2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ssce1Subject2Grade")
                        .HasColumnType("int");

                    b.Property<string>("Ssce1Subject3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ssce1Subject3Grade")
                        .HasColumnType("int");

                    b.Property<string>("Ssce1Subject4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ssce1Subject4Grade")
                        .HasColumnType("int");

                    b.Property<string>("Ssce1Subject5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ssce1Subject5Grade")
                        .HasColumnType("int");

                    b.Property<string>("Ssce1Subject6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ssce1Subject6Grade")
                        .HasColumnType("int");

                    b.Property<string>("Ssce1Subject7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ssce1Subject7Grade")
                        .HasColumnType("int");

                    b.Property<string>("Ssce1Subject8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ssce1Subject8Grade")
                        .HasColumnType("int");

                    b.Property<string>("Ssce1Subject9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ssce1Subject9Grade")
                        .HasColumnType("int");

                    b.Property<string>("Ssce1Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ssce1Year")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ssce2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ssce2Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ssce2Subject1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ssce2Subject1Grade")
                        .HasColumnType("int");

                    b.Property<string>("Ssce2Subject2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ssce2Subject2Grade")
                        .HasColumnType("int");

                    b.Property<string>("Ssce2Subject3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ssce2Subject3Grade")
                        .HasColumnType("int");

                    b.Property<string>("Ssce2Subject4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ssce2Subject4Grade")
                        .HasColumnType("int");

                    b.Property<string>("Ssce2Subject5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ssce2Subject5Grade")
                        .HasColumnType("int");

                    b.Property<string>("Ssce2Subject6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ssce2Subject6Grade")
                        .HasColumnType("int");

                    b.Property<string>("Ssce2Subject7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ssce2Subject7Grade")
                        .HasColumnType("int");

                    b.Property<string>("Ssce2Subject8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ssce2Subject8Grade")
                        .HasColumnType("int");

                    b.Property<string>("Ssce2Subject9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ssce2Subject9Grade")
                        .HasColumnType("int");

                    b.Property<string>("Ssce2Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ssce2Year")
                        .HasColumnType("datetime2");

                    b.Property<string>("StateOfOrigin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdChoice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UTEMTotal")
                        .HasColumnType("int");

                    b.Property<string>("UTMESubject1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UTMESubject1Score")
                        .HasColumnType("int");

                    b.Property<string>("UTMESubject2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UTMESubject2Score")
                        .HasColumnType("int");

                    b.Property<string>("UTMESubject3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UTMESubject3Score")
                        .HasColumnType("int");

                    b.Property<string>("UTMESubject4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UTMESubject4Score")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Applicant");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}