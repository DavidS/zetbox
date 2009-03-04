using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Kistl.API;
using Kistl.App.Base;
using Kistl.App.Extensions;
using Kistl.Server.Generators.Extensions;

namespace Kistl.Server.Generators.Templates.Implementation.ObjectClasses
{
    public partial class CollectionEntryListProperty
    {
        /// <summary>
        /// TODO: Frage: Rollen schon beim Aufruf tauschen? Es wird primär mit otherEnd gearbeitet.
        /// </summary>
        /// <param name="host"></param>
        /// <param name="ctx"></param>
        /// <param name="serializationList"></param>
        /// <param name="rel"></param>
        /// <param name="endRole"></param>
        public static void Call(Arebis.CodeGeneration.IGenerationHost host,
            IKistlContext ctx,
            Templates.Implementation.SerializationMembersList serializationList,
            Relation rel, RelationEndRole endRole)
        {
            RelationEnd relEnd = rel.GetEnd(endRole);
            RelationEnd otherEnd = rel.GetOtherEnd(relEnd);

            string name = relEnd.Navigator.PropertyName;
            string exposedCollectionInterface = rel.NeedsPositionStorage((RelationEndRole)otherEnd.Role) ? "IList" : "ICollection";
            string referencedInterface = otherEnd.Type.GetDataTypeString();
            string backingName = "_" + name;
            string backingCollectionType = "undefined wrapper class";
            if (rel.NeedsPositionStorage((RelationEndRole)otherEnd.Role))
            {
                if ((RelationEndRole)otherEnd.Role == RelationEndRole.A)
                {
                    backingCollectionType = "ClientListASideWrapper";
                }
                else if ((RelationEndRole)otherEnd.Role == RelationEndRole.B)
                {
                    backingCollectionType = "ClientListBSideWrapper";
                }
            }
            else
            {
                if ((RelationEndRole)otherEnd.Role == RelationEndRole.A)
                {
                    backingCollectionType = "ClientCollectionASideWrapper";
                }
                else if ((RelationEndRole)otherEnd.Role == RelationEndRole.B)
                {
                    backingCollectionType = "ClientCollectionBSideWrapper";
                }
            }
            
            string aSideType = rel.A.Type.GetDataTypeString();
            string bSideType = rel.B.Type.GetDataTypeString();
            string entryType = rel.GetCollectionEntryClassName() + Kistl.API.Helper.ImplementationSuffix;
            string providerCollectionType = (rel.NeedsPositionStorage((RelationEndRole)otherEnd.Role) ? "IList<" : "ICollection<")
                + entryType + ">";

            host.CallTemplate("Implementation.ObjectClasses.CollectionEntryListProperty",
                ctx, serializationList,
                name, exposedCollectionInterface, referencedInterface,
                backingName, backingCollectionType, aSideType, bSideType, entryType,
                providerCollectionType,
                rel.ID, endRole);
        }
    }
}
