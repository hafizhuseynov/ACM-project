using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]    //Test for Full Name
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Hafiz",
                LastName = "Huseynov"
            };
            string expected = "Hafiz Huseynov";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]    //Test for Full name *without Last Name
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Hafiz",
            };
            string expected = "Hafiz";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]    //Test for Full name *without First Name
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                LastName = "Huseynov"
            };
            string expected = "Huseynov";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            var a = new Customer {FirstName = "Bilbo"};
            Customer.InstanceCount += 1;
            var b = new Customer {FirstName = "Frodo"};
            Customer.InstanceCount += 1;
            var c = new Customer {FirstName = "Rosie"};
            Customer.InstanceCount += 1;
            //--------------------------

            //-------------------------
            Assert.AreEqual(3, Customer.InstanceCount);
        }
        [TestMethod]
        public void ValidateValid()
        {
            var customer = new Customer
            {
                LastName = "Hafiz",
                EmailAddress = "hafizhuseynov@gmail.com"
            };

            var expected = true;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingLastName()
        {
            var customer = new Customer(1)
            {
                
                EmailAddress = "huseynoff.hafiz@gmail.com"
            };

            var expected = true;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }
    }
}
