using Microsoft.AspNetCore.Mvc;

namespace Endpoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
       
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}