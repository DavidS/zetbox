
namespace Kistl.DalProvider.NHibernate.Generator.Templates.Mappings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Arebis.CodeGeneration;
    using Kistl.API;
    using Kistl.App.Base;
    using Kistl.App.Extensions;
    using Kistl.Generator;
    using Kistl.Generator.Extensions;

    public partial class PropertiesHbm
    {
        //public static void Call(IGenerationHost host, IKistlContext ctx, string prefix, IEnumerable<Property> properties)
        //{
        //    if (host == null) { throw new ArgumentNullException("host"); }
        //    if (ctx == null) { throw new ArgumentNullException("ctx"); }
        //    if (prefix == null) { throw new ArgumentNullException("prefix"); }
        //    if (properties == null) { throw new ArgumentNullException("properties"); }

        //    host.CallTemplate("Mappings.PropertiesHbm", ctx, prefix, properties);
        //}

        protected virtual void ApplyObjectReferenceProperty(string prefix, ObjectReferenceProperty prop)
        {
            this.WriteLine("<!-- ObjectReferenceProperty -->");

            var rel = Kistl.App.Extensions.RelationExtensions.Lookup(ctx, prop);
            var relEnd = rel.GetEnd(prop);
            var otherEnd = rel.GetOtherEnd(relEnd);
            bool inverse = false;

            // mark this relation mapping as inverse if there are both navigators defined
            // and we are currently working on the second
            // TODO: actually we'd probably want to choose the n-side for setting inverse
            //       except for lists, which are not supported as inverse by NHibernate
            if (relEnd.Navigator != null && otherEnd.Navigator != null && relEnd == rel.B)
            {
                inverse = true;
            }

            string nameAttr = String.Format("name=\"{0}\"", prop.Name);
            string columnAttr = String.Format("column=\"`fk_{0}{1}`\"", prefix, otherEnd.RoleName);
            string classAttr = String.Format("class=\"{0}\"",
                ObjectClassHbm.GetAssemblyQualifiedImplementation(otherEnd.Type, this.Settings));
            //string tableAttr = String.Format("table =\"`{0}`\" ", rel.GetAssociationName());

            switch (rel.GetRelationType())
            {
                case RelationType.one_one:
                    this.WriteObjects("<one-to-one ", nameAttr, " ", classAttr,
                        " cascade=\"none\" constrained=\"true\" ",
                        prop.EagerLoading ? "fetch=\"join\" " : String.Empty,
                        inverse ? "property-ref=\"" + otherEnd.Navigator.Name + "\" " : String.Empty,
                        "/>");
                    break;
                case RelationType.one_n:
                    if (otherEnd.Multiplicity.UpperBound() > 1) // we are 1-side
                    {
                        this.WriteObjects("<set ", nameAttr, " cascade=\"none\" ");
                        if (prop.EagerLoading)
                        {
                            this.WriteObjects("lazy=\"false\" fetch=\"join\" ");
                        }
                        else
                        {
                            this.WriteObjects("batch-size=\"100\" ");
                        }
                        // TODO: always mark this side inverse. See p57 in the reference
                        if (inverse)
                        {
                            this.WriteObjects("inverse=\"true\" ");
                        }
                        this.WriteLine(">");
                        this.WriteObjects("    <key column=\"`", Construct.ForeignKeyColumnName(otherEnd), "`\" />");
                        this.WriteLine();
                        this.WriteObjects("    <one-to-many ", classAttr, " />");
                        this.WriteLine();
                        this.WriteLine("</set>");
                    }
                    else // we are n-side
                    {
                        this.WriteObjects("<many-to-one ", nameAttr, " ", columnAttr, " ", classAttr, " cascade=\"none\" ");
                        if (prop.EagerLoading)
                        {
                            this.WriteObjects("fetch=\"join\" ");
                        }
                        if (inverse)
                        {
                            // invalid: this.WriteObjects("inverse=\"true\" ");
                        }
                        this.WriteLine("/>");
                    }
                    break;
                case RelationType.n_m:
                    ApplyNMProperty(rel, relEnd, otherEnd, prop, inverse);
                    break;
                default:
                    throw new NotImplementedException(String.Format("Unknown RelationType {0} found", rel.GetRelationType()));
            }

            this.WriteLine();

            if (rel.NeedsPositionStorage(relEnd.GetRole()))
            {
                this.WriteLine("<!-- pos storage missing -->");
            }
        }

        private void ApplyNMProperty(
            Relation rel, RelationEnd relEnd, RelationEnd otherEnd,
            ObjectReferenceProperty prop,
            bool inverse)
        {
            this.WriteLine("<!-- NMProperty -->");
            this.WriteLine("<!-- rel={0} -->", rel.GetRelationClassName());
            this.WriteLine("<!-- relEnd={0} otherEnd={1} -->", relEnd.RoleName, otherEnd.RoleName);

            string nameAttr = String.Format("name=\"{0}\"", prop.Name);
            string tableAttr = String.Format("table=\"`{0}`\"", rel.GetRelationTableName());
            string otherClassAttr = String.Format("class=\"{0}\"",
                ObjectClassHbm.GetAssemblyQualifiedImplementation(otherEnd.Type, this.Settings));
            string inverseAttr = String.Format("inverse=\"{0}\"", inverse ? "true" : "false");
            string mappingType = otherEnd.HasPersistentOrder ? "list" : "idbag";

            string relationEntryClassAttr = String.Format("class=\"{0}.{1}{2},Kistl.Objects.NHibernateImpl\"",
                rel.Module.Namespace,
                rel.GetRelationClassName(),
                ImplementationSuffix);

            string fkThisColumnAttr = String.Format("column=\"`{0}`\"", Construct.ForeignKeyColumnName(relEnd));
            string fkOtherColumnAttr = String.Format("column=\"`{0}`\"", Construct.ForeignKeyColumnName(otherEnd));

            this.WriteObjects("<", mappingType, " ", nameAttr, " ", tableAttr, " ", inverseAttr, ">");
            this.WriteLine();

            if (!otherEnd.HasPersistentOrder)
            {
                this.WriteObjects("    <collection-id column=\"`ID`\" type=\"Int32\">");
                this.WriteLine();
                this.WriteObjects("        <generator class=\"native\" />");
                this.WriteLine();
                this.WriteObjects("    </collection-id>");
                this.WriteLine();
            }

            this.WriteObjects("    <key ", fkThisColumnAttr, " />");
            this.WriteLine();

            if (otherEnd.HasPersistentOrder)
            {
                this.WriteObjects("    <index column=\"`", Construct.ListPositionColumnName(otherEnd), "`\" />");
                this.WriteLine();
            }


            if (relEnd.Type.ImplementsIExportable() && otherEnd.Type.ImplementsIExportable())
            {
                string propertyNameAttr = String.Format("name=\"{0}\"", otherEnd.GetRole().ToString());
                this.WriteObjects("    <composite-element ", relationEntryClassAttr, " >");
                this.WriteLine();
                this.WriteObjects("        <many-to-one ",
                    propertyNameAttr, " ",
                    otherClassAttr, " ",
                    fkOtherColumnAttr, " />");
                this.WriteLine();
                this.WriteObjects("        <property name=\"ExportGuid\" column=\"`ExportGuid`\" type=\"Guid\" />");
                this.WriteLine();
                this.WriteObjects("    </composite-element>");
                this.WriteLine();
            }
            else
            {
                this.WriteObjects("    <many-to-many ", otherClassAttr, " ", fkOtherColumnAttr, " />");
                this.WriteLine();
            }
            this.WriteObjects("</", mappingType, ">");
            this.WriteLine();
        }

        protected virtual void ApplyValueTypeProperty(string prefix, ValueTypeProperty prop)
        {
            this.WriteLine("<!-- ValueTypeProperty -->");
            string nameAttr = String.Format("name=\"{0}\"", prop.Name);
            string tableAttr = String.Format("table=\"`{0}`\"", prop.GetCollectionEntryTable());
            string typeAttr = String.Format("type=\"{0}\"", prop.GetPropertyType().AssemblyQualifiedName);
            string mappingType = prop.HasPersistentOrder ? "list" : "idbag";

            if (prop.IsList)
            {
                this.WriteObjects("<", mappingType, " ", nameAttr, " ", tableAttr, ">");
                this.WriteLine();

                if (!prop.HasPersistentOrder)
                {
                    this.WriteObjects("    <collection-id column=\"`ID`\" type=\"Int32\">");
                    this.WriteLine();
                    this.WriteObjects("        <generator class=\"native\" />");
                    this.WriteLine();
                    this.WriteObjects("    </collection-id>");
                    this.WriteLine();
                }

                this.WriteObjects("    <key column=\"`", prop.GetCollectionEntryReverseKeyColumnName(), "`\" />");
                this.WriteLine();

                if (prop.HasPersistentOrder)
                {
                    this.WriteObjects("    <index column=\"`", Construct.ListPositionColumnName(prop), "`\" />");
                    this.WriteLine();
                }

                this.WriteObjects("    <element column=\"`", prop.Name, "`\" ", typeAttr, " />");
                this.WriteLine();
                this.WriteObjects("</", mappingType, ">");
                this.WriteLine();
            }
            else
            {
                this.WriteObjects("<property ", nameAttr);
                this.WriteLine();
                this.WriteObjects("          column=\"`", prefix, prop.Name, "`\"");
                this.WriteLine();
                this.WriteObjects("          ", typeAttr, " />");
                this.WriteLine();
            }
        }

        protected virtual void ApplyCompoundObjectProperty(string prefix, CompoundObjectProperty prop)
        {
            this.WriteLine("<!-- CompoundObjectProperty -->");
            string nameAttr = String.Format("name=\"{0}\"", prop.Name);
            string tableAttr = String.Format("table=\"`{0}`\"", prop.GetCollectionEntryTable());
            string classAttr = String.Format("class=\"{0}.{1}{2},Kistl.Objects.NHibernateImpl\"",
                prop.CompoundObjectDefinition.Module.Namespace,
                prop.CompoundObjectDefinition.Name,
                ImplementationSuffix);

            string mappingType = prop.HasPersistentOrder ? "list" : "idbag";

            if (prop.IsList)
            {
                this.WriteObjects("<", mappingType, " ", nameAttr, " ", tableAttr, ">");
                this.WriteLine();

                if (!prop.HasPersistentOrder)
                {
                    this.WriteObjects("    <collection-id column=\"`ID`\" type=\"Int32\">");
                    this.WriteLine();
                    this.WriteObjects("        <generator class=\"native\" />");
                    this.WriteLine();
                    this.WriteObjects("    </collection-id>");
                    this.WriteLine();
                }

                this.WriteObjects("    <key column=\"`", prop.GetCollectionEntryReverseKeyColumnName(), "`\" />");
                this.WriteLine();

                if (prop.HasPersistentOrder)
                {
                    this.WriteObjects("    <index column=\"`", Construct.ListPositionColumnName(prop), "`\" />");
                    this.WriteLine();
                }

                this.WriteObjects("    <composite-element ", classAttr, ">");
                this.WriteLine();

                Call(Host, ctx, prefix + prop.Name + "_", prop.CompoundObjectDefinition.Properties);

                this.WriteObjects("    </composite-element>");
                this.WriteLine();
                this.WriteObjects("</", mappingType, ">");
                this.WriteLine();
            }
            else
            {
                this.WriteObjects("<component ", nameAttr, " ", classAttr, " >");
                this.WriteLine();

                Call(Host, ctx, prefix + prop.Name + "_", prop.CompoundObjectDefinition.Properties);

                this.WriteObjects("</component>");
                this.WriteLine();
            }
        }
    }
}
