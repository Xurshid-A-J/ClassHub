using Application.Abstractions;
using Domain.Entities.Assignments;
using Domain.Entities.Groups;
using Domain.Entities.Marks;
using Domain.Entities.Notices;
using Domain.Entities.Students;
using Domain.Entities.Teachers;
using Domain.IdentityEntities;
using Microsoft.EntityFrameworkCore;

namespace Intrastructure.DataAcces
{
    public partial class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        { }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }

        public DbSet<Mark> Marks { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
