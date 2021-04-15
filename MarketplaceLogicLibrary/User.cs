using System;
using System.Collections.Generic;
using System.Text;

namespace MarketplaceLogicLibrary
{
	public class User
	{
		/// <summary>
		/// Attributes of User class
		/// </summary>
		private string _name;
		private string _emailAddress;

		/// <summary>
		/// Initializes a new instance of User class with the specified values
		/// </summary>
		/// <param name="name">Name of user</param>
		/// <param name="emailAddress">Email address of user</param>
		public User(string name, string emailAddress)
		{
			Name = name;
			EmailAddress = emailAddress;
		}

		/// <summary>
		/// Name of user
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
		/// Email address of user
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

		/*public virtual string Register(string name, string email, string userName, string password)
		{

		}

		public virtual string Login(string userName, string password)
		{

		}*/
	}
}
