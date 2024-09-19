using ExamApp_Domain.Context;
using ExamApp_Domain.Repositories;
using ExamApp_Domain.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ExamApp_Domain
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration config)
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));

            services.AddDbContext<AppDbContext>(cfg =>
                cfg.UseSqlServer(config.GetConnectionString("Local")));

            return services;
        }

        public static IServiceCollection AddDomainRepositories(this IServiceCollection services)
        {
            services.AddScoped<ISubjectRepository, SubjectRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IExamRepository, ExamRepository>();

            // services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            return services;
        }
    }
}
