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
    public sealed partial class ContactSellerPage : Page
    {
        private Supplier _selectedSupplier;
        public Supplier SelectedSupplier
        {
            get => _selectedSupplier;
            set
            {
                if (value != null)
                    _selectedSupplier = value;
            }
        }
        public ContactSellerPage()
        {
            this.InitializeComponent();
        }
        /// <summary>
        /// Receives the objects send by the previous page
        /// </summary>
        /// <param name="e"></param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            SelectedSupplier = e.Parameter as Supplier;
            
        }
        /// <summary>
        /// Navigates back to previous page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onBack(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
                Frame.GoBack();
        }
        /// <summary>
        /// Sends a message to the seller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onSend(object sender, RoutedEventArgs e)
        {
            string senderName = TxtBx_SenderName.Text;
            string message = TxtBx_Message.Text;
            SelectedSupplier.AddReceivedMessage(senderName, message);
        }
    }
}
