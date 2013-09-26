namespace DemoMvcApp.Html
{
    /// <summary>
    /// Holds parameters that should be supplied in nested calls to Html.Editor and Html.Display 
    /// within EditorSection and DisplaySection templates
    /// </summary>
    public class TemplateParams
    {
        public string TemplateName { get; set; }
        public string HtmlFieldName { get; set; }
        public object AdditionalViewData { get; set; }
    }
}