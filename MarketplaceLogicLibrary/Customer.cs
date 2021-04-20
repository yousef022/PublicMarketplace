using System;

namespace MarketplaceLogicLibrary
{
	public class Customer : User
	{

		/// <summary>
		/// Initializes a new instance of customer class with the specified values
		/// </summary>
		/// <param name="name"></param>
		/// <param name="emailAddress"></param>
		public Customer(string name, string emailAddress) : base( name, emailAddress) 
		{

		}

	}
}
