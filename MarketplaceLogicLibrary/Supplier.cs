using System;
using System.Collections.Generic;
using System.Text;

namespace MarketplaceLogicLibrary
{
	public class Supplier
	{
		/// <summary>
		/// Attributes of Supplier class
		/// </summary>
		private string _name;
		private string _emailAddress;
		private string _location;

		/// <summary>
		/// Initializes a new instance of Supplier with the specified values
		/// </summary>
		/// <param name="name"></param>
		/// <param name="emailAddress"></param>
		public Supplier(string name, string emailAddress)
		{
			Name = name;
			EmailAddress = emailAddress;
		}

		/// <summary>
		/// Name of supplier
		/// </summary>
		public string Name
		{
			get => _name;
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new Exception("Name cannot be empty");
				_name = value;
			}
		}

		/// <summary>
		/// Email address of supplier
		/// </summary>
		public string EmailAddress
		{
			get => _emailAddress;
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new Exception("Email address cannot be empty");
				_emailAddress = value;
			}
		}

		/// <summary>
		/// Location of supplier
		/// </summary>
		public string Location
		{
			get => _location;
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new Exception("Location cannot be empty");
				_location = value;
			}
		}
	}
}
