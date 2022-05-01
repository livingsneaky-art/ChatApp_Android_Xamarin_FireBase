using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatApp_LLAMIDO
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateAccount : ContentPage
    {
        public CreateAccount()
        {
            InitializeComponent();
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ForgotPasswordPage());
        }

        private void Button_ValidationBehavior(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))&& (string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtConfirmPassword.Text)))
            {
                DisplayAlert("Error..", "Missing Fields", "OKAY");
                MessagingCenter.Send<object, bool>(this, "Hi", true);
            }
            else if ((string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text)) && (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtConfirmPassword.Text)))
            {
                DisplayAlert("Error..", "Missing Fields", "OKAY");
                MessagingCenter.Send<object, bool>(this, "Hi", true);
            }

            else if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                DisplayAlert("Error..", "Missing Field", "OKAY");
                MessagingCenter.Send<object, bool>(this, "Hi", true);
            }

            else if (string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                DisplayAlert("Error..", "Password cant be empty.", "OKAY");
                MessagingCenter.Send<object, bool>(this, "Hi", true);
            }

            else if (!myEmailValidation.IsValid)
            {
                DisplayAlert("Error..", "Email is Incorrect.", "OKAY");
                MessagingCenter.Send<object, bool>(this, "Hi", true);
            }
            else if (!myUsernameValidation.IsValid)
            {
                DisplayAlert("Error..", "Username is Incorrect. Maximum 8 ", "OKAY");
                MessagingCenter.Send<object, bool>(this, "Hi", true);
            }
            else if ((myPasswordValidation.IsValid == myConfirmPasswordValidation.IsValid)== !txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                DisplayAlert("Error..", "Confirmation Password is Incorrect.", "OKAY");
                MessagingCenter.Send<object, bool>(this, "Hi", true);
            }

            else
            {
                DisplayAlert("Success", "Sign up successful. Verification email sent.", "OKAY");
                Navigation.PushAsync(new LoginUI());
            }
            
        }



        private void StarCall(object sender, FocusEventArgs e)
        {
            MessagingCenter.Send<object, bool>(this, "Hi", false);
        }
        
       private void ImageButton_Google(object sender, EventArgs e)
       {
           Navigation.PushAsync(new GoogleLogin());
       }

       private void TapGestureRecognizer_Google(object sender, EventArgs e)
       {
           Navigation.PushAsync(new GoogleLogin());
       }

       private void ImageButton_Facebook(object sender, EventArgs e)
       {
           Navigation.PushAsync(new FacebookLogin());
       }
       private void TapGestureRecognizer_Facebook(object sender, EventArgs e)
       {
           Navigation.PushAsync(new FacebookLogin());
       }

        private void Button_SignIn(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginUI());
        }
    }
}