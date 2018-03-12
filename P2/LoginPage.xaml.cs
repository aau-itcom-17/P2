using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace P2
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked_Create(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateUserPage(), false);
        }

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginWindowPage(), false);
        }
    }
}
