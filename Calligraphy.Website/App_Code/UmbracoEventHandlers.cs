using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using System.Web.Optimization;

namespace Calligraphy.App_Code
{
    public class UmbracoEventHandlers : ApplicationEventHandler
    {
        protected override void ApplicationInitialized(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}