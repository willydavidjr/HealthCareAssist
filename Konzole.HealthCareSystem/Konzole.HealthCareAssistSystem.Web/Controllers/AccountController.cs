using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Konzole.HealthCareAssistSystem.Web.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace Konzole.HealthCareAssistSystem.Web.Controllers
{
    //[Authorize]
    public class AccountController : Controller
    {
      
        public ActionResult Login(string returnUrl = "")
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        
       [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
                    return RedirectToLocal(returnUrl);
          
        }

       
        public ActionResult Register()
        {
            return View();
        }

      
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

     
    }
}