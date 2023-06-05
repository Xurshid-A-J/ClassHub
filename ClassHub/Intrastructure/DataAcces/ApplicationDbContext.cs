using Application.Abstractions;
using Domain.Common;
using Domain.Entities.Assignments;
using Domain.Entities.Groups;
using Domain.Entities.Marks;
using Domain.Entities.Notices;
using Domain.Entities.Students;
using Domain.Entities.Teachers;
using Domain.IdentityEntities;
using Intrastructure.DataAcces.Interceptors;
using Microsoft.EntityFrameworkCore;

namespace Intrastructure.DataAcces
{
    public partial class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        private readonly AuditableEntitySaveChangesInterceptor interceptor;
        public ApplicationDbContext(
                DbContextOptions<ApplicationDbContext> options, 
                AuditableEntitySaveChangesInterceptor interceptor) :base(options)
        { 
            this.interceptor = interceptor; 
        }

        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }

        public DbSet<Mark> Marks { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        =>optionsBuilder.AddInterceptors(interceptor);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().HasKey(t => t.Id);

            modelBuilder.Entity<Student>().HasBaseType<UserEntity>().ToTable("Students");
            modelBuilder.Entity<Teacher>().HasBaseType<UserEntity>().ToTable("Teachers");

            base.OnModelCreating(modelBuilder);
        }

    }
}
