using Microsoft.AspNetCore.Mvc;
namespace razor_fun.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
    }
}