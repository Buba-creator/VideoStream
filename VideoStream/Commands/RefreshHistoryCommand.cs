using System;
using System.Windows.Input;
using VideoStream.ViewModels;

namespace VideoStream.Commands
{
    public class RefreshHistoryCommand :ICommand
    {
        private MainPageViewModel MainPageVM;
        public RefreshHistoryCommand(MainPageViewModel mainPageVM)
        {
            MainPageVM = mainPageVM;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            MainPageVM.IsRefreshing = true;
            MainPageVM.History = await App.Database.GetAllVideos();
            MainPageVM.IsRefreshing = false;
        }
    }
}
