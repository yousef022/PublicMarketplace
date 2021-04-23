using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
		private Dictionary<string, string> _receivedMessages;

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
		/// <summary>
		/// [Hanin] Method that adds a message to the dictionary of messages a user receives
		/// </summary>
		/// <param name="sender">name of user who sent the message</param>
		/// <param name="message">the message being sent</param>
		public void AddReceivedMessage (string sender, string message)
        {
			_receivedMessages.Add(sender, message);
        }

		/*public virtual string Register(string name, string email, string userName, string password)
		{

		}

		public virtual string Login(string userName, string password)
		{

		}*/
	}
}
