using System;
using System.Collections.Generic;
using System.Linq;
using Kistl.App.Base;
using Kistl.App.Extensions;


namespace Kistl.DalProvider.Frozen.Generator.Repositories
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.DalProvider.Frozen\Generator\Repositories\FrozenContextImplementation.cst")]
    public partial class FrozenContextImplementation : Kistl.Server.Generators.KistlCodeTemplate
    {
		protected Kistl.API.IKistlContext ctx;
		protected List<Module> modulesWithFrozenClasses;


        public FrozenContextImplementation(Arebis.CodeGeneration.IGenerationHost _host, Kistl.API.IKistlContext ctx, List<Module> modulesWithFrozenClasses)
            : base(_host)
        {
			this.ctx = ctx;
			this.modulesWithFrozenClasses = modulesWithFrozenClasses;

        }
        
        public override void Generate()
        {
#line 12 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Repositories\FrozenContextImplementation.cst"
this.WriteObjects("// <autogenerated/>\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("using System;\r\n");
this.WriteObjects("using System.Collections.Generic;\r\n");
this.WriteObjects("using System.Linq;\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("using Kistl.API;\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("namespace Kistl.Objects.Frozen\r\n");
this.WriteObjects("{\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("	public class FrozenContextImplementation\r\n");
this.WriteObjects("		: Kistl.DalProvider.Frozen.BaseFrozenContext\r\n");
this.WriteObjects("	{\r\n");
this.WriteObjects("		static FrozenContextImplementation()\r\n");
this.WriteObjects("		{\r\n");
#line 29 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Repositories\FrozenContextImplementation.cst"
foreach(var module in modulesWithFrozenClasses)
	{

#line 32 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Repositories\FrozenContextImplementation.cst"
this.WriteObjects("			",  module.Namespace , ".Frozen",  module.Name , "Repository.CreateInstances();\r\n");
#line 34 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Repositories\FrozenContextImplementation.cst"
}

#line 36 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Repositories\FrozenContextImplementation.cst"
this.WriteObjects("\r\n");
#line 38 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Repositories\FrozenContextImplementation.cst"
foreach(var module in modulesWithFrozenClasses)
	{

#line 41 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Repositories\FrozenContextImplementation.cst"
this.WriteObjects("			",  module.Namespace , ".Frozen",  module.Name , "Repository.FillDataStore();\r\n");
#line 43 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Repositories\FrozenContextImplementation.cst"
}

#line 45 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Repositories\FrozenContextImplementation.cst"
this.WriteObjects("			InitialiseGuidCache(GetAttachedObjects()); \r\n");
this.WriteObjects("		}\r\n");
this.WriteObjects("		\r\n");
this.WriteObjects("		public override IQueryable<T> GetQuery<T>()\r\n");
this.WriteObjects("		{\r\n");
this.WriteObjects("			return GetQuery(new InterfaceType(typeof(T))).Cast<T>();\r\n");
this.WriteObjects("		}\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("		public override IQueryable<IDataObject> GetQuery(InterfaceType ifType)\r\n");
this.WriteObjects("		{\r\n");
#line 56 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Repositories\FrozenContextImplementation.cst"
foreach(var module in modulesWithFrozenClasses)
	{
	    // TODO: remove ToList when IsFrozenObject correctly inherits across meta-data
		foreach(var frozenCls in module.DataTypes.OfType<ObjectClass>().ToList().Where(cls => cls.IsFrozen()).OrderBy(c => c.Name))
		{

#line 62 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Repositories\FrozenContextImplementation.cst"
this.WriteObjects("			if (ifType == typeof(",  frozenCls.Module.Namespace , ".",  frozenCls.Name , "))\r\n");
this.WriteObjects("				return ",  frozenCls.Module.Namespace , ".",  Implementation.ObjectClasses.Template.GetClassName(frozenCls) , ".DataStore.Values.AsQueryable().Cast<IDataObject>();\r\n");
#line 65 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Repositories\FrozenContextImplementation.cst"
}
	}

#line 68 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Repositories\FrozenContextImplementation.cst"
this.WriteObjects("			throw new NotImplementedException();\r\n");
this.WriteObjects("		}\r\n");
this.WriteObjects("		\r\n");
this.WriteObjects("        public override IEnumerable<IPersistenceObject> AttachedObjects\r\n");
this.WriteObjects("        {\r\n");
this.WriteObjects("			get\r\n");
this.WriteObjects("			{\r\n");
this.WriteObjects("				return GetAttachedObjects();\r\n");
this.WriteObjects("			}\r\n");
this.WriteObjects("		}\r\n");
this.WriteObjects("		\r\n");
this.WriteObjects("		private static IEnumerable<IPersistenceObject> GetAttachedObjects() {\r\n");
this.WriteObjects("			return new List<IPersistenceObject>(0)\r\n");
#line 82 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Repositories\FrozenContextImplementation.cst"
foreach(var module in modulesWithFrozenClasses)
	{
		// TODO: remove ToList when IsFrozenObject correctly inherits across meta-data
        foreach(var frozenCls in module.DataTypes.OfType<ObjectClass>().ToList().Where(cls => cls.IsFrozen()).OrderBy(c => c.Name))
		{

#line 88 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Repositories\FrozenContextImplementation.cst"
this.WriteObjects("				.Concat(",  frozenCls.Module.Namespace , ".",  Implementation.ObjectClasses.Template.GetClassName(frozenCls) , ".DataStore.Values.AsQueryable().Cast<IPersistenceObject>())\r\n");
#line 90 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Repositories\FrozenContextImplementation.cst"
}
	}

#line 93 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Repositories\FrozenContextImplementation.cst"
this.WriteObjects("				.Distinct();\r\n");
this.WriteObjects("		}\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("        public override IDataObject Find(InterfaceType ifType, int ID)\r\n");
this.WriteObjects("		{\r\n");
#line 99 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Repositories\FrozenContextImplementation.cst"
foreach(var module in modulesWithFrozenClasses)
	{
		// TODO: remove ToList when IsFrozenObject correctly inherits across meta-data
		foreach(var frozenCls in module.DataTypes.OfType<ObjectClass>().ToList().Where(cls => cls.IsFrozen()).OrderBy(c => c.Name))
		{

#line 105 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Repositories\FrozenContextImplementation.cst"
this.WriteObjects("			if (ifType == typeof(",  frozenCls.Module.Namespace , ".",  frozenCls.Name , "))\r\n");
this.WriteObjects("				return ",  frozenCls.Module.Namespace , ".",  Implementation.ObjectClasses.Template.GetClassName(frozenCls) , ".DataStore[ID];\r\n");
#line 108 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Repositories\FrozenContextImplementation.cst"
}
	}

#line 111 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Repositories\FrozenContextImplementation.cst"
this.WriteObjects("			throw new NotImplementedException();\r\n");
this.WriteObjects("		}\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("        public override T Find<T>(int ID)\r\n");
this.WriteObjects("        {\r\n");
this.WriteObjects("			return (T)Find(new InterfaceType(typeof(T)), ID);\r\n");
this.WriteObjects("        }\r\n");
this.WriteObjects("	}\r\n");
this.WriteObjects("}");

        }



    }
}