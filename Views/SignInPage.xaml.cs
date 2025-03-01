using Microsoft.Maui.Controls;

namespace PenPal.Views
{
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {

            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void OnSignInClicked(object sender, EventArgs e)
        {
            // Authentication Logic Here (Firebase/Supabase/Auth0, etc.)
            await DisplayAlert("Login", "Sign-In Logic Not Implemented", "OK");
        }

        private async void OnForgotPasswordClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgotPasswordPage());
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }
    }
}
