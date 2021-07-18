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
    public sealed partial class QuestionPage : Page
    {
        public QuestionPage()
        {
            this.InitializeComponent();
        }

        public Question Question { get; set; }
        public ResponseLogin ResponseLogin { get; set; }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            
            base.OnNavigatedTo(e);
            Question = (Question)e.Parameter;
           
            Pregunta.Text = $"{Question.Description}";
            Opcion1.Text = $"{Question.Options.ElementAt(0).Description}";
            Opcion2.Text = $"{Question.Options.ElementAt(1).Description}";
            Opcion3.Text = $"{Question.Options.ElementAt(2).Description}";
            Opcion4.Text = $"{Question.Options.ElementAt(3).Description}";
            WelcomeTextBlock.Text = $"Bienvenid@: {MainPage.GetInstance().ResponseLogin.User.Name}";

        }


        private async void VoteOption1_Click(object sender, RoutedEventArgs e)
        {


           Response response = await ApiServices.SendVoteAsync(MainPage.GetInstance().ResponseLogin.Token,
                new Vote{
                    QuestionId = Question.Id,
                    OptionId = "1",
                }) ;

            validateVote(response);

        }


        private async void VoteOption2_Click(object sender, RoutedEventArgs e)
        {
            Response response =  await ApiServices.SendVoteAsync(MainPage.GetInstance().ResponseLogin.Token,
                new Vote
                {
                    QuestionId = Question.Id,
                    OptionId = "2",
                });
            validateVote(response);
        }


        private async void VoteOption3_Click(object sender, RoutedEventArgs e)
        {
            Response response = await ApiServices.SendVoteAsync(MainPage.GetInstance().ResponseLogin.Token,
                new Vote
                {
                    QuestionId = Question.Id,
                    OptionId = "3",
                });

            validateVote(response);
        }


        private async void VoteOption4_Click(object sender, RoutedEventArgs e)
        {
            Response response = await ApiServices.SendVoteAsync(MainPage.GetInstance().ResponseLogin.Token,
                new Vote
                {
                    QuestionId = Question.Id,
                    OptionId = "4",
                });

            validateVote(response);

          
        }

        private async void validateVote(Response response)
        {
            if (response.IsSuccess)
            {
                MessageDialog messageDialog;
                messageDialog = new MessageDialog("Su voto ha sido registrado con exito", "OK");
                await messageDialog.ShowAsync();
                Frame.Navigate(typeof(LoginPage));

            }
        }



        }
}
