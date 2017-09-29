using System;
using Zetbox.API;
using Zetbox.API.Server;
using Zetbox.App.Base;
using Zetbox.App.Extensions;
using Zetbox.Generator;
using Zetbox.Generator.Extensions;


namespace Zetbox.DalProvider.NHibernate.Generator.Templates.Properties
{
    [Arebis.CodeGeneration.TemplateInfo(@"C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst")]
    public partial class ObjectReferencePropertyTemplate : Zetbox.Generator.MemberTemplate
    {
		protected IZetboxContext ctx;
		protected Zetbox.Generator.Templates.Serialization.SerializationMembersList serializationList;
		protected string moduleNamespace;
		protected string ownInterface;
		protected string name;
		protected string implNameUnused;
		protected string eventName;
		protected string fkBackingName;
		protected string fkGuidBackingName;
		protected string referencedInterface;
		protected string referencedImplementation;
		protected string associationNameUnused;
		protected string targetRoleNameUnused;
		protected string positionPropertyName;
		protected string inverseNavigatorName;
		protected bool inverseNavigatorIsList;
		protected bool notifyInverseCollection;
		protected bool eagerLoading;
		protected bool relDataTypeExportable;
		protected bool callGetterSetterEvents;
		protected bool isCalculated;
		protected bool disableExport;


        public static void Call(Arebis.CodeGeneration.IGenerationHost _host, IZetboxContext ctx, Zetbox.Generator.Templates.Serialization.SerializationMembersList serializationList, string moduleNamespace, string ownInterface, string name, string implNameUnused, string eventName, string fkBackingName, string fkGuidBackingName, string referencedInterface, string referencedImplementation, string associationNameUnused, string targetRoleNameUnused, string positionPropertyName, string inverseNavigatorName, bool inverseNavigatorIsList, bool notifyInverseCollection, bool eagerLoading, bool relDataTypeExportable, bool callGetterSetterEvents, bool isCalculated, bool disableExport)
        {
            if (_host == null) { throw new global::System.ArgumentNullException("_host"); }

            _host.CallTemplate("Properties.ObjectReferencePropertyTemplate", ctx, serializationList, moduleNamespace, ownInterface, name, implNameUnused, eventName, fkBackingName, fkGuidBackingName, referencedInterface, referencedImplementation, associationNameUnused, targetRoleNameUnused, positionPropertyName, inverseNavigatorName, inverseNavigatorIsList, notifyInverseCollection, eagerLoading, relDataTypeExportable, callGetterSetterEvents, isCalculated, disableExport);
        }

        public ObjectReferencePropertyTemplate(Arebis.CodeGeneration.IGenerationHost _host, IZetboxContext ctx, Zetbox.Generator.Templates.Serialization.SerializationMembersList serializationList, string moduleNamespace, string ownInterface, string name, string implNameUnused, string eventName, string fkBackingName, string fkGuidBackingName, string referencedInterface, string referencedImplementation, string associationNameUnused, string targetRoleNameUnused, string positionPropertyName, string inverseNavigatorName, bool inverseNavigatorIsList, bool notifyInverseCollection, bool eagerLoading, bool relDataTypeExportable, bool callGetterSetterEvents, bool isCalculated, bool disableExport)
            : base(_host)
        {
			this.ctx = ctx;
			this.serializationList = serializationList;
			this.moduleNamespace = moduleNamespace;
			this.ownInterface = ownInterface;
			this.name = name;
			this.implNameUnused = implNameUnused;
			this.eventName = eventName;
			this.fkBackingName = fkBackingName;
			this.fkGuidBackingName = fkGuidBackingName;
			this.referencedInterface = referencedInterface;
			this.referencedImplementation = referencedImplementation;
			this.associationNameUnused = associationNameUnused;
			this.targetRoleNameUnused = targetRoleNameUnused;
			this.positionPropertyName = positionPropertyName;
			this.inverseNavigatorName = inverseNavigatorName;
			this.inverseNavigatorIsList = inverseNavigatorIsList;
			this.notifyInverseCollection = notifyInverseCollection;
			this.eagerLoading = eagerLoading;
			this.relDataTypeExportable = relDataTypeExportable;
			this.callGetterSetterEvents = callGetterSetterEvents;
			this.isCalculated = isCalculated;
			this.disableExport = disableExport;

        }

