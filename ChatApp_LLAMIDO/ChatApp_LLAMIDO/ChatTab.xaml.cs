using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatApp_LLAMIDO
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatTab : ContentPage
    {
        List<string> colors = new List<string> 
        { 
            "Red", "Blue", "Green", "Magenta", "Yellow", "Navy", "Orange"
        };

        ObservableCollection<string> myColors = new ObservableCollection<string>();

        public ChatTab()
        {
            InitializeComponent();
        }

        private void ColorSearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            var keyword = ColorSearchBar.Text;
            var isExists = colors.Where(c => c.ToLower().Contains(keyword.ToLower()));
            if (isExists == null || !isExists.Any())
            {
                DisplayAlert("", "User not found.", "OKAY");
                SuggestionsListView.IsVisible = false;
            }
            else
            {
                if (keyword.Length >= 1)
                {
                    var suggestions = colors.Where(c => c.ToLower().Contains(keyword.ToLower()));
                    SuggestionsListView.ItemsSource = suggestions;
                    SuggestionsListView.IsVisible = true;
                }
            }

        }

        private void ColorSearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        async private void SuggestionsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var color = e.Item as string;
            var isExists = myColors.Where(c => c.ToLower().Contains(color.ToLower()));
            var ans = await DisplayAlert("Add contact", "Would you like to add "+color,  " Yes", "No");

            if (ans == true)
            {
                if (isExists == null || !isExists.Any())
                {
                    myColors.Add(color);
                    ColorsListView.ItemsSource = myColors;
                    SuggestionsListView.IsVisible = false;
                }
                else
                {
                    await DisplayAlert("Failed", "You both already have a connection.", "OKAY");
                    SuggestionsListView.IsVisible = false;
                }
            }
            else
            {
                //false conditon
                SuggestionsListView.IsVisible = false;
            }
            
        }

        private void ColorsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new ConversationLayout());
        }
        /*
private void StarCall(object sender, FocusEventArgs e)
{
MessagingCenter.Send<object, bool>(this, "Hi", false);
}*/
    }
}