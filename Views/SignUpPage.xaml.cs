using Microsoft.Maui.Controls;

namespace PenPal.Views
{
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            // Registration Logic Here
            await DisplayAlert("Register", "Registration Logic Not Implemented", "OK");
        }

        private async void OnSignInClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); // Goes back to Sign In Page
        }
    }
}
