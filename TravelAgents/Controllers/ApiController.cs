using ErrorOr;
using Microsoft.AspNetCore.Mvc;

namespace TravelAgents.Controllers;

[ApiController]
[Route("[controller]")]
public class ApiController : ControllerBase
{
    protected IActionResult Problem(List<Error> errors)//overloaded or customer Problem method
    {
        Error firstError = errors[0];//get the first error
        var statusCode = firstError.Type switch
        {//assign the status code the right value based on the type of the Error object
            ErrorType.NotFound => StatusCodes.Status404NotFound,
            ErrorType.Validation => StatusCodes.Status403Forbidden,
            ErrorType.Conflict => StatusCodes.Status409Conflict
        };

        return Problem(statusCode: statusCode, title: firstError.Description);
    }

}