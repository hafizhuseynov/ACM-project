using Acme.Common;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
         public Customer() : this(0) {}
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }
        public string Log() => $"{CustomerId} : {FullName} Email: {EmailAddress} Status:{EntityState.ToString()}";

        public override string ToString() => FullName;
        public List<Address> AddressList{ get; set; }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public static int InstanceCount { get; set; }
        private string _lastName; //Backing Field
        public string LastName
        {
            get { return _lastName; }   //Getter
            set { _lastName = value; }  //Setter
        }
        public string FullName
        {
            get 
            {
                string fullName = FirstName;
                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += " ";
                    }
                    fullName += LastName;
                }
                return fullName;
            }
        }
        public override bool Validate()
        {
            return !(string.IsNullOrWhiteSpace(LastName) && string.IsNullOrWhiteSpace(EmailAddress));
        }
    }
}