        public override void Generate()
        {
#line 50 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
this.WriteObjects("        // BEGIN ",  this.GetType() , " for ",  name , "\r\n");
this.WriteObjects("        // fkBackingName=this.Proxy.",  name , "; fkGuidBackingName=",  fkGuidBackingName , ";\r\n");
this.WriteObjects("        // referencedInterface=",  referencedInterface , "; moduleNamespace=",  moduleNamespace , ";\r\n");
#line 53 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
if (notifyInverseCollection && !String.IsNullOrEmpty(inverseNavigatorName)) { 
#line 54 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
this.WriteObjects("        // will get inverse collection for notifications for ",  inverseNavigatorName , "\r\n");
#line 55 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
} else if (!notifyInverseCollection && !String.IsNullOrEmpty(inverseNavigatorName)) { 
#line 56 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
this.WriteObjects("        // inverse Navigator=",  String.IsNullOrEmpty(inverseNavigatorName) ? "none" : inverseNavigatorName , "; ",  inverseNavigatorIsList ? "is list" : "is reference" , ";\r\n");
#line 57 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
} else { 
#line 58 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
this.WriteObjects("        // no inverse navigator handling\r\n");
#line 59 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
} 
#line 60 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
this.WriteObjects("        // PositionStorage=",  String.IsNullOrEmpty(positionPropertyName) ? "none" : positionPropertyName , ";\r\n");
this.WriteObjects("        // Target ",  relDataTypeExportable ? String.Empty : "not " , "exportable; does ",  callGetterSetterEvents ? String.Empty : "not " , "call events\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]\r\n");
this.WriteObjects("        ",  GetModifiers() , " ",  referencedInterface , " ",  name , "\r\n");
this.WriteObjects("        {\r\n");
this.WriteObjects("            get\r\n");
this.WriteObjects("            {\r\n");
this.WriteObjects("                ",  referencedImplementation , " __value = (",  referencedImplementation , ")OurContext.AttachAndWrap(this.Proxy.",  name , ");\r\n");
this.WriteObjects("\r\n");
#line 70 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
if (callGetterSetterEvents) { 
#line 71 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
this.WriteObjects("                if (",  eventName , "_Getter != null)\r\n");
this.WriteObjects("                {\r\n");
this.WriteObjects("                    var e = new PropertyGetterEventArgs<",  referencedInterface , ">(__value);\r\n");
this.WriteObjects("                    ",  eventName , "_Getter(this, e);\r\n");
this.WriteObjects("                    __value = (",  referencedImplementation , ")e.Result;\r\n");
this.WriteObjects("                }\r\n");
#line 77 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
} 
#line 78 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
this.WriteObjects("\r\n");
this.WriteObjects("                return __value;\r\n");
this.WriteObjects("            }\r\n");
this.WriteObjects("            set\r\n");
this.WriteObjects("            {\r\n");
this.WriteObjects("                if (this.IsReadonly) throw new ReadOnlyObjectException();\r\n");
this.WriteObjects("                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("                // shortcut noop with nulls\r\n");
this.WriteObjects("                if (value == null && this.Proxy.",  name , " == null)\r\n");
this.WriteObjects("                {\r\n");
this.WriteObjects("                    SetInitializedProperty(\"",  name , "\");\r\n");
this.WriteObjects("                    return;\r\n");
this.WriteObjects("                }\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("                // cache old value to remove inverse references later\r\n");
this.WriteObjects("                var __oldValue = (",  referencedImplementation , ")OurContext.AttachAndWrap(this.Proxy.",  name , ");\r\n");
this.WriteObjects("                var __newValue = (",  referencedImplementation , ")value;\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("                // shortcut noop on objects\r\n");
this.WriteObjects("                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.\r\n");
this.WriteObjects("                if (__oldValue == __newValue)\r\n");
this.WriteObjects("                {\r\n");
this.WriteObjects("                    SetInitializedProperty(\"",  name , "\");\r\n");
this.WriteObjects("                    return;\r\n");
this.WriteObjects("                }\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("                // Changing Event fires before anything is touched\r\n");
this.WriteObjects("                NotifyPropertyChanging(\"",  name , "\", __oldValue, __newValue);\r\n");
this.WriteObjects("\r\n");
#line 108 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
if (!String.IsNullOrEmpty(inverseNavigatorName) && inverseNavigatorIsList) { 
#line 109 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
this.WriteObjects("                if (__oldValue != null) {\r\n");
this.WriteObjects("                    __oldValue.NotifyPropertyChanging(\"",  inverseNavigatorName , "\", null, null);\r\n");
this.WriteObjects("                }\r\n");
this.WriteObjects("                if (__newValue != null) {\r\n");
this.WriteObjects("                    __newValue.NotifyPropertyChanging(\"",  inverseNavigatorName , "\", null, null);\r\n");
this.WriteObjects("                }\r\n");
this.WriteObjects("\r\n");
#line 116 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
} 
#line 117 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
if (callGetterSetterEvents) { 
#line 118 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
this.WriteObjects("                if (",  eventName , "_PreSetter != null && IsAttached)\r\n");
this.WriteObjects("                {\r\n");
this.WriteObjects("                    var e = new PropertyPreSetterEventArgs<",  referencedInterface , ">(__oldValue, __newValue);\r\n");
this.WriteObjects("                    ",  eventName , "_PreSetter(this, e);\r\n");
this.WriteObjects("                    __newValue = (",  referencedImplementation , ")e.Result;\r\n");
this.WriteObjects("                }\r\n");
this.WriteObjects("\r\n");
#line 125 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
} 
#line 126 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
this.WriteObjects("                // next, set the local reference\r\n");
this.WriteObjects("                if (__newValue == null)\r\n");
this.WriteObjects("                {\r\n");
this.WriteObjects("                    this.Proxy.",  name , " = null;\r\n");
this.WriteObjects("                }\r\n");
this.WriteObjects("                else\r\n");
this.WriteObjects("                {\r\n");
this.WriteObjects("                    this.Proxy.",  name , " = __newValue.Proxy;\r\n");
this.WriteObjects("                }\r\n");
this.WriteObjects("\r\n");
#line 136 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
if (!String.IsNullOrEmpty(inverseNavigatorName)) { 
#line 137 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
this.WriteObjects("                // now fixup redundant, inverse references\r\n");
this.WriteObjects("                // The inverse navigator will also fire events when changed, so should\r\n");
this.WriteObjects("                // only be touched after setting the local value above.\r\n");
this.WriteObjects("                // TODO: for complete correctness, the \"other\" Changing event should also fire\r\n");
this.WriteObjects("                //       before the local value is changed\r\n");
this.WriteObjects("                if (__oldValue != null)\r\n");
this.WriteObjects("                {\r\n");
#line 144 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
if (inverseNavigatorIsList) {
            // TODO: check whether __oldValue is loaded before potentially triggering a DB Call

#line 147 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
this.WriteObjects("                    // remove from old list\r\n");
this.WriteObjects("                    (__oldValue.",  inverseNavigatorName , " as IRelationListSync<",  ownInterface , ">).RemoveWithoutClearParent(this);\r\n");
#line 149 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
} else { 
#line 150 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
this.WriteObjects("                    // unset old reference\r\n");
this.WriteObjects("                    __oldValue.",  inverseNavigatorName , " = null;\r\n");
#line 152 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
} 
#line 153 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
this.WriteObjects("                }\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("                if (__newValue != null)\r\n");
this.WriteObjects("                {\r\n");
#line 157 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
if (inverseNavigatorIsList) { 
#line 158 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
this.WriteObjects("                    // add to new list\r\n");
this.WriteObjects("                    (__newValue.",  inverseNavigatorName , " as IRelationListSync<",  ownInterface , ">).AddWithoutSetParent(this);\r\n");
#line 160 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
} else { 
#line 161 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
this.WriteObjects("                    // set new reference\r\n");
this.WriteObjects("                    __newValue.",  inverseNavigatorName , " = this;\r\n");
#line 163 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
} 
#line 164 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
this.WriteObjects("                }\r\n");
#line 165 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
} 
#line 166 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
this.WriteObjects("                // everything is done. fire the Changed event\r\n");
this.WriteObjects("                NotifyPropertyChanged(\"",  name , "\", __oldValue, __newValue);\r\n");
this.WriteObjects("                if(IsAttached) UpdateChangedInfo = true;\r\n");
this.WriteObjects("\r\n");
#line 170 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
if (callGetterSetterEvents) { 
#line 171 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
this.WriteObjects("                if (",  eventName , "_PostSetter != null && IsAttached)\r\n");
this.WriteObjects("                {\r\n");
this.WriteObjects("                    var e = new PropertyPostSetterEventArgs<",  referencedInterface , ">(__oldValue, __newValue);\r\n");
this.WriteObjects("                    ",  eventName , "_PostSetter(this, e);\r\n");
this.WriteObjects("                }\r\n");
#line 176 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
} 
#line 177 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
this.WriteObjects("            }\r\n");
this.WriteObjects("        }\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("        /// <summary>Backing store for ",  UglyXmlEncode(name) , "'s id, used on dehydration only</summary>\r\n");
this.WriteObjects("        private int? ",  fkBackingName , " = null;\r\n");
this.WriteObjects("\r\n");
#line 183 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
if (relDataTypeExportable) { 
#line 184 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
this.WriteObjects("        /// <summary>Backing store for ",  UglyXmlEncode(name) , "'s guid, used on import only</summary>\r\n");
this.WriteObjects("        private Guid? ",  fkGuidBackingName , " = null;\r\n");
#line 186 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
} 
#line 187 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
this.WriteObjects("\r\n");
this.WriteObjects("    public Zetbox.API.Async.ZbTask TriggerFetch",  name , "Async()\r\n");
this.WriteObjects("    {\r\n");
this.WriteObjects("        return new Zetbox.API.Async.ZbTask<",  referencedInterface , ">(this.",  name , ");\r\n");
this.WriteObjects("    }\r\n");
this.WriteObjects("\r\n");
#line 194 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
AddSerialization(serializationList, name, fkBackingName, fkGuidBackingName);

    if (!String.IsNullOrEmpty(positionPropertyName))
    {
        Properties.NotifyingValueProperty.Call(
            Host, ctx, serializationList,
            "int?", positionPropertyName, moduleNamespace, false, disableExport);
    }

#line 203 "C:\Projects\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\Properties\ObjectReferencePropertyTemplate.cst"
this.WriteObjects("        // END ",  this.GetType() , " for ",  name , "\r\n");

        }

    }
}