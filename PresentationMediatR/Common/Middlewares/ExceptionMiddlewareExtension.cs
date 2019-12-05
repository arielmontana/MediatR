using Microsoft.AspNetCore.Builder;
using PresentationMediatR.Common.Middlewares;

namespace ApplicationLayer.Common.Exceptions
{
    public static class ExceptionMiddlewareExtension
    {
        public static IApplicationBuilder UseValidationException(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionHandler>();
        }
    }
}