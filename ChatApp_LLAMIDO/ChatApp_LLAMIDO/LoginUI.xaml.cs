using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace ChatApp_LLAMIDO
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class LoginUI : ContentPage
    {
        public LoginUI()
        {
            InitializeComponent();
            
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ForgotPasswordPage());
        }

        private void Button_Login(object sender, EventArgs e)
        {
            if(txtEmail.Text=="ryanllamido@gmail.com" && txtPassword.Text == "123")
            {
                Navigation.PushAsync(new HomePage());
            }
            if(txtEmail.Text != "ryanllamido@gmail.com" && txtPassword.Text == "123")
            {
                DisplayAlert("Error..", "Email not verified. Sent another verification email.", "OKAY");
                MessagingCenter.Send<object, bool>(this, "Hi", true);
            }
            else if(txtEmail.Text == "ryanllamido@gmail.com" && txtPassword.Text != "123")
            {
                DisplayAlert("Error..", "Incorrect Password", "OKAY");
                MessagingCenter.Send<object, bool>(this, "Hi", true);
            }
            else if (txtEmail.Text == null || txtPassword.Text == null)
            {
                DisplayAlert("Error..", "Missing Fields", "OKAY");
                MessagingCenter.Send<object, bool>(this, "Hi", true);
            }
            else if (txtEmail.Text != "ryanllamido@gmail.com" && txtPassword.Text != "123")
            {
                DisplayAlert("Error..", "Incorrect Email and Password", "OKAY");
                MessagingCenter.Send<object, bool>(this, "Hi", true);
            }
        }

       // void Handle_Clicked(object sender, System.EventArgs e)
        //{
        //    entry.Focus();
        //}

        private void Button_CreateAccount(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateAccount());
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

        
    }
}