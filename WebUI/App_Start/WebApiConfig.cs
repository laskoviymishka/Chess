using System.Web.Http;
using System.Web.Routing;
//using ProxyApi;

namespace Chess.UI.WebUI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var routeValues = new RouteValueDictionary();
            routeValues.Add("controller", null);
            routeValues.Add("action", null);

            //RouteTable.Routes.Add("ProxyApi",
            //    new Route("api/proxies", routeValues, ProxyDependencyResolver.Instance.GetService(typeof(RouteHandler)) as RouteHandler));

            GlobalConfiguration.Configuration.Routes.MapHttpRoute(
                name: "ApiProxy",
                routeTemplate: "api/{proxy}/{controller}/{action}",
                defaults: new { },
                constraints: new { proxy = "^proxy$" } //note: this is to prevent EVERY controller/action route being returned as api/proxy/controller/action when calling Url.Action etc
            );
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
