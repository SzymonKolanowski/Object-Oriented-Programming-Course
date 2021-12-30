using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
	[TestClass]
	public class CustomerRepositoryTest
	{
		[TestMethod]
		public void RetrieveValid()
		{
			// Arrange
			var customerRepository = new CustomerRepository();
			var expected = new Customer(1)
			{
				
				EmailAdress = "fbaggins@hobbiton.me",
				FirstName = "Frodo",
				LastName = "Baggins",
				AddressList = new List<Address>()
				{
					new Address()
					{
						AdressType = 1,
						StreetLine1 = "Bag End",
						StreetLine2 = "Bagshot row",
						City = "Hobbiton",
						State = "Shire",
						Country = "Middle Earth",
						PostalCode = "144",
					},
					new Address()
					{
						AdressType = 2,
						StreetLine1 = "Green Dragon",
						City = "Bywater",
						State = "Shire",
						Country = "Middle Earth",
						PostalCode = "146"
					}

		}

			};
			// Act
			var actual = customerRepository.Retrieve(1);
			// Assert
			Assert.AreEqual(expected.CustomerId, actual.CustomerId);
			Assert.AreEqual(expected.EmailAdress, actual.EmailAdress);
			Assert.AreEqual(expected.FirstName,actual.FirstName);
			Assert.AreEqual(expected.LastName, actual.LastName);

			for (int i = 0; i < 1; i++)
			{
				Assert.AreEqual(expected.AddressList[i].AdressType, actual.AddressList[i].AdressType);
				Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
				Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
				Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
				Assert.AreEqual(expected.AddressList[i].Country,actual.AddressList[i].Country);
				Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
			}
		}
	}
}
