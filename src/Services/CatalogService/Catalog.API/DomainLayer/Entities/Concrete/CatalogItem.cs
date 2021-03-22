using Catalog.API.DomainLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.DomainLayer.Entities.Concrete
{
    public class CatalogItem: CoreItem<string>
    {
        public override string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string PictureFileName { get; set; }

        public string PictureUri { get; set; }

        public string CatalogTypeId { get; set; }
        public CatalogType CatalogType { get; set; }

        public string CatalogBrandId { get; set; }
        public CatalogBrand CatalogBrand { get; set; }
    }
}
