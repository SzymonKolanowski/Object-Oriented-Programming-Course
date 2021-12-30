using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Acme.Common.Test
{
	[TestClass]
	public class LoggingServiceTest
	{
		[TestMethod]
		public void WriteToFileTest()
		{
			// arrange
			var changeItems = new List<Iloggable>();

			var customer = new Customer(1)
			{
				EmailAdress = "fbaggins@hobbiton.me",
				FirstName = "Frodo",
				LastName = "Baggins",
				AddressList = null
			};
			changeItems.Add(customer);

			var product = new Product(2)
			{
				ProductName = "Rake",
				ProductDescription = "Garden Rake with Steel Head",
				CurrentPrice = 6M
			};

			// Act
			LogginService.WriteToFile(changeItems);
		}
	}
}
