using soannpcn_apppassword.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace soannpcn_apppassword.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public string User { get; set; }
        public string Password { get; set; }


        

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            if (User == "soann" && Password == "1234")
            {
                await Shell.Current.GoToAsync($"//{nameof(InformationPage)}");
                User = "";
                Password = "";
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Erreur", "Nom d'utilisateur ou mot de passe incorrect.", "OK");

            }
            

        }

        
    }
}
