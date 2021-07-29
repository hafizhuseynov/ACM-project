using Acme.Common;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Product : EntityBase,ILoggable
    {
        public Product() {}
        public Product(int productId) => ProductId = productId;
        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName.InsertSpace();
            }
            set
            {
                _productName = value;
            }
        }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public string Log() => $"{ProductId} : {ProductName} Detail: {ProductDescription} Status:{EntityState.ToString()}";
        public override string ToString() => ProductName;
        public decimal? CurrentPrice { get; set; }
        public override bool  Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName) || CurrentPrice == null) isValid = false;
            return isValid;
        }
    }
}
