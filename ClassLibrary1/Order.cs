using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PrettyHairSolution
{
    interface IOrder
    {
        int GetOrderDate();
        int GetDeliveryDate();
        List<IOrderLine> GetWareList();
    }
    class Order : IOrder
    {
        public int OrderDate { get; set; }
        public int DeliveryDate { get; set; }
        public List<IOrderLine> OrderList;
        public int GetDeliveryDate()
        {
            return DeliveryDate;
        }

        public int GetOrderDate()
        {
            return OrderDate;
        }

        public List<IOrderLine> GetWareList()
        {
            return OrderList;
        }
    }
}
