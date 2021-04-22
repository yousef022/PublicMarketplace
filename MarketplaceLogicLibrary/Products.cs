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
		private Departments _productDepartment;
		private int _productStock;

		/// <summary>
		/// Initializes a new instance of Products class with the specified values
		/// </summary>
		/// <param name="productCode">Product code, unique identifier</param>
		/// <param name="productName">Name of product</param>
		/// <param name="productPrice">Price of product</param>
		/// <param name="productDepartment"></param>
		/// <param name="stock"></param>
		public Products(string productCode, string productName, double productPrice, Departments productDepartment,int productStock)
		{
			ProductCode = productCode;
			ProductName = productName;
			ProductPrice = productPrice;
			ProductDepartment = productDepartment;
			ProductStock = productStock;
			
		}

		/// <summary>
		/// Product code, unique identifier
		/// </summary>
		public  string ProductCode
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
				_productName = value;
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
				_productPrice = value;
			}
		}

		public Departments ProductDepartment
        {
			get => _productDepartment;
			set => _productDepartment = value;
        }

		public int ProductStock
        {
			get => _productStock;
            set
            {
				if (value < 1)
					throw new Exception("Product stock cannot be less than 1");
				_productStock = value;
            }
        }
	}
}
