using AspNetMvcCoreNullContainer.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcCoreNullContainer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return this.View(new TopLevelClass());
        }
    }
}
