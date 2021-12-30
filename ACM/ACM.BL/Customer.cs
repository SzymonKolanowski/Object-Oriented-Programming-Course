using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {

		public Customer():this(0)
		{

		}

		public Customer(int customerId)
		{
			CustomerId = customerId;
			AddressList = new List<Address>();
		}

		//public Address WorkAddress { get; set; }
		//public Address HomeAddress { get; set; }

		public List<Address> AddressList { get; set; }

		public int CustomerId { get; private set; }
		public int CustomerType { get; set; }
		public string EmailAdress { get; set; }
		public string FirstName { get; set; }

		public string FullName
		{
			get
			{
				string fullName = LastName;
				if (!string.IsNullOrWhiteSpace(FirstName))
				{
					if (!string.IsNullOrWhiteSpace(fullName))
					{
						fullName += ", ";
					}
					fullName += FirstName;
				}
				return fullName;
			}
			
		}

		public static int InstanceCount { get; set; }

		private string _lastName;
		public string LastName
		{
			get
			{
				return _lastName;
			}
			set
			{
				_lastName = value;
			}
		}

		public override string ToString() => FullName;
		
		public bool Validate()
		{
			var isValid = true;

			if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
			if (string.IsNullOrWhiteSpace(EmailAdress)) isValid = false;

			return isValid;
		}
		
	}
	
}
