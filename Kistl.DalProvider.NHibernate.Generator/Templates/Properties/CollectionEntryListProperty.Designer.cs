using System;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.Generator;
using Kistl.Generator.Extensions;


namespace Kistl.DalProvider.NHibernate.Generator.Templates.Properties
{
    [Arebis.CodeGeneration.TemplateInfo(@"/srv/CCNet/Projects/zbox/repo/Kistl.DalProvider.NHibernate.Generator/Templates/Properties/CollectionEntryListProperty.cst")]
    public partial class CollectionEntryListProperty : Kistl.Generator.MemberTemplate
    {
		protected IKistlContext ctx;
		protected Kistl.Generator.Templates.Serialization.SerializationMembersList serializationList;
		protected string name;
		protected string exposedCollectionInterface;
		protected string referencedInterface;
		protected string backingName;
		protected string backingCollectionType;
		protected string aSideType;
		protected string bSideType;
		protected string entryType;
		protected string providerCollectionType;
		protected Guid relId;
		protected RelationEndRole role;
		protected bool eagerLoading;
		protected string entryProxyType;
		protected string inverseNavigatorName;


        public static void Call(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, Kistl.Generator.Templates.Serialization.SerializationMembersList serializationList, string name, string exposedCollectionInterface, string referencedInterface, string backingName, string backingCollectionType, string aSideType, string bSideType, string entryType, string providerCollectionType, Guid relId, RelationEndRole role, bool eagerLoading, string entryProxyType, string inverseNavigatorName)
        {
            if (_host == null) { throw new global::System.ArgumentNullException("_host"); }

            _host.CallTemplate("Properties.CollectionEntryListProperty", ctx, serializationList, name, exposedCollectionInterface, referencedInterface, backingName, backingCollectionType, aSideType, bSideType, entryType, providerCollectionType, relId, role, eagerLoading, entryProxyType, inverseNavigatorName);
        }

        public CollectionEntryListProperty(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, Kistl.Generator.Templates.Serialization.SerializationMembersList serializationList, string name, string exposedCollectionInterface, string referencedInterface, string backingName, string backingCollectionType, string aSideType, string bSideType, string entryType, string providerCollectionType, Guid relId, RelationEndRole role, bool eagerLoading, string entryProxyType, string inverseNavigatorName)
            : base(_host)
        {
			this.ctx = ctx;
			this.serializationList = serializationList;
			this.name = name;
			this.exposedCollectionInterface = exposedCollectionInterface;
			this.referencedInterface = referencedInterface;
			this.backingName = backingName;
			this.backingCollectionType = backingCollectionType;
			this.aSideType = aSideType;
			this.bSideType = bSideType;
			this.entryType = entryType;
			this.providerCollectionType = providerCollectionType;
			this.relId = relId;
			this.role = role;
			this.eagerLoading = eagerLoading;
			this.entryProxyType = entryProxyType;
			this.inverseNavigatorName = inverseNavigatorName;

        }

        public override void Generate()
        {
#line 27 "/srv/CCNet/Projects/zbox/repo/Kistl.DalProvider.NHibernate.Generator/Templates/Properties/CollectionEntryListProperty.cst"
this.WriteObjects("   		// ",  this.GetType() , "\r\n");
this.WriteObjects("		",  GetModifiers() , " ",  exposedCollectionInterface , "<",  referencedInterface , "> ",  name , "\r\n");
this.WriteObjects("		{\r\n");
this.WriteObjects("			get\r\n");
this.WriteObjects("			{\r\n");
this.WriteObjects("				if (",  backingName , " == null)\r\n");
this.WriteObjects("				{\r\n");
this.WriteObjects("					",  backingName , " \r\n");
this.WriteObjects("						= new ",  backingCollectionType , "<",  aSideType , ", ",  bSideType , ", ",  entryType , ">(\r\n");
this.WriteObjects("							this, \r\n");
this.WriteObjects("							new ProjectedCollection<",  entryProxyType , ", ",  entryType , ">(\r\n");
this.WriteObjects("                                this.Proxy.",  name , ",\r\n");
this.WriteObjects("                                p => (",  entryType , ")OurContext.AttachAndWrap(p),\r\n");
this.WriteObjects("                                ce => (",  entryProxyType , ")((NHibernatePersistenceObject)ce).NHibernateProxy),\r\n");
#line 41 "/srv/CCNet/Projects/zbox/repo/Kistl.DalProvider.NHibernate.Generator/Templates/Properties/CollectionEntryListProperty.cst"
if (!String.IsNullOrEmpty(inverseNavigatorName)) { 
#line 42 "/srv/CCNet/Projects/zbox/repo/Kistl.DalProvider.NHibernate.Generator/Templates/Properties/CollectionEntryListProperty.cst"
this.WriteObjects("                            entry => (IRelationListSync<",  entryType , ">)entry.",  role == RelationEndRole.A ? "B" : "A" , ".",  inverseNavigatorName , ");\r\n");
#line 43 "/srv/CCNet/Projects/zbox/repo/Kistl.DalProvider.NHibernate.Generator/Templates/Properties/CollectionEntryListProperty.cst"
} else { 
#line 44 "/srv/CCNet/Projects/zbox/repo/Kistl.DalProvider.NHibernate.Generator/Templates/Properties/CollectionEntryListProperty.cst"
this.WriteObjects("                            entry => (IRelationListSync<",  entryType , ">)null);\r\n");
#line 45 "/srv/CCNet/Projects/zbox/repo/Kistl.DalProvider.NHibernate.Generator/Templates/Properties/CollectionEntryListProperty.cst"
} 
#line 46 "/srv/CCNet/Projects/zbox/repo/Kistl.DalProvider.NHibernate.Generator/Templates/Properties/CollectionEntryListProperty.cst"
this.WriteObjects("                    if (",  name , "_was_eagerLoaded) { ",  name , "_was_eagerLoaded = false; }\r\n");
this.WriteObjects("				}\r\n");
this.WriteObjects("				return (",  exposedCollectionInterface , "<",  referencedInterface , ">)",  backingName , ";\r\n");
this.WriteObjects("			}\r\n");
this.WriteObjects("		}\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("		private ",  backingCollectionType , "<",  aSideType , ", ",  bSideType , ", ",  entryType , "> ",  backingName , ";\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("        // ignored, but required for Serialization\r\n");
this.WriteObjects("        private bool ",  name , "_was_eagerLoaded;\r\n");
#line 57 "/srv/CCNet/Projects/zbox/repo/Kistl.DalProvider.NHibernate.Generator/Templates/Properties/CollectionEntryListProperty.cst"
AddSerialization(serializationList, name, eagerLoading);


        }

    }
}