using Microsoft.Maui.Controls;

namespace PenPal.Views
{
    public partial class ForgotPasswordPage : ContentPage
    {
        public ForgotPasswordPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void OnSubmitClicked(object sender, EventArgs e)
        {
            // Forgot Password Logic Here
            await DisplayAlert("Reset Link Sent", "Check your email for the reset link.", "OK");
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
