using Syncfusion.XForms.Chat;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using System.Text;
using Syncfusion.XForms;

namespace ChatApp_LLAMIDO
{
    public class ViewModel : INotifyPropertyChanged
    {
        public Author CurrentUser { get; set; }
        public ObservableCollection<object> messages { get; set; }

        public ViewModel()
        {
            this.Messages = new ObservableCollection<object>();
            this.CurrentUser = new Author() { Name = "Ryan", Avatar = "mybaby" };
            this.GenerateMessages();
        }

        public ObservableCollection<object> Messages
        {
            get
            {
                return this.messages;
            }
            set
            {
                this.messages = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void GenerateMessages()
        {
            this.Messages.Add(new TextMessage()
            {
                Author = CurrentUser,
                Text = "Hi guys, good morning! I'm very delighted to share with you the news that our team is going to launch a new mobile application.",
                ShowAvatar = true,
            });
            this.Messages.Add(new TextMessage()
            {
                Author = new Author() { Name = "Andrea", Avatar = "Andrea.png" },
                Text = "Oh! That's great.",
                ShowAvatar = true,
            });
            this.Messages.Add(new TextMessage()
            {
                Author = new Author() { Name = "Harrison", Avatar = "Harrison.png" },
                Text = "That is good news.",
                ShowAvatar = true,
            });
            this.Messages.Add(new TextMessage()
            {
                Author = new Author() { Name = "Margaret", Avatar = "Margaret.png" },
                Text = "What kind of application is it and when are we going to launch?",
                ShowAvatar = true,
            });
        }
    }
}
