using MarketplaceLogicLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MarketplaceLogicLibrary;
using JetBrains.Annotations;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PublicMarketplace
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class HomePage : Page, INotifyPropertyChanged
	{
		public MarketPlace _selectedProduct;
		public event PropertyChangedEventHandler PropertyChanged;

		public MarketPlace SelectedProduct
		{
			get => _selectedProduct;
			set
			{
				if (value != _selectedProduct)
				{
					_selectedProduct = value;
					OnPropertyChanged();
				}
			}
		}
		public HomePage()
		{
			this.InitializeComponent();
		}


		private ObservableCollection<MarketPlace> _products = new ObservableCollection<MarketPlace>()
		{
			new MarketPlace("P001", "Bike", 200, "A brand new bike", "New" ,Departments.Sports, 10, "bike.png", true, 0, new DateTime(2021,2,12)),

			new MarketPlace("P002", "Xbox Series X", 499, "A brand new Xbox Series X", "New" ,Departments.Electronics, 4,"xboxSeriesX.png", false, 20, new DateTime(2021, 2, 12)),

			new MarketPlace("P003", "PlayStation 5", 499, "A brand new PlayStation 5", "New" ,Departments.Electronics, 2, "ps5.png", false, 20, new DateTime(2021,3,14)),

			new MarketPlace("P004", "Nintendo Switch", 499, "A brand new Nintendo Switch", "New" ,Departments.Electronics, 5, "switch.png", false, 20, new DateTime(2021, 2, 12)),

			new MarketPlace("P005", "Lawn Mower", 150, "A used lawn mower in good condition", "Used" ,Departments.HomeAppliances, 1, "lawnMower.png", true, 0, new DateTime(2020, 5,16)),

			new MarketPlace("P006", "Hockey Stick", 50, "A used hockey stick in good condition","Used" ,Departments.Sports, 9, "hockeyStick.png", true, 0, new DateTime(2019, 2, 20)),

			new MarketPlace("P007", "Basket Ball", 25, "A brand new basket ball","New" ,Departments.Sports, 10,"basketball.png", true, 10, new DateTime(2021,4,23)),

			new MarketPlace("P008", "Blender", 100, "A brand new Blender", "New" ,Departments.HomeAppliances, 10, "blender.png", true, 22, new DateTime(2021,1,17)),
		};

		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		private void OnTappedRequest(object sender, TappedRoutedEventArgs e)
		{
			List<string> productDetails = new List<string>() { SelectedProduct.ProductCode, SelectedProduct.ProductName, SelectedProduct.ProductPrice.ToString(), SelectedProduct.ProductDescription, SelectedProduct.ProductDepartment.ToString(), SelectedProduct.ProductStock.ToString(), SelectedProduct.Condition, SelectedProduct.ImageFilePath, SelectedProduct.Returns.ToString(), SelectedProduct.Shipping.ToString(), SelectedProduct.DateListed.ToString()};
			Frame.Navigate(typeof(ItemDisplayPage), productDetails);
		}

		private void OnSellRequest(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(ItemListingPage));
		}
	}
}
