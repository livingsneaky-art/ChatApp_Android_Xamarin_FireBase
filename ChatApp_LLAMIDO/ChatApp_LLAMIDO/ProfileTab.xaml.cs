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
    public partial class ProfileTab : ContentPage
    {
        public ProfileTab()
        {
            InitializeComponent();
        }

        private void Button_SignOut(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginUI());
        }
        
    }
}