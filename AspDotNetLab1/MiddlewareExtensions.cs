using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetLab1
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseLogger
            (this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggerMiddleware>();
        }

        public static IApplicationBuilder SecretPage
            (this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SecretMiddleware>();
        }
    }
}
