using System.Web.Http;
using Swashbuckle.Application;

namespace CargoManagementApi
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "CargoManagementApi");
                })
                .EnableSwaggerUi();
        }
    }
}
