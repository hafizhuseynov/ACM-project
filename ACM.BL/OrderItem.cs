using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        public OrderItem Retrieve(int orderItemId)
        {
            //Code to retrieve Order Item by Id
            return new OrderItem();
        }
        public bool Save()
        {
            //Code to save order Item
            return true;
        }
        public bool Validate()
        {
            var isValid = true;
            if (PurchasePrice == null || Quantity <= 0 || ProductId <= 0) isValid = false;
            return isValid;
        }
    }
}
