using System.Web.Mvc;
using RazorDisplayEditorTemplates.DemoMvcApp.Controllers.Home;

namespace RazorDisplayEditorTemplates.DemoMvcApp.Controllers.Testing
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