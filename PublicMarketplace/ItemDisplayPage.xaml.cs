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
using Windows.UI.Xaml.Media.Imaging;
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

		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			base.OnNavigatedTo(e);
			List<string> productDetails = e.Parameter as List<string>;
			if (productDetails != null)
			{
				TxtName.Text = productDetails[1];
				TxtPrice.Text = productDetails[2];
				TxtDescription.Text = productDetails[3];
				TxtCondition.Text = productDetails[6];
				ImgProductImage.Source = new BitmapImage(new Uri($"ms-appx:///Assets/Images/{productDetails[7]}"));
				TxtQuantityAvailable.Text = productDetails[5];
				TxtReturns.Text = productDetails[8];
				TxtShipping.Text = productDetails[9];
				TxtDateListed.Text = productDetails[10];
			}
		}

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

		private void OnBackRequested(object sender, RoutedEventArgs e)
		{
			if (Frame.CanGoBack)
				Frame.GoBack();
		}
	}
}
