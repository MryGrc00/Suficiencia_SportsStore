using Microsoft.AspNetCore.Mvc;


namespace Suficiencia_SportsStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
