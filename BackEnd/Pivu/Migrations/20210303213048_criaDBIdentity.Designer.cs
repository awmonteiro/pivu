﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using Pivu.Data;

namespace Pivu.Migrations
{
    [DbContext(typeof(PivuContextIdentity))]
    [Migration("20210303213048_criaDBIdentity")]
    partial class criaDBIdentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR2(450)")
                        .HasColumnName("ID");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("CONCURRENCYSTAMP");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)")
                        .HasColumnName("NAME");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)")
                        .HasColumnName("NORMALIZEDNAME");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("\"NORMALIZEDNAME\" IS NOT NULL");

                    b.ToTable("ASPNETROLES");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("CLAIMTYPE");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("CLAIMVALUE");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)")
                        .HasColumnName("ROLEID");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("ASPNETROLECLAIMS");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("CLAIMTYPE");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("CLAIMVALUE");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)")
                        .HasColumnName("USERID");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ASPNETUSERCLAIMS");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("NVARCHAR2(128)")
                        .HasColumnName("LOGINPROVIDER");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("NVARCHAR2(128)")
                        .HasColumnName("PROVIDERKEY");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("PROVIDERDISPLAYNAME");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)")
                        .HasColumnName("USERID");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("ASPNETUSERLOGINS");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("NVARCHAR2(450)")
                        .HasColumnName("USERID");

                    b.Property<string>("RoleId")
                        .HasColumnType("NVARCHAR2(450)")
                        .HasColumnName("ROLEID");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("ASPNETUSERROLES");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("NVARCHAR2(450)")
                        .HasColumnName("USERID");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("NVARCHAR2(128)")
                        .HasColumnName("LOGINPROVIDER");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("NVARCHAR2(128)")
                        .HasColumnName("NAME");

                    b.Property<string>("Value")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("VALUE");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("ASPNETUSERTOKENS");
                });

            modelBuilder.Entity("Pivu.Areas.Identity.Data.PivuUserIdentity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("NVARCHAR2(450)")
                        .HasColumnName("ID_USUARIO");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ACCESSFAILEDCOUNT");

                    b.Property<int>("CPF")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("CPF");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("CONCURRENCYSTAMP");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)")
                        .HasColumnName("EMAIL");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("NUMBER(1)")
                        .HasColumnName("EMAILCONFIRMED");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("NUMBER(1)")
                        .HasColumnName("LOCKOUTENABLED");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TIMESTAMP(7) WITH TIME ZONE")
                        .HasColumnName("LOCKOUTEND");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("NASCIMENTO");

                    b.Property<string>("Nome")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("NOME");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)")
                        .HasColumnName("NORMALIZEDEMAIL");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)")
                        .HasColumnName("NORMALIZEDUSERNAME");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("PASSWORDHASH");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("PHONENUMBER");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("NUMBER(1)")
                        .HasColumnName("PHONENUMBERCONFIRMED");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("SECURITYSTAMP");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("NUMBER(1)")
                        .HasColumnName("TWOFACTORENABLED");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("NVARCHAR2(256)")
                        .HasColumnName("USERNAME");

                    b.Property<int>("id_endereco_pricipal")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_ENDERECO_PRINCIPAL");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("\"NORMALIZEDUSERNAME\" IS NOT NULL");

                    b.ToTable("USUARIO");
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
                    b.HasOne("Pivu.Areas.Identity.Data.PivuUserIdentity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Pivu.Areas.Identity.Data.PivuUserIdentity", null)
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

                    b.HasOne("Pivu.Areas.Identity.Data.PivuUserIdentity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Pivu.Areas.Identity.Data.PivuUserIdentity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}