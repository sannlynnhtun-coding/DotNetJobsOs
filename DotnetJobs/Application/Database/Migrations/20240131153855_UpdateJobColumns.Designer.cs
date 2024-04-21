﻿// <auto-generated />
using System;
using DotnetJobs.Application.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DotnetJobs.Application.Database.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240131153855_UpdateJobColumns")]
    partial class UpdateJobColumns
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DotnetJobs.Application.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("email");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("location");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("logo");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("name");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("slug");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.Property<bool>("Verified")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("verified");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("website");

                    b.HasKey("Id")
                        .HasName("pk_companies");

                    b.ToTable("companies", (string)null);
                });

            modelBuilder.Entity("DotnetJobs.Application.Models.ExperienceLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_default");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_experience_levels");

                    b.ToTable("experience_levels", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDefault = false,
                            Name = "Junior"
                        },
                        new
                        {
                            Id = 2,
                            IsDefault = false,
                            Name = "Mid-level"
                        },
                        new
                        {
                            Id = 3,
                            IsDefault = false,
                            Name = "Senior"
                        },
                        new
                        {
                            Id = 4,
                            IsDefault = false,
                            Name = "Lead"
                        });
                });

            modelBuilder.Entity("DotnetJobs.Application.Models.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("ApplyCount")
                        .HasColumnType("int")
                        .HasColumnName("apply_count");

                    b.Property<string>("ApplyLink")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("apply_link");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int")
                        .HasColumnName("company_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<int>("ExperienceLevelId")
                        .HasColumnType("int")
                        .HasColumnName("experience_level_id");

                    b.Property<bool>("HasPaid")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("has_paid");

                    b.Property<bool>("IsClosed")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_closed");

                    b.Property<bool>("IsPremium")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_premium");

                    b.Property<string>("Location")
                        .HasColumnType("longtext")
                        .HasColumnName("location");

                    b.Property<string>("LocationRestrictions")
                        .HasColumnType("longtext")
                        .HasColumnName("location_restrictions");

                    b.Property<string>("PaymentCallbackGuid")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("payment_callback_guid");

                    b.Property<int>("RemotePolicyId")
                        .HasColumnType("int")
                        .HasColumnName("remote_policy_id");

                    b.Property<int?>("SalaryEnd")
                        .HasColumnType("int")
                        .HasColumnName("salary_end");

                    b.Property<int?>("SalaryStart")
                        .HasColumnType("int")
                        .HasColumnName("salary_start");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("slug");

                    b.Property<string>("StripeIdentifier")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("stripe_identifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("title");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.Property<int?>("ViewCount")
                        .HasColumnType("int")
                        .HasColumnName("view_count");

                    b.Property<int>("WorkTypeId")
                        .HasColumnType("int")
                        .HasColumnName("work_type_id");

                    b.HasKey("Id")
                        .HasName("pk_jobs");

                    b.HasIndex("CompanyId")
                        .HasDatabaseName("ix_jobs_company_id");

                    b.HasIndex("ExperienceLevelId")
                        .HasDatabaseName("ix_jobs_experience_level_id");

                    b.HasIndex("RemotePolicyId")
                        .HasDatabaseName("ix_jobs_remote_policy_id");

                    b.HasIndex("WorkTypeId")
                        .HasDatabaseName("ix_jobs_work_type_id");

                    b.ToTable("jobs", (string)null);
                });

            modelBuilder.Entity("DotnetJobs.Application.Models.JobUpload", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("ApplyLink")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("apply_link");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("company_name");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("status");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_job_uploads");

                    b.ToTable("job_uploads", (string)null);
                });

            modelBuilder.Entity("DotnetJobs.Application.Models.RemotePolicy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_default");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_remote_policies");

                    b.ToTable("remote_policies", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDefault = true,
                            Name = "Remote"
                        },
                        new
                        {
                            Id = 2,
                            IsDefault = false,
                            Name = "Hybrid"
                        },
                        new
                        {
                            Id = 3,
                            IsDefault = false,
                            Name = "On-site"
                        });
                });

            modelBuilder.Entity("DotnetJobs.Application.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("varchar(450)")
                        .HasColumnName("name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_roles");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasDatabaseName("ix_roles_name");

                    b.ToTable("roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "User"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("DotnetJobs.Application.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("varchar(450)")
                        .HasColumnName("email");

                    b.Property<DateTime?>("EmailVerifiedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("email_verified_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.Property<string>("RememberToken")
                        .HasColumnType("longtext")
                        .HasColumnName("remember_token");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("ix_users_email");

                    b.ToTable("users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "walk8919@gmail.com",
                            Name = "Wes",
                            Password = "HErVg3ksn0p1C5U9mtIgoUrFF7xObNrLE5FF58JmzU4="
                        });
                });

            modelBuilder.Entity("DotnetJobs.Application.Models.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.HasKey("UserId", "RoleId")
                        .HasName("pk_user_roles");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_user_roles_role_id");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_user_roles_user_id");

                    b.ToTable("user_roles", (string)null);
                });

            modelBuilder.Entity("DotnetJobs.Application.Models.WorkType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_default");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_work_types");

                    b.ToTable("work_types", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDefault = true,
                            Name = "Full-time"
                        },
                        new
                        {
                            Id = 2,
                            IsDefault = false,
                            Name = "Part-time"
                        },
                        new
                        {
                            Id = 3,
                            IsDefault = false,
                            Name = "Internship"
                        },
                        new
                        {
                            Id = 4,
                            IsDefault = false,
                            Name = "Freelance"
                        },
                        new
                        {
                            Id = 5,
                            IsDefault = false,
                            Name = "Contract"
                        });
                });

            modelBuilder.Entity("DotnetJobs.Application.Models.Job", b =>
                {
                    b.HasOne("DotnetJobs.Application.Models.Company", "Company")
                        .WithMany("Jobs")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_jobs_companies_company_id");

                    b.HasOne("DotnetJobs.Application.Models.ExperienceLevel", "ExperienceLevel")
                        .WithMany()
                        .HasForeignKey("ExperienceLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_jobs_experience_levels_experience_level_id");

                    b.HasOne("DotnetJobs.Application.Models.RemotePolicy", "RemotePolicy")
                        .WithMany()
                        .HasForeignKey("RemotePolicyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_jobs_remote_policies_remote_policy_id");

                    b.HasOne("DotnetJobs.Application.Models.WorkType", "WorkType")
                        .WithMany()
                        .HasForeignKey("WorkTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_jobs_work_types_work_type_id");

                    b.Navigation("Company");

                    b.Navigation("ExperienceLevel");

                    b.Navigation("RemotePolicy");

                    b.Navigation("WorkType");
                });

            modelBuilder.Entity("DotnetJobs.Application.Models.UserRole", b =>
                {
                    b.HasOne("DotnetJobs.Application.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_user_roles_roles_role_id");

                    b.HasOne("DotnetJobs.Application.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_user_roles_users_user_id");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DotnetJobs.Application.Models.Company", b =>
                {
                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("DotnetJobs.Application.Models.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("DotnetJobs.Application.Models.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
