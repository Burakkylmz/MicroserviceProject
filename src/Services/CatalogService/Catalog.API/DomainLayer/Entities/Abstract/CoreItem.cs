using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Catalog.API.DomainLayer.Entities.Abstract
{
    public abstract class CoreItem<T>
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public abstract T Id { get; set; }
    }
}
