// AlexeyQwake Qwake

using Microsoft.AspNetCore.Builder;

namespace WebApplication1
{
    public static class LogMiddlewareExtensions
    {
        public static IApplicationBuilder UseLogMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LogMiddleware>();
        }
    }
}