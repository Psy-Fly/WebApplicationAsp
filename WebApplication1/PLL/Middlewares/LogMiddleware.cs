// AlexeyQwake Qwake

using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace WebApplication1
{
    public class LogMiddleware
    {
        private readonly RequestDelegate next;
        private ILogger logger;

        public LogMiddleware(RequestDelegate next, ILogger logger)
        {
            this.next = next;
            this.logger = logger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            logger.WriteEvent("Я твой Middleware " + httpContext.Connection.RemoteIpAddress);
            await next(httpContext);
        }
    }
}