using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Veenca
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes(); //rende possibile l'utilizzo di attributi
                                            //in modo tale che il controller
                                            //ed il route comunichino meglio.
                                            //Senza ciò si dovrebbe aggiornare
                                            //ad ogni cambiamento del nome dell'
                                            //azione anche il nome della route    
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
