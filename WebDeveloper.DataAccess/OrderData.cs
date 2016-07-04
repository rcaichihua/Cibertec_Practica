using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class OrderData : BaseDataAccess<Order>
    {
        public Order GetOrder(int? id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.order.FirstOrDefault(x => x.OrderID == id);
            }
        }
    }
}
