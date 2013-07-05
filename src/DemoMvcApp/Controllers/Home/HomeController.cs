using System.Web.Mvc;
using RazorDisplayEditorTemplates.DemoMvcApp.Controllers.Home;

namespace RazorDisplayEditorTemplates.DemoMvcApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return DisplayStandardView();
        }

        public ActionResult DisplayTemplatesDemo()
        {
            return DisplayStandardView();
        }

        public ActionResult EditorTemplatesDemo()
        {
            return DisplayStandardView();
        }

        public ActionResult EditorSectionsDemo()
        {
            return DisplayStandardView();
        }

        public ActionResult DisplaySectionsDemo()
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