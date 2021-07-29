using ACM.BL;
using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }

        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if(customerId == 1)
            {
                customer.EmailAddress = "huseynoff.hafiz@gmail.com";
                customer.FirstName = "Hafiz";
                customer.LastName = "Huseynov";
                customer.AddressList = addressRepository.RetrieveByCustomerId(1).ToList();
            }
            return customer;
        }
        /// <summary>
        /// Saves the current customer.
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            //Code to save customer.
            return true;
        }
    }
}
