﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PM.DatabaseContext;

#nullable disable

namespace PM.DatabaseContext.Migrations
{
    [DbContext(typeof(DatabaseDbContext))]
    partial class DatabaseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PM.Core.Domain.Boards.Attachment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime?>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<long>("IssueId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedOnUtc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IssueId");

                    b.ToTable("Attachments");
                });

            modelBuilder.Entity("PM.Core.Domain.Boards.Comment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<long>("IssueId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("IssueId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("PM.Core.Domain.Boards.Issue", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("BoardId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Flagged")
                        .HasColumnType("bit");

                    b.Property<long?>("IssueLabelId")
                        .HasColumnType("bigint");

                    b.Property<long?>("IssueTypeId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ParentId")
                        .HasColumnType("bigint");

                    b.Property<long>("ReporterId")
                        .HasColumnType("bigint");

                    b.Property<long?>("StatusId")
                        .HasColumnType("bigint");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("UpdatedOnUtc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BoardId");

                    b.HasIndex("IssueLabelId");

                    b.HasIndex("IssueTypeId");

                    b.HasIndex("ParentId");

                    b.HasIndex("ReporterId");

                    b.HasIndex("StatusId");

                    b.ToTable("Issues");
                });

            modelBuilder.Entity("PM.Core.Domain.Boards.IssueLabel", b =>
                {
                    b.Property<long>("ProjectId")
                        .HasColumnType("bigint");

                    b.Property<long>("LabelId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<long?>("IssueId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedOnUtc")
                        .HasColumnType("datetime2");

                    b.HasKey("ProjectId", "LabelId");

                    b.HasIndex("IssueId");

                    b.HasIndex("LabelId");

                    b.ToTable("IssueLabels");
                });

            modelBuilder.Entity("PM.Core.Domain.Boards.IssueMember", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("AssignedOn")
                        .HasColumnType("datetime2");

                    b.Property<long>("IssueId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("IssueId");

                    b.HasIndex("UserId");

                    b.ToTable("IssueMembers");
                });

            modelBuilder.Entity("PM.Core.Domain.Boards.IssueType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("IconUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar");

                    b.Property<long>("ProjectId")
                        .HasColumnType("bigint");

                    b.Property<bool>("SubTask")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("IssueTypes");
                });

            modelBuilder.Entity("PM.Core.Domain.Boards.Label", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<DateTime?>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar");

                    b.Property<DateTime?>("UpdatedOnUtc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Labels");
                });

            modelBuilder.Entity("PM.Core.Domain.Boards.Team", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<DateTime?>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar");

                    b.Property<DateTime?>("UpdatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<long>("WorkspaceId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("WorkspaceId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("PM.Core.Domain.Boards.TeamMember", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime?>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<long>("TeamId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.HasIndex("UserId");

                    b.ToTable("TeamMembers");
                });

            modelBuilder.Entity("PM.Core.Domain.Boards.WorkspaceMember", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("BoardId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("WorkspaceId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("BoardId");

                    b.HasIndex("UserId");

                    b.HasIndex("WorkspaceId");

                    b.ToTable("WorkspaceMember");
                });

            modelBuilder.Entity("PM.Core.Domain.Customers.UserPassword", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("PasswordFormat")
                        .HasColumnType("int");

                    b.Property<int>("PasswordFormatId")
                        .HasColumnType("int");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("UpdatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("UserPasswords");
                });

            modelBuilder.Entity("PM.Core.Domain.Projects.Board", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime?>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar");

                    b.Property<long>("ProjectId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedOnUtc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Boards");
                });

            modelBuilder.Entity("PM.Core.Domain.Projects.Project", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("AssigneeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar");

                    b.Property<long?>("ProjectLeadId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ProjectTypeId")
                        .HasColumnType("bigint");

                    b.Property<long>("WorkspaceId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProjectLeadId");

                    b.HasIndex("ProjectTypeId");

                    b.HasIndex("WorkspaceId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("PM.Core.Domain.Projects.ProjectCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime?>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar");

                    b.Property<DateTime?>("UpdatedOnUtc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ProjectCategories");
                });

            modelBuilder.Entity("PM.Core.Domain.Projects.ProjectType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime?>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar");

                    b.Property<DateTime?>("UpdatedOnUtc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ProjectTypes");
                });

            modelBuilder.Entity("PM.Core.Domain.Projects.Status", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("BoardId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOnUtc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BoardId");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("PM.Core.Domain.Users.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar");

                    b.Property<bool>("EmailVerified")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<bool>("IsSystemAccount")
                        .HasColumnType("bit");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar");

                    b.Property<string>("LastIpAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<DateTime?>("LastLoginDateUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar");

                    b.Property<string>("Organization")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("UpdatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PM.Core.Domain.Users.UserRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSystemRole")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("PM.Core.Domain.Users.Workspace", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("Workspaces");
                });

            modelBuilder.Entity("PM.Core.Domain.Boards.Attachment", b =>
                {
                    b.HasOne("PM.Core.Domain.Boards.Issue", "Issue")
                        .WithMany("Attachments")
                        .HasForeignKey("IssueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Issue");
                });

            modelBuilder.Entity("PM.Core.Domain.Boards.Comment", b =>
                {
                    b.HasOne("PM.Core.Domain.Boards.Issue", "Issue")
                        .WithMany("Comments")
                        .HasForeignKey("IssueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PM.Core.Domain.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Issue");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PM.Core.Domain.Boards.Issue", b =>
                {
                    b.HasOne("PM.Core.Domain.Projects.Board", "Board")
                        .WithMany()
                        .HasForeignKey("BoardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PM.Core.Domain.Boards.Label", "IssueLabel")
                        .WithMany()
                        .HasForeignKey("IssueLabelId");

                    b.HasOne("PM.Core.Domain.Boards.IssueType", "IssueType")
                        .WithMany()
                        .HasForeignKey("IssueTypeId");

                    b.HasOne("PM.Core.Domain.Boards.Issue", "ParentIssue")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.HasOne("PM.Core.Domain.Users.User", "Reporter")
                        .WithMany()
                        .HasForeignKey("ReporterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PM.Core.Domain.Projects.Status", "Status")
                        .WithMany("Issues")
                        .HasForeignKey("StatusId");

                    b.Navigation("Board");

                    b.Navigation("IssueLabel");

                    b.Navigation("IssueType");

                    b.Navigation("ParentIssue");

                    b.Navigation("Reporter");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("PM.Core.Domain.Boards.IssueLabel", b =>
                {
                    b.HasOne("PM.Core.Domain.Boards.Issue", null)
                        .WithMany("IssueLabels")
                        .HasForeignKey("IssueId");

                    b.HasOne("PM.Core.Domain.Boards.Label", "Label")
                        .WithMany()
                        .HasForeignKey("LabelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PM.Core.Domain.Projects.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Label");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("PM.Core.Domain.Boards.IssueMember", b =>
                {
                    b.HasOne("PM.Core.Domain.Boards.Issue", "Issue")
                        .WithMany("IssueMembers")
                        .HasForeignKey("IssueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PM.Core.Domain.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Issue");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PM.Core.Domain.Boards.IssueType", b =>
                {
                    b.HasOne("PM.Core.Domain.Projects.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("PM.Core.Domain.Boards.Team", b =>
                {
                    b.HasOne("PM.Core.Domain.Users.Workspace", "Workspace")
                        .WithMany()
                        .HasForeignKey("WorkspaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Workspace");
                });

            modelBuilder.Entity("PM.Core.Domain.Boards.TeamMember", b =>
                {
                    b.HasOne("PM.Core.Domain.Boards.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PM.Core.Domain.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PM.Core.Domain.Boards.WorkspaceMember", b =>
                {
                    b.HasOne("PM.Core.Domain.Projects.Board", null)
                        .WithMany("BoardMembers")
                        .HasForeignKey("BoardId");

                    b.HasOne("PM.Core.Domain.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PM.Core.Domain.Users.Workspace", "Workspace")
                        .WithMany()
                        .HasForeignKey("WorkspaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Workspace");
                });

            modelBuilder.Entity("PM.Core.Domain.Projects.Board", b =>
                {
                    b.HasOne("PM.Core.Domain.Projects.Project", "Project")
                        .WithMany("Boards")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("PM.Core.Domain.Projects.Project", b =>
                {
                    b.HasOne("PM.Core.Domain.Projects.ProjectCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("PM.Core.Domain.Users.User", "ProjectLead")
                        .WithMany()
                        .HasForeignKey("ProjectLeadId");

                    b.HasOne("PM.Core.Domain.Projects.ProjectType", "ProjectType")
                        .WithMany()
                        .HasForeignKey("ProjectTypeId");

                    b.HasOne("PM.Core.Domain.Users.Workspace", "Workspace")
                        .WithMany("Projects")
                        .HasForeignKey("WorkspaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("ProjectLead");

                    b.Navigation("ProjectType");

                    b.Navigation("Workspace");
                });

            modelBuilder.Entity("PM.Core.Domain.Projects.Status", b =>
                {
                    b.HasOne("PM.Core.Domain.Projects.Board", "Board")
                        .WithMany("Statuses")
                        .HasForeignKey("BoardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Board");
                });

            modelBuilder.Entity("PM.Core.Domain.Boards.Issue", b =>
                {
                    b.Navigation("Attachments");

                    b.Navigation("Comments");

                    b.Navigation("IssueLabels");

                    b.Navigation("IssueMembers");
                });

            modelBuilder.Entity("PM.Core.Domain.Projects.Board", b =>
                {
                    b.Navigation("BoardMembers");

                    b.Navigation("Statuses");
                });

            modelBuilder.Entity("PM.Core.Domain.Projects.Project", b =>
                {
                    b.Navigation("Boards");
                });

            modelBuilder.Entity("PM.Core.Domain.Projects.Status", b =>
                {
                    b.Navigation("Issues");
                });

            modelBuilder.Entity("PM.Core.Domain.Users.Workspace", b =>
                {
                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
