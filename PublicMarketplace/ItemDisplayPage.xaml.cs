using MarketplaceLogicLibrary;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PublicMarketplace
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class ItemDisplayPage : Page
	{
		private Products _selectedProduct;
		private Supplier _selectedSupplier;
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
		public Supplier SelectedSupplier
        {
			get => _selectedSupplier;
            set
            {
				if (value != _selectedSupplier)
                {
					value = _selectedSupplier;
                }
            }
        }

		public ItemDisplayPage()
		{
			this.InitializeComponent();
		}

		private void OnBuy(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(ItemPurchasePage), SelectedProduct);
		}

		private void OnPriceMatch(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(ItemPriceMatchPage));
		}

        private void onContactSeller(object sender, RoutedEventArgs e)
        {
			Frame.Navigate(typeof(ContactSellerPage), SelectedSupplier);
        }
    }
}
