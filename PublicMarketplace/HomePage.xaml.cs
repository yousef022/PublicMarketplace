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
	public sealed partial class HomePage : Page
	{
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
