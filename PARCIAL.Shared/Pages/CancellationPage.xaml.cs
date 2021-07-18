using PARCIAL.Helpers;
using PARCIAL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PARCIAL.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CancellationPage : Page
    {
        public CancellationPage()
        {
            this.InitializeComponent();
        }


        private async void Cancel_ButtonClick(object sender, RoutedEventArgs e)
        {
            ContentDialogResult result = await ConfirmDeleteAsync();



            if (result == ContentDialogResult.Primary)
            {
                Response response = await ApiServices.CancelAsync(MainPage.GetInstance().ResponseLogin.Token);
                if (response.IsSuccess)
                {
                    MessageDialog messageDialog;
                    messageDialog = new MessageDialog("Su voto ha sido cancelado con exito", "OK");
                    await messageDialog.ShowAsync();
                    Frame.Navigate(typeof(LoginPage));
                }


            }
            else
            {
                return;
            }

        }


        private async Task<ContentDialogResult> ConfirmDeleteAsync()
        {
            ContentDialog confirmDialog = new ContentDialog
            {
                Title = "Confirmación",
                Content = "¿Estás seguro de cancelar el voto?",
                PrimaryButtonText = "Sí",
                CloseButtonText = "No"
            };

            return await confirmDialog.ShowAsync();
        }
    }
}
