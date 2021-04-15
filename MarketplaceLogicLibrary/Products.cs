using System;
using System.Collections.Generic;
using System.Text;

namespace MarketplaceLogicLibrary
{
	public class Products
	{
		/// <summary>
		/// Attributes of Products class
		/// </summary>
		private string _productCode;
		private string _productName;
		private double _productPrice;

		/// <summary>
		/// Initializes a new instance of Products class with the specified values
		/// </summary>
		/// <param name="productCode">Product code, unique identifier</param>
		/// <param name="productName">Name of product</param>
		/// <param name="productPrice">Price of product</param>
		public Products(string productCode, string productName, double productPrice)
		{
			ProductCode = _productCode;
			ProductName = _productName;
			ProductPrice = _productPrice;
		}

		/// <summary>
		/// Product code, unique identifier
		/// </summary>
		public string ProductCode
		{ get => _productCode; set => _productCode = value; }

		/// <summary>
		/// Name of product
		/// </summary>
		public string ProductName
		{
			get => _productName;
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new Exception("Name of product cannot be blank");
			}
		}

		/// <summary>
		/// Price of product
		/// </summary>
		public double ProductPrice
		{
			get => _productPrice;
			set
			{
				if (value < 0)
					throw new Exception("Product price cannot be less than zero");
			}
		}

	}
}
