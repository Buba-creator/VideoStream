using System;
using System.Windows.Input;
using MediaManager;
using VideoStream.Models;
using VideoStream.ViewModels;
using Xamarin.Forms;

namespace VideoStream.Commands
{
    public class PlayVideo:ICommand
    {
        MainPageViewModel MainPageVM;
        public PlayVideo(MainPageViewModel mainPageVM)
        {
            this.MainPageVM = mainPageVM;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            MainPageVM.PlayerYTranslation = -365;
            MainPageVM.IsPlaying = true;
            MainPageVM.IsMultiTasking = true;
            if (MainPageVM.IsFirstShowing == true)
            {
                MainPageVM.tabSelect = TabSelect.first;
            }
            else if (MainPageVM.IsSecondShowing == true)
            {
                MainPageVM.tabSelect = TabSelect.second;
            }
            MainPageVM.IsFirstShowing = false;
            MainPageVM.IsSecondShowing = false;
            var video = parameter as Video;
            await  App.Database.AddVideo(video);
            await  CrossMediaManager.Current.Play(video.VideoLink);
            MainPageVM.CurrentVideo = video;
        }

    }
}
