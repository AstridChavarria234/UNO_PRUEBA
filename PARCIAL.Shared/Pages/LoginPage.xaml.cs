using PARCIAL.Models;
using PARCIAL.Helpers;
using System;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PARCIAL.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();
        }

        private async void RecoverButton_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = await ValidEmail();
            if (!isValid)
            {
                return;
            }

            Response response = await ApiServices.RecoverAsync(new LoginRequest
            {
                Email = EmailTextBox.Text
            });


            if (response.IsSuccess)
            {
                MessageDialog messageDialog;
                messageDialog = new MessageDialog("Contraseña en proceso de restauracion", "OK");
                await messageDialog.ShowAsync();
            }
          
        }


        private async Task<bool> ValidEmail()
        {
            MessageDialog messageDialog;
            if (string.IsNullOrEmpty(EmailTextBox.Text))
            {
                messageDialog = new MessageDialog("Debes ingresar tu email", "Error");
                await messageDialog.ShowAsync();
                return false;

            }

            return true;
        }

        public async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = await ValidPassword();
            if (!isValid)
            {
                return;
            }

            Response response = await ApiServices.LoginAsync(new LoginRequest
            {
                Email = EmailTextBox.Text,
                Password = PasswordPasswordBox.Password,
            });

            ResponseLogin responseLogin = (ResponseLogin)response.Result;
            Frame.Navigate(typeof(MainPage), responseLogin);



        }

           


        private async Task<bool> ValidPassword()
        {
            MessageDialog messageDialog;
            if (PasswordPasswordBox.Password.Length < 6)
            {
                messageDialog = new MessageDialog("Debes ingresar tu contraseña de al seis(6) caracteres", "Error");
                await messageDialog.ShowAsync();
                return false;

            }
            return true;
        }




    }
}
