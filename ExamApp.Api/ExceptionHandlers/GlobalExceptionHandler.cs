using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace ExamApp.Api.ExceptionHandlers
{
    internal sealed class GlobalExceptionHandler : IExceptionHandler
    {
        private readonly IHostEnvironment _environment;
        private readonly ILogger<GlobalExceptionHandler> _logger;

        public GlobalExceptionHandler(IHostEnvironment environment, ILogger<GlobalExceptionHandler> logger)
        {
            _environment = environment;
            _logger = logger;
        }
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext,
            Exception exception,
            CancellationToken cancellationToken)
        {
            // stacktrace info include where in code exception occured,
            // only for development :-)
            string trace = _environment.IsDevelopment() ? GetFirstStackTraceLine(exception) : string.Empty;
            string instance = _environment.IsDevelopment() ? $"{httpContext.Request.Method} {httpContext.Request.Path}\n" :
                            string.Empty;
            var problemDetail = new ProblemDetails
            {
                Status = StatusCodes.Status500InternalServerError, // status code
                Type = exception.GetType().ToString(),            // get exception type
                Detail = exception.Message,                       // exception message
                Title = "An unexpected error occurred",           // title 

                // used only in development, id field empty or null it hided in responce )
                Instance = instance + trace // show path + code line number
            };
            var problemDetailJson = JsonSerializer.Serialize(problemDetail);
            _logger.LogError("Unhandle exception Info {@problemDetail}", problemDetailJson);
            await httpContext.Response.WriteAsJsonAsync(problemDetail, cancellationToken);

            return true;
        }

        private string GetFirstStackTraceLine(Exception exception)
        {
            if (exception.StackTrace == null)
            {
                return "No stack trace available";
            }

            var stackTrace = new StackTrace(exception, true);
            var frame = stackTrace.GetFrame(0);
            return frame != null ? $"{frame?.GetMethod()?.Name} at {frame?.GetFileName()}:line {frame?.GetFileLineNumber()}" : "No stack trace available";
        }
    }
}
