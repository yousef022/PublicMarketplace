using System;
using System.Collections.Generic;
using System.Text;

namespace MarketplaceLogicLibrary
{
	public class Supplier : User
	{
		/// <summary>
		/// Attributes of Supplier class
		/// </summary>
		private string _location;

		/// <summary>
		/// Initializes a new instance of Supplier with the specified values
		/// </summary>
		/// <param name="name"></param>
		/// <param name="emailAddress"></param>
		public Supplier(string name, string emailAddress, string location) : base(name, emailAddress)
		{
			Location = location;
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
