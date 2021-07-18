using PARCIAL.Helpers;
using PARCIAL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
    public sealed partial class MainPage : Page
    {
        private static MainPage _instance;
        public MainPage()
        {
            this.InitializeComponent();
            _instance = this;
        }

        public ResponseLogin ResponseLogin { get; set; }

        public static MainPage GetInstance()
        {
            return _instance;
        }

   
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            ResponseLogin = (ResponseLogin)e.Parameter;
            LoadQuestionAsync(ResponseLogin.Token);
           

        }


        private async void LoadQuestionAsync(string token)
        {
            Response response = await ApiServices.QuestionAsync(token);
           
            if (response.IsSuccess)
            {
                Question responseQuestion = (Question)response.Result;
                MyFrame.Navigate(typeof(QuestionPage),responseQuestion);
            }
            else
            {
       
                MessageDialog messageDialog;
                messageDialog = new MessageDialog(response.Message, "Error");
                await messageDialog.ShowAsync();

             MyFrame.Navigate(typeof(CancellationPage));



            }

        }


        }
}
