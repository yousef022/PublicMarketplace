using System;
using System.Collections.Generic;
using System.Text;

namespace MarketplaceLogicLibrary
{
	public class MarketPlace : Products
	{
		/// <summary>
		/// Attributes of MarketPlace class
		/// </summary>
		private string _productDescription;

		private string _condition;

		private string _imageFilePath;

		private bool _returns;

		private double _shipping;

		private DateTime _dateListed;
		

		
		public MarketPlace(string productCode, string productName, double productPrice, string productDescription, string condition ,Departments productDepartment, int productStock, string imageFilePath, bool returns, double shipping, DateTime dateListed) : base( productCode, productName, productPrice, productDepartment, productStock)
		{
			ProductDescription = productDescription;
			Condition = condition;
			ImageFilePath = imageFilePath;
			Returns = returns;
			Shipping = shipping;
			DateListed = dateListed;
		}

		/// <summary>
		/// The description of a product
		/// </summary>
		public string ProductDescription
		{
			get => _productDescription;
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new Exception("Description cannot be blank");
				_productDescription = value;
			}
		}

		public string ImageFilePath
		{
			get => _imageFilePath;
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new Exception("Image path cannot be blank");
				_imageFilePath = value;
			}

		}

		public string Condition
		{
			get => _condition;
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new Exception("Condition cannot be blank");
				_condition = value;
			}
		}

		public DateTime DateListed
		{
			get => _dateListed;
			set => _dateListed = value;

		}

		public double Shipping
		{
			get => _shipping;
			set => _shipping = value;
		}

		public bool Returns
		{
			get => _returns;
			set => _returns = value;
		}

		//Computed property
		public string ProductIcon => $"ms-appx:///Assets/Images/{ImageFilePath}";
	}
}
