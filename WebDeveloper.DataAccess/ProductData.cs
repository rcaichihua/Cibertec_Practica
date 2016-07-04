using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ProductData : BaseDataAccess<Product>
    {
        public Product GetProduct(int? id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.product.FirstOrDefault(x => x.ProductID == id);
            }
        }
    }
}
