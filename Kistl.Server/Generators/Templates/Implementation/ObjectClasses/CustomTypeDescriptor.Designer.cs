using System;
using System.Linq;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.Server.Generators;
using Kistl.Server.Generators.Extensions;


namespace Kistl.Server.Generators.Templates.Implementation.ObjectClasses
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CustomTypeDescriptor.cst")]
    public partial class CustomTypeDescriptor : Kistl.Server.Generators.KistlCodeTemplate
    {
		protected IKistlContext ctx;
		protected ObjectClass cls;
		protected string typeDescriptorClass;
		protected string implName;


        public CustomTypeDescriptor(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, ObjectClass cls, string typeDescriptorClass, string implName)
            : base(_host)
        {
			this.ctx = ctx;
			this.cls = cls;
			this.typeDescriptorClass = typeDescriptorClass;
			this.implName = implName;

        }
        
        public override void Generate()
        {
#line 16 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CustomTypeDescriptor.cst"
this.WriteObjects("\r\n");
#line 18 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CustomTypeDescriptor.cst"
var properties = cls.Properties.OrderBy(p => p.Name).ToList();
	var rels = cls.Context.GetQuery<Relation>().Where(r => r.A.Type == cls || r.B.Type == cls)
		.OrderBy(i => i.A.RoleName).ThenBy(i => i.Verb).ThenBy(i => i.B.RoleName)
		.OrderBy(i => i.A.Type.Name).ThenBy(i => i.B.Type.Name)
		.ThenBy(i => i.ExportGuid)
		.ToList();
	
	if (properties.Count > 0 || rels.Count > 0)
	{

#line 28 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CustomTypeDescriptor.cst"
this.WriteObjects("		private static readonly object _propertiesLock = new object();\r\n");
this.WriteObjects("		private static System.ComponentModel.PropertyDescriptor[] _properties;\r\n");
this.WriteObjects("		\r\n");
this.WriteObjects("		private void _InitializePropertyDescriptors(Func<IFrozenContext> lazyCtx)\r\n");
this.WriteObjects("		{\r\n");
this.WriteObjects("			if (_properties != null) return;\r\n");
this.WriteObjects("			lock (_propertiesLock)\r\n");
this.WriteObjects("			{\r\n");
this.WriteObjects("				// recheck for a lost race after aquiring the lock\r\n");
this.WriteObjects("				if (_properties != null) return;\r\n");
this.WriteObjects("				\r\n");
this.WriteObjects("				_properties = new System.ComponentModel.PropertyDescriptor[] {\r\n");
#line 41 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CustomTypeDescriptor.cst"
foreach(var property in properties)
		{
			string propertyName = property.Name;
			if (property.IsAssociation() && !property.IsObjectReferencePropertySingle())
			{

#line 47 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CustomTypeDescriptor.cst"
this.WriteObjects("					// property.IsAssociation() && !property.IsObjectReferencePropertySingle()\r\n");
this.WriteObjects("					new ",  typeDescriptorClass , "<",  implName , ", ",  property.GetCollectionTypeString() , ">(\r\n");
this.WriteObjects("						lazyCtx,\r\n");
this.WriteObjects("						new Guid(\"",  property.ExportGuid , "\"),\r\n");
this.WriteObjects("						\"",  propertyName , "\",\r\n");
this.WriteObjects("						null,\r\n");
this.WriteObjects("						obj => obj.",  propertyName , ",\r\n");
this.WriteObjects("						null), // lists are read-only properties\r\n");
#line 56 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CustomTypeDescriptor.cst"
}
			else if (property is CalculatedObjectReferenceProperty)
			{

#line 60 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CustomTypeDescriptor.cst"
this.WriteObjects("					// property is CalculatedObjectReferenceProperty\r\n");
this.WriteObjects("					new ",  typeDescriptorClass , "<",  implName , ", ",  property.ReferencedTypeAsCSharp() , ">(\r\n");
this.WriteObjects("						lazyCtx,\r\n");
this.WriteObjects("						new Guid(\"",  property.ExportGuid , "\"),\r\n");
this.WriteObjects("						\"",  propertyName , "\",\r\n");
this.WriteObjects("						null,\r\n");
this.WriteObjects("						obj => obj.",  propertyName , ",\r\n");
this.WriteObjects("						null), // CalculatedObjectReferenceProperty is a read-only property\r\n");
#line 69 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CustomTypeDescriptor.cst"
} else {

#line 71 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CustomTypeDescriptor.cst"
this.WriteObjects("					// else\r\n");
this.WriteObjects("					new ",  typeDescriptorClass , "<",  implName , ", ",  property.ReferencedTypeAsCSharp() , ">(\r\n");
this.WriteObjects("						lazyCtx,\r\n");
this.WriteObjects("						new Guid(\"",  property.ExportGuid , "\"),\r\n");
this.WriteObjects("						\"",  propertyName , "\",\r\n");
this.WriteObjects("						null,\r\n");
this.WriteObjects("						obj => obj.",  propertyName , ",\r\n");
this.WriteObjects("						(obj, val) => obj.",  propertyName , " = val),\r\n");
#line 80 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CustomTypeDescriptor.cst"
}
		}
		

		if ("Frozen".Equals(Settings["extrasuffix"]))
		{

#line 87 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CustomTypeDescriptor.cst"
this.WriteObjects("					// skipping position columns for frozen context (not implemented)\r\n");
#line 89 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CustomTypeDescriptor.cst"
} else {		

#line 91 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CustomTypeDescriptor.cst"
this.WriteObjects("					// position columns\r\n");
#line 93 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CustomTypeDescriptor.cst"
foreach(var rel in rels.Where(r => r.GetRelationType() == RelationType.one_n))
			{
			// only show debugging if there actually is an position column
			if (   (rel.A.Type == cls && rel.A.HasPersistentOrder)
				|| (rel.B.Type == cls && rel.B.HasPersistentOrder))
			{			

#line 100 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CustomTypeDescriptor.cst"
this.WriteObjects("					// rel: ",  rel.A.RoleName , " ",  rel.Verb , " ",  rel.B.RoleName , " (",  rel.ExportGuid , ")\r\n");
#line 102 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CustomTypeDescriptor.cst"
}
			if (rel.A.Type == cls && rel.A.HasPersistentOrder) 
			{
				var posColumnName = Construct.ListPositionPropertyName(rel.A);

#line 107 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CustomTypeDescriptor.cst"
this.WriteObjects("					// rel.A.Type == cls && rel.A.HasPersistentOrder\r\n");
this.WriteObjects("					new ",  typeDescriptorClass , "<",  implName , ", int?>(\r\n");
this.WriteObjects("						lazyCtx,\r\n");
this.WriteObjects("						null,\r\n");
this.WriteObjects("						\"",  posColumnName , "\",\r\n");
this.WriteObjects("						null,\r\n");
this.WriteObjects("						obj => obj.",  posColumnName , ",\r\n");
this.WriteObjects("						(obj, val) => obj.",  posColumnName , " = val),\r\n");
#line 116 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CustomTypeDescriptor.cst"
}
			
				if (rel.B.Type == cls && rel.B.HasPersistentOrder) 
				{
					var posColumnName = Construct.ListPositionPropertyName(rel.B);

#line 122 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CustomTypeDescriptor.cst"
this.WriteObjects("					// rel.B.Type == cls && rel.B.HasPersistentOrder\r\n");
this.WriteObjects("					new ",  typeDescriptorClass , "<",  implName , ", int?>(\r\n");
this.WriteObjects("						lazyCtx,\r\n");
this.WriteObjects("						null,\r\n");
this.WriteObjects("						\"",  posColumnName , "\",\r\n");
this.WriteObjects("						null,\r\n");
this.WriteObjects("						obj => obj.",  posColumnName , ",\r\n");
this.WriteObjects("						(obj, val) => obj.",  posColumnName , " = val),\r\n");
#line 131 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CustomTypeDescriptor.cst"
}
			}
		}

#line 135 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CustomTypeDescriptor.cst"
this.WriteObjects("				};\r\n");
this.WriteObjects("			}\r\n");
this.WriteObjects("		}\r\n");
this.WriteObjects("		\r\n");
this.WriteObjects("		protected override void CollectProperties(Func<IFrozenContext> lazyCtx, List<System.ComponentModel.PropertyDescriptor> props)\r\n");
this.WriteObjects("		{\r\n");
this.WriteObjects("			base.CollectProperties(props);\r\n");
this.WriteObjects("			_InitializePropertyDescriptors(lazyCtx);\r\n");
this.WriteObjects("			props.AddRange(_properties);\r\n");
this.WriteObjects("		}\r\n");
#line 146 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CustomTypeDescriptor.cst"
}

#line 148 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CustomTypeDescriptor.cst"
this.WriteObjects("	\r\n");

        }



    }
}