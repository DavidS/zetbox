using System;
using System.Collections.Generic;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.Generator;
using Kistl.Generator.Extensions;


namespace Kistl.Generator.Templates.CollectionEntries
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.Generator\Templates\CollectionEntries\CollectionEntryTemplate.cst")]
    public partial class CollectionEntryTemplate : Kistl.Generator.ResourceTemplate
    {
		protected IKistlContext ctx;


        public static void Call(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx)
        {
            if (_host == null) { throw new global::System.ArgumentNullException("_host"); }

            _host.CallTemplate("CollectionEntries.CollectionEntryTemplate", ctx);
        }

        public CollectionEntryTemplate(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx)
            : base(_host)
        {
			this.ctx = ctx;

        }

        public override void Generate()
        {
#line 13 "P:\Kistl\Kistl.Generator\Templates\CollectionEntries\CollectionEntryTemplate.cst"
this.WriteObjects("    // BEGIN ",  this.GetType().FullName , "\r\n");
#line 15 "P:\Kistl\Kistl.Generator\Templates\CollectionEntries\CollectionEntryTemplate.cst"
ApplyClassAttributeTemplate();

#line 17 "P:\Kistl\Kistl.Generator\Templates\CollectionEntries\CollectionEntryTemplate.cst"
this.WriteObjects("    [System.Diagnostics.DebuggerDisplay(\"",  GetCeClassName() , "\")]\r\n");
this.WriteObjects("    public class ",  GetCeClassName() , " ",  GetInheritance() , "\r\n");
this.WriteObjects("    {\r\n");
#line 20 "P:\Kistl\Kistl.Generator\Templates\CollectionEntries\CollectionEntryTemplate.cst"
ApplyConstructorTemplate(); 
#line 21 "P:\Kistl\Kistl.Generator\Templates\CollectionEntries\CollectionEntryTemplate.cst"
ApplyClassHeadTemplate(); 
#line 22 "P:\Kistl\Kistl.Generator\Templates\CollectionEntries\CollectionEntryTemplate.cst"
this.WriteObjects("\r\n");
this.WriteObjects("        /// <summary>\r\n");
this.WriteObjects("        /// the A-side value of this CollectionEntry\r\n");
this.WriteObjects("        /// </summary>\r\n");
#line 27 "P:\Kistl\Kistl.Generator\Templates\CollectionEntries\CollectionEntryTemplate.cst"
ApplyAPropertyTemplate();

#line 29 "P:\Kistl\Kistl.Generator\Templates\CollectionEntries\CollectionEntryTemplate.cst"
this.WriteObjects("\r\n");
this.WriteObjects("        /// <summary>\r\n");
this.WriteObjects("        /// the B-side value of this CollectionEntry\r\n");
this.WriteObjects("        /// </summary>\r\n");
#line 34 "P:\Kistl\Kistl.Generator\Templates\CollectionEntries\CollectionEntryTemplate.cst"
ApplyBPropertyTemplate();


    if (IsOrdered())
    {

#line 40 "P:\Kistl\Kistl.Generator\Templates\CollectionEntries\CollectionEntryTemplate.cst"
this.WriteObjects("\r\n");
this.WriteObjects("        /// <summary>\r\n");
this.WriteObjects("        /// Index into the A-side list of this relation\r\n");
this.WriteObjects("        /// </summary>\r\n");
#line 45 "P:\Kistl\Kistl.Generator\Templates\CollectionEntries\CollectionEntryTemplate.cst"
ApplyAIndexPropertyTemplate();

#line 47 "P:\Kistl\Kistl.Generator\Templates\CollectionEntries\CollectionEntryTemplate.cst"
this.WriteObjects("\r\n");
this.WriteObjects("        /// <summary>\r\n");
this.WriteObjects("        /// Index into the B-side list of this relation\r\n");
this.WriteObjects("        /// </summary>\r\n");
#line 52 "P:\Kistl\Kistl.Generator\Templates\CollectionEntries\CollectionEntryTemplate.cst"
ApplyBIndexPropertyTemplate();
    }

#line 55 "P:\Kistl\Kistl.Generator\Templates\CollectionEntries\CollectionEntryTemplate.cst"
this.WriteObjects("\r\n");
this.WriteObjects("        #region Serializer\r\n");
this.WriteObjects("\r\n");
#line 59 "P:\Kistl\Kistl.Generator\Templates\CollectionEntries\CollectionEntryTemplate.cst"
Serialization.SerializerTemplate.Call(Host, ctx,
        Serialization.SerializerDirection.ToStream, this.MembersToSerialize, true, null);

    Serialization.SerializerTemplate.Call(Host, ctx,
        Serialization.SerializerDirection.FromStream, this.MembersToSerialize, true, null);

    Serialization.SerializerTemplate.Call(Host, ctx,
        Serialization.SerializerDirection.ToXmlStream, this.MembersToSerialize, true, null);

    Serialization.SerializerTemplate.Call(Host, ctx,
        Serialization.SerializerDirection.FromXmlStream, this.MembersToSerialize, true, null);

    if (IsExportable())
    {
        Serialization.SerializerTemplate.Call(Host, ctx,
            Serialization.SerializerDirection.Export, this.MembersToSerialize, false, GetExportGuidBackingStoreReference());

        Serialization.SerializerTemplate.Call(Host, ctx,
            Serialization.SerializerDirection.MergeImport, this.MembersToSerialize, false, GetExportGuidBackingStoreReference());
    }

#line 80 "P:\Kistl\Kistl.Generator\Templates\CollectionEntries\CollectionEntryTemplate.cst"
this.WriteObjects("\r\n");
this.WriteObjects("        #endregion\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("        public override Type GetImplementedInterface()\r\n");
this.WriteObjects("        {\r\n");
this.WriteObjects("            return typeof(",  GetCeInterface() , ");\r\n");
this.WriteObjects("        }\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("        public override void ApplyChangesFrom(IPersistenceObject obj)\r\n");
this.WriteObjects("        {\r\n");
this.WriteObjects("            base.ApplyChangesFrom(obj);\r\n");
this.WriteObjects("            var other = (",  GetCeClassName() , ")obj;\r\n");
this.WriteObjects("            var me = (",  GetCeClassName() , ")this;\r\n");
this.WriteObjects("\r\n");
#line 95 "P:\Kistl\Kistl.Generator\Templates\CollectionEntries\CollectionEntryTemplate.cst"
ApplyChangesFromBody();

#line 97 "P:\Kistl\Kistl.Generator\Templates\CollectionEntries\CollectionEntryTemplate.cst"
this.WriteObjects("        }\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("        public override void ReloadReferences()\r\n");
this.WriteObjects("        {\r\n");
this.WriteObjects("            // Do not reload references if the current object has been deleted.\r\n");
this.WriteObjects("            // TODO: enable when MemoryContext uses MemoryDataObjects\r\n");
this.WriteObjects("            //if (this.ObjectState == DataObjectState.Deleted) return;\r\n");
#line 106 "P:\Kistl\Kistl.Generator\Templates\CollectionEntries\CollectionEntryTemplate.cst"
ApplyReloadReferenceBody();

#line 108 "P:\Kistl\Kistl.Generator\Templates\CollectionEntries\CollectionEntryTemplate.cst"
this.WriteObjects("\r\n");
this.WriteObjects("        }\r\n");
this.WriteObjects("\r\n");
#line 112 "P:\Kistl\Kistl.Generator\Templates\CollectionEntries\CollectionEntryTemplate.cst"
ApplyClassTailTemplate();

#line 114 "P:\Kistl\Kistl.Generator\Templates\CollectionEntries\CollectionEntryTemplate.cst"
this.WriteObjects("    }\r\n");
this.WriteObjects("    // END ",  this.GetType().FullName , "\r\n");

        }

    }
}