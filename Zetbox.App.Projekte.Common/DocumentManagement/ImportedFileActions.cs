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

namespace at.dasz.DocumentManagement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Zetbox.API;
    using Zetbox.App.Base;

    [Implementor]
    public static class ImportedFileActions
    {
        [Invocation]
        public static void NotifyCreated(at.dasz.DocumentManagement.ImportedFile obj)
        {
            obj.IsFileReadonly = true;
        }

        private static void MakeInternal(IZetboxContext ctx, ImportedFile obj, File doc)
        {
            // Clone blob, so it could be deleted
            doc.Blob = ctx.Find<Blob>(ctx.CreateBlob(ctx.GetFileInfo(obj.Blob.ID), obj.Blob.MimeType));
            doc.Name = obj.Name;
            ctx.Delete(obj);
        }

        [Invocation]
        public static void MakeFile(ImportedFile obj, MethodReturnEventArgs<File> e)
        {
            var ctx = obj.Context;
            var doc = ctx.Create<File>();
            MakeInternal(ctx, obj, doc);
            e.Result = doc;
        }

        [Invocation]
        public static void MakeReadonlyFile(ImportedFile obj, MethodReturnEventArgs<File> e)
        {
            var ctx = obj.Context;
            var doc = ctx.Create<File>();
            MakeInternal(ctx, obj, doc);
            doc.IsFileReadonly = true;
            e.Result = doc;
        }

        // Deprecated
        [Invocation]
        public static void MakeStaticFile(ImportedFile obj, MethodReturnEventArgs<StaticFile> e)
        {
            var ctx = obj.Context;
            var doc = ctx.Create<StaticFile>();
            MakeInternal(ctx, obj, doc);
            e.Result = doc;
        }
    }
}
