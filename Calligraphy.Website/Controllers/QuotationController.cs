using Calligraphy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
                using (MailMessage mm = new MailMessage(model.Email, "hriley99@hotmail.com"))
                {
                    mm.Subject = string.Format("Quotation for {0}", model.Name);
                    mm.Body = model.Details;
                    mm.IsBodyHtml = false;
                    using (SmtpClient smtp = new SmtpClient())
                    {
                        smtp.Host = "smtp.gmail.com";
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = new NetworkCredential("hrvriley@gamil.com", "DonkeyBeach69");
                        smtp.Port = 587;
                        smtp.Send(mm);
                        ViewBag.Message = "Email sent.";
                    }
                }
            }

            return CurrentUmbracoPage();
        }
    }
}