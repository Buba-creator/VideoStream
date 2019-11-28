using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using VideoStream.Models;
using VideoStream.ViewModels;
using MediaManager;

namespace VideoStream.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible (false)]
    public partial class ItemDetailPage : ContentPage
    {
        MainPageViewModel viewModel;

        public ItemDetailPage(MainPageViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        protected override bool OnBackButtonPressed()
        {
            viewModel.IsPlaying = CrossMediaManager.Current.IsPlaying();
            return base.OnBackButtonPressed();
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new MainPageViewModel();
            BindingContext = viewModel;
        }
    }
}