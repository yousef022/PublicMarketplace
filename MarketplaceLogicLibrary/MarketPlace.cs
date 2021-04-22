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
		

		/// <summary>
		/// Initializes a new instance of MarketPlace class with the specified values
		/// </summary>
		/// <param name="productCode"></param>
		/// <param name="productName"></param>
		/// <param name="productPrice"></param>
		/// <param name="productDescription"></param>
		public MarketPlace(string productCode, string productName, double productPrice, string productDescription, Departments productDepartment, int productStock) : base( productCode, productName, productPrice, productDepartment, productStock)
		{
			ProductDescription = productDescription;
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

		//Computed property
		public string ProductIcon => $"ms-appx:///Assets/Images/{ProductName}.png";
	}
}
