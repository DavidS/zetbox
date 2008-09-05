using System;
using System.Collections.Generic;
using System.Linq;

using Kistl.API;
using Kistl.App.Base;
using Kistl.App.GUI;
using Kistl.Client;
using Kistl.API.Client;

namespace Kistl.GUI.DB
{
    /// <summary>
    /// The abstract entity representing a visualisation of a object
    /// </summary>
    public static class TemplateHelper
    {
        public static Template DefaultTemplate(Type objectType)
        {
            if (objectType == null)
                throw new ArgumentNullException("objectType", "Template.DefaultTemplate(objectType): need objectType to create Template");

            Template result = KistlGUIContext.GuiContext.GetQuery<Template>()
                .ToList() // TODO: remove after implementing ConditionalExpressions in Linq2Kistl
                .Where(tmpl =>
                    (tmpl.DisplayedTypeAssembly == null
                        ? typeof(object).Assembly.FullName == objectType.Assembly.FullName
                        : tmpl.DisplayedTypeAssembly.AssemblyName == objectType.Assembly.FullName
                    )
                    && (tmpl.DisplayedTypeFullName == objectType.FullName)
                    )
                .SingleOrDefault();

            if (result == null)
                result = CreateDefaultTemplate(objectType);


            return result;
        }

        public static Template CreateDefaultTemplate(Type objectType)
        {
            if (objectType == null)
                throw new ArgumentNullException("objectType", "Template.CreateDefaultTemplate(objectType): need objectType to create Template");

            Template result = null;

            // actually this should be done while editing/creating an 
            // ObjectClass using the editor's Context and comitted together 
            // with the edits on the class.
            // using (
                IKistlContext ctx = KistlGUIContext.GuiContext; // KistlContext.GetContext()
            //     )
            {

                result = ctx.Create<Template>();
                result.DisplayName = objectType.Name;
                result.DisplayedTypeAssembly = ctx.GetQuery<Assembly>()
                    .Where(ass => ass.AssemblyName == objectType.Assembly.FullName)
                    .SingleOrDefault();
                result.DisplayedTypeFullName = objectType.FullName;
                result.VisualTree = ctx.CreateVisual(
                    VisualType.Object,
                    "top level visual to display a object"
                    );

                Visual methodResults = ctx.CreateVisual(
                    VisualType.PropertyGroup,
                    "list of calculated results"
                    );

                ObjectClass @class = ClientHelper.ObjectClasses[objectType];
                while (@class != null)
                {
                    foreach (BaseProperty p in @class.Properties)
                    {
                        result.VisualTree.Children.Add(ctx.CreateDefaultVisual(p));
                    }

                    foreach (Method m in @class.Methods)
                    {
                        Visual v = ctx.CreateDefaultVisual(m);
                        if (v != null)
                            methodResults.Children.Add(v);
                    }
                    @class = @class.BaseObjectClass;
                }

                if (methodResults.Children.Count > 0)
                    result.VisualTree.Children.Add(methodResults);

                // ctx.SubmitChanges();
            }
            return result;
        }

    }

    /// <summary>
    /// the different usage scenarios a template can be used for
    /// </summary>
    public enum TemplateUsage
    {
        /// <summary>
        /// Use this Template as Control to edit a instance
        /// </summary>
        EditControl = 0
    }
}
