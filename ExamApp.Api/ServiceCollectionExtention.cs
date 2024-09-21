using ExamApp.Api.ExceptionHandlers;

namespace ExamApp.Api
{
    public static class ServiceCollectionExtention
    {
        public static IServiceCollection AddExceptionHandlers(this IServiceCollection services)
        {
            services.AddProblemDetails();
            services.AddExceptionHandler<GlobalExceptionHandler>();

            return services;
        }

    }
}
