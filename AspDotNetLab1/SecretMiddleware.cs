using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetLab1 {
    public class SecretMiddleware {
        private readonly RequestDelegate _next;

        public SecretMiddleware (RequestDelegate next) {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext context) {
            string path = context.Request.Path.Value.ToLower();
            if (path == "/secret-455546664") {
                await context.Response.WriteAsync("You join to the secret page");
            }
            else {
                await _next.Invoke(context);
            }
        }
    }
}