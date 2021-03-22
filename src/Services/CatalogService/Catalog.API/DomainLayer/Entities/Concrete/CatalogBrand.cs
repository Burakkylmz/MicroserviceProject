using Catalog.API.DomainLayer.Entities.Abstract;
using MongoDB.Bson.Serialization.Attributes;

namespace Catalog.API.DomainLayer.Entities.Concrete
{
    public class CatalogBrand:CoreItem<string>
    {
        public override string Id { get; set ; }

        [BsonElement("Brand")]
        public string Brand { get; set; }
        
    }
}
