using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class SupplierData : BaseDataAccess<Supplier>
    {
        public Supplier GetSupplier(int? id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.supplier.FirstOrDefault(x => x.SupplierID == id);
            }
        }
    }
}
