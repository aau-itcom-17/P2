using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace P2
{
    public partial class CreateUserPage : ContentPage
    {
        private User user = new User();

        public CreateUserPage()
        {
            InitializeComponent();

        }

        async void createButtonClickedAsync(object sender, EventArgs e)
        {
            if ((passwordEntry.Text == (confirmPasswordEntry.Text)) && (firstNameEntry.Text != (null)) && (lastNameEntry.Text != (null)) && (usernameEntry.Text != (null)) && (emailEntry.Text != (null)) && (passwordEntry.Text != (null)) && (confirmPasswordEntry.Text != (null))) // check if email exists.
            {
                user.firstName = firstNameEntry.Text;
                user.lastName = lastNameEntry.Text;
                user.username = usernameEntry.Text;
                user.email = emailEntry.Text;
                user.password = passwordEntry.Text;
                //user.getSetPhotoFileName = photoFileName;
                // set id to random number // or to amount of users + 1;
                await Navigation.PushAsync(new UserTest(), false);

            }else
            {
                await DisplayAlert("Alert", "Please fill out all the fields", "OK");
               
            }







        }

       
            

    }
}
