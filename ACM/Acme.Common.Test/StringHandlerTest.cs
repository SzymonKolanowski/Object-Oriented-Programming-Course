using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.Common.Test
{
	[TestClass]
	public class StringHandlerTest
	{
		[TestMethod]
		public void InsertSpacesTestValid()
		{
			// Arrange
			var source = "SonicScrewdriver";
			var expected = "Sonic Screwdriver";
			

			// Act
			var actual = source.InsertSpaces();

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void InsertSpacesWithExistingSpace()
		{
			// Arrange
			var source = "SonicScrewdriver";
			var expected = "Sonic Screwdriver";
			// a

			// Act
			var actual = source.InsertSpaces();

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
