using System.Web.Mvc;
using System.Web.Security;
using Calligraphy.Models;

namespace UmbracoLogin
{


    public class MemberLoginSurfaceController : Umbraco.Web.Mvc.SurfaceController
    {
        [HttpGet]
        [ActionName("MemberLogin")]
        public ActionResult MemberLoginGet()
        {
            return PartialView("MemberLogin", new MemberLoginModel());
        }

        [HttpGet]
        public ActionResult MemberLogout()
        {
            Session.Clear();
            FormsAuthentication.SignOut();
            return Redirect("/");
        }

        [HttpPost]
        [ActionName("MemberLogin")]
        public ActionResult MemberLoginPost(MemberLoginModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (Membership.ValidateUser(model.Username, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.Username, model.RememberMe);
                    if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/") && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return Redirect("/");
                    }
                }
                else
                {
                    TempData["Status"] = "Invalid username or password";
                    return RedirectToCurrentUmbracoPage();
                }
            }

            TempData["Status"] = "Please enter username and password";
            return RedirectToCurrentUmbracoPage();
        }
    }
}