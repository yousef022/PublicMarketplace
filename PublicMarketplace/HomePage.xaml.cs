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
		private MarketPlace _selectedProduct;
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

		private ObservableCollection<MarketPlace> _products = new ObservableCollection<MarketPlace>()
		{
			new MarketPlace("P001", "bike", 200, "test", Departments.Sports, 10),
			new MarketPlace("P002", "switch", 499, "test", Departments.Electronics, 10),
			new MarketPlace("P003", "ps5", 499, "test", Departments.Electronics, 10),
			new MarketPlace("P004", "xboxSeriesX", 499, "test", Departments.Electronics, 10),
			new MarketPlace("P005", "lawnMower", 150, "test", Departments.HomeAppliances, 10)
		};
		public HomePage()
		{
			this.InitializeComponent();
		}

		

		private void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		private void UIElement_OnTapped(object sender, TappedRoutedEventArgs e)
		{
			Frame.Navigate(typeof(ItemDisplayPage));
		}
	}
}
