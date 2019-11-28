using System;
using System.Collections.Generic;
using VideoStream.Models;
using VideoStream.ViewModels;
using Xamarin.Forms;

namespace VideoStream.Views
{
    public partial class SecondPage : ContentView
    {
        public SecondPage()
        {
            InitializeComponent();
            BackgroundColor = Color.White;
        }

        private async void HandleTapped(object sender,EventArgs e)
        {
            var gestureRecognizer =(sender as StackLayout).GestureRecognizers[0] as TapGestureRecognizer;
            var video = gestureRecognizer.CommandParameter as Video;
            var MainPageVM = BindingContext as MainPageViewModel;
            MainPageVM.PlayVideoCommand.Execute(video);
        }

        private async void Refreshing(object sender,EventArgs e)
        {
            var MainPageVM = BindingContext as MainPageViewModel;
            MainPageVM.RefreshCommand.Execute(new object());
        }
    }
}
