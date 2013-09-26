using System.Web.Mvc;
using DemoMvcApp.Controllers.Home;

namespace DemoMvcApp.Controllers.Testing
{
    public class TestingController : Controller
    {
        public ActionResult Index()
        {
            return DisplayStandardView();
        }

        private ActionResult DisplayStandardView()
        {
            var model = SampleModel.Create();
            return View(model);
        }
    }
}