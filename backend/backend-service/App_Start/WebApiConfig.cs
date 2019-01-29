using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace backend_service
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            var cors = new System.Web.Http.Cors.EnableCorsAttribute("*", "*", "GET, POST, PUT, DELETE, OPTIONS") { SupportsCredentials = true };
            config.EnableCors(cors);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
