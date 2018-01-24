using System.Web.Mvc;
using web.workplace.VM;
using Workplace.services.Account;

namespace web.workplace.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private IAccountService accountService;

        public AccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        [HttpGet]
        public ActionResult SignIn()
        {
           
            return View(new LoginVM());
        }


        [HttpPost]
       public ActionResult SignIn(LoginVM login) {

            if (ModelState.IsValid)
            {
               var isAuthenticated =  this.accountService.ValidateUser(login.UserName, login.Password);
               return RedirectToAction("Index", "Home");
            }
            return View(login);
        }


        [HttpGet]
        [ActionName("logout")]
        public ActionResult SignOut()
        {

            return View();
        }

    }
}