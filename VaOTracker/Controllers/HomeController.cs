using Microsoft.AspNetCore.Mvc;
using VaOTracker.Models;

namespace VaOTracker.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}
