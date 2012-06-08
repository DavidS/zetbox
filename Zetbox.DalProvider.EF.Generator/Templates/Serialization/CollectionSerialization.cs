
namespace Zetbox.DalProvider.Ef.Generator.Templates.Serialization
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Zetbox.API;
    using Templates = Zetbox.Generator.Templates;

    public class CollectionSerialization
        : Templates.Serialization.CollectionSerialization
    {
        public CollectionSerialization(
            Arebis.CodeGeneration.IGenerationHost _host,
            IZetboxContext ctx,
            Templates.Serialization.SerializerDirection direction,
            string streamName,
            string xmlnamespace,
            string xmlname,
            string collectionName,
            bool orderByValue,
            bool inPlace)
            : base(_host, ctx, direction, streamName, xmlnamespace, xmlname, collectionName, orderByValue, inPlace)
        {
        }

        public override bool ShouldSerialize()
        {
            // Do not deserialize colletion entries from client to server
            // they will be send by the Client ZetboxContext as seperate objects
            // from server to client the will be serialized - some kind of eager loading
            return inPlace || direction != Templates.Serialization.SerializerDirection.FromStream;
        }
    }
}
