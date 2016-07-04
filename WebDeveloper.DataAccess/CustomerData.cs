using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class CustomerData :BaseDataAccess<Customer>
    {
        public Customer GetCustomer(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.customer.FirstOrDefault(x => x.CustomerID == id);
            }
        }
    }
}
