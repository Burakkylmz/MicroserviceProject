using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.DomainLayer.Entities.Abstract
{
    public class CoreItem
    {
        [BsonId]
        public string Id { get; set; }
    }
}
