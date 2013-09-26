using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Mvc;

namespace DemoMvcApp.Html
{
    public class TemplateHelper
    {
        private static readonly PropertyInfo VisitedObjectsProperty;

        static TemplateHelper()
        {
            try
            {
                VisitedObjectsProperty = typeof(TemplateInfo).GetProperty("VisitedObjects",
                                                                          BindingFlags.Instance | BindingFlags.NonPublic); 
            }
            catch (Exception exception)
            {
                throw new Exception("An error occured while attempting to access the PropertyInfo for the VisitedObjects property of type System.Web.Mvc.TemplateInfo. This might be happening because you're using a different version of ASP.Net MVC", exception);
            }
        }
        
        /// <summary>
        /// Removes a model from the VisitedObjects used by TemplateInfo to track which models
        /// have been displayed. See ~/Views/Shared/EditorTemplates/DisplaySection.cshtml and
        /// ~/Views/Shared/DisplayTemplates/DisplaySection.cshtml for further background.
        /// </summary>
        /// <param name="viewData"></param>
        public static void RemoveModelFromVisitedObjects(ViewDataDictionary viewData)
        {
            var visitedObjects = VisitedObjectsProperty.GetValue(viewData.TemplateInfo) as HashSet<object>;
            var model = viewData.Model;
            if (visitedObjects != null)
            {
                // Remove model if present - if model is null, the type is stored
                visitedObjects.Remove(model ?? viewData.ModelMetadata.ModelType);
                visitedObjects.Clear();
            }
        }
    }
}