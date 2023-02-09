using deh.api.Exceptions;
using deh.api.Exceptions.Base;

namespace deh.api.Infrastructure;

public class ExceptionMiddleware
{
    private const string ResponseContentType = "application/json";
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionMiddleware> _logger;
    public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
    {
        _logger = logger;
        _next = next;
    }
    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(httpContext, ex);
        }
    }
    
    private async Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        if (exception is CustomException)
        {
            _logger.LogInformation(exception.ToString());
        }
    
        _logger.LogError("Unhandled exception, {0}", exception);

        var problemDetails = ExceptionMapper.Map(exception);
        context.Response.StatusCode = problemDetails.Status ?? 500;
        context.Response.ContentType = ResponseContentType;
        await context.Response.WriteAsJsonAsync(problemDetails);
    }
}