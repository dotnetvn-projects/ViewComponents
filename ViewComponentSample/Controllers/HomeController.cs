using Microsoft.AspNetCore.Mvc;
using ViewComponentSample.Models;

namespace ViewComponentSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SampleAjaxCall(GirlModel model)
        {
            return ViewComponent("sampleviewcomponent", model);
        }
    }
}
