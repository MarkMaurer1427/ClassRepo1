using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult HttpStatusCodeHandler(int statusCode)
        { 
            var statusCodeResult=HttpContext.Features.Get<IStatusCodePagesFeature>();
            switch(statusCode)
            {
                case 404:
                    {
                        ViewBag.ErrorMessage = "The resource you were looking for was not found.";
                        return View("NotFound");
                    }

            }
            return View();
        }

        [Route("Error")]
        public IActionResult Error()
        {
            var exHandler = HttpContext.Features.Get<IExceptionHandlerFeature>();
            return View();
        }
    }
}
