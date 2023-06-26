using Microsoft.AspNetCore.Mvc.Filters;

namespace Traveler.Api.Filters
{
    public class MvcRequestLoggingFilter : IAsyncActionFilter
    {
        public Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            throw new NotImplementedException();
        }
    }
}
