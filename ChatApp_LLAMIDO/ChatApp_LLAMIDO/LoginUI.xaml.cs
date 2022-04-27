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

    public partial class LoginUI : ContentPage
    {
        public LoginUI()
        {
            InitializeComponent();
        }
       
        private void Button_Clicked(object sender, EventArgs e)
        {
            if(txtUsername.Text=="admin" && txtPassword.Text == "123")
            {
                Navigation.PushAsync(new HomePage());
            }
            else
            {
                DisplayAlert("Opss..", "Username or Password is incorrect!", "Ok");
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
        
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            entry.Focus();
        }
    }
}