using ErrorOr;

namespace TravelAgents.ServiceErrors;

public static class Errors
{
    public static class Origin
    {
        public static Error NotFound => Error.NotFound(
            code: "Origin.NotFound",
            description: "Origin Not Found"
        );
    }
}