using Catalog.API.DomainLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.DomainLayer.Entities.Concrete
{
    public class CatalogType: CoreItem<string>
    {
        public override string Id { get; set; }

        public string Type { get; set; }
    }
}
