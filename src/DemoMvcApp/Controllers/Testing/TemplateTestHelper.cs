using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace DemoMvcApp.Controllers.Testing
{
    public class TemplateTestHelper
    {
        private static readonly Lazy<string> CacheItemId = new Lazy<string>(GetCacheItemId);
        
        private static string GetCacheItemId()
        {
            // Accesses internal field on internal type System.Web.Mvc.Html.TemplateHelpers
            var templateHelpersType = typeof(Controller).Assembly.GetType("System.Web.Mvc.Html.TemplateHelpers");
            var field = templateHelpersType.GetField("CacheItemId",
                BindingFlags.NonPublic | BindingFlags.Static);
            object value = field.GetValue(null);
            return (string) value;
        }

        private static List<IViewEngine> originalViewEngines;

        /// <summary>
        /// Prevents our templates from being used by HtmlHelper Display and Editor extension methods
        /// TestingController displays output from built-in templates side-by-side with custom
        /// templates.
        /// </summary>
        public static void ClearCachedViewsAndRemoveViewEngines()
        {
            // Internal System.Web.Mvc.Html.TemplateHelpers class within MVC framework caches located 
            // template views, so we need to remove cached items.
            HttpContext.Current.Items.Remove(CacheItemId.Value);
            if (ViewEngines.Engines.Any())
            {
                originalViewEngines = ViewEngines.Engines.ToList();
                ViewEngines.Engines.Clear();
            }
        }

        /// <summary>
        /// Put things back how they were before ClearCachedViewsAndRemoveViewEngines was called
        /// </summary>
        public static void RestoreViewEngines()
        {
            if (!ViewEngines.Engines.Any())
            {
                int index = 0;
                foreach (var viewEngine in originalViewEngines)
                {
                    ViewEngines.Engines.Insert(index, viewEngine);
                    index++;
                }
            }
        } 
    }
}