using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{

    public class ProductSupplierConfiguration : BaseConfiguration<ProductSupplier>
    {
        public ProductSupplierConfiguration()
        {
            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.ProductID,
                x.SupplierID
            });
        }
    }
}
