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
    public partial class ForgotPasswordPage : ContentPage
    {
        public ForgotPasswordPage()
        {
            InitializeComponent();
        }

        private void Button_ValidationBehavior(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ForgotEmail.Text))
            {
                DisplayAlert("Error..", "Missing Field", "OKAY");
                MessagingCenter.Send<object, bool>(this, "Hi", true);
            }

            else if (!myEmailValidation.IsValid)
            {
                DisplayAlert("Error..", "Email is Incorrect.", "OKAY");
                MessagingCenter.Send<object, bool>(this, "Hi", true);
            }

            else
            {
                DisplayAlert("Success", "Email has been sent to your email address.", "OKAY");
                Navigation.PushAsync(new LoginUI());
            }
        }
            private void StarCall(object sender, FocusEventArgs e)
        {
            MessagingCenter.Send<object, bool>(this, "Hi", false);
        }
    }
}