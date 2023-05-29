using Application.Abstractions;
using Application.Interfaces.IEntityRepositories;
using Intrastructure.DataAcces;
using Intrastructure.DataAcces.Interceptors;
using Intrastructure.Services.EntityRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Intrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<AuditableEntitySaveChangesInterceptor>();
            services.AddScoped<IAssignmentRepository, AssignmentRepository>();
            services.AddScoped<IGroupRepository, GroupRepository>();
            services.AddScoped<IMarkRepository, MarkRepository>();
            services.AddScoped<INoticeRepository, NoticeRepository>();
            services.AddScoped<IPermissionRepository, PermissionRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();

            services.AddDbContext<IApplicationDbContext, ApplicationDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("ClassHubDb")));

            return services;
        }
    }
}