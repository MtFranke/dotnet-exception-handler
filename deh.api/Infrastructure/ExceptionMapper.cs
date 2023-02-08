using deh.api.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace deh.api.Infrastructure;

public class ExceptionMapper
{
    public static ProblemDetails Map(Exception exception)
    {
        return exception switch
        {
            DomainException => new ProblemDetails
            {
                Detail = exception.Message,
                Type = exception.GetType().ToString(),
                Status = StatusCodes.Status400BadRequest,
            },
            _ => new ProblemDetails()
            {
                Detail = exception.Message,
                Type = exception.GetType().ToString(),
                Status = StatusCodes.Status500InternalServerError
            }
        };
    }
}