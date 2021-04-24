using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MarketplaceLogicLibrary;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PublicMarketplace
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class ItemPurchasePage : Page
	{
		private ProductRepository _productRepository = new ProductRepository();
		public ProductRepository ProdRep => _productRepository;

		private Products _selectedProduct;
		public Products SelectedProduct
		{
			get => _selectedProduct;
            set
            {
				if (value != _selectedProduct)
                {
					value = _selectedProduct;
                }
            }
		}
		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			base.OnNavigatedTo(e);
			SelectedProduct= e.Parameter as Products;
		}

		public ItemPurchasePage()
		{
			
			this.InitializeComponent();
			CmbBx_Departments.ItemsSource = Enum.GetValues(typeof(Departments));
		}
		/// <summary>
		/// [Hanin] Allows purchasing of items
		/// </summary>
		/// <param name="product"></param>
		/// <param name="amount"></param>
		public void Purchase(Products product, int amount)
		{
			if (ProdRep.GetByCode(product.ProductCode) != null)
				if (amount >= product.ProductStock)
					throw new Exception("Amount selected exceeds item stock.");
				product.ProductStock -= amount;
		}
		/// <summary>
		/// [Hanin] Purchases when user clicks on Buy Item button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void onBuyItem(object sender, RoutedEventArgs e)
        {
			int amount = int.Parse(TxtBx_Amount.Text);
			Purchase(SelectedProduct, amount);
        }

        private void onBack(object sender, RoutedEventArgs e)
        {
			if (Frame.CanGoBack)
				Frame.GoBack();
        }
    }
}
