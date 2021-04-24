using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
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
	public sealed partial class ItemListingPage : Page
	{
		private string _productImagePath;

		public ItemListingPage()
		{
			this.InitializeComponent();
		}

		private async void OnUpload(object sender, RoutedEventArgs e)
		{
			FileOpenPicker filePicker = new FileOpenPicker();
			filePicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
			filePicker.FileTypeFilter.Add(".jpg");
			filePicker.FileTypeFilter.Add(".gif");
			filePicker.FileTypeFilter.Add(".png");
			filePicker.FileTypeFilter.Add(".jpeg");
			StorageFile file = await filePicker.PickSingleFileAsync();
			if (file != null)
			{
				//create a copy of the file chosen by the end user in the application's local folder
				await file.CopyAsync(ApplicationData.Current.LocalFolder, file.Name, NameCollisionOption.ReplaceExisting);

				_productImagePath = $"ms-appdata:///local/{file.Name}";

				ImgPreviewImage.Source = new BitmapImage(new Uri(_productImagePath));
			}
		}

		private void OnBackRequested(object sender, RoutedEventArgs e)
		{
			if (Frame.CanGoBack)
				Frame.GoBack();
		}
	}
}
