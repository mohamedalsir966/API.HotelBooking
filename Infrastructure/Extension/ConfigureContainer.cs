﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Extension
{
    public static class ConfigureContainer
    {
        public static void ConfigureSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(setupAction =>
            {
                setupAction.SwaggerEndpoint("/swagger/OpenAPISpecification/swagger.json", "Onion Architecture API");
                setupAction.RoutePrefix = "OpenAPI";
            });


        }
        public static void ConfigureSwagger(this ILoggerFactory loggerFactory)
        {
            loggerFactory.AddSerilog();
        }

    }
}
