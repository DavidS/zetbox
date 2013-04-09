﻿// This file is part of zetbox.
//
// Zetbox is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as
// published by the Free Software Foundation, either version 3 of
// the License, or (at your option) any later version.
//
// Zetbox is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with zetbox.  If not, see <http://www.gnu.org/licenses/>.

namespace Zetbox.Client.ASPNET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Web.Mvc;
    using System.IO;
    using System.Web.Mvc.Html;
    using System.Linq.Expressions;
    using Zetbox.Client.Presentables;
    using System.Reflection;
    using Zetbox.Client.Presentables.ValueViewModels;

    public static class HtmlHelpers
    {
        #region Widget
        private class WidgetContainer : IDisposable
        {
            private readonly TextWriter _writer;
            public WidgetContainer(TextWriter writer, string title)
            {
                _writer = writer;

                _writer.Write("<div class=\"widget\"><div class=\"top\"><div class=\"bottom\"><div class=\"left\"><div class=\"right\"><div class=\"ro\"><div class=\"lo\"><div class=\"ru\"><div class=\"lu\">\n");
                _writer.Write("<h4 class=\"widget-title\">");
                _writer.Write(title);
                _writer.Write("</h4>\n");

                _writer.Write("<div class=\"widget-content\">\n");
            }

            public void Dispose()
            {
                _writer.Write("</div>\n");
                _writer.Write("</div></div></div></div></div></div></div></div></div>\n");
            }
        }
        public static IDisposable Widget(this HtmlHelper html, string title)
        {
            return new WidgetContainer(html.ViewContext.Writer, title);
        }
        #endregion

        #region Label
        public static MvcHtmlString ZbLabelFor<TModel>(this HtmlHelper<TModel> html, Expression<Func<TModel, ILabeledViewModel>> expression)
        {
            var vmdl = (ILabeledViewModel)System.Web.Mvc.ModelMetadata.FromLambdaExpression<TModel, ILabeledViewModel>(expression, html.ViewData).Model;
            return LabelExtensions.Label(html, vmdl.Label);
        }
        #endregion

        #region Display
        public static MvcHtmlString ZbDisplayFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string templateName = null, string htmlFieldName = null, object additionalViewData = null)
            where TValue : BaseValueViewModel
        {
            var newExpression = AppendMember<TModel, TValue, string>(expression, "FormattedValue");
            var vmdl = (BaseValueViewModel)System.Web.Mvc.ModelMetadata.FromLambdaExpression<TModel, TValue>(expression, html.ViewData).Model;
            return DisplayExtensions.DisplayFor<TModel, string>(html, newExpression, GetTemplate(vmdl, templateName), htmlFieldName, additionalViewData);
        }
        #endregion

        #region Editor
        /// <summary>
        /// Select a default editor. Only usable for very primitiv types (int, string, DateTime). These types are rendered through EditorFor() & "FormattedValue" appended to the original expression. Enums are supported by rendering a dropdown.
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="html"></param>
        /// <param name="expression"></param>
        /// <param name="templateName"></param>
        /// <param name="htmlFieldName"></param>
        /// <param name="additionalViewData"></param>
        /// <returns></returns>
        public static MvcHtmlString ZbEditorFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string templateName = null, string htmlFieldName = null, object additionalViewData = null)
            where TValue : BaseValueViewModel
        {
            var vmdl = (BaseValueViewModel)ModelMetadata.FromLambdaExpression<TModel, TValue>(expression, html.ViewData).Model;
            var type = vmdl.GetType();
            if (vmdl.IsReadOnly)
            {
                return DisplayExtensions.DisplayFor<TModel, string>(html, AppendMember<TModel, TValue, string>(expression, "FormattedValue"), GetTemplate(vmdl, templateName), htmlFieldName, additionalViewData);
            }
            else
            {
                if (typeof(EnumerationValueViewModel).IsAssignableFrom(type))
                {
                    var enumVmdl = (EnumerationValueViewModel)vmdl;
                    return SelectExtensions.DropDownList(
                        html,
                        ExpressionHelper.GetExpressionText(expression) + ".Value",
                        enumVmdl
                            .PossibleValues
                            .Select(i => new SelectListItem()
                            {
                                Text = i.Value,
                                Value = i.Key != null ? i.Key.Value.ToString() : string.Empty,
                                Selected = i.Key == enumVmdl.Value
                            }));
                }
                else
                {
                    return EditorExtensions.EditorFor<TModel, string>(html, AppendMember<TModel, TValue, string>(expression, "FormattedValue"), GetTemplate(vmdl, templateName), htmlFieldName, additionalViewData);
                }
            }
        }
        #endregion

        #region ValidationMessageFor
        public static MvcHtmlString ZbValidationMessageFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string validationMessage = null, object htmlAttributes = null)
             where TValue : BaseValueViewModel
        {
            var vmdl = (BaseValueViewModel)ModelMetadata.FromLambdaExpression<TModel, TValue>(expression, html.ViewData).Model;
            var type = vmdl.GetType();
            if (typeof(EnumerationValueViewModel).IsAssignableFrom(type))
            {
                return ValidationExtensions.ValidationMessageFor<TModel, string>(html, AppendMember<TModel, TValue, string>(expression, "Value"), validationMessage, htmlAttributes);
            }
            else
            {
                return ValidationExtensions.ValidationMessageFor<TModel, string>(html, AppendMember<TModel, TValue, string>(expression, "FormattedValue"), validationMessage, htmlAttributes);
            }
        }
        #endregion

        #region TextBox
        public static MvcHtmlString ZbTextBoxFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, object htmlAttributes = null)
            where TValue : BaseValueViewModel
        {
            return InputExtensions.TextBoxFor<TModel, string>(html, AppendMember<TModel, TValue, string>(expression, "FormattedValue"), htmlAttributes);
        }
        #endregion

        #region Helper
        private static Expression<Func<TModel, TReturnValue>> AppendMember<TModel, TValue, TReturnValue>(Expression<Func<TModel, TValue>> expression, string member)
            where TValue : BaseValueViewModel
        {
            return Expression.Lambda<Func<TModel, TReturnValue>>(
                        Expression.Property(expression.Body, member),
                        expression.Parameters.ToArray());
        }

        /// <summary>
        /// Resolve only very basic kind of views. Don't use the ViewDescriptor infrastructure. In ASP.NET the HTML is fully controlled by the developer.
        /// Also, don't resole ObjectList/Collections -> this will render a table.
        /// Object references are also too complicated to be handled here.
        /// This method is used by EditorFor & DisplayFor. EditorFor would never resolve Enums - they will be rendered passing by value & possible values. All other by passing FormattedValue
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="templateName"></param>
        /// <returns></returns>
        private static string GetTemplate(object vmdl, string templateName)
        {
            if (vmdl == null) return templateName;

            var type = vmdl.GetType();
            if (typeof(NullableDateTimePropertyViewModel).IsAssignableFrom(type))
            {
                return templateName ?? "DateTime";
            }
            else if (typeof(NullableDecimalPropertyViewModel).IsAssignableFrom(type))
            {
                return templateName ?? "Decimal";
            }
            else if (typeof(NullableIntPropertyViewModel).IsAssignableFrom(type))
            {
                return templateName ?? "Integer";
            }
            else if (typeof(NullableDoublePropertyViewModel).IsAssignableFrom(type))
            {
                return templateName ?? "Double";
            }
            else if (typeof(NullableGuidPropertyViewModel).IsAssignableFrom(type))
            {
                return templateName ?? "Guid";
            }
            else if (typeof(StringValueViewModel).IsAssignableFrom(type))
            {
                return templateName ?? "String";
            }
            else if (typeof(EnumerationValueViewModel).IsAssignableFrom(type))
            {
                return templateName ?? "Enumeration";
            }
            else if (typeof(ObjectReferenceViewModel).IsAssignableFrom(type))
            {
                return templateName ?? "ObjectReference";
            }
            else
            {
                return templateName;
            }
        }
        #endregion
    }
}