using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace RazorDisplayEditorTemplates.DemoMvcApp.Html
{
    /// <summary>
    /// Contains extension methods for displaying editor elements together with surrounding HTML, labels and validation messages
    /// </summary>
    public static class EditorExtensions
    {
        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper Editor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorSection(this HtmlHelper html, string expression)
        {
            return html.EditorSection(expression, null, null, null);
        }
        
        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper Editor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorSection(this HtmlHelper html, string expression, object additionalViewData)
        {
            return html.EditorSection(expression, null, null, additionalViewData);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper Editor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorSection(this HtmlHelper html, string expression, string templateName)
        {
            return html.EditorSection(expression, templateName, null, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper Editor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorSection(this HtmlHelper html, string expression, string templateName, object additionalViewData)
        {
            return html.EditorSection(expression, templateName, null, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper Editor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorSection(this HtmlHelper html, string expression, string templateName, string htmlFieldName)
        {
            return html.EditorSection(expression, templateName, htmlFieldName, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper Editor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorSection(this HtmlHelper html, string expression, string templateName, string htmlFieldName, object additionalViewData)
        {
            var templateParams = new TemplateParams
            {
                TemplateName = templateName,
                AdditionalViewData = additionalViewData,
                HtmlFieldName = htmlFieldName
            };
            // additionalViewData used to pass on parameters to EditorSection
            return html.Editor(expression, "EditorSection", new { TemplateParams = templateParams });
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper EditorFor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorSectionFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
        {
            return html.EditorSectionFor(expression, null, null, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper EditorFor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorSectionFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, object additionalViewData)
        {
            return html.EditorSectionFor(expression, null, null, additionalViewData);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper EditorFor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorSectionFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string templateName)
        {
            return html.EditorSectionFor(expression, templateName, null, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper EditorFor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorSectionFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string templateName, object additionalViewData)
        {
            return html.EditorSectionFor(expression, templateName, null, additionalViewData);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper EditorFor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorSectionFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string templateName, string htmlFieldName)
        {
            return html.EditorSectionFor(expression, templateName, htmlFieldName, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper EditorFor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorSectionFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string templateName, string htmlFieldName, object additionalViewData)
        {
            var templateParams = new TemplateParams
            {
                TemplateName = templateName,
                AdditionalViewData = additionalViewData,
                HtmlFieldName = htmlFieldName
            };
            // additionalViewData used to pass on parameters to EditorSection
            return html.EditorFor(expression, "EditorSection", new { TemplateParams = templateParams });
        }

    }
}