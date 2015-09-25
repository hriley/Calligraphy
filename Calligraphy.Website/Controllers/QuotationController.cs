using Calligraphy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calligraphy.Controllers
{
    public class QuotationController : Umbraco.Web.Mvc.SurfaceController
    {
        [HttpPost]
        public ActionResult QuotationForm(QuotationModel model)
        {
            if (ModelState.IsValid)
            {

            }

            return CurrentUmbracoPage();
        }
    }
}