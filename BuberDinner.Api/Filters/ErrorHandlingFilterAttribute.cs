using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BuberDinner.Api.Filters;

public class ErrorHandlingFilterAttribute: ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        var exception = context.Exception;

        var errorResuult = new { error = "An error occured while processing your request."};

        context.Result = new ObjectResult(errorResuult)
        {
            StatusCode = 500
        };

        context.ExceptionHandled = true;
    }
}