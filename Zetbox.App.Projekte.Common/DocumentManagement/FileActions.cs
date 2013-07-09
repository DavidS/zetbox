// This file is part of zetbox.
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zetbox.API;
using Zetbox.API.Common;

namespace at.dasz.DocumentManagement
{
    [Implementor]
    public class FileActions
    {
        public static readonly string DELETE_KEY = "Deleting";

        private static ITextExtractor _textExtractor;
        public FileActions(ITextExtractor textExtractor)
        {
            _textExtractor = textExtractor;
        }

        [Invocation]
        public static void ToString(File obj, MethodReturnEventArgs<System.String> e)
        {
            e.Result = obj.Name;
        }

        [Invocation]
        public static void preSet_Blob(File obj, PropertyPreSetterEventArgs<Zetbox.App.Base.Blob> e)
        {
            e.Result = obj.HandleBlobChange(e.OldValue, e.NewValue);
        }

        [Invocation]
        public static void postSet_Blob(File obj, PropertyPostSetterEventArgs<Zetbox.App.Base.Blob> e)
        {
            obj.ExtractText();
        }

        // required for StaticFile.HandleBlobChange
        [Invocation]
        public static void NotifyDeleting(File obj)
        {
            obj.TransientState[DELETE_KEY] = true;
        }

        [Invocation]
        public static void postSet_Excerpt(File obj, PropertyPostSetterEventArgs<Excerpt> e)
        {
            if (e.OldValue != null)
            {
                obj.Context.Delete(e.OldValue);
            }
        }

        [Invocation]
        public static void ExtractText(File obj)
        {
            var blob = obj.Blob;

            if (blob != null)
            {
                var txt = _textExtractor.GetText(obj.Blob.GetStream(), blob.MimeType);
                var excerpt = obj.Excerpt;
                if (string.IsNullOrWhiteSpace(txt))
                {
                    if (excerpt != null)
                    {
                        // no excerpt -> delete excerpt object
                        obj.Context.Delete(excerpt);
                    }
                }
                else
                {
                    if (excerpt == null)
                    {
                        excerpt = obj.Excerpt = obj.Context.Create<Excerpt>();
                        excerpt.File = obj;
                    }
                    excerpt.Text = txt.Trim();
                }
            }
        }
    }
}
