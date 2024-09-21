using Microsoft.AspNetCore.Diagnostics;

namespace ExamApp.Api.ExceptionHandlers
{
    internal class GlobalExceptionHandler : IExceptionHandler
    {
        public ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
