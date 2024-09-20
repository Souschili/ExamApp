using ExamApp.Services.Services;
using ExamApp.Services.Services.Contract;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ExamApp.Services
{
    public static class ServiceCollectionExtention
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly())
                .AddFluentValidationAutoValidation(); // автовалидация в контроллере
            services.AddAutoMapper(Assembly.GetExecutingAssembly()); // забираем все профайлы

            services.AddScoped<IRegistrationService, RegistrationService>();

            return services;
        }

    }
}
