using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace DemoMvcApp.Html
{
    public static class DisplayExtensions
    {
        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper Display extension method together with surrounding HTML and label
        /// </summary>
        public static MvcHtmlString DisplaySection(this HtmlHelper html, string expression)
        {
            return html.DisplaySection(expression, null, null, null);
        }
        
        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper Display extension method together with surrounding HTML and label 
        /// </summary>
        public static MvcHtmlString DisplaySection(this HtmlHelper html, string expression, object additionalViewData)
        {
            return html.DisplaySection(expression, null, null, additionalViewData);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper Display extension method together with surrounding HTML and label 
        /// </summary>
        public static MvcHtmlString DisplaySection(this HtmlHelper html, string expression, string templateName)
        {
            return html.DisplaySection(expression, templateName, null, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper Display extension method together with surrounding HTML and label
        /// </summary>
        public static MvcHtmlString DisplaySection(this HtmlHelper html, string expression, string templateName, object additionalViewData)
        {
            return html.DisplaySection(expression, templateName, null, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper Display extension method together with surrounding HTML and label
        /// </summary>
        public static MvcHtmlString DisplaySection(this HtmlHelper html, string expression, string templateName, string htmlFieldName)
        {
            return html.DisplaySection(expression, templateName, htmlFieldName, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper Display extension method together with surrounding HTML and label 
        /// </summary>
        public static MvcHtmlString DisplaySection(this HtmlHelper html, string expression, string templateName, string htmlFieldName, object additionalViewData)
        {
            var templateParams = new TemplateParams
            {
                TemplateName = templateName,
                AdditionalViewData = additionalViewData,
                HtmlFieldName = htmlFieldName
            };
            // additionalViewData used to pass on parameters to DisplaySection
            return html.Display(expression, "DisplaySection", new { TemplateParams = templateParams });
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper DisplayFor extension method together with surrounding HTML and label 
        /// </summary>
        public static MvcHtmlString DisplaySectionFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
        {
            return html.DisplaySectionFor(expression, null, null, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper DisplayFor extension method together with surrounding HTML and label 
        /// </summary>
        public static MvcHtmlString DisplaySectionFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, object additionalViewData)
        {
            return html.DisplaySectionFor(expression, null, null, additionalViewData);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper DisplayFor extension method together with surrounding HTML and label 
        /// </summary>
        public static MvcHtmlString DisplaySectionFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string templateName)
        {
            return html.DisplaySectionFor(expression, templateName, null, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper DisplayFor extension method together with surrounding HTML and label 
        /// </summary>
        public static MvcHtmlString DisplaySectionFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string templateName, object additionalViewData)
        {
            return html.DisplaySectionFor(expression, templateName, null, additionalViewData);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper DisplayFor extension method together with surrounding HTML and label 
        /// </summary>
        public static MvcHtmlString DisplaySectionFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string templateName, string htmlFieldName)
        {
            return html.DisplaySectionFor(expression, templateName, htmlFieldName, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper DisplayFor extension method together with surrounding HTML and label 
        /// </summary>
        public static MvcHtmlString DisplaySectionFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string templateName, string htmlFieldName, object additionalViewData)
        {
            var templateParams = new TemplateParams
            {
                TemplateName = templateName,
                AdditionalViewData = additionalViewData,
                HtmlFieldName = htmlFieldName
            };
            // additionalViewData used to pass on parameters to DisplaySection
            return html.DisplayFor(expression, "DisplaySection", new { TemplateParams = templateParams });
        }

    }
}