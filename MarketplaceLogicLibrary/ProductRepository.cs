using System;
using System.Collections.Generic;
using System.Text;

namespace MarketplaceLogicLibrary
{
	/// <summary>
	/// Maintains a collection of products
	/// </summary>
	public class ProductRepository
	{
		//Readonly list
		private readonly List<Products> _products = new List<Products>();
		public List<Products> Products => _products;

		/// <summary>
		/// Default constructor of ProductRepository, takes no arguments 
		/// </summary>
		public ProductRepository()
		{
			
		}

		/// <summary>
		/// Adds instance of class Products to repository
		/// </summary>
		/// <param name="products">Object of Products class</param>
		public void AddProduct(Products products)
		{
			if (GetByCode(products.ProductCode) != null)
			{
				throw new Exception("Product already exists");
			}
			_products.Add(products);
		}

		/// <summary>
		/// Searches for matching product code in the Products class
		/// </summary>
		/// <param name="productCode">Attribute of Products class</param>
		/// <returns>null</returns>
		public Products GetByCode(string productCode)
		{
			foreach (Products pc in _products)
			{
				if (pc.ProductCode == productCode)
				{
					return pc;
				}
			}
			return null;
		}



	}
}
