using System;
using System.Collections.Generic;
using VideoStream.Models;
using VideoStream.ViewModels;
using Xamarin.Forms;

namespace VideoStream.Views
{
    public partial class FirstPage : ContentView
    {
        public FirstPage()
        {
            InitializeComponent();
            BackgroundColor = Color.White;
        }

        private async void HandleTapped(object sender,EventArgs e)
        {
            var gestureRecognizer = (sender as StackLayout).GestureRecognizers[0] as TapGestureRecognizer;
            var video = gestureRecognizer.CommandParameter as Video;
            var mainVm = BindingContext as MainPageViewModel;
            mainVm.PlayVideoCommand.Execute(video);
        }
    }
}
