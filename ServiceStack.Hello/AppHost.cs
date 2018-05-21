using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookMyShow.ServiceInterface;
using ServiceStack;
using ServiceStack.Data;
using ServiceStack.Mvc;
using ServiceStack.OrmLite;

using Funq;

namespace ServiceStack.Hello
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base("Test", typeof(ArtistService).Assembly)
        {

        }

        public override void Configure(Funq.Container container)
        {

            // ASP.NET MVC integration
            ControllerBuilder.Current.SetControllerFactory(new FunqControllerFactory(container));

            SetConfig(CreateEndpointHostConfig());
        }

        protected virtual HostConfig CreateEndpointHostConfig()
        {
            return new HostConfig
            {
                DebugMode = true,
                DefaultContentType = MimeTypes.Json,
                HandlerFactoryPath = "api"
            };
        }
    }
}