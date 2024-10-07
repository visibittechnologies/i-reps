namespace PM.DatabaseContext
{
    using Microsoft.EntityFrameworkCore;
    using PM.Core.Domain.Boards;
    using PM.Core.Domain.Customers;
    using PM.Core.Domain.Projects;
    using PM.Core.Domain.Users;

    public class DatabaseDbContext : DbContext
    {
        public DatabaseDbContext(DbContextOptions<DatabaseDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserPassword> UserPasswords { get; set; }
        public DbSet<Workspace> Workspaces { get; set; }
        public DbSet<WorkspaceMember> WorkspaceMembers { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectCategory> ProjectCategories { get; set; }
        public DbSet<ProjectType> ProjectTypes { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<WorkspaceMember> BoardMembers { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<IssueLabel> IssueLabels { get; set; }
        public DbSet<IssueType> IssueTypes { get; set; }
        public DbSet<IssueMember> IssueMembers { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Attachment> Attachments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuring relationships for many-to-many
            modelBuilder.Entity<IssueLabel>().HasKey(cl => new { cl.ProjectId, cl.LabelId });

            //modelBuilder.Entity<BoardMember>()
            //    .HasOne(bm => bm.User)
            //    .WithMany(u => u.BoardMembers)
            //    .HasForeignKey(bm => bm.UserId);

            //modelBuilder.Entity<BoardMember>()
            //    .HasOne(bm => bm.Board)
            //    .WithMany(b => b.BoardMembers)
            //    .HasForeignKey(bm => bm.BoardId);
        }
    }
}
