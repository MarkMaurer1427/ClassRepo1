using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        { 
            switch(statusCode)
            {
                case 404:
                    {
                        ViewBag.ErrorMessage = "The resource you were looking for was not found.";

                    }

            }
        }
    }
}
