using Calligraphy.Models;
using System;
using System.Net.Mail;
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
                try { 
                    using (MailMessage mm = new MailMessage())
                    {
                        mm.To.Add("hriley99@hotmail.com");
                        mm.Subject = string.Format("Quotation for {0}. From {1}", model.Name, model.Email);
                        mm.Body = model.Details;
                        mm.IsBodyHtml = false;

                        //see web.config for settings
                        using (SmtpClient smtp = new SmtpClient())
                        {
                            smtp.Send(mm);
                            ViewBag.Message = "Email sent.";
                        }
                    }
                }
                catch(Exception ex)
                {
                    ViewBag.ErrorMsg = ex.Message;
                }
            }
            return CurrentUmbracoPage();
        }
    }
}